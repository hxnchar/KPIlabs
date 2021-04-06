using System;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            label1.Text =$"{DateTime.Now.Hour} : {DateTime.Now.Minute} : {DateTime.Now.Second}";
            
        }
        
    }
}