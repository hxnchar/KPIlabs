
namespace CCS.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.selfActivateButton = new System.Windows.Forms.RadioButton();
            this.autoActivateButton = new System.Windows.Forms.RadioButton();
            this.activateButton = new System.Windows.Forms.Button();
            this.autoBox = new System.Windows.Forms.GroupBox();
            this.selfBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.autoTemperatureLabel = new System.Windows.Forms.Label();
            this.autoHumidityLabel = new System.Windows.Forms.Label();
            this.autoModeGroupBox = new System.Windows.Forms.GroupBox();
            this.autoWarmerRadioButton = new System.Windows.Forms.RadioButton();
            this.autoNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.autoCoolerRadioButton = new System.Windows.Forms.RadioButton();
            this.selfTemperatureScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.downgradeTemperatureButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.upgradeTemperatureButton = new System.Windows.Forms.Button();
            this.upgradeHumidityButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.downgradeHumidityButton = new System.Windows.Forms.Button();
            this.selfHumidityScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.selfHumidityLabel = new System.Windows.Forms.Label();
            this.selfTemperatureLabel = new System.Windows.Forms.Label();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.humidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            this.autoBox.SuspendLayout();
            this.selfBox.SuspendLayout();
            this.autoModeGroupBox.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(867, 12);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(224, 71);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "10:37:02";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperatureChart
            // 
            chartArea3.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.temperatureChart.Legends.Add(legend3);
            this.temperatureChart.Location = new System.Drawing.Point(12, 12);
            this.temperatureChart.Name = "temperatureChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.temperatureChart.Series.Add(series3);
            this.temperatureChart.Size = new System.Drawing.Size(530, 301);
            this.temperatureChart.TabIndex = 1;
            this.temperatureChart.Text = "chart1";
            // 
            // selfActivateButton
            // 
            this.selfActivateButton.AutoSize = true;
            this.selfActivateButton.ForeColor = System.Drawing.Color.White;
            this.selfActivateButton.Location = new System.Drawing.Point(10, 28);
            this.selfActivateButton.Name = "selfActivateButton";
            this.selfActivateButton.Size = new System.Drawing.Size(116, 24);
            this.selfActivateButton.TabIndex = 3;
            this.selfActivateButton.TabStop = true;
            this.selfActivateButton.Text = "Активувати";
            this.selfActivateButton.UseVisualStyleBackColor = true;
            // 
            // autoActivateButton
            // 
            this.autoActivateButton.AutoSize = true;
            this.autoActivateButton.ForeColor = System.Drawing.Color.White;
            this.autoActivateButton.Location = new System.Drawing.Point(6, 28);
            this.autoActivateButton.Name = "autoActivateButton";
            this.autoActivateButton.Size = new System.Drawing.Size(116, 24);
            this.autoActivateButton.TabIndex = 4;
            this.autoActivateButton.TabStop = true;
            this.autoActivateButton.Text = "Активувати";
            this.autoActivateButton.UseVisualStyleBackColor = true;
            // 
            // activateButton
            // 
            this.activateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateButton.Location = new System.Drawing.Point(169, 262);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(201, 32);
            this.activateButton.TabIndex = 5;
            this.activateButton.Text = "Увімкнути систему";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // autoBox
            // 
            this.autoBox.Controls.Add(this.autoModeGroupBox);
            this.autoBox.Controls.Add(this.autoHumidityLabel);
            this.autoBox.Controls.Add(this.autoTemperatureLabel);
            this.autoBox.Controls.Add(this.label4);
            this.autoBox.Controls.Add(this.label3);
            this.autoBox.Controls.Add(this.autoActivateButton);
            this.autoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoBox.ForeColor = System.Drawing.Color.White;
            this.autoBox.Location = new System.Drawing.Point(268, 25);
            this.autoBox.Name = "autoBox";
            this.autoBox.Size = new System.Drawing.Size(256, 233);
            this.autoBox.TabIndex = 6;
            this.autoBox.TabStop = false;
            this.autoBox.Text = "Автоматична регуляція";
            // 
            // selfBox
            // 
            this.selfBox.Controls.Add(this.selfHumidityLabel);
            this.selfBox.Controls.Add(this.selfTemperatureLabel);
            this.selfBox.Controls.Add(this.upgradeHumidityButton);
            this.selfBox.Controls.Add(this.label8);
            this.selfBox.Controls.Add(this.downgradeHumidityButton);
            this.selfBox.Controls.Add(this.selfHumidityScrollBar2);
            this.selfBox.Controls.Add(this.upgradeTemperatureButton);
            this.selfBox.Controls.Add(this.label7);
            this.selfBox.Controls.Add(this.downgradeTemperatureButton);
            this.selfBox.Controls.Add(this.selfTemperatureScrollBar1);
            this.selfBox.Controls.Add(this.selfActivateButton);
            this.selfBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selfBox.ForeColor = System.Drawing.Color.White;
            this.selfBox.Location = new System.Drawing.Point(6, 25);
            this.selfBox.Name = "selfBox";
            this.selfBox.Size = new System.Drawing.Size(256, 233);
            this.selfBox.TabIndex = 7;
            this.selfBox.TabStop = false;
            this.selfBox.Text = "Ручна регуляція";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Поточна температура:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поточна вологість:";
            // 
            // autoTemperatureLabel
            // 
            this.autoTemperatureLabel.AutoSize = true;
            this.autoTemperatureLabel.Location = new System.Drawing.Point(222, 99);
            this.autoTemperatureLabel.Name = "autoTemperatureLabel";
            this.autoTemperatureLabel.Size = new System.Drawing.Size(27, 20);
            this.autoTemperatureLabel.TabIndex = 7;
            this.autoTemperatureLabel.Text = "15";
            // 
            // autoHumidityLabel
            // 
            this.autoHumidityLabel.AutoSize = true;
            this.autoHumidityLabel.Location = new System.Drawing.Point(222, 61);
            this.autoHumidityLabel.Name = "autoHumidityLabel";
            this.autoHumidityLabel.Size = new System.Drawing.Size(27, 20);
            this.autoHumidityLabel.TabIndex = 8;
            this.autoHumidityLabel.Text = "80";
            // 
            // autoModeGroupBox
            // 
            this.autoModeGroupBox.Controls.Add(this.autoCoolerRadioButton);
            this.autoModeGroupBox.Controls.Add(this.autoNormalRadioButton);
            this.autoModeGroupBox.Controls.Add(this.autoWarmerRadioButton);
            this.autoModeGroupBox.ForeColor = System.Drawing.Color.White;
            this.autoModeGroupBox.Location = new System.Drawing.Point(7, 133);
            this.autoModeGroupBox.Name = "autoModeGroupBox";
            this.autoModeGroupBox.Size = new System.Drawing.Size(242, 93);
            this.autoModeGroupBox.TabIndex = 9;
            this.autoModeGroupBox.TabStop = false;
            this.autoModeGroupBox.Text = "Оберіть режим";
            // 
            // autoWarmerRadioButton
            // 
            this.autoWarmerRadioButton.AutoSize = true;
            this.autoWarmerRadioButton.ForeColor = System.Drawing.Color.White;
            this.autoWarmerRadioButton.Location = new System.Drawing.Point(6, 65);
            this.autoWarmerRadioButton.Name = "autoWarmerRadioButton";
            this.autoWarmerRadioButton.Size = new System.Drawing.Size(89, 24);
            this.autoWarmerRadioButton.TabIndex = 4;
            this.autoWarmerRadioButton.TabStop = true;
            this.autoWarmerRadioButton.Text = "Тепліше";
            this.autoWarmerRadioButton.UseVisualStyleBackColor = true;
            // 
            // autoNormalRadioButton
            // 
            this.autoNormalRadioButton.AutoSize = true;
            this.autoNormalRadioButton.ForeColor = System.Drawing.Color.White;
            this.autoNormalRadioButton.Location = new System.Drawing.Point(6, 42);
            this.autoNormalRadioButton.Name = "autoNormalRadioButton";
            this.autoNormalRadioButton.Size = new System.Drawing.Size(103, 24);
            this.autoNormalRadioButton.TabIndex = 5;
            this.autoNormalRadioButton.TabStop = true;
            this.autoNormalRadioButton.Text = "Середньо";
            this.autoNormalRadioButton.UseVisualStyleBackColor = true;
            // 
            // autoCoolerRadioButton
            // 
            this.autoCoolerRadioButton.AutoSize = true;
            this.autoCoolerRadioButton.ForeColor = System.Drawing.Color.White;
            this.autoCoolerRadioButton.Location = new System.Drawing.Point(6, 19);
            this.autoCoolerRadioButton.Name = "autoCoolerRadioButton";
            this.autoCoolerRadioButton.Size = new System.Drawing.Size(111, 24);
            this.autoCoolerRadioButton.TabIndex = 6;
            this.autoCoolerRadioButton.TabStop = true;
            this.autoCoolerRadioButton.Text = "Холодніше";
            this.autoCoolerRadioButton.UseVisualStyleBackColor = true;
            // 
            // selfTemperatureScrollBar1
            // 
            this.selfTemperatureScrollBar1.Location = new System.Drawing.Point(17, 95);
            this.selfTemperatureScrollBar1.Name = "selfTemperatureScrollBar1";
            this.selfTemperatureScrollBar1.Size = new System.Drawing.Size(211, 30);
            this.selfTemperatureScrollBar1.TabIndex = 4;
            // 
            // downgradeTemperatureButton
            // 
            this.downgradeTemperatureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downgradeTemperatureButton.Location = new System.Drawing.Point(17, 95);
            this.downgradeTemperatureButton.Name = "downgradeTemperatureButton";
            this.downgradeTemperatureButton.Size = new System.Drawing.Size(37, 30);
            this.downgradeTemperatureButton.TabIndex = 5;
            this.downgradeTemperatureButton.Text = "-1";
            this.downgradeTemperatureButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Встановіть температуру:";
            // 
            // upgradeTemperatureButton
            // 
            this.upgradeTemperatureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upgradeTemperatureButton.Location = new System.Drawing.Point(214, 95);
            this.upgradeTemperatureButton.Name = "upgradeTemperatureButton";
            this.upgradeTemperatureButton.Size = new System.Drawing.Size(37, 30);
            this.upgradeTemperatureButton.TabIndex = 11;
            this.upgradeTemperatureButton.Text = "+1";
            this.upgradeTemperatureButton.UseVisualStyleBackColor = true;
            // 
            // upgradeHumidityButton
            // 
            this.upgradeHumidityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upgradeHumidityButton.Location = new System.Drawing.Point(214, 192);
            this.upgradeHumidityButton.Name = "upgradeHumidityButton";
            this.upgradeHumidityButton.Size = new System.Drawing.Size(37, 30);
            this.upgradeHumidityButton.TabIndex = 15;
            this.upgradeHumidityButton.Text = "+1";
            this.upgradeHumidityButton.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Встановіть вологість:";
            // 
            // downgradeHumidityButton
            // 
            this.downgradeHumidityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downgradeHumidityButton.Location = new System.Drawing.Point(17, 192);
            this.downgradeHumidityButton.Name = "downgradeHumidityButton";
            this.downgradeHumidityButton.Size = new System.Drawing.Size(37, 30);
            this.downgradeHumidityButton.TabIndex = 13;
            this.downgradeHumidityButton.Text = "-1";
            this.downgradeHumidityButton.UseVisualStyleBackColor = true;
            // 
            // selfHumidityScrollBar2
            // 
            this.selfHumidityScrollBar2.Location = new System.Drawing.Point(17, 192);
            this.selfHumidityScrollBar2.Name = "selfHumidityScrollBar2";
            this.selfHumidityScrollBar2.Size = new System.Drawing.Size(211, 30);
            this.selfHumidityScrollBar2.TabIndex = 12;
            // 
            // selfHumidityLabel
            // 
            this.selfHumidityLabel.AutoSize = true;
            this.selfHumidityLabel.Location = new System.Drawing.Point(225, 152);
            this.selfHumidityLabel.Name = "selfHumidityLabel";
            this.selfHumidityLabel.Size = new System.Drawing.Size(27, 20);
            this.selfHumidityLabel.TabIndex = 11;
            this.selfHumidityLabel.Text = "80";
            // 
            // selfTemperatureLabel
            // 
            this.selfTemperatureLabel.AutoSize = true;
            this.selfTemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.selfTemperatureLabel.Location = new System.Drawing.Point(225, 62);
            this.selfTemperatureLabel.Name = "selfTemperatureLabel";
            this.selfTemperatureLabel.Size = new System.Drawing.Size(27, 20);
            this.selfTemperatureLabel.TabIndex = 10;
            this.selfTemperatureLabel.Text = "15";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.selfBox);
            this.settingsGroupBox.Controls.Add(this.activateButton);
            this.settingsGroupBox.Controls.Add(this.autoBox);
            this.settingsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.settingsGroupBox.ForeColor = System.Drawing.Color.White;
            this.settingsGroupBox.Location = new System.Drawing.Point(561, 332);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(530, 301);
            this.settingsGroupBox.TabIndex = 8;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Налаштування";
            // 
            // humidityChart
            // 
            chartArea4.Name = "ChartArea1";
            this.humidityChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.humidityChart.Legends.Add(legend4);
            this.humidityChart.Location = new System.Drawing.Point(12, 332);
            this.humidityChart.Name = "humidityChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.humidityChart.Series.Add(series4);
            this.humidityChart.Size = new System.Drawing.Size(530, 301);
            this.humidityChart.TabIndex = 9;
            this.humidityChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(563, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "Доброго дня!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(563, 53);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(298, 30);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Сьогодні — вівторок, 06.04.2021";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(563, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Бажаєте увімкнути систему клімат контролю?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1103, 643);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.humidityChart);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.temperatureChart);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Система клімат-контролю";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            this.autoBox.ResumeLayout(false);
            this.autoBox.PerformLayout();
            this.selfBox.ResumeLayout(false);
            this.selfBox.PerformLayout();
            this.autoModeGroupBox.ResumeLayout(false);
            this.autoModeGroupBox.PerformLayout();
            this.settingsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private System.Windows.Forms.RadioButton selfActivateButton;
        private System.Windows.Forms.RadioButton autoActivateButton;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.GroupBox autoBox;
        private System.Windows.Forms.GroupBox autoModeGroupBox;
        private System.Windows.Forms.RadioButton autoCoolerRadioButton;
        private System.Windows.Forms.RadioButton autoNormalRadioButton;
        private System.Windows.Forms.RadioButton autoWarmerRadioButton;
        private System.Windows.Forms.Label autoHumidityLabel;
        private System.Windows.Forms.Label autoTemperatureLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox selfBox;
        private System.Windows.Forms.Button upgradeHumidityButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button downgradeHumidityButton;
        private System.Windows.Forms.HScrollBar selfHumidityScrollBar2;
        private System.Windows.Forms.Button upgradeTemperatureButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button downgradeTemperatureButton;
        private System.Windows.Forms.HScrollBar selfTemperatureScrollBar1;
        private System.Windows.Forms.Label selfHumidityLabel;
        private System.Windows.Forms.Label selfTemperatureLabel;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart humidityChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
    }
}