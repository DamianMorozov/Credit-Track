﻿using LibCredit;
using LibWin;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
// ReSharper disable ResourceItemNotResolved

[assembly: NeutralResourcesLanguage("en-US")]
namespace WinForms.App
{
    public partial class FormMain : Form
    {
        #region Private fields and properties

        private readonly Process _proc = Process.Instance;
        private ResourceManager _resManager { get; set; }

        #endregion

        #region Form methods

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMain_Resize(sender, e);
            // Localization.
            comboBoxLocalization.SelectedIndex = CultureInfo.CurrentCulture.Name == "ru-RU" ? 1 : 0;
            // View type.
            comboBoxViewType.SelectedIndex = 0;
            // Clear.
            ButtonClear_Click(sender, e);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            //buttonClear.Width = buttonCalc.Width = Width/2 - 25;
            //buttonClear.Left = Width / 2;
            labelCreditTerm.Left = labelAnnualInterest.Left = labelViewType.Left = Width / 2;
            fieldCreditTermYears.Left = fieldCreditTermMonths.Left = fieldAnnualInterest.Left = comboBoxViewType.Left = Width / 2 + labelCreditTerm.Width + 5;
            labelCreditTermYears.Left = labelCreditTermMonths.Left = labelAnnualInterest2.Left = Width / 2 + labelCreditTerm.Width + 75;
        }

        private void SetLocalization(int localization)
        {
            string[] cultureNames = { "en-US", "ru-RU" };
            _resManager = new ResourceManager("WinForms.App.Resources.strings", Assembly.GetExecutingAssembly());
            var cultureName = cultureNames[0];
            if (localization >= 0 && localization <= 1)
                cultureName = cultureNames[localization];
            var culture = CultureInfo.CreateSpecificCulture(cultureName);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Text = _resManager.GetString("CreditTrack");

            labelLocalization.Text = _resManager.GetString("labelLocalization");
            comboBoxLocalization.SelectedIndexChanged -= ComboBoxLocalization_SelectedIndexChanged;
            comboBoxLocalization.Items[0] = _resManager.GetString("comboBoxLocalization0");
            comboBoxLocalization.Items[1] = _resManager.GetString("comboBoxLocalization1");
            comboBoxLocalization.SelectedIndexChanged += ComboBoxLocalization_SelectedIndexChanged;

            labelViewType.Text = _resManager.GetString("labelViewType");
            comboBoxViewType.SelectedIndexChanged -= ComboBoxViewType_SelectedIndexChanged;
            comboBoxViewType.Items[0] = _resManager.GetString("comboBoxViewType0");
            comboBoxViewType.Items[1] = _resManager.GetString("comboBoxViewType1");
            comboBoxViewType.SelectedIndexChanged += ComboBoxViewType_SelectedIndexChanged;

            dataGridView.Columns[0].HeaderText = _resManager.GetString("dataGridViewColumn0");
            dataGridView.Columns[1].HeaderText = _resManager.GetString("dataGridViewColumn1");
            dataGridView.Columns[2].HeaderText = _resManager.GetString("dataGridViewColumn2");
            dataGridView.Columns[3].HeaderText = _resManager.GetString("dataGridViewColumn3");
            dataGridView.Columns[4].HeaderText = _resManager.GetString("dataGridViewColumn4");

            labelMoneyCost.Text = _resManager.GetString("labelMoneyCost");
            labelMoneyOwn.Text = _resManager.GetString("labelMoneyOwn");
            labelMoneyCredit.Text = _resManager.GetString("labelMoneyCredit");

            labelAnnualInterest.Text = _resManager.GetString("labelAnnualInterest");
            labelCreditTerm.Text = _resManager.GetString("labelCreditTerm");
            labelCreditTermMonths.Text = _resManager.GetString("labelCreditTermMonths");
            labelCreditTermYears.Text = _resManager.GetString("labelCreditTermYears");

            buttonCalcExe.Text = _resManager.GetString("buttonCalcExe");
            buttonCalc.Text = _resManager.GetString("buttonCalc");
            buttonClear.Text = _resManager.GetString("buttonClear");

            // Chart
            if (chart.Series.Count > 0)
            {
                chart.Series[0].LegendText = _resManager.GetString("dataGridViewColumn1");
                if (chart.Series.Count > 1)
                    chart.Series[1].LegendText = _resManager.GetString("dataGridViewColumn2");
                if (chart.Series.Count > 2)
                    chart.Series[2].LegendText = _resManager.GetString("dataGridViewColumn3");
            }
        }

        #endregion

        #region Private methods

        private void ComboBoxLocalization_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLocalization(((ComboBox)sender).SelectedIndex);
        }

        private void ComboBoxViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView.Visible = !(chart.Visible = comboBoxViewType.SelectedIndex != 0);
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            var creditAmount = fieldMoneyCredit.Value;
            var annualInterest = fieldAnnualInterest.Value;
            var creditTerm = fieldCreditTermMonths.Value;

            // Check-list.
            if (creditAmount <= 0 || annualInterest <= 0 || creditTerm <= 0)
            {
                MessageBox.Show(_resManager.GetString("messageErrorZeroInFields"),
                    _resManager.GetString("formCaption"));
                return;
            }

            var calc = ClassCalc.Instance;
            var records = calc.Exec(creditAmount, annualInterest, creditTerm, true);

            PrintBody(records);
        }

        private void PrintBody(IReadOnlyList<ClassRecord> records)
        {
            switch (comboBoxViewType.SelectedIndex)
            {
                // Chart
                case 1:
                    PrintBodyChart(records);
                    break;
                // Table
                default:
                    PrintBodyTable(records);
                    break;
            }
        }

        private void PrintBodyTable(IReadOnlyList<ClassRecord> records)
        {
            dataGridView.Rows.Clear();
            // Summary.
            dataGridView.Rows.Add(null, records[records.Count - 1].Pay, records[records.Count - 1].Percent, records[records.Count - 1].Credit, null);
            // Items.
            foreach (var item in records)
            {
                if (item.Number > 0 && item.Remaining > 0)
                {
                    dataGridView.Rows.Add(item.Number, item.Pay, item.Percent, item.Credit, item.Remaining);
                }
            }
        }

        private void PrintBodyChart(IReadOnlyList<ClassRecord> records)
        {
            chart.Series.Clear();
            chart.Titles.Clear();
            chart.Palette = ChartColorPalette.Excel;

            Series seriesPercent = null;
            Series seriesCredit = null;
            if (_resManager != null)
            {
                var namePercent = _resManager.GetString("dataGridViewColumn2");
                if (!string.IsNullOrEmpty(namePercent))
                    seriesPercent = chart.Series.Add(namePercent);
                var nameCredit = _resManager.GetString("dataGridViewColumn3");
                if (!string.IsNullOrEmpty(nameCredit))
                    seriesCredit = chart.Series.Add(nameCredit);
            }
            foreach (var item in records)
            {
                if (item.Number > 0 && item.Remaining > 0)
                {
                    seriesPercent?.Points.Add(new DataPoint((int)item.Number, (double)item.Percent));
                    seriesCredit?.Points.Add(new DataPoint((int)item.Number, (double)item.Credit));
                }
            }
        }

        private void FieldMoneyCost_ValueChanged(object sender, EventArgs e)
        {
            fieldMoneyCredit.Value = fieldMoneyCost.Value - fieldMoneyOwn.Value;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            // Chart
            chart.Titles.Clear();
            chart.Series.Clear();
            chart.Palette = ChartColorPalette.Chocolate;
            // Table
            dataGridView.Rows.Clear();
            // Fields
            fieldMoneyCost.Value = 100_000;
            fieldMoneyOwn.Value = 50_000;
            fieldAnnualInterest.Value = 10;
            fieldCreditTermMonths.Value = 12;
        }

        private void FieldCreditTermMonths_ValueChanged(object sender, EventArgs e)
        {
            fieldCreditTermYears.Value = fieldCreditTermMonths.Value / 12;
        }

        private void ButtonCalcExe_Click(object sender, EventArgs e)
        {
            _proc.Run("calc");
        }

        #endregion
    }
}
