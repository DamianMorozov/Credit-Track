using DevExpress.XtraBars;
using LibWin;
using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
// ReSharper disable ResourceItemNotResolved

namespace DXApp
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Private fields and properties

        private readonly Process _proc = Process.Instance;
        private ResourceManager _resManager;
        private uint _lastLocalization = 0;
        private uint _lastViewType = 0;

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
            _resManager = new ResourceManager("DXApp.Resources.strings", Assembly.GetExecutingAssembly());
            var cultureName = cultureNames[0];
            if (localization >= 0 && localization <= 1)
                cultureName = cultureNames[localization];
            var culture = CultureInfo.CreateSpecificCulture(cultureName);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Text = _resManager.GetString("formCaption");

            ribbonPageGroupSettings.Text = _resManager.GetString("labelSettings");
            ribbonPageSettings.Text = _resManager.GetString("labelSettings");
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
            var j = GetBarEditItemIndex(barEditItemViewType);
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

            //dataGridView.Columns[0].HeaderText = ResManager.GetString("dataGridViewColumn0");
            //dataGridView.Columns[1].HeaderText = ResManager.GetString("dataGridViewColumn1");
            //dataGridView.Columns[2].HeaderText = ResManager.GetString("dataGridViewColumn2");
            //dataGridView.Columns[3].HeaderText = ResManager.GetString("dataGridViewColumn3");
            //dataGridView.Columns[4].HeaderText = ResManager.GetString("dataGridViewColumn4");
        }

        #endregion

        #region Private methods

        private void barEditItemLocalization_EditValueChanged(object sender, EventArgs e)
        {
            SetLocalization(GetBarEditItemIndex(sender));
        }

        private int GetBarEditItemIndex(object sender)
        {
            var i = 0;
            var isFind = false;
            if (sender is BarEditItem editItem)
            {
                foreach (var item in repositoryItemLocalization.Items)
                {
                    if (editItem.EditValue == item)
                    {
                        isFind = true;
                        break;
                    }
                    i++;
                }
            }
            return isFind ? i : -1;
        }

        private void barEditItemViewType_EditValueChanged(object sender, EventArgs e)
        {
            chartControl.Visible = GetBarEditItemIndex(barEditItemViewType) != 0;
            gridControl.Visible = GetBarEditItemIndex(barEditItemViewType) == 0;
        }

        private void BarButtonItemCalc_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void BarButtonItemClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            // Chart
            chartControl.Titles.Clear();
            chartControl.Series.Clear();
            // Table
            for (int i = 0; i < gridView.RowCount; i++)
            {
                gridView.DeleteRow(i);
            }
            // Fields
            fieldMoneyCost.EditValue = 100_000;
            fieldMoneyOwn.EditValue = 50_000;
            fieldAnnualInterest.EditValue = 10;
            fieldCreditTermMonths.EditValue = 12;
        }

        private void fieldCreditTermMonths_EditValueChanged(object sender, EventArgs e)
        {
            fieldCreditTermYears.EditValue = (int)fieldCreditTermMonths.EditValue / 12;
        }

        private void BarButtonItemCalcExe_ItemClick(object sender, ItemClickEventArgs e)
        {
            _proc.Run("calc");
        }

        #endregion
    }
}
