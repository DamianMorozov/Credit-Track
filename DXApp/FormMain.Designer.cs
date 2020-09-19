namespace DXApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView1 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView2 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView3 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditItemLocalization = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLocalization = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItemViewType = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemViewType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.fieldMoneyCost = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMoney = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fieldAnnualInterest = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemAnnualInterest = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fieldCreditTermMonths = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCreditTerm = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fieldMoneyOwn = new DevExpress.XtraBars.BarEditItem();
            this.fieldMoneyCredit = new DevExpress.XtraBars.BarEditItem();
            this.fieldCreditTermYears = new DevExpress.XtraBars.BarEditItem();
            this.barButtonItemCalc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClear = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCalcExe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCalc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCalc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSettings = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSettings = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnRemaining = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLocalization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemViewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAnnualInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCreditTerm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.barEditItemLocalization,
            this.barEditItemViewType,
            this.fieldMoneyCost,
            this.fieldAnnualInterest,
            this.fieldCreditTermMonths,
            this.fieldMoneyOwn,
            this.fieldMoneyCredit,
            this.fieldCreditTermYears,
            this.barButtonItemCalc,
            this.barButtonItemClear,
            this.barButtonItemCalcExe});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 13;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageCalc,
            this.ribbonPageSettings});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLocalization,
            this.repositoryItemViewType,
            this.repositoryItemMoney,
            this.repositoryItemAnnualInterest,
            this.repositoryItemCreditTerm});
            this.ribbonControl.Size = new System.Drawing.Size(690, 143);
            // 
            // barEditItemLocalization
            // 
            this.barEditItemLocalization.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.False;
            this.barEditItemLocalization.Caption = "Localization";
            this.barEditItemLocalization.CaptionAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.barEditItemLocalization.Edit = this.repositoryItemLocalization;
            this.barEditItemLocalization.EditWidth = 92;
            this.barEditItemLocalization.Id = 1;
            this.barEditItemLocalization.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEditItemLocalization.ImageOptions.SvgImage")));
            this.barEditItemLocalization.Name = "barEditItemLocalization";
            this.barEditItemLocalization.EditValueChanged += new System.EventHandler(this.barEditItemLocalization_EditValueChanged);
            // 
            // repositoryItemLocalization
            // 
            this.repositoryItemLocalization.AutoHeight = false;
            this.repositoryItemLocalization.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLocalization.Items.AddRange(new object[] {
            "English",
            "Russian"});
            this.repositoryItemLocalization.Name = "repositoryItemLocalization";
            this.repositoryItemLocalization.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barEditItemViewType
            // 
            this.barEditItemViewType.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.False;
            this.barEditItemViewType.Caption = "View type";
            this.barEditItemViewType.Edit = this.repositoryItemViewType;
            this.barEditItemViewType.EditWidth = 100;
            this.barEditItemViewType.Id = 2;
            this.barEditItemViewType.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEditItemViewType.ImageOptions.SvgImage")));
            this.barEditItemViewType.Name = "barEditItemViewType";
            this.barEditItemViewType.EditValueChanged += new System.EventHandler(this.barEditItemViewType_EditValueChanged);
            // 
            // repositoryItemViewType
            // 
            this.repositoryItemViewType.AutoHeight = false;
            this.repositoryItemViewType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemViewType.Items.AddRange(new object[] {
            "Chart",
            "Table"});
            this.repositoryItemViewType.Name = "repositoryItemViewType";
            this.repositoryItemViewType.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // fieldMoneyCost
            // 
            this.fieldMoneyCost.Caption = "Cost money";
            this.fieldMoneyCost.Edit = this.repositoryItemMoney;
            this.fieldMoneyCost.EditValue = 100000F;
            this.fieldMoneyCost.EditWidth = 80;
            this.fieldMoneyCost.Id = 3;
            this.fieldMoneyCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fieldMoneyCost.ImageOptions.SvgImage")));
            this.fieldMoneyCost.Name = "fieldMoneyCost";
            // 
            // repositoryItemMoney
            // 
            this.repositoryItemMoney.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMoney.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemMoney.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemMoney.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemMoney.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemMoney.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemMoney.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemMoney.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemMoney.AutoHeight = false;
            this.repositoryItemMoney.DisplayFormat.FormatString = "c0";
            this.repositoryItemMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemMoney.EditFormat.FormatString = "c0";
            this.repositoryItemMoney.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemMoney.Mask.EditMask = "c0";
            this.repositoryItemMoney.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemMoney.Name = "repositoryItemMoney";
            // 
            // fieldAnnualInterest
            // 
            this.fieldAnnualInterest.Caption = "Annual interest";
            this.fieldAnnualInterest.Edit = this.repositoryItemAnnualInterest;
            this.fieldAnnualInterest.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.fieldAnnualInterest.EditWidth = 75;
            this.fieldAnnualInterest.Id = 3;
            this.fieldAnnualInterest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fieldAnnualInterest.ImageOptions.SvgImage")));
            this.fieldAnnualInterest.Name = "fieldAnnualInterest";
            // 
            // repositoryItemAnnualInterest
            // 
            this.repositoryItemAnnualInterest.Appearance.Options.UseTextOptions = true;
            this.repositoryItemAnnualInterest.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemAnnualInterest.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemAnnualInterest.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemAnnualInterest.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemAnnualInterest.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemAnnualInterest.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemAnnualInterest.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemAnnualInterest.AutoHeight = false;
            this.repositoryItemAnnualInterest.Mask.EditMask = "p";
            this.repositoryItemAnnualInterest.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemAnnualInterest.Name = "repositoryItemAnnualInterest";
            // 
            // fieldCreditTermMonths
            // 
            this.fieldCreditTermMonths.Caption = "Credit term (months)";
            this.fieldCreditTermMonths.Edit = this.repositoryItemCreditTerm;
            this.fieldCreditTermMonths.EditValue = ((short)(12));
            this.fieldCreditTermMonths.EditWidth = 48;
            this.fieldCreditTermMonths.Id = 4;
            this.fieldCreditTermMonths.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fieldCreditTermMonths.ImageOptions.SvgImage")));
            this.fieldCreditTermMonths.Name = "fieldCreditTermMonths";
            this.fieldCreditTermMonths.EditValueChanged += new System.EventHandler(this.fieldCreditTermMonths_EditValueChanged);
            // 
            // repositoryItemCreditTerm
            // 
            this.repositoryItemCreditTerm.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCreditTerm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCreditTerm.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemCreditTerm.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCreditTerm.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemCreditTerm.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCreditTerm.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemCreditTerm.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCreditTerm.AutoHeight = false;
            this.repositoryItemCreditTerm.Name = "repositoryItemCreditTerm";
            // 
            // fieldMoneyOwn
            // 
            this.fieldMoneyOwn.Caption = "Own money";
            this.fieldMoneyOwn.Edit = this.repositoryItemMoney;
            this.fieldMoneyOwn.EditValue = 50000;
            this.fieldMoneyOwn.EditWidth = 80;
            this.fieldMoneyOwn.Id = 6;
            this.fieldMoneyOwn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fieldMoneyOwn.ImageOptions.SvgImage")));
            this.fieldMoneyOwn.Name = "fieldMoneyOwn";
            // 
            // fieldMoneyCredit
            // 
            this.fieldMoneyCredit.Caption = "Credit money";
            this.fieldMoneyCredit.Edit = this.repositoryItemMoney;
            this.fieldMoneyCredit.EditValue = 50000;
            this.fieldMoneyCredit.EditWidth = 73;
            this.fieldMoneyCredit.Enabled = false;
            this.fieldMoneyCredit.Id = 7;
            this.fieldMoneyCredit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fieldMoneyCredit.ImageOptions.SvgImage")));
            this.fieldMoneyCredit.Name = "fieldMoneyCredit";
            // 
            // fieldCreditTermYears
            // 
            this.fieldCreditTermYears.Caption = "Credit term (years)";
            this.fieldCreditTermYears.Edit = this.repositoryItemCreditTerm;
            this.fieldCreditTermYears.EditValue = 1;
            this.fieldCreditTermYears.EditWidth = 56;
            this.fieldCreditTermYears.Enabled = false;
            this.fieldCreditTermYears.Id = 9;
            this.fieldCreditTermYears.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fieldCreditTermYears.ImageOptions.SvgImage")));
            this.fieldCreditTermYears.Name = "fieldCreditTermYears";
            // 
            // barButtonItemCalc
            // 
            this.barButtonItemCalc.Caption = "Calculate";
            this.barButtonItemCalc.Id = 10;
            this.barButtonItemCalc.Name = "barButtonItemCalc";
            this.barButtonItemCalc.SmallWithTextWidth = 70;
            this.barButtonItemCalc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemCalc_ItemClick);
            // 
            // barButtonItemClear
            // 
            this.barButtonItemClear.Caption = "Clear";
            this.barButtonItemClear.Id = 11;
            this.barButtonItemClear.Name = "barButtonItemClear";
            this.barButtonItemClear.SmallWithTextWidth = 70;
            this.barButtonItemClear.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemClear_ItemClick);
            // 
            // barButtonItemCalcExe
            // 
            this.barButtonItemCalcExe.Caption = "Run calc.exe";
            this.barButtonItemCalcExe.Id = 12;
            this.barButtonItemCalcExe.Name = "barButtonItemCalcExe";
            this.barButtonItemCalcExe.SmallWithTextWidth = 70;
            this.barButtonItemCalcExe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BarButtonItemCalcExe_ItemClick);
            // 
            // ribbonPageCalc
            // 
            this.ribbonPageCalc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupCalc});
            this.ribbonPageCalc.Name = "ribbonPageCalc";
            this.ribbonPageCalc.Text = "Calc";
            // 
            // ribbonPageGroupCalc
            // 
            this.ribbonPageGroupCalc.ItemLinks.Add(this.fieldMoneyCost);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.fieldMoneyOwn);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.fieldMoneyCredit);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.fieldAnnualInterest, true);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.fieldCreditTermMonths);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.fieldCreditTermYears);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.barButtonItemCalc, true);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.barButtonItemClear);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.barButtonItemCalcExe);
            this.ribbonPageGroupCalc.Name = "ribbonPageGroupCalc";
            this.ribbonPageGroupCalc.ShowCaptionButton = false;
            this.ribbonPageGroupCalc.Text = "Calculate";
            // 
            // ribbonPageSettings
            // 
            this.ribbonPageSettings.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSettings});
            this.ribbonPageSettings.Name = "ribbonPageSettings";
            this.ribbonPageSettings.Text = "Settings";
            // 
            // ribbonPageGroupSettings
            // 
            this.ribbonPageGroupSettings.ItemLinks.Add(this.barEditItemLocalization);
            this.ribbonPageGroupSettings.ItemLinks.Add(this.barEditItemViewType);
            this.ribbonPageGroupSettings.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.ThreeRows;
            this.ribbonPageGroupSettings.Name = "ribbonPageGroupSettings";
            this.ribbonPageGroupSettings.ShowCaptionButton = false;
            this.ribbonPageGroupSettings.Text = "Settings";
            // 
            // chartControl
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Location = new System.Drawing.Point(0, 143);
            this.chartControl.Name = "chartControl";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series1.LegendName = "Default Legend";
            series1.Name = "Series 1";
            series1.View = sideBySideStackedBarSeriesView1;
            series2.Name = "Series 2";
            series2.View = sideBySideStackedBarSeriesView2;
            series3.Name = "Series 3";
            series3.View = sideBySideStackedBarSeriesView3;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2,
        series3};
            this.chartControl.SeriesTemplate.SeriesColorizer = null;
            this.chartControl.Size = new System.Drawing.Size(690, 502);
            this.chartControl.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 143);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(690, 502);
            this.gridControl.TabIndex = 3;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnNumber,
            this.gridColumnPay,
            this.gridColumnPercent,
            this.gridColumnCredit,
            this.gridColumnRemaining});
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            // 
            // gridColumnNumber
            // 
            this.gridColumnNumber.Caption = "Number";
            this.gridColumnNumber.Name = "gridColumnNumber";
            this.gridColumnNumber.Visible = true;
            this.gridColumnNumber.VisibleIndex = 0;
            // 
            // gridColumnPay
            // 
            this.gridColumnPay.Caption = "Pay";
            this.gridColumnPay.Name = "gridColumnPay";
            this.gridColumnPay.Visible = true;
            this.gridColumnPay.VisibleIndex = 1;
            // 
            // gridColumnPercent
            // 
            this.gridColumnPercent.Caption = "Percent";
            this.gridColumnPercent.Name = "gridColumnPercent";
            this.gridColumnPercent.Visible = true;
            this.gridColumnPercent.VisibleIndex = 2;
            // 
            // gridColumnCredit
            // 
            this.gridColumnCredit.Caption = "Credit";
            this.gridColumnCredit.Name = "gridColumnCredit";
            this.gridColumnCredit.Visible = true;
            this.gridColumnCredit.VisibleIndex = 3;
            // 
            // gridColumnRemaining
            // 
            this.gridColumnRemaining.Caption = "Remaining";
            this.gridColumnRemaining.Name = "gridColumnRemaining";
            this.gridColumnRemaining.Visible = true;
            this.gridColumnRemaining.VisibleIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 645);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.ribbonControl);
            this.MaximumSize = new System.Drawing.Size(1400, 1400);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl;
            this.Text = "Credit-track.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLocalization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemViewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAnnualInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCreditTerm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCalc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCalc;
        private DevExpress.XtraBars.BarEditItem barEditItemLocalization;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemLocalization;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraBars.BarEditItem barEditItemViewType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemViewType;
        private DevExpress.XtraBars.BarEditItem fieldMoneyCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemMoney;
        private DevExpress.XtraBars.BarEditItem fieldAnnualInterest;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemAnnualInterest;
        private DevExpress.XtraBars.BarEditItem fieldCreditTermMonths;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemCreditTerm;
        private DevExpress.XtraBars.BarEditItem fieldMoneyOwn;
        private DevExpress.XtraBars.BarEditItem fieldMoneyCredit;
        private DevExpress.XtraBars.BarEditItem fieldCreditTermYears;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSettings;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCalc;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClear;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCalcExe;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPercent;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCredit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRemaining;
    }
}

