using LibCredit;
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

        private ResourceManager ResManager { get; set; }

        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        #region Private methods

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormMain_Resize(sender, e);
            // Localization.
            comboBoxLocalization.SelectedIndex = CultureInfo.CurrentCulture.Name == "ru-RU" ? 1 : 0;
            // View type.
            comboBoxViewType.SelectedIndex = 0;
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

        private void ComboBoxLocalization_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetLocalization(((ComboBox)sender).SelectedIndex);
        }

        private void ComboBoxViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Visible = comboBoxViewType.SelectedIndex != 0;
            dataGridView.Visible = comboBoxViewType.SelectedIndex == 0;
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            var creditAmount = fieldMoneyCost.Value;
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
            var records = calc.Exec(creditAmount, annualInterest, creditTerm);

            PrintBody(records);
        }

        private void PrintBody(IReadOnlyList<(int, decimal, decimal, decimal, decimal)> records)
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
                        if (item.Item1 > 0 && item.Item5 > 0)
                        {
                            //seriesNumber.Points.Add(new DataPoint(item.Item1, (double)item.Item1));
                            seriesPay?.Points.Add(new DataPoint(item.Item1, (double)item.Item2));
                            seriesPercent?.Points.Add(new DataPoint(item.Item1, (double)item.Item3));
                            seriesCredit?.Points.Add(new DataPoint(item.Item1, (double)item.Item4));
                            //seriesRemaining.Points.Add(new DataPoint(item.Item1, (double)item.Item5));
                        }
                    }
                    break;
                // Table
                default:
                    dataGridView.Rows.Clear();
                    dataGridView.Rows.Add(new object[] { null,
                        records[records.Count - 1].Item2,
                        records[records.Count - 1].Item3,
                        records[records.Count - 1].Item4,
                        null});
                    foreach (var item in records)
                    {
                        if (item.Item1 > 0 && item.Item5 > 0)
                        {
                            dataGridView.Rows.Add(new object[] {
                                item.Item1,
                                item.Item2,
                                item.Item3,
                                item.Item4,
                                item.Item5 });
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

        private void FormMain_Resize(object sender, EventArgs e)
        {
            //buttonClear.Width = buttonCalc.Width = Width/2 - 25;
            //buttonClear.Left = Width / 2;

            labelCreditTerm.Left = labelAnnualInterest.Left = labelViewType.Left = Width / 2;
            fieldCreditTermYears.Left = fieldCreditTermMonths.Left = fieldAnnualInterest.Left = comboBoxViewType.Left = Width / 2 + labelCreditTerm.Width + 5;
            labelCreditTermYears.Left = labelCreditTermMonths.Left = labelAnnualInterest2.Left = Width / 2 + labelCreditTerm.Width + 75;
        }

        private void FieldCreditTermMonths_ValueChanged(object sender, EventArgs e)
        {
            fieldCreditTermYears.Value = fieldCreditTermMonths.Value / 12;
        }

        private void ButtonCalcExe_Click(object sender, EventArgs e)
        {
            var pProcess = new System.Diagnostics.Process
            {
                StartInfo =
                {
                    FileName = @"Calc.exe",
                    Arguments = "",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    CreateNoWindow = false
                }
            };
            pProcess.Start();
            //string output = pProcess.StandardOutput.ReadToEnd(); //The output result
            pProcess.WaitForExit();
        }

        #endregion
    }
}
