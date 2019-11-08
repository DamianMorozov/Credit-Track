using DevExpress.XtraBars;
using DevExpress.XtraCharts;
using LibCredit;
using LibDevExpress;
using LibWin;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
// ReSharper disable ResourceItemNotResolved

[assembly: NeutralResourcesLanguage("en-US")]
namespace DX.App
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Private fields & properties & helpers

        private DevExpressHelper _devHelper = DevExpressHelper.Instance;
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
            barEditItemLocalization.EditValue = CultureInfo.CurrentCulture.Name == "ru-RU"
                ? repositoryItemLocalization.Items[1] : repositoryItemLocalization.Items[0];
            // View type.
            barEditItemViewType.EditValue = repositoryItemViewType.Items[0];
            // Clear.
            BarButtonItemClear_ItemClick(sender, null);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            //
        }

        private void SetLocalization(int localization)
        {
            string[] cultureNames = { "en-US", "ru-RU" };
            ResManager = new ResourceManager("DX.App.Resources.strings", Assembly.GetExecutingAssembly());
            var cultureName = cultureNames[0];
            if (localization >= 0 && localization <= 1)
                cultureName = cultureNames[localization];
            var culture = CultureInfo.CreateSpecificCulture(cultureName);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Text = ResManager.GetString("formCaption");

            ribbonPageGroupSettings.Text = ResManager.GetString("labelSettings");
            ribbonPageCalc.Text = ResManager.GetString("labelCalc");
            ribbonPageGroupCalc.Text = ResManager.GetString("buttonCalc");

            // Settings - Localization.
            barEditItemLocalization.Caption = ResManager.GetString("labelLocalization");
            barEditItemLocalization.EditValueChanged -= barEditItemLocalization_EditValueChanged;
            var i = GetBarEditItemIndex(barEditItemLocalization);
            repositoryItemLocalization.Items[0] = ResManager.GetString("comboBoxLocalization0");
            repositoryItemLocalization.Items[1] = ResManager.GetString("comboBoxLocalization1");
            barEditItemLocalization.EditValue = repositoryItemLocalization.Items[i];
            barEditItemLocalization.EditValueChanged += barEditItemLocalization_EditValueChanged;
            // Settings - ViewType.
            barEditItemViewType.Caption = ResManager.GetString("labelViewType");
            barEditItemViewType.EditValueChanged -= barEditItemViewType_EditValueChanged;
            var j = GetBarEditItemIndex(barEditItemViewType);
            repositoryItemViewType.Items[0] = ResManager.GetString("comboBoxViewType0");
            repositoryItemViewType.Items[1] = ResManager.GetString("comboBoxViewType1");
            barEditItemViewType.EditValue = repositoryItemViewType.Items[i];
            barEditItemViewType.EditValueChanged += barEditItemViewType_EditValueChanged;

            // Calculate.
            fieldMoneyCost.Caption = ResManager.GetString("labelMoneyCost");
            fieldMoneyOwn.Caption = ResManager.GetString("labelMoneyOwn");
            fieldMoneyCredit.Caption = ResManager.GetString("labelMoneyCredit");

            fieldAnnualInterest.Caption = ResManager.GetString("labelAnnualInterest");
            fieldCreditTermMonths.Caption = ResManager.GetString("labelCreditTermMonthsFull");
            fieldCreditTermYears.Caption = ResManager.GetString("labelCreditTermYearsFull");

            barButtonItemCalc.Caption = ResManager.GetString("buttonCalc");
            barButtonItemClear.Caption = ResManager.GetString("buttonClear");
            barButtonItemCalcExe.Caption = ResManager.GetString("buttonCalcExe");

            gridView.Columns[0].Caption = ResManager.GetString("dataGridViewColumn0");
            gridView.Columns[1].Caption = ResManager.GetString("dataGridViewColumn1");
            gridView.Columns[2].Caption = ResManager.GetString("dataGridViewColumn2");
            gridView.Columns[3].Caption = ResManager.GetString("dataGridViewColumn3");
            gridView.Columns[4].Caption = ResManager.GetString("dataGridViewColumn4");
        }

        #endregion

        #region Private methods

        private void barEditItemLocalization_EditValueChanged(object sender, EventArgs e)
        {
            SetLocalization(GetBarEditItemIndex(sender));
            GetBarEditItemIndex(barEditItemViewType);
        }

        private int GetBarEditItemIndex(object sender)
        {
            var i = 0;
            var isFind = false;
            if (sender is BarEditItem editItem)
            {
                DevExpress.XtraEditors.Controls.ComboBoxItemCollection items = null;
                if (sender is BarEditItem barEditItem)
                {
                    if (barEditItem.Name.Equals(barEditItemLocalization.Name))
                        items = repositoryItemLocalization.Items;
                    if (barEditItem.Name.Equals(barEditItemViewType.Name))
                        items = repositoryItemViewType.Items;
                }
                if (items != null && items.Count > 0)
                {
                    foreach (var item in items)
                    {
                        if (editItem.EditValue == item)
                        {
                            isFind = true;
                            break;
                        }
                        i++;
                    }
                }
            }
            return isFind ? i : -1;
        }

        private void barEditItemViewType_EditValueChanged(object sender, EventArgs e)
        {
            var i = GetBarEditItemIndex(barEditItemViewType);
            gridControl.Visible = !(chartControl.Visible = i != 0);
        }

        private void BarButtonItemCalc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var creditAmount = Convert.ToInt32(fieldMoneyCredit.EditValue);
            var annualInterest = Convert.ToDecimal(fieldAnnualInterest.EditValue);
            var creditTerm = Convert.ToInt32(fieldCreditTermMonths.EditValue);

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

        private Task PrintBody(IReadOnlyList<ClassRecord> records)
        {
            return Task.Run(() =>
            {
                switch (GetBarEditItemIndex(barEditItemViewType))
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
            });
        }

        private void PrintBodyTable(IReadOnlyList<ClassRecord> records)
        {
            _devHelper.GridControl_SetDataSource(gridControl, records);
        }

        private void PrintBodyChart(IReadOnlyList<ClassRecord> records)
        {
            chartControl.Series.Clear();
            chartControl.Titles.Clear();
            chartControl.PaletteName = "Default";

            Series seriesPercent = null;
            Series seriesCredit = null;
            if (ResManager != null)
            {
                var namePercent = ResManager.GetString("dataGridViewColumn2");
                if (!string.IsNullOrEmpty(namePercent))
                    chartControl.Series.Add(seriesPercent = new Series(namePercent, ViewType.Bar));
                var nameCredit = ResManager.GetString("dataGridViewColumn3");
                if (!string.IsNullOrEmpty(nameCredit))
                    chartControl.Series.Add(seriesCredit = new Series(nameCredit, ViewType.Bar));
            }
            foreach (var item in records)
            {
                if (item.Number > 0 && item.Remaining > 0)
                {
                    seriesPercent?.Points.Add(new SeriesPoint(item.Number, (double)item.Percent));
                    seriesCredit?.Points.Add(new SeriesPoint(item.Number, (double)item.Credit));
                }
            }
        }

        private void BarEditItemCreditTermMonths_EditValueChanged(object sender, EventArgs e)
        {
            fieldCreditTermYears.EditValue = Convert.ToDecimal(
                Convert.ToInt32(fieldCreditTermMonths.EditValue) / 12);
        }

        private void FieldMoneyCost_EditValueChanged(object sender, EventArgs e)
        {
            var moneyCost = default(int);
            if (fieldMoneyCost.EditValue != null)
                moneyCost = (int)fieldMoneyCost.EditValue;
            var moneyOwn = default(int);
            if (fieldMoneyOwn.EditValue != null)
                moneyOwn = (int)fieldMoneyOwn.EditValue;
            fieldMoneyCredit.EditValue = moneyCost - moneyOwn;
        }

        private void BarButtonItemClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Chart
            chartControl.Titles.Clear();
            chartControl.Series.Clear();
            chartControl.PaletteName = "Default";
            // Table
            gridControl.DataSource = null;
            // Fields
            fieldMoneyCost.EditValue = 100_000;
            fieldMoneyOwn.EditValue = 50_000;
            fieldAnnualInterest.EditValue = 10;
            fieldCreditTermMonths.EditValue = 12;
        }

        private void BarButtonItemCalcExe_ItemClick(object sender, ItemClickEventArgs e)
        {
            _proc.Run("calc");
        }

        #endregion
    }
}
