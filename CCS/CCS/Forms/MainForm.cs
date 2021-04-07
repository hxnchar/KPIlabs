using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CCS.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int count = 0;

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0396A6");
            downgradeTemperatureButton.BackColor = ColorTranslator.FromHtml("#026873");
            upgradeTemperatureButton.BackColor = ColorTranslator.FromHtml("#026873");
            downgradeHumidityButton.BackColor = ColorTranslator.FromHtml("#026873");
            upgradeHumidityButton.BackColor = ColorTranslator.FromHtml("#026873");
            activateButton.BackColor = ColorTranslator.FromHtml("#026873");
            UpdateInfo();
            selfBox.Enabled = false;
            autoBox.Enabled = false;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = $"{GetTime()}";
            if (DateTime.Now.Minute == 0)
            {
                UpdateInfo();
            }
        }

        private string GetFormattedNum(int num)
        {
            if (num < 10)
                return "0" + num.ToString();
            else
                return num.ToString();
        }

        private void CheckTimeOfDay(Label label)
        {
            int hours = DateTime.Now.Hour;
            if (hours >= 4 && hours <= 11)
                label.Text = "Доброго ранку!";
            else if (hours >= 12 && hours <= 15)
                label.Text = "Доброго дня!";
            else if (hours >= 16 && hours <= 22)
                label.Text = "Доброго вечора!";
            else
                label.Text = "Доброї ночі!";
        }


        private string GetDayOfTheWeek()
        {
            int numOfThe = (int)DateTime.Now.DayOfWeek;
            string result;
            switch (numOfThe)
            {
                case 1:
                    result = "понеділок";
                    break;
                case 2:
                    result = "вівторок";
                    break;
                case 3:
                    result = "середа";
                    break;
                case 4:
                    result = "четвер";
                    break;
                case 5:
                    result = "п'ятниця";
                    break;
                case 6:
                    result = "субота";
                    break;
                case 7:
                    result = "неділя";
                    break;
                default:
                    result = "помилка";
                    break;
            }
            return result;
        }

        private string GetTime()
        {
            return $"{GetFormattedNum(DateTime.Now.Hour)}:{GetFormattedNum(DateTime.Now.Minute)}:{GetFormattedNum(DateTime.Now.Second)}";
        }

        private string GetDate()
        {
            return $"{GetFormattedNum(DateTime.Now.Day)}.{GetFormattedNum(DateTime.Now.Month)}.{GetFormattedNum(DateTime.Now.Year)}";
        }

        private void UpdateInfo()
        {
            CheckTimeOfDay(greetingsLabel);
            dateLabel.Text = $"Сьогодні — {GetDayOfTheWeek()}, {GetDate()}.";
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            if (++count % 2 == 1 || count == 1)
            {
                stateLabel.Text = "Cистему клімат-контролю увімкнено";
                activateButton.BackColor = ColorTranslator.FromHtml("#025573");
            }

            else
            {
                stateLabel.Text = "Бажаєте увімкнути систему клімат-контролю?";
                activateButton.BackColor = ColorTranslator.FromHtml("#026873");
            }
                
        }

        private void selfActivateButton_CheckedChanged(object sender, EventArgs e)
        {
            autoBox.Enabled = false;
            selfBox.Enabled = true;
        }

        private void autoActivateButton_CheckedChanged(object sender, EventArgs e)
        {
            selfBox.Enabled = false;
            autoBox.Enabled = true;
        }

        private void selfBox_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void autoBox_EnabledChanged(object sender, EventArgs e)
        {
            autoBox.ForeColor = Color.White;
        }
    }
}
