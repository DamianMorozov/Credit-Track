using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LibCredit;

[assembly: NeutralResourcesLanguageAttribute("en-US")]
namespace ExampleMSChart
{
    public partial class Form1 : Form
    {
        #region Private fields and properties

        public ResourceManager ResManager { get; private set; }

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_Resize(sender, e);
            // Localization.
            comboBoxLocalization.SelectedIndex = 0;
            // View type.
            if (CultureInfo.CurrentCulture.Name == "ru-RU")
                comboBoxViewType.SelectedIndex = 1;
            else
                comboBoxViewType.SelectedIndex = 0;
        }

        private void SetLocalization(int localization)
        {
            string[] cultureNames = { "en-US", "ru-RU" };
            ResManager = new ResourceManager("WinForms.App.Resources.strings", Assembly.GetExecutingAssembly());
            string cultureName = cultureNames[0];
            if (localization >= 0 && localization <= 1)
                cultureName = cultureNames[localization];
            var culture = CultureInfo.CreateSpecificCulture(cultureName);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Text = ResManager.GetString("formCaption");

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
            SetLocalization((sender as ComboBox).SelectedIndex);
        }

        private void ComboBoxViewType_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart.Visible = comboBoxViewType.SelectedIndex != 0;
            dataGridView.Visible = comboBoxViewType.SelectedIndex == 0;
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            decimal creditAamount = fieldMoneyCredit.Value;
            decimal annualInterest = fieldAnnualInterest.Value;
            decimal creditTerm = fieldCreditTermMonths.Value;

            // Check-list.
            if (creditAamount <= 0 || annualInterest <= 0 || creditTerm <= 0)
            {
                MessageBox.Show(ResManager.GetString("messageErrorZeroInFields"),
                    ResManager.GetString("formCaption"));
                return;
            }

            ClassCalc _calc = ClassCalc.Instance;
            var records = _calc.Exec(creditAamount, annualInterest, creditTerm);

            PrintBody(records);
        }

        private void PrintBody(List<(int, decimal, decimal, decimal, decimal)> records)
        {
            // Chart
            PrintBodyChart(records);

            // Table
            PrintBodyTable(records);
        }

        private void PrintBodyChart(List<(int, decimal, decimal, decimal, decimal)> records)
        {
            chart.Titles.Clear();
            chart.Series.Clear();
            chart.Palette = ChartColorPalette.Chocolate;
            //var seriesNumber = chart.Series.Add(ResManager.GetString("dataGridViewColumn0"));
            var seriesPay = chart.Series.Add(ResManager.GetString("dataGridViewColumn1"));
            var seriesPercent = chart.Series.Add(ResManager.GetString("dataGridViewColumn2"));
            var seriesCredit = chart.Series.Add(ResManager.GetString("dataGridViewColumn3"));
            //var seriesRemaining= chart.Series.Add(ResManager.GetString("dataGridViewColumn4"));
            seriesCredit.ChartType = seriesPercent.ChartType = seriesPay.ChartType = SeriesChartType.RangeColumn;
            foreach (var item in records)
            {
                if (item.Item1 > 0 && item.Item5 > 0)
                {
                    //seriesNumber.Points.Add(new DataPoint(item.Item1, (double)item.Item1));
                    seriesPay.Points.Add(new DataPoint(item.Item1, (double)item.Item2));
                    seriesPercent.Points.Add(new DataPoint(item.Item1, (double)item.Item3));
                    seriesCredit.Points.Add(new DataPoint(item.Item1, (double)item.Item4));
                    //seriesRemaining.Points.Add(new DataPoint(item.Item1, (double)item.Item5));
                }
            }
        }

        private void PrintBodyTable(List<(int, decimal, decimal, decimal, decimal)> records)
        {
            // Table
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

        private void Form1_Resize(object sender, EventArgs e)
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
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = @"Calc.exe";
            pProcess.StartInfo.Arguments = "";
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            pProcess.StartInfo.CreateNoWindow = false;
            pProcess.Start();
            //string output = pProcess.StandardOutput.ReadToEnd(); //The output result
            pProcess.WaitForExit();
        }
    }
}
