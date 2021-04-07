using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CCS.Forms
{
    public partial class MainForm : Form
    {
        (Color, Color) currentColor = (ColorTranslator.FromHtml("#348AC7"), ColorTranslator.FromHtml("#0396A6"));
        bool gradientChanged = false;
        GradientColors gc = GradientColors.green;

        #region colors
        readonly Color red = ColorTranslator.FromHtml("#e53935");
        readonly Color orange = ColorTranslator.FromHtml("#e35d5b");
        readonly Color green = ColorTranslator.FromHtml("#134E5E");
        readonly Color lightGreen = ColorTranslator.FromHtml("#71B280");
        readonly Color blue = ColorTranslator.FromHtml("#7474BF");
        readonly Color lightBlue = ColorTranslator.FromHtml("#348AC7");
        #endregion

        enum GradientColors
        {
            blue, green, orange
        }
        int count = 0;
        int k = -255;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0396A6");
            activateButton.BackColor = Color.FromArgb(60, Color.Black);
            UpdateInfo();
            updateTimer.Start();
            gradientTimer.Start();
        }
       
        private Color ChangeGradient(Color color1, Color color2, int k)
        {
            if (k < 0)
            {
                k = 255 + k;
                Color tempColor = color1;
                color1 = color2;
                color2 = tempColor;
            }
            int r1 = color1.R;
            int r2 = color2.R;
            int g1 = color1.G;
            int g2 = color2.G;
            int b1 = color1.B;
            int b2 = color2.B;
            Color output = Color.FromArgb((int)(r1 + (r2 - r1) * k / 255f), (int)(g1 + (g2 - g1) * k / 255f), (int)(b1 + (b2 - b1) * k / 255f));
            return output;
        }
        #region trash
        private void selfActivateButton_CheckedChanged(object sender, EventArgs e)
        {
            autoBox.Visible = false;
        }

        private void autoActivateButton_CheckedChanged(object sender, EventArgs e)
        {
            autoBox.Visible = true;
        }

        private void selfBox_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void downgradeTemperatureButton_Click(object sender, EventArgs e)
        {
            /*necessaryTemperature--;*/
        }

        private void upgradeHumidityButton_Click(object sender, EventArgs e)
        {
           /*necessaryHumidity++;*/
        }

        private void downgradeHumidityButton_Click(object sender, EventArgs e)
        {
            /*necessaryHumidity--;*/
        }

        private void autoBox_EnabledChanged(object sender, EventArgs e)
        {
            autoBox.ForeColor = Color.White;
        }

        private void upgradeTemperatureButton_Click(object sender, EventArgs e)
        {
            /*necessaryTemperature++;*/
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

        private void IntToLabel(Label label, int num)
        {
            label.Text = num.ToString();
        }

        private void activateButton_Click(object sender, EventArgs e)
        {
            if (++count % 2 == 1 || count == 1)
            {
                stateLabel.Text = "Cистему клімат-контролю увімкнено.";
                activateButton.BackColor = Color.FromArgb(40, Color.Black);
            }

            else
            {
                stateLabel.Text = "Бажаєте увімкнути систему клімат-контролю?";
                activateButton.BackColor = Color.FromArgb(60, Color.Black);
            }

            /*if (autoCoolerRadioButton.Checked)
                ChangeGradient(ColorTranslator.FromHtml("#00B4DB"), ColorTranslator.FromHtml("#0083B0"));*/
        }
        #endregion
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.BackColor = ChangeGradient(currentColor.Item1, currentColor.Item2, k++);
            if (gradientChanged && k == 0)
            {
                switch (gc)
                {
                    case GradientColors.blue:
                        currentColor = (lightBlue, blue);
                        break;
                    case GradientColors.green:
                        currentColor = (lightGreen, green);
                        break;
                    case GradientColors.orange:
                        currentColor = (orange, red);
                        break;
                    default:
                        break;
                }
                gradientChanged = false;
            }
            if (k == 255)
            {
                k = -255;
            }
        }

        private void autoCoolerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gc = GradientColors.blue;
            gradientChanged = true;
            k = -255;
            currentColor = (lightBlue, this.BackColor);

        }

        private void autoNormalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gc = GradientColors.green;
            gradientChanged = true;
            k = -255;
            currentColor = (lightGreen, this.BackColor);
        }

        private void autoWarmerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            gc = GradientColors.orange;
            gradientChanged = true;
            k = -255;
            currentColor = (orange, this.BackColor);
        }
    }
}
