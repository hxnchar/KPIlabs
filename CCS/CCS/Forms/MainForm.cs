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
        System.Windows.Forms.DataVisualization.Charting.Series temperatureSeries;
        private int counter = 0;

        public MainForm()
        {
            InitializeComponent();
            temperatureSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            InitializeComponent();
            environment.Temperature = 45;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#0396A6");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second}";
            environment.UpdateTemperature();
            temperatureSeries.Points.AddXY(counter++, environment.Temperature);
        }
    }
}
