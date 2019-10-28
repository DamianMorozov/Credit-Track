using LibCredit;
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

        private Process _proc = Process.Instance;
        private ResourceManager ResManager { get; set; }

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
            ResManager = new ResourceManager("WinForms.App.Resources.strings", Assembly.GetExecutingAssembly());
            var cultureName = cultureNames[0];
            if (localization >= 0 && localization <= 1)
                cultureName = cultureNames[localization];
            var culture = CultureInfo.CreateSpecificCulture(cultureName);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Text = ResManager.GetString("CreditTrack");

            labelLocalization.Text = ResManager.GetString("labelLocalization");
            comboBoxLocalization.SelectedIndexChanged -= ComboBoxLocalization_SelectedIndexChanged;
            comboBoxLocalization.Items[0] = ResManager.GetString("comboBoxLocalization0");
            comboBoxLocalization.Items[1] = ResManager.GetString("comboBoxLocalization1");
            comboBoxLocalization.SelectedIndexChanged += ComboBoxLocalization_SelectedIndexChanged;

            labelViewType.Text = ResManager.GetString("labelViewType");
            comboBoxViewType.SelectedIndexChanged -= ComboBoxViewType_SelectedIndexChanged;
            comboBoxViewType.Items[0] = ResManager.GetString("comboBoxViewType0");
            comboBoxViewType.Items[1] = ResManager.GetString("comboBoxViewType1");
            comboBoxViewType.SelectedIndexChanged += ComboBoxViewType_SelectedIndexChanged;

            dataGridView.Columns[0].HeaderText = ResManager.GetString("dataGridViewColumn0");
            dataGridView.Columns[1].HeaderText = ResManager.GetString("dataGridViewColumn1");
            dataGridView.Columns[2].HeaderText = ResManager.GetString("dataGridViewColumn2");
            dataGridView.Columns[3].HeaderText = ResManager.GetString("dataGridViewColumn3");
            dataGridView.Columns[4].HeaderText = ResManager.GetString("dataGridViewColumn4");

            labelMoneyCost.Text = ResManager.GetString("labelMoneyCost");
            labelMoneyOwn.Text = ResManager.GetString("labelMoneyOwn");
            labelMoneyCredit.Text = ResManager.GetString("labelMoneyCredit");

            labelAnnualInterest.Text = ResManager.GetString("labelAnnualInterest");
            labelCreditTerm.Text = ResManager.GetString("labelCreditTerm");
            labelCreditTermMonths.Text = ResManager.GetString("labelCreditTermMonths");
            labelCreditTermYears.Text = ResManager.GetString("labelCreditTermYears");

            buttonCalcExe.Text = ResManager.GetString("buttonCalcExe");
            buttonCalc.Text = ResManager.GetString("buttonCalc");
            buttonClear.Text = ResManager.GetString("buttonClear");

            // Chart
            if (chart.Series.Count > 0)
            {
                chart.Series[0].LegendText = ResManager.GetString("dataGridViewColumn1");
                if (chart.Series.Count > 1)
                    chart.Series[1].LegendText = ResManager.GetString("dataGridViewColumn2");
                if (chart.Series.Count > 2)
                    chart.Series[2].LegendText = ResManager.GetString("dataGridViewColumn3");
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
                MessageBox.Show(ResManager.GetString("messageErrorZeroInFields"),
                    ResManager.GetString("formCaption"));
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
                    chart.Series.Clear();
                    chart.Titles.Clear();
                    chart.Palette = ChartColorPalette.Excel;
                    //var seriesNumber = chart.Series.Add(ResManager.GetString("dataGridViewColumn0"));
                    Series seriesPay = null;
                    Series seriesPercent = null;
                    Series seriesCredit = null;
                    if (ResManager != null)
                    {
                        var name1 = ResManager.GetString("dataGridViewColumn1");
                        if (!string.IsNullOrEmpty(name1))
                            seriesPay = chart.Series.Add(name1);
                        var name2 = ResManager.GetString("dataGridViewColumn2");
                        if (!string.IsNullOrEmpty(name2))
                            seriesPercent = chart.Series.Add(name2);
                        var name3 = ResManager.GetString("dataGridViewColumn3");
                        if (!string.IsNullOrEmpty(name3))
                            seriesCredit = chart.Series.Add(name3);
                    }
                    //var seriesRemaining= chart.Series.Add(ResManager.GetString("dataGridViewColumn4"));
                    foreach (var item in records)
                    {
                        if (item.Number > 0 && item.Remaining > 0)
                        {
                            //seriesNumber.Points.Add(new DataPoint(item.Number, (double)item.Number));
                            seriesPay?.Points.Add(new DataPoint(item.Number, (double)item.Pay));
                            seriesPercent?.Points.Add(new DataPoint(item.Number, (double)item.Percent));
                            seriesCredit?.Points.Add(new DataPoint(item.Number, (double)item.Credit));
                            //seriesRemaining.Points.Add(new DataPoint(item.Number, (double)item.Remaining));
                        }
                    }
                    break;
                // Table
                default:
                    dataGridView.Rows.Clear();
                    // Summary.
                    dataGridView.Rows.Add(new object[] { null,
                        records[records.Count - 1].Pay,
                        records[records.Count - 1].Percent,
                        records[records.Count - 1].Credit,
                        null});
                    // Items.
                    foreach (var item in records)
                    {
                        if (item.Number > 0 && item.Remaining > 0)
                        {
                            dataGridView.Rows.Add(new object[] {
                                item.Number,
                                item.Pay,
                                item.Percent,
                                item.Credit,
                                item.Remaining });
                        }
                    }
                    break;
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
