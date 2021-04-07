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

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0396A6");
            downgradeTemperatureButton.BackColor = ColorTranslator.FromHtml("#026873");
            upgradeTemperatureButton.BackColor = ColorTranslator.FromHtml("#026873");
            downgradeHumidityButton.BackColor = ColorTranslator.FromHtml("#026873");
            upgradeHumidityButton.BackColor = ColorTranslator.FromHtml("#026873");
            activateButton.BackColor = ColorTranslator.FromHtml("#026873");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = $"{GetFormattedNum(DateTime.Now.Hour)}:{GetFormattedNum(DateTime.Now.Minute)}:{GetFormattedNum(DateTime.Now.Second)}";
            
        }

        private string GetFormattedNum(int num)
        {
            if (num < 10)
                return "0" + num.ToString();
            else
                return num.ToString();
        }

        private void activateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
