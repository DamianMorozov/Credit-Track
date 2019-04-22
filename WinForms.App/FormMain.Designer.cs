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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.comboBoxViewType = new System.Windows.Forms.ComboBox();
            this.labelViewType = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.labelLocalization = new System.Windows.Forms.Label();
            this.comboBoxLocalization = new System.Windows.Forms.ComboBox();
            this.labelMoneyCredit = new System.Windows.Forms.Label();
            this.fieldMoneyCredit = new System.Windows.Forms.NumericUpDown();
            this.fieldAnnualInterest = new System.Windows.Forms.NumericUpDown();
            this.labelAnnualInterest = new System.Windows.Forms.Label();
            this.labelAnnualInterest2 = new System.Windows.Forms.Label();
            this.labelCreditTerm2 = new System.Windows.Forms.Label();
            this.fieldCreditTerm = new System.Windows.Forms.NumericUpDown();
            this.labelCreditTerm = new System.Windows.Forms.Label();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.fieldMoneyCost = new System.Windows.Forms.NumericUpDown();
            this.labelMoneyCost = new System.Windows.Forms.Label();
            this.fieldMoneyOwn = new System.Windows.Forms.NumericUpDown();
            this.labelMoneyOwn = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.ColumnNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldMoneyCredit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldAnnualInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldCreditTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldMoneyCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldMoneyOwn)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackColor = System.Drawing.SystemColors.Control;
            this.chart.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea6.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea6);
            legend6.Alignment = System.Drawing.StringAlignment.Center;
            legend6.BackColor = System.Drawing.SystemColors.Control;
            legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend6.ForeColor = System.Drawing.Color.Blue;
            legend6.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend6.MaximumAutoSize = 30F;
            legend6.Name = "Legend1";
            legend6.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chart.Legends.Add(legend6);
            this.chart.Location = new System.Drawing.Point(10, 145);
            this.chart.Margin = new System.Windows.Forms.Padding(4);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart.Size = new System.Drawing.Size(615, 250);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            this.chart.Visible = false;
            // 
            // comboBoxViewType
            // 
            this.comboBoxViewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViewType.FormattingEnabled = true;
            this.comboBoxViewType.Items.AddRange(new object[] {
            "Table",
            "Chart"});
            this.comboBoxViewType.Location = new System.Drawing.Point(460, 10);
            this.comboBoxViewType.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxViewType.Name = "comboBoxViewType";
            this.comboBoxViewType.Size = new System.Drawing.Size(100, 23);
            this.comboBoxViewType.TabIndex = 1;
            this.comboBoxViewType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxViewType_SelectedIndexChanged);
            // 
            // labelViewType
            // 
            this.labelViewType.Location = new System.Drawing.Point(330, 15);
            this.labelViewType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelViewType.Name = "labelViewType";
            this.labelViewType.Size = new System.Drawing.Size(125, 15);
            this.labelViewType.TabIndex = 2;
            this.labelViewType.Text = "View type";
            this.labelViewType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNum,
            this.ColumnPay,
            this.ColumnPercent,
            this.ColumnCredit,
            this.Column});
            this.dataGridView.Location = new System.Drawing.Point(10, 145);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(615, 455);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.Visible = false;
            // 
            // labelLocalization
            // 
            this.labelLocalization.Location = new System.Drawing.Point(10, 15);
            this.labelLocalization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocalization.Name = "labelLocalization";
            this.labelLocalization.Size = new System.Drawing.Size(160, 15);
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
            // labelMoneyCredit
            // 
            this.labelMoneyCredit.Location = new System.Drawing.Point(10, 96);
            this.labelMoneyCredit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoneyCredit.Name = "labelMoneyCredit";
            this.labelMoneyCredit.Size = new System.Drawing.Size(160, 15);
            this.labelMoneyCredit.TabIndex = 6;
            this.labelMoneyCredit.Text = "Credit money";
            this.labelMoneyCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fieldMoneyCredit
            // 
            this.fieldMoneyCredit.Location = new System.Drawing.Point(175, 91);
            this.fieldMoneyCredit.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.fieldMoneyCredit.Name = "fieldMoneyCredit";
            this.fieldMoneyCredit.ReadOnly = true;
            this.fieldMoneyCredit.Size = new System.Drawing.Size(100, 23);
            this.fieldMoneyCredit.TabIndex = 7;
            this.fieldMoneyCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldMoneyCredit.ThousandsSeparator = true;
            this.fieldMoneyCredit.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            // 
            // fieldAnnualInterest
            // 
            this.fieldAnnualInterest.DecimalPlaces = 2;
            this.fieldAnnualInterest.Location = new System.Drawing.Point(460, 40);
            this.fieldAnnualInterest.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fieldAnnualInterest.Name = "fieldAnnualInterest";
            this.fieldAnnualInterest.Size = new System.Drawing.Size(65, 23);
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
            this.labelAnnualInterest.Location = new System.Drawing.Point(330, 45);
            this.labelAnnualInterest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnnualInterest.Name = "labelAnnualInterest";
            this.labelAnnualInterest.Size = new System.Drawing.Size(127, 15);
            this.labelAnnualInterest.TabIndex = 8;
            this.labelAnnualInterest.Text = "Annual interest";
            this.labelAnnualInterest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAnnualInterest2
            // 
            this.labelAnnualInterest2.AutoSize = true;
            this.labelAnnualInterest2.Location = new System.Drawing.Point(530, 45);
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
            this.labelCreditTerm2.Location = new System.Drawing.Point(530, 70);
            this.labelCreditTerm2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreditTerm2.Name = "labelCreditTerm2";
            this.labelCreditTerm2.Size = new System.Drawing.Size(49, 15);
            this.labelCreditTerm2.TabIndex = 13;
            this.labelCreditTerm2.Text = "months";
            this.labelCreditTerm2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fieldCreditTerm
            // 
            this.fieldCreditTerm.Location = new System.Drawing.Point(460, 65);
            this.fieldCreditTerm.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.fieldCreditTerm.Name = "fieldCreditTerm";
            this.fieldCreditTerm.Size = new System.Drawing.Size(65, 23);
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
            this.labelCreditTerm.Location = new System.Drawing.Point(330, 70);
            this.labelCreditTerm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreditTerm.Name = "labelCreditTerm";
            this.labelCreditTerm.Size = new System.Drawing.Size(125, 15);
            this.labelCreditTerm.TabIndex = 11;
            this.labelCreditTerm.Text = "Credit term";
            this.labelCreditTerm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Location = new System.Drawing.Point(10, 120);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(300, 23);
            this.buttonCalc.TabIndex = 14;
            this.buttonCalc.Text = "Calculate";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // fieldMoneyCost
            // 
            this.fieldMoneyCost.Location = new System.Drawing.Point(175, 40);
            this.fieldMoneyCost.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.fieldMoneyCost.Name = "fieldMoneyCost";
            this.fieldMoneyCost.Size = new System.Drawing.Size(100, 23);
            this.fieldMoneyCost.TabIndex = 16;
            this.fieldMoneyCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldMoneyCost.ThousandsSeparator = true;
            this.fieldMoneyCost.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fieldMoneyCost.ValueChanged += new System.EventHandler(this.FieldMoneyCost_ValueChanged);
            // 
            // labelMoneyCost
            // 
            this.labelMoneyCost.Location = new System.Drawing.Point(10, 45);
            this.labelMoneyCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoneyCost.Name = "labelMoneyCost";
            this.labelMoneyCost.Size = new System.Drawing.Size(160, 15);
            this.labelMoneyCost.TabIndex = 15;
            this.labelMoneyCost.Text = "Cost money";
            this.labelMoneyCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fieldMoneyOwn
            // 
            this.fieldMoneyOwn.Location = new System.Drawing.Point(175, 65);
            this.fieldMoneyOwn.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.fieldMoneyOwn.Name = "fieldMoneyOwn";
            this.fieldMoneyOwn.Size = new System.Drawing.Size(100, 23);
            this.fieldMoneyOwn.TabIndex = 18;
            this.fieldMoneyOwn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fieldMoneyOwn.ThousandsSeparator = true;
            this.fieldMoneyOwn.Value = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.fieldMoneyOwn.ValueChanged += new System.EventHandler(this.FieldMoneyCost_ValueChanged);
            // 
            // labelMoneyOwn
            // 
            this.labelMoneyOwn.Location = new System.Drawing.Point(10, 70);
            this.labelMoneyOwn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMoneyOwn.Name = "labelMoneyOwn";
            this.labelMoneyOwn.Size = new System.Drawing.Size(160, 15);
            this.labelMoneyOwn.TabIndex = 17;
            this.labelMoneyOwn.Text = "Own money";
            this.labelMoneyOwn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(325, 120);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(300, 23);
            this.buttonClear.TabIndex = 19;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ColumnNum
            // 
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle32.Format = "N0";
            dataGridViewCellStyle32.NullValue = null;
            this.ColumnNum.DefaultCellStyle = dataGridViewCellStyle32;
            this.ColumnNum.FillWeight = 60F;
            this.ColumnNum.HeaderText = "Number";
            this.ColumnNum.MinimumWidth = 60;
            this.ColumnNum.Name = "ColumnNum";
            this.ColumnNum.ReadOnly = true;
            this.ColumnNum.Width = 60;
            // 
            // ColumnPay
            // 
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle33.Format = "C0";
            dataGridViewCellStyle33.NullValue = null;
            this.ColumnPay.DefaultCellStyle = dataGridViewCellStyle33;
            this.ColumnPay.FillWeight = 120F;
            this.ColumnPay.HeaderText = "Pay";
            this.ColumnPay.MinimumWidth = 120;
            this.ColumnPay.Name = "ColumnPay";
            this.ColumnPay.ReadOnly = true;
            this.ColumnPay.Width = 120;
            // 
            // ColumnPercent
            // 
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle34.Format = "C0";
            dataGridViewCellStyle34.NullValue = null;
            this.ColumnPercent.DefaultCellStyle = dataGridViewCellStyle34;
            this.ColumnPercent.FillWeight = 120F;
            this.ColumnPercent.HeaderText = "Percent";
            this.ColumnPercent.MinimumWidth = 120;
            this.ColumnPercent.Name = "ColumnPercent";
            this.ColumnPercent.ReadOnly = true;
            this.ColumnPercent.Width = 120;
            // 
            // ColumnCredit
            // 
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle35.Format = "C0";
            dataGridViewCellStyle35.NullValue = null;
            this.ColumnCredit.DefaultCellStyle = dataGridViewCellStyle35;
            this.ColumnCredit.FillWeight = 120F;
            this.ColumnCredit.HeaderText = "Credit";
            this.ColumnCredit.MinimumWidth = 120;
            this.ColumnCredit.Name = "ColumnCredit";
            this.ColumnCredit.Width = 120;
            // 
            // Column
            // 
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle36.Format = "C0";
            dataGridViewCellStyle36.NullValue = null;
            this.Column.DefaultCellStyle = dataGridViewCellStyle36;
            this.Column.FillWeight = 120F;
            this.Column.HeaderText = "Remaining";
            this.Column.MinimumWidth = 120;
            this.Column.Name = "Column";
            this.Column.ReadOnly = true;
            this.Column.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.fieldMoneyOwn);
            this.Controls.Add(this.labelMoneyOwn);
            this.Controls.Add(this.fieldMoneyCost);
            this.Controls.Add(this.labelMoneyCost);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.labelCreditTerm2);
            this.Controls.Add(this.fieldCreditTerm);
            this.Controls.Add(this.labelCreditTerm);
            this.Controls.Add(this.labelAnnualInterest2);
            this.Controls.Add(this.fieldAnnualInterest);
            this.Controls.Add(this.labelAnnualInterest);
            this.Controls.Add(this.fieldMoneyCredit);
            this.Controls.Add(this.labelMoneyCredit);
            this.Controls.Add(this.labelLocalization);
            this.Controls.Add(this.comboBoxLocalization);
            this.Controls.Add(this.labelViewType);
            this.Controls.Add(this.comboBoxViewType);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1920, 1400);
            this.MinimumSize = new System.Drawing.Size(650, 300);
            this.Name = "Form1";
            this.Text = "Credit pays";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldMoneyCredit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldAnnualInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldCreditTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldMoneyCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fieldMoneyOwn)).EndInit();
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
        private System.Windows.Forms.Label labelMoneyCredit;
        private System.Windows.Forms.NumericUpDown fieldMoneyCredit;
        private System.Windows.Forms.NumericUpDown fieldAnnualInterest;
        private System.Windows.Forms.Label labelAnnualInterest;
        private System.Windows.Forms.Label labelAnnualInterest2;
        private System.Windows.Forms.Label labelCreditTerm2;
        private System.Windows.Forms.NumericUpDown fieldCreditTerm;
        private System.Windows.Forms.Label labelCreditTerm;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.NumericUpDown fieldMoneyCost;
        private System.Windows.Forms.Label labelMoneyCost;
        private System.Windows.Forms.NumericUpDown fieldMoneyOwn;
        private System.Windows.Forms.Label labelMoneyOwn;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column;
    }
}

