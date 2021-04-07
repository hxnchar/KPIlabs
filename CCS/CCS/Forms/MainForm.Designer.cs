
using System.Drawing;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.selfActivateButton = new System.Windows.Forms.RadioButton();
            this.autoActivateButton = new System.Windows.Forms.RadioButton();
            this.activateButton = new System.Windows.Forms.Button();
            this.autoBox = new System.Windows.Forms.GroupBox();
            this.autoModeGroupBox = new System.Windows.Forms.GroupBox();
            this.autoCoolerRadioButton = new System.Windows.Forms.RadioButton();
            this.autoNormalRadioButton = new System.Windows.Forms.RadioButton();
            this.autoWarmerRadioButton = new System.Windows.Forms.RadioButton();
            this.autoHumidityLabel = new System.Windows.Forms.Label();
            this.autoTemperatureLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selfBox = new System.Windows.Forms.GroupBox();
            this.selfHumidityLabel = new System.Windows.Forms.Label();
            this.selfTemperatureLabel = new System.Windows.Forms.Label();
            this.upgradeHumidityButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.downgradeHumidityButton = new System.Windows.Forms.Button();
            this.selfHumidityScrollBar2 = new System.Windows.Forms.HScrollBar();
            this.upgradeTemperatureButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.downgradeTemperatureButton = new System.Windows.Forms.Button();
            this.selfTemperatureScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.humidityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.greetingsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.gradientTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            this.autoBox.SuspendLayout();
            this.autoModeGroupBox.SuspendLayout();
            this.selfBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Interval = 1000;
            this.updateTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.ForeColor = System.Drawing.Color.White;
            this.timeLabel.Location = new System.Drawing.Point(0, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(990, 46);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "10:37:02";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperatureChart
            // 
            this.temperatureChart.BackColor = System.Drawing.Color.Transparent;
            this.temperatureChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.temperatureChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.temperatureChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.temperatureChart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.temperatureChart.BorderSkin.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.temperatureChart.BorderSkin.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.temperatureChart.BorderSkin.BorderWidth = 0;
            this.temperatureChart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            chartArea1.BackColor = Color.Transparent;
            this.temperatureChart.ChartAreas.Add(chartArea1);
            this.temperatureChart.Location = new System.Drawing.Point(448, 49);
            this.temperatureChart.Name = "temperatureChart";
            this.temperatureChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.temperatureChart.Series.Add(series1);
            this.temperatureChart.Size = new System.Drawing.Size(530, 264);
            this.temperatureChart.TabIndex = 1;
            this.temperatureChart.Text = "chart1";
            // 
            // selfActivateButton
            // 
            this.selfActivateButton.AutoSize = true;
            this.selfActivateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selfActivateButton.ForeColor = System.Drawing.Color.White;
            this.selfActivateButton.Location = new System.Drawing.Point(121, 529);
            this.selfActivateButton.Name = "selfActivateButton";
            this.selfActivateButton.Size = new System.Drawing.Size(225, 24);
            this.selfActivateButton.TabIndex = 3;
            this.selfActivateButton.Text = "Активувати ручний режим";
            this.selfActivateButton.UseVisualStyleBackColor = true;
            this.selfActivateButton.CheckedChanged += new System.EventHandler(this.selfActivateButton_CheckedChanged);
            // 
            // autoActivateButton
            // 
            this.autoActivateButton.AutoSize = true;
            this.autoActivateButton.Checked = true;
            this.autoActivateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.autoActivateButton.ForeColor = System.Drawing.Color.White;
            this.autoActivateButton.Location = new System.Drawing.Point(121, 559);
            this.autoActivateButton.Name = "autoActivateButton";
            this.autoActivateButton.Size = new System.Drawing.Size(283, 24);
            this.autoActivateButton.TabIndex = 4;
            this.autoActivateButton.TabStop = true;
            this.autoActivateButton.Text = "Активувати автоматичний режим";
            this.autoActivateButton.UseVisualStyleBackColor = true;
            this.autoActivateButton.CheckedChanged += new System.EventHandler(this.autoActivateButton_CheckedChanged);
            // 
            // activateButton
            // 
            this.activateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.activateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.activateButton.FlatAppearance.BorderSize = 0;
            this.activateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.activateButton.ForeColor = System.Drawing.Color.White;
            this.activateButton.Location = new System.Drawing.Point(161, 589);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(176, 44);
            this.activateButton.TabIndex = 5;
            this.activateButton.Text = "Увімкнути систему";
            this.activateButton.UseVisualStyleBackColor = false;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // autoBox
            // 
            this.autoBox.Controls.Add(this.label4);
            this.autoBox.Controls.Add(this.autoModeGroupBox);
            this.autoBox.Controls.Add(this.autoHumidityLabel);
            this.autoBox.Controls.Add(this.autoTemperatureLabel);
            this.autoBox.Controls.Add(this.label3);
            this.autoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.autoBox.ForeColor = System.Drawing.Color.White;
            this.autoBox.Location = new System.Drawing.Point(121, 328);
            this.autoBox.Name = "autoBox";
            this.autoBox.Size = new System.Drawing.Size(256, 195);
            this.autoBox.TabIndex = 6;
            this.autoBox.TabStop = false;
            this.autoBox.Text = "Автоматична регуляція";
            this.autoBox.EnabledChanged += new System.EventHandler(this.autoBox_EnabledChanged);
            // 
            // autoModeGroupBox
            // 
            this.autoModeGroupBox.Controls.Add(this.autoCoolerRadioButton);
            this.autoModeGroupBox.Controls.Add(this.autoNormalRadioButton);
            this.autoModeGroupBox.Controls.Add(this.autoWarmerRadioButton);
            this.autoModeGroupBox.ForeColor = System.Drawing.Color.White;
            this.autoModeGroupBox.Location = new System.Drawing.Point(8, 96);
            this.autoModeGroupBox.Name = "autoModeGroupBox";
            this.autoModeGroupBox.Size = new System.Drawing.Size(242, 93);
            this.autoModeGroupBox.TabIndex = 9;
            this.autoModeGroupBox.TabStop = false;
            this.autoModeGroupBox.Text = "Оберіть режим";
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
            this.autoCoolerRadioButton.CheckedChanged += new System.EventHandler(this.autoCoolerRadioButton_CheckedChanged);
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
            this.autoNormalRadioButton.CheckedChanged += new System.EventHandler(this.autoNormalRadioButton_CheckedChanged);
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
            this.autoWarmerRadioButton.CheckedChanged += new System.EventHandler(this.autoWarmerRadioButton_CheckedChanged);
            // 
            // autoHumidityLabel
            // 
            this.autoHumidityLabel.AutoSize = true;
            this.autoHumidityLabel.Location = new System.Drawing.Point(220, 69);
            this.autoHumidityLabel.Name = "autoHumidityLabel";
            this.autoHumidityLabel.Size = new System.Drawing.Size(27, 20);
            this.autoHumidityLabel.TabIndex = 8;
            this.autoHumidityLabel.Text = "80";
            // 
            // autoTemperatureLabel
            // 
            this.autoTemperatureLabel.AutoSize = true;
            this.autoTemperatureLabel.Location = new System.Drawing.Point(218, 34);
            this.autoTemperatureLabel.Name = "autoTemperatureLabel";
            this.autoTemperatureLabel.Size = new System.Drawing.Size(27, 20);
            this.autoTemperatureLabel.TabIndex = 7;
            this.autoTemperatureLabel.Text = "15";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Поточна вологість:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(5, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Поточна температура:";
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
            this.selfBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selfBox.ForeColor = System.Drawing.Color.White;
            this.selfBox.Location = new System.Drawing.Point(121, 328);
            this.selfBox.Name = "selfBox";
            this.selfBox.Size = new System.Drawing.Size(256, 195);
            this.selfBox.TabIndex = 7;
            this.selfBox.TabStop = false;
            this.selfBox.Text = "Ручна регуляція";
            this.selfBox.EnabledChanged += new System.EventHandler(this.selfBox_EnabledChanged);
            // 
            // selfHumidityLabel
            // 
            this.selfHumidityLabel.AutoSize = true;
            this.selfHumidityLabel.Location = new System.Drawing.Point(220, 117);
            this.selfHumidityLabel.Name = "selfHumidityLabel";
            this.selfHumidityLabel.Size = new System.Drawing.Size(27, 20);
            this.selfHumidityLabel.TabIndex = 11;
            this.selfHumidityLabel.Text = "80";
            // 
            // selfTemperatureLabel
            // 
            this.selfTemperatureLabel.AutoSize = true;
            this.selfTemperatureLabel.BackColor = System.Drawing.Color.Transparent;
            this.selfTemperatureLabel.Location = new System.Drawing.Point(220, 34);
            this.selfTemperatureLabel.Name = "selfTemperatureLabel";
            this.selfTemperatureLabel.Size = new System.Drawing.Size(27, 20);
            this.selfTemperatureLabel.TabIndex = 10;
            this.selfTemperatureLabel.Text = "15";
            // 
            // upgradeHumidityButton
            // 
            this.upgradeHumidityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upgradeHumidityButton.Location = new System.Drawing.Point(208, 155);
            this.upgradeHumidityButton.Name = "upgradeHumidityButton";
            this.upgradeHumidityButton.Size = new System.Drawing.Size(37, 30);
            this.upgradeHumidityButton.TabIndex = 15;
            this.upgradeHumidityButton.Text = "+1";
            this.upgradeHumidityButton.UseVisualStyleBackColor = true;
            this.upgradeHumidityButton.Click += new System.EventHandler(this.upgradeHumidityButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(8, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Встановіть вологість:";
            // 
            // downgradeHumidityButton
            // 
            this.downgradeHumidityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downgradeHumidityButton.Location = new System.Drawing.Point(11, 155);
            this.downgradeHumidityButton.Name = "downgradeHumidityButton";
            this.downgradeHumidityButton.Size = new System.Drawing.Size(37, 30);
            this.downgradeHumidityButton.TabIndex = 13;
            this.downgradeHumidityButton.Text = "-1";
            this.downgradeHumidityButton.UseVisualStyleBackColor = true;
            this.downgradeHumidityButton.Click += new System.EventHandler(this.downgradeHumidityButton_Click);
            // 
            // selfHumidityScrollBar2
            // 
            this.selfHumidityScrollBar2.Location = new System.Drawing.Point(47, 155);
            this.selfHumidityScrollBar2.Name = "selfHumidityScrollBar2";
            this.selfHumidityScrollBar2.Size = new System.Drawing.Size(161, 30);
            this.selfHumidityScrollBar2.TabIndex = 12;
            this.selfHumidityScrollBar2.Value = 50;
            // 
            // upgradeTemperatureButton
            // 
            this.upgradeTemperatureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upgradeTemperatureButton.Location = new System.Drawing.Point(209, 64);
            this.upgradeTemperatureButton.Name = "upgradeTemperatureButton";
            this.upgradeTemperatureButton.Size = new System.Drawing.Size(37, 30);
            this.upgradeTemperatureButton.TabIndex = 11;
            this.upgradeTemperatureButton.Text = "+1";
            this.upgradeTemperatureButton.UseVisualStyleBackColor = true;
            this.upgradeTemperatureButton.Click += new System.EventHandler(this.upgradeTemperatureButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Встановіть температуру:";
            // 
            // downgradeTemperatureButton
            // 
            this.downgradeTemperatureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downgradeTemperatureButton.Location = new System.Drawing.Point(12, 64);
            this.downgradeTemperatureButton.Name = "downgradeTemperatureButton";
            this.downgradeTemperatureButton.Size = new System.Drawing.Size(37, 30);
            this.downgradeTemperatureButton.TabIndex = 5;
            this.downgradeTemperatureButton.Text = "-1";
            this.downgradeTemperatureButton.UseVisualStyleBackColor = true;
            this.downgradeTemperatureButton.Click += new System.EventHandler(this.downgradeTemperatureButton_Click);
            // 
            // selfTemperatureScrollBar1
            // 
            this.selfTemperatureScrollBar1.Location = new System.Drawing.Point(48, 64);
            this.selfTemperatureScrollBar1.Name = "selfTemperatureScrollBar1";
            this.selfTemperatureScrollBar1.Size = new System.Drawing.Size(161, 30);
            this.selfTemperatureScrollBar1.TabIndex = 4;
            this.selfTemperatureScrollBar1.Value = 50;
            // 
            // humidityChart
            // 
            this.humidityChart.BackColor = System.Drawing.Color.Transparent;
            this.humidityChart.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            chartArea2.BackColor = Color.Transparent;
            this.humidityChart.ChartAreas.Add(chartArea2);
            this.humidityChart.Location = new System.Drawing.Point(448, 369);
            this.humidityChart.Name = "humidityChart";
            this.humidityChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.humidityChart.Series.Add(series2);
            this.humidityChart.Size = new System.Drawing.Size(530, 264);
            this.humidityChart.TabIndex = 9;
            this.humidityChart.Text = "chart1";
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingsLabel.ForeColor = System.Drawing.Color.White;
            this.greetingsLabel.Location = new System.Drawing.Point(12, 49);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(163, 30);
            this.greetingsLabel.TabIndex = 10;
            this.greetingsLabel.Text = "Доброго ранку!";
            this.greetingsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.Location = new System.Drawing.Point(12, 90);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(298, 30);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Сьогодні — вівторок, 06.04.2021";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stateLabel
            // 
            this.stateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLabel.ForeColor = System.Drawing.Color.White;
            this.stateLabel.Location = new System.Drawing.Point(12, 134);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(437, 30);
            this.stateLabel.TabIndex = 11;
            this.stateLabel.Text = "Бажаєте увімкнути систему клімат-контролю?";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gradientTimer
            // 
            this.gradientTimer.Interval = 30;
            this.gradientTimer.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(988, 643);
            this.Controls.Add(this.autoBox);
            this.Controls.Add(this.autoActivateButton);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.selfBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.greetingsLabel);
            this.Controls.Add(this.humidityChart);
            this.Controls.Add(this.selfActivateButton);
            this.Controls.Add(this.temperatureChart);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Система клімат-контролю";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            this.autoBox.ResumeLayout(false);
            this.autoBox.PerformLayout();
            this.autoModeGroupBox.ResumeLayout(false);
            this.autoModeGroupBox.PerformLayout();
            this.selfBox.ResumeLayout(false);
            this.selfBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.humidityChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer updateTimer;
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
        private System.Windows.Forms.DataVisualization.Charting.Chart humidityChart;
        private System.Windows.Forms.Label greetingsLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Timer gradientTimer;
    }
}