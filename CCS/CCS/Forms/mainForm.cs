using System;
using System.Timers;
using System.Windows.Forms;

namespace CCS
{
    public partial class MainForm : Form
    {
        System.Windows.Forms.DataVisualization.Charting.Series temperatureSeries;
        private int counter = 0;

        public MainForm()
        {
            temperatureSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            InitializeComponent();
            environment.Temperature = 45;
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            label1.Text = $"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second}";
            environment.UpdateTemperature();
            temperatureSeries.Points.AddXY(counter++, environment.Temperature);
        }
    }
}