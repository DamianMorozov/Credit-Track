using LibCredit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors.Repository;
// ReSharper disable ResourceItemNotResolved

namespace DXApp
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Private fields and properties

        private ResourceManager ResManager { get; set; }
        private uint LastLocalization { get; set; } = 0;
        private uint LastViewType { get; set; }  = 0;

        #endregion

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Localization.
            barEditItemLocalization.EditValue = CultureInfo.CurrentCulture.Name == "ru-RU"
                ? repositoryItemLocalization.Items[1] : repositoryItemLocalization.Items[0];
            // View type.
            barEditItemViewType.EditValue = repositoryItemViewType.Items[0];
        }

        private void SetLocalization(int localization)
        {
            string[] cultureNames = { "en-US", "ru-RU" };
            ResManager = new ResourceManager("DXApp.Resources.strings", Assembly.GetExecutingAssembly());
            string cultureName = cultureNames[0];
            if (localization >= 0 && localization <= 1)
                cultureName = cultureNames[localization];
            var culture = CultureInfo.CreateSpecificCulture(cultureName);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            Text = ResManager.GetString("formCaption");

            ribbonPageGroupSettings.Text = ResManager.GetString("labelSettings");

            barEditItemLocalization.Caption = ResManager.GetString("labelLocalization");
            barEditItemLocalization.EditValueChanged -= barEditItemLocalization_EditValueChanged;
            var i = GetBarEditItemIndex(barEditItemLocalization);
            repositoryItemLocalization.Items[0] = ResManager.GetString("comboBoxLocalization0");
            repositoryItemLocalization.Items[1] = ResManager.GetString("comboBoxLocalization1");
            barEditItemLocalization.EditValue = repositoryItemLocalization.Items[i];
            barEditItemLocalization.EditValueChanged += barEditItemLocalization_EditValueChanged;

            barEditItemViewType.Caption = ResManager.GetString("labelViewType");
            barEditItemViewType.EditValueChanged -= barEditItemViewType_EditValueChanged;
            var j = GetBarEditItemIndex(barEditItemViewType);
            repositoryItemViewType.Items[0] = ResManager.GetString("comboBoxViewType0");
            repositoryItemViewType.Items[1] = ResManager.GetString("comboBoxViewType1");
            barEditItemViewType.EditValue = repositoryItemViewType.Items[i];
            barEditItemViewType.EditValueChanged += barEditItemViewType_EditValueChanged;

            ribbonPageGroupCalc.Text = ResManager.GetString("buttonCalc");

            barEditItemMoneyCost.Caption = ResManager.GetString("labelMoneyCost");
            barEditItemCreditTermMonths.Caption = ResManager.GetString("labelCreditTermMonthsFull");
            barEditItemCreditTermYears.Caption = ResManager.GetString("labelCreditTermYearsFull");
            //labelAnnualInterest.Text = ResManager.GetString("labelAnnualInterest");
            //labelCreditTerm.Text = ResManager.GetString("labelCreditTerm");
            //labelCreditTerm2.Text = ResManager.GetString("labelCreditTermMonths");

            //dataGridView.Columns[0].HeaderText = ResManager.GetString("dataGridViewColumn0");
            //dataGridView.Columns[1].HeaderText = ResManager.GetString("dataGridViewColumn1");
            //dataGridView.Columns[2].HeaderText = ResManager.GetString("dataGridViewColumn2");
            //dataGridView.Columns[3].HeaderText = ResManager.GetString("dataGridViewColumn3");
            //dataGridView.Columns[4].HeaderText = ResManager.GetString("dataGridViewColumn4");

            //buttonCalc.Text = ResManager.GetString("buttonCalc");
            //buttonClear.Text = ResManager.GetString("buttonClear");
            //buttonCalcExe.Text = ResManager.GetString("buttonCalcExe");
        }

        private void barEditItemLocalization_EditValueChanged(object sender, EventArgs e)
        {
            SetLocalization(GetBarEditItemIndex(sender));
        }

        private int GetBarEditItemIndex(object sender)
        {
            var i = 0;
            var isFind = false;
            if (sender is BarEditItem editItem)
                foreach (var item in repositoryItemLocalization.Items)
                {
                    if (editItem.EditValue == item)
                    {
                        isFind = true;
                        break;
                    }
                    i++;
                }
            return isFind ? i : -1;
        }

        private void barEditItemViewType_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
