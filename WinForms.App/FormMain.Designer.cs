namespace ExampleMSChart
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxViewType = new System.Windows.Forms.ComboBox();
            this.labelViewType = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelLocalization = new System.Windows.Forms.Label();
            this.comboBoxLocalization = new System.Windows.Forms.ComboBox();
            this.labelCreditAmount = new System.Windows.Forms.Label();
            this.fieldCreditAamount = new System.Windows.Forms.NumericUpDown();
            this.fieldAnnualInterest = new System.Windows.Forms.NumericUpDown();
            this.labelAnnualInterest = new System.Windows.Forms.Label();
            this.labelAnnualInterest2 = new System.Windows.Forms.Label();
            this.labelCreditTerm2 = new System.Windows.Forms.Label();
            this.fieldCreditTerm = new System.Windows.Forms.NumericUpDown();
            this.labelCreditTerm = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldCreditAamount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldAnnualInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldCreditTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(10, 100);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(615, 500);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            title3.Name = "Title1";
            this.chart.Titles.Add(title3);
            this.chart.Visible = false;
            // 
            // comboBoxViewType
            // 
            this.comboBoxViewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewType.FormattingEnabled = true;
            this.comboBoxViewType.Items.AddRange(new object[] {
            "Table",
            "Chart"});
            this.comboBoxViewType.Location = new System.Drawing.Point(400, 10);
            this.comboBoxViewType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxViewType.Name = "comboBoxViewType";
            this.comboBoxViewType.Size = new System.Drawing.Size(100, 23);
            this.comboBoxViewType.TabIndex = 1;
            this.comboBoxViewType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxViewType_SelectedIndexChanged);
            // 
            // labelViewType
            // 
            this.labelViewType.Location = new System.Drawing.Point(295, 15);
            this.labelViewType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelViewType.Name = "labelViewType";
            this.labelViewType.Size = new System.Drawing.Size(100, 15);
            this.labelViewType.TabIndex = 2;
            this.labelViewType.Text = "View type";
            this.labelViewType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNum,
            this.ColumnPay,
            this.ColumnPercent,
            this.Column});
            this.dataGridView.Location = new System.Drawing.Point(10, 100);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(615, 500);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.Visible = false;
            // 
            // ColumnNum
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Format = "N0";
            dataGridViewCellStyle12.NullValue = null;
            this.ColumnNum.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnNum.HeaderText = "Number";
            this.ColumnNum.Name = "ColumnNum";
            this.ColumnNum.ReadOnly = true;
            // 
            // ColumnPay
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Format = "C0";
            dataGridViewCellStyle13.NullValue = null;
            this.ColumnPay.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnPay.FillWeight = 150F;
            this.ColumnPay.HeaderText = "Pay";
            this.ColumnPay.Name = "ColumnPay";
            this.ColumnPay.ReadOnly = true;
            this.ColumnPay.Width = 150;
            // 
            // ColumnPercent
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Format = "C0";
            dataGridViewCellStyle14.NullValue = null;
            this.ColumnPercent.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnPercent.FillWeight = 150F;
            this.ColumnPercent.HeaderText = "Percent";
            this.ColumnPercent.Name = "ColumnPercent";
            this.ColumnPercent.ReadOnly = true;
            this.ColumnPercent.Width = 150;
            // 
            // Column
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Format = "C0";
            dataGridViewCellStyle15.NullValue = null;
            this.Column.DefaultCellStyle = dataGridViewCellStyle15;
            this.Column.FillWeight = 150F;
            this.Column.HeaderText = "Remaining";
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Width = 150;
            // 
            // labelLocalization
            // 
            this.labelLocalization.Location = new System.Drawing.Point(65, 15);
            this.labelLocalization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocalization.Name = "labelLocalization";
            this.labelLocalization.Size = new System.Drawing.Size(100, 15);
            this.labelLocalization.TabIndex = 5;
            this.labelLocalization.Text = "Localization";
            this.labelLocalization.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxLocalization
            // 
            this.comboBoxLocalization.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLocalization.FormattingEnabled = true;
            this.comboBoxLocalization.Items.AddRange(new object[] {
            "English",
            "Russian"});
            this.comboBoxLocalization.Location = new System.Drawing.Point(175, 10);
            this.comboBoxLocalization.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxLocalization.Name = "comboBoxLocalization";
            this.comboBoxLocalization.Size = new System.Drawing.Size(100, 23);
            this.comboBoxLocalization.TabIndex = 4;
            this.comboBoxLocalization.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLocalization_SelectedIndexChanged);
            // 
            // labelCreditAmount
            // 
            this.labelCreditAmount.Location = new System.Drawing.Point(10, 45);
            this.labelCreditAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreditAmount.Name = "labelCreditAmount";
            this.labelCreditAmount.Size = new System.Drawing.Size(100, 15);
            this.labelCreditAmount.TabIndex = 6;
            this.labelCreditAmount.Text = "Credit amount";
            this.labelCreditAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fieldCreditAamount
            // 
            this.fieldCreditAamount.Location = new System.Drawing.Point(110, 40);
            this.fieldCreditAamount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.fieldCreditAamount.Name = "fieldCreditAamount";
            this.fieldCreditAamount.Size = new System.Drawing.Size(95, 23);
            this.fieldCreditAamount.TabIndex = 7;
            this.fieldCreditAamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldCreditAamount.ThousandsSeparator = true;
            this.fieldCreditAamount.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // fieldAnnualInterest
            // 
            this.fieldAnnualInterest.DecimalPlaces = 2;
            this.fieldAnnualInterest.Location = new System.Drawing.Point(348, 40);
            this.fieldAnnualInterest.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fieldAnnualInterest.Name = "fieldAnnualInterest";
            this.fieldAnnualInterest.Size = new System.Drawing.Size(60, 23);
            this.fieldAnnualInterest.TabIndex = 9;
            this.fieldAnnualInterest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldAnnualInterest.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // labelAnnualInterest
            // 
            this.labelAnnualInterest.Location = new System.Drawing.Point(225, 45);
            this.labelAnnualInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnnualInterest.Name = "labelAnnualInterest";
            this.labelAnnualInterest.Size = new System.Drawing.Size(120, 15);
            this.labelAnnualInterest.TabIndex = 8;
            this.labelAnnualInterest.Text = "Annual interest";
            this.labelAnnualInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAnnualInterest2
            // 
            this.labelAnnualInterest2.AutoSize = true;
            this.labelAnnualInterest2.Location = new System.Drawing.Point(412, 45);
            this.labelAnnualInterest2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnnualInterest2.Name = "labelAnnualInterest2";
            this.labelAnnualInterest2.Size = new System.Drawing.Size(14, 15);
            this.labelAnnualInterest2.TabIndex = 10;
            this.labelAnnualInterest2.Text = "%";
            this.labelAnnualInterest2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCreditTerm2
            // 
            this.labelCreditTerm2.AutoSize = true;
            this.labelCreditTerm2.Location = new System.Drawing.Point(577, 45);
            this.labelCreditTerm2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreditTerm2.Name = "labelCreditTerm2";
            this.labelCreditTerm2.Size = new System.Drawing.Size(49, 15);
            this.labelCreditTerm2.TabIndex = 13;
            this.labelCreditTerm2.Text = "months";
            this.labelCreditTerm2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fieldCreditTerm
            // 
            this.fieldCreditTerm.Location = new System.Drawing.Point(522, 40);
            this.fieldCreditTerm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fieldCreditTerm.Name = "fieldCreditTerm";
            this.fieldCreditTerm.Size = new System.Drawing.Size(50, 23);
            this.fieldCreditTerm.TabIndex = 12;
            this.fieldCreditTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldCreditTerm.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // labelCreditTerm
            // 
            this.labelCreditTerm.Location = new System.Drawing.Point(427, 45);
            this.labelCreditTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreditTerm.Name = "labelCreditTerm";
            this.labelCreditTerm.Size = new System.Drawing.Size(90, 15);
            this.labelCreditTerm.TabIndex = 11;
            this.labelCreditTerm.Text = "Credit term";
            this.labelCreditTerm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(10, 71);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(615, 23);
            this.buttonCalc.TabIndex = 14;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelCreditTerm2);
            this.Controls.Add(this.fieldCreditTerm);
            this.Controls.Add(this.labelCreditTerm);
            this.Controls.Add(this.labelAnnualInterest2);
            this.Controls.Add(this.fieldAnnualInterest);
            this.Controls.Add(this.labelAnnualInterest);
            this.Controls.Add(this.fieldCreditAamount);
            this.Controls.Add(this.labelCreditAmount);
            this.Controls.Add(this.labelLocalization);
            this.Controls.Add(this.comboBoxLocalization);
            this.Controls.Add(this.labelViewType);
            this.Controls.Add(this.comboBoxViewType);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.chart);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 1400);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "Form1";
            this.Text = "Credit pays";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldCreditAamount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldAnnualInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldCreditTerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.ComboBox comboBoxViewType;
        private System.Windows.Forms.Label labelViewType;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelLocalization;
        private System.Windows.Forms.ComboBox comboBoxLocalization;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
        private System.Windows.Forms.Label labelCreditAmount;
        private System.Windows.Forms.NumericUpDown fieldCreditAamount;
        private System.Windows.Forms.NumericUpDown fieldAnnualInterest;
        private System.Windows.Forms.Label labelAnnualInterest;
        private System.Windows.Forms.Label labelAnnualInterest2;
        private System.Windows.Forms.Label labelCreditTerm2;
        private System.Windows.Forms.NumericUpDown fieldCreditTerm;
        private System.Windows.Forms.Label labelCreditTerm;
        private System.Windows.Forms.Button buttonCalc;
    }
}

