using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;

namespace Clock
{
    public partial class MainForm : Form
    {
        int currentFontIndex = 0;

        readonly string[] fontResources =
        {
            "Clock.Resources.TechnicallyInsaneWidesemibold.ttf",
            "Clock.Resources.Orecrusherexpandital.ttf",
            "Clock.Resources.YawTaht.ttf",
            "Clock.Resources.Montrocital.ttf"
        };

        PrivateFontCollection privateFonts = new PrivateFontCollection();
        ColorDialog backgroundDialog;
        ColorDialog foregroundDialog;
        public MainForm()
        {
            InitializeComponent();

            var asm = Assembly.GetExecutingAssembly();
            var names = asm.GetManifestResourceNames();
            MessageBox.Show(string.Join("\n", names));
            LoadFonts();

            if(privateFonts.Families.Length > 0)
            {
                // Загружаем сохраненный индекс шрифта или используем 0
                int savedIndex = Properties.Settings.Default.SelectedFontIndex;
                if (savedIndex >= 0 && savedIndex < privateFonts.Families.Length)
                {
                    ApplyFont(savedIndex);
                }
                else
                {
                    ApplyFont(0);
                }
            }
            else
            {
                MessageBox.Show("Не удалось загрузить шрифты.");
            }

                this.Location = new Point
                    (
                        Screen.PrimaryScreen.Bounds.Width - this.Width - 50, 50
                    );
            tsmiShowControls.Checked = true;

            backgroundDialog = new ColorDialog();
            foregroundDialog = new ColorDialog();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Сохраняем текущий шрифт
            Font currentFont = labelTime.Font;

            labelTime.Text = DateTime.Now.ToString(
                "hh:mm:ss tt",  // Изменено с "hh:mm.ss tt" на "hh:mm:ss tt" (обычно двоеточие для секунд)
                System.Globalization.CultureInfo.InvariantCulture
            );

            if (checkBoxShowDate.Checked)
            {
                labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
            }
            if (checkBoxShowWeekDay.Checked)
            {
                labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
            }
            notifyIcon.Text = labelTime.Text;

            // Восстанавливаем шрифт после обновления текста
            labelTime.Font = currentFont;

        }
        void SetVisibility(bool visible)
        {
            labelControls.Visible = visible;
            checkBoxShowDate.Visible = visible; //делает checkBoxShowDate невидимым
            checkBoxShowWeekDay.Visible = visible; //делает  checkBoxShowWeekDay невидимым
            buttonHideControls.Visible = visible; //делает buttonHideControls невидимым
            this.ShowInTaskbar = visible; //Скрываем кнопку приложения в панели задач 
            this.FormBorderStyle = visible ? FormBorderStyle.FixedToolWindow : FormBorderStyle.None; //Полностью убираем границы окна
            this.TransparencyKey = visible ? Color.Empty : this.BackColor; //делаем окно прозрачным
                                                                           //для того что бы сделать окно прозрачным, его TransparencyKey должен совпадать с BackColor

        }
        private void buttonHideControls_Click(object sender, EventArgs e) => tsmiShowControls.Checked = false;

        private void labelTime_DoubleClick(object sender, EventArgs e) => tsmiShowControls.Checked = true;

        private void MainForm_DoubleClick(object sender, EventArgs e) => tsmiShowControls.Checked = true;

        //this.TopMost = tsmiTopmost.Checked;
        //this.TopMost = ((ToolStripMenuItem)sender).Cheked;
        private void tsmiTopmost_CheckedChanged(object sender, EventArgs e) => this.TopMost = (sender as ToolStripMenuItem).Checked;

        private void tsmiShowControls_CheckedChanged(object sender, EventArgs e) => SetVisibility(tsmiShowControls.Checked);

        private void tsmiExit_Click(object sender, EventArgs e) => this.Close();

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!this.TopMost)
            {
                this.TopMost = true;
                this.TopMost = false;
            }
        }

        private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e) =>
            tsmiShowDate.Checked = (sender as CheckBox).Checked;

        private void checkBoxShowWeekDay_CheckedChanged(object sender, EventArgs e) => tsmiShowWeekday.Checked = (sender as CheckBox).Checked;

        private void tsmiShowDate_CheckedChanged(object sender, EventArgs e) => checkBoxShowDate.Checked = (sender as ToolStripMenuItem).Checked;

        private void tsmiShowWeekday_CheckedChanged(object sender, EventArgs e) => checkBoxShowWeekDay.Checked = (sender as ToolStripMenuItem).Checked;

        private void tsmiBackgroundColor_Click(object sender, EventArgs e)
        {
            DialogResult result = backgroundDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                labelTime.BackColor = backgroundDialog.Color;
            }
        }

        private void tsmiForegroundColor_Click(object sender, EventArgs e)
        {
            if (foregroundDialog.ShowDialog() == DialogResult.OK)
            {
                labelTime.ForeColor = foregroundDialog.Color;
            }
        }

        private readonly List<IntPtr> fontPtrs = new List<IntPtr>();

        private void LoadFonts()
        {
            var asm = Assembly.GetExecutingAssembly();

            foreach (string res in fontResources)

            {
                using (Stream stream = asm.GetManifestResourceStream(res))
                {
                    if (stream == null)
                    {
                        MessageBox.Show($"Шрифт не найден: {res}");
                        continue;
                    }

                    byte[] fontData = new byte[stream.Length];
                    stream.Read(fontData, 0, fontData.Length);

                    IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
                    System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                    privateFonts.AddMemoryFont(fontPtr, fontData.Length);
                    fontPtrs.Add(fontPtr); // ХРАНИМ, чтобы GC не убил
                }
            }
        }
       
        private void labelControls_DoubleClick(object sender, EventArgs e)
        {
            tsmiShowControls.Checked = false;
        }

        private void labelControls_Click(object sender, EventArgs e)
        {
            tsmiShowControls.Checked = false;
        }

        private void ApplyFont(int index)
        {

            if (index < 0 || index >= privateFonts.Families.Length)
            {
                return;
            }

            try
            {
                // Сохраняем текущий размер шрифта
                float fontSize = labelTime.Font.Size;

                // Создаем новый шрифт
                Font newFont = new Font(privateFonts.Families[index], fontSize, FontStyle.Regular);

                // Применяем шрифт
                labelTime.Font = newFont;

                currentFontIndex = index;

                // Сохраняем выбранный шрифт в настройках (если нужно)
                Properties.Settings.Default.SelectedFontIndex = index;
                Properties.Settings.Default.Save();

                UpdateFontMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при применении шрифта: {ex.Message}");
            }
        }

        private void tsmiTechnicallyInsaneWidesemibold_Click(object sender, EventArgs e) => ApplyFont(0);

        private void tsmiOrecrusherexpandital_Click(object sender, EventArgs e) => ApplyFont(1);

        private void tsmiYawTaht_Click(object sender, EventArgs e) => ApplyFont(2);

        private void tsmiMontrocital_Click(object sender, EventArgs e) => ApplyFont(3);

        private void UpdateFontMenu()
        {
            tsmiTechnicallyInsaneWidesemibold.Checked = currentFontIndex == 0;
            tsmiOrecrusherexpandital.Checked = currentFontIndex == 1;
            tsmiYawTaht.Checked = currentFontIndex == 2;
            tsmiMontrocital.Checked = currentFontIndex == 3;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            foreach (var ptr in fontPtrs)
                System.Runtime.InteropServices.Marshal.FreeCoTaskMem(ptr);

            base.OnFormClosed(e);
        }
    }
}
