using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class MainForm : Form
    {
      
        public MainForm()
        {
            InitializeComponent();
            this.Location = new Point
                (
                    Screen.PrimaryScreen.Bounds.Width - this.Width - 50, 50
                );
            tsmiShowControls.Checked = true;
       
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            labelTime.Text = DateTime.Now.ToString(
                "hh:mm.ss tt",
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

        }
        void SetVisibility(bool visible)
        {
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
            if(!this.TopMost)
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

    }
}
