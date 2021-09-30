
namespace StatisticsFunctionsWPF
{
    partial class form
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valuesTextBox = new System.Windows.Forms.TextBox();
            this.disFractionTextBox = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.sortedListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.miniArrayLabel = new System.Windows.Forms.Label();
            this.arrayMaxLabel = new System.Windows.Forms.Label();
            this.arrayMeanLabel = new System.Windows.Forms.Label();
            this.arrayTrunMeanLabel = new System.Windows.Forms.Label();
            this.arrayMedianLabel = new System.Windows.Forms.Label();
            this.arraySTDSamLabel = new System.Windows.Forms.Label();
            this.arraySTDPopLabel = new System.Windows.Forms.Label();
            this.listMiniLabel = new System.Windows.Forms.Label();
            this.ListMaxLabel = new System.Windows.Forms.Label();
            this.listMeanLabel = new System.Windows.Forms.Label();
            this.listTrunMeanLabel = new System.Windows.Forms.Label();
            this.listMedianLabel = new System.Windows.Forms.Label();
            this.listSTDSamLabel = new System.Windows.Forms.Label();
            this.listSTDPopLabel = new System.Windows.Forms.Label();
            this.arrayModeLabel = new System.Windows.Forms.Label();
            this.listModeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.SystemColors.Control;
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            this.chart1.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(336, 26);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(370, 428);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chartControl";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "# Values:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discard Fraction";
            // 
            // valuesTextBox
            // 
            this.valuesTextBox.Location = new System.Drawing.Point(117, 29);
            this.valuesTextBox.Name = "valuesTextBox";
            this.valuesTextBox.Size = new System.Drawing.Size(96, 20);
            this.valuesTextBox.TabIndex = 3;
            this.valuesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disFractionTextBox
            // 
            this.disFractionTextBox.Location = new System.Drawing.Point(117, 55);
            this.disFractionTextBox.Name = "disFractionTextBox";
            this.disFractionTextBox.Size = new System.Drawing.Size(96, 20);
            this.disFractionTextBox.TabIndex = 4;
            this.disFractionTextBox.Text = "0";
            this.disFractionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(72, 81);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(95, 26);
            this.goButton.TabIndex = 5;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Values";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sorted";
            // 
            // valuesListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(16, 141);
            this.valuesListBox.Name = "valuesListBox";
            this.valuesListBox.Size = new System.Drawing.Size(101, 82);
            this.valuesListBox.TabIndex = 8;
            // 
            // sortedListBox
            // 
            this.sortedListBox.FormattingEnabled = true;
            this.sortedListBox.Location = new System.Drawing.Point(144, 141);
            this.sortedListBox.Name = "sortedListBox";
            this.sortedListBox.Size = new System.Drawing.Size(101, 82);
            this.sortedListBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Minimum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Maximum";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Mean (Average):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Truncated Mean:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Median:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 382);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Mode:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Stddev Sample:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 429);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Stddev Population:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(157, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Array";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(238, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "List";
            // 
            // miniArrayLabel
            // 
            this.miniArrayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.miniArrayLabel.Location = new System.Drawing.Point(144, 261);
            this.miniArrayLabel.Name = "miniArrayLabel";
            this.miniArrayLabel.Size = new System.Drawing.Size(61, 20);
            this.miniArrayLabel.TabIndex = 20;
            // 
            // arrayMaxLabel
            // 
            this.arrayMaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayMaxLabel.Location = new System.Drawing.Point(144, 286);
            this.arrayMaxLabel.Name = "arrayMaxLabel";
            this.arrayMaxLabel.Size = new System.Drawing.Size(61, 20);
            this.arrayMaxLabel.TabIndex = 21;
            // 
            // arrayMeanLabel
            // 
            this.arrayMeanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayMeanLabel.Location = new System.Drawing.Point(144, 310);
            this.arrayMeanLabel.Name = "arrayMeanLabel";
            this.arrayMeanLabel.Size = new System.Drawing.Size(61, 20);
            this.arrayMeanLabel.TabIndex = 22;
            // 
            // arrayTrunMeanLabel
            // 
            this.arrayTrunMeanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayTrunMeanLabel.Location = new System.Drawing.Point(144, 333);
            this.arrayTrunMeanLabel.Name = "arrayTrunMeanLabel";
            this.arrayTrunMeanLabel.Size = new System.Drawing.Size(61, 20);
            this.arrayTrunMeanLabel.TabIndex = 23;
            // 
            // arrayMedianLabel
            // 
            this.arrayMedianLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayMedianLabel.Location = new System.Drawing.Point(144, 358);
            this.arrayMedianLabel.Name = "arrayMedianLabel";
            this.arrayMedianLabel.Size = new System.Drawing.Size(61, 20);
            this.arrayMedianLabel.TabIndex = 24;
            // 
            // arraySTDSamLabel
            // 
            this.arraySTDSamLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arraySTDSamLabel.Location = new System.Drawing.Point(144, 404);
            this.arraySTDSamLabel.Name = "arraySTDSamLabel";
            this.arraySTDSamLabel.Size = new System.Drawing.Size(61, 20);
            this.arraySTDSamLabel.TabIndex = 25;
            // 
            // arraySTDPopLabel
            // 
            this.arraySTDPopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arraySTDPopLabel.Location = new System.Drawing.Point(144, 429);
            this.arraySTDPopLabel.Name = "arraySTDPopLabel";
            this.arraySTDPopLabel.Size = new System.Drawing.Size(61, 20);
            this.arraySTDPopLabel.TabIndex = 26;
            // 
            // listMiniLabel
            // 
            this.listMiniLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMiniLabel.Location = new System.Drawing.Point(223, 261);
            this.listMiniLabel.Name = "listMiniLabel";
            this.listMiniLabel.Size = new System.Drawing.Size(61, 20);
            this.listMiniLabel.TabIndex = 27;
            // 
            // ListMaxLabel
            // 
            this.ListMaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListMaxLabel.Location = new System.Drawing.Point(223, 286);
            this.ListMaxLabel.Name = "ListMaxLabel";
            this.ListMaxLabel.Size = new System.Drawing.Size(61, 20);
            this.ListMaxLabel.TabIndex = 28;
            // 
            // listMeanLabel
            // 
            this.listMeanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMeanLabel.Location = new System.Drawing.Point(223, 310);
            this.listMeanLabel.Name = "listMeanLabel";
            this.listMeanLabel.Size = new System.Drawing.Size(61, 20);
            this.listMeanLabel.TabIndex = 29;
            // 
            // listTrunMeanLabel
            // 
            this.listTrunMeanLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTrunMeanLabel.Location = new System.Drawing.Point(223, 333);
            this.listTrunMeanLabel.Name = "listTrunMeanLabel";
            this.listTrunMeanLabel.Size = new System.Drawing.Size(61, 20);
            this.listTrunMeanLabel.TabIndex = 30;
            // 
            // listMedianLabel
            // 
            this.listMedianLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listMedianLabel.Location = new System.Drawing.Point(223, 358);
            this.listMedianLabel.Name = "listMedianLabel";
            this.listMedianLabel.Size = new System.Drawing.Size(61, 20);
            this.listMedianLabel.TabIndex = 31;
            // 
            // listSTDSamLabel
            // 
            this.listSTDSamLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSTDSamLabel.Location = new System.Drawing.Point(223, 404);
            this.listSTDSamLabel.Name = "listSTDSamLabel";
            this.listSTDSamLabel.Size = new System.Drawing.Size(61, 20);
            this.listSTDSamLabel.TabIndex = 32;
            // 
            // listSTDPopLabel
            // 
            this.listSTDPopLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listSTDPopLabel.Location = new System.Drawing.Point(223, 429);
            this.listSTDPopLabel.Name = "listSTDPopLabel";
            this.listSTDPopLabel.Size = new System.Drawing.Size(61, 20);
            this.listSTDPopLabel.TabIndex = 33;
            // 
            // arrayModeLabel
            // 
            this.arrayModeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayModeLabel.Location = new System.Drawing.Point(144, 382);
            this.arrayModeLabel.Name = "arrayModeLabel";
            this.arrayModeLabel.Size = new System.Drawing.Size(61, 20);
            this.arrayModeLabel.TabIndex = 34;
            // 
            // listModeLabel
            // 
            this.listModeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listModeLabel.Location = new System.Drawing.Point(223, 381);
            this.listModeLabel.Name = "listModeLabel";
            this.listModeLabel.Size = new System.Drawing.Size(61, 20);
            this.listModeLabel.TabIndex = 35;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 488);
            this.Controls.Add(this.listModeLabel);
            this.Controls.Add(this.arrayModeLabel);
            this.Controls.Add(this.listSTDPopLabel);
            this.Controls.Add(this.listSTDSamLabel);
            this.Controls.Add(this.listMedianLabel);
            this.Controls.Add(this.listTrunMeanLabel);
            this.Controls.Add(this.listMeanLabel);
            this.Controls.Add(this.ListMaxLabel);
            this.Controls.Add(this.listMiniLabel);
            this.Controls.Add(this.arraySTDPopLabel);
            this.Controls.Add(this.arraySTDSamLabel);
            this.Controls.Add(this.arrayMedianLabel);
            this.Controls.Add(this.arrayTrunMeanLabel);
            this.Controls.Add(this.arrayMeanLabel);
            this.Controls.Add(this.arrayMaxLabel);
            this.Controls.Add(this.miniArrayLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sortedListBox);
            this.Controls.Add(this.valuesListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.disFractionTextBox);
            this.Controls.Add(this.valuesTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "form";
            this.Text = "StatisticsFunction";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valuesTextBox;
        private System.Windows.Forms.TextBox disFractionTextBox;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.ListBox sortedListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label miniArrayLabel;
        private System.Windows.Forms.Label arrayMaxLabel;
        private System.Windows.Forms.Label arrayMeanLabel;
        private System.Windows.Forms.Label arrayTrunMeanLabel;
        private System.Windows.Forms.Label arrayMedianLabel;
        private System.Windows.Forms.Label arraySTDSamLabel;
        private System.Windows.Forms.Label arraySTDPopLabel;
        private System.Windows.Forms.Label listMiniLabel;
        private System.Windows.Forms.Label ListMaxLabel;
        private System.Windows.Forms.Label listMeanLabel;
        private System.Windows.Forms.Label listTrunMeanLabel;
        private System.Windows.Forms.Label listMedianLabel;
        private System.Windows.Forms.Label listSTDSamLabel;
        private System.Windows.Forms.Label listSTDPopLabel;
        private System.Windows.Forms.Label arrayModeLabel;
        private System.Windows.Forms.Label listModeLabel;
    }
}

