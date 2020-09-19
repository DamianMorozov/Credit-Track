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

        private readonly DevExpressHelper _devHelper = DevExpressHelper.Instance;
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
            _resManager = new ResourceManager("DX.App.Resources.strings", Assembly.GetExecutingAssembly());
            var cultureName = cultureNames[0];
            if (localization >= 0 && localization <= 1)
                cultureName = cultureNames[localization];
            var culture = CultureInfo.CreateSpecificCulture(cultureName);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Text = _resManager.GetString("formCaption");

            ribbonPageGroupSettings.Text = _resManager.GetString("labelSettings");
            ribbonPageCalc.Text = _resManager.GetString("labelCalc");
            ribbonPageGroupCalc.Text = _resManager.GetString("buttonCalc");

            // Settings - Localization.
            barEditItemLocalization.Caption = _resManager.GetString("labelLocalization");
            barEditItemLocalization.EditValueChanged -= barEditItemLocalization_EditValueChanged;
            var i = GetBarEditItemIndex(barEditItemLocalization);
            repositoryItemLocalization.Items[0] = _resManager.GetString("comboBoxLocalization0");
            repositoryItemLocalization.Items[1] = _resManager.GetString("comboBoxLocalization1");
            barEditItemLocalization.EditValue = repositoryItemLocalization.Items[i];
            barEditItemLocalization.EditValueChanged += barEditItemLocalization_EditValueChanged;
            // Settings - ViewType.
            barEditItemViewType.Caption = _resManager.GetString("labelViewType");
            barEditItemViewType.EditValueChanged -= barEditItemViewType_EditValueChanged;
            //var j = GetBarEditItemIndex(barEditItemViewType);
            repositoryItemViewType.Items[0] = _resManager.GetString("comboBoxViewType0");
            repositoryItemViewType.Items[1] = _resManager.GetString("comboBoxViewType1");
            barEditItemViewType.EditValue = repositoryItemViewType.Items[i];
            barEditItemViewType.EditValueChanged += barEditItemViewType_EditValueChanged;

            // Calculate.
            fieldMoneyCost.Caption = _resManager.GetString("labelMoneyCost");
            fieldMoneyOwn.Caption = _resManager.GetString("labelMoneyOwn");
            fieldMoneyCredit.Caption = _resManager.GetString("labelMoneyCredit");

            fieldAnnualInterest.Caption = _resManager.GetString("labelAnnualInterest");
            fieldCreditTermMonths.Caption = _resManager.GetString("labelCreditTermMonthsFull");
            fieldCreditTermYears.Caption = _resManager.GetString("labelCreditTermYearsFull");

            barButtonItemCalc.Caption = _resManager.GetString("buttonCalc");
            barButtonItemClear.Caption = _resManager.GetString("buttonClear");
            barButtonItemCalcExe.Caption = _resManager.GetString("buttonCalcExe");

            gridView.Columns[0].Caption = _resManager.GetString("dataGridViewColumn0");
            gridView.Columns[1].Caption = _resManager.GetString("dataGridViewColumn1");
            gridView.Columns[2].Caption = _resManager.GetString("dataGridViewColumn2");
            gridView.Columns[3].Caption = _resManager.GetString("dataGridViewColumn3");
            gridView.Columns[4].Caption = _resManager.GetString("dataGridViewColumn4");
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
                if (editItem.Name.Equals(barEditItemLocalization.Name))
                    items = repositoryItemLocalization.Items;
                if (editItem.Name.Equals(barEditItemViewType.Name))
                    items = repositoryItemViewType.Items;
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
                MessageBox.Show(_resManager.GetString("messageErrorZeroInFields"),
                    _resManager.GetString("formCaption"));
                return;
            }

            var calc = ClassCalc.Instance;
            var records = calc.Exec(creditAmount, annualInterest, creditTerm, true);

            PrintBodyAsync(records);
        }

        private Task PrintBodyAsync(IReadOnlyList<ClassRecord> records)
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
            if (_resManager != null)
            {
                var namePercent = _resManager.GetString("dataGridViewColumn2");
                if (!string.IsNullOrEmpty(namePercent))
                    chartControl.Series.Add(seriesPercent = new Series(namePercent, ViewType.Bar));
                var nameCredit = _resManager.GetString("dataGridViewColumn3");
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
