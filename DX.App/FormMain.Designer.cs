namespace DX.App
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
            DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView4 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView5 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            DevExpress.XtraCharts.Series series6 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideStackedBarSeriesView sideBySideStackedBarSeriesView6 = new DevExpress.XtraCharts.SideBySideStackedBarSeriesView();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barEditItemViewType = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemViewType = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barEditItemLocalization = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemLocalization = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.fieldMoneyCost = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMoney = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fieldAnnualInterest = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemAnnualInterest = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fieldCreditTermMonths = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCreditTermMonths = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fieldMoneyOwn = new DevExpress.XtraBars.BarEditItem();
            this.fieldMoneyCredit = new DevExpress.XtraBars.BarEditItem();
            this.fieldCreditTermYears = new DevExpress.XtraBars.BarEditItem();
            this.repositoryCreditTermYears = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barButtonItemCalc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemClear = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemCalcExe = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCalc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupCalc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemViewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLocalization)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAnnualInterest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCreditTermMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCreditTermYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView6)).BeginInit();
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
            this.barEditItemViewType,
            this.barEditItemLocalization,
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
            this.ribbonPageCalc});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLocalization,
            this.repositoryItemViewType,
            this.repositoryItemMoney,
            this.repositoryItemAnnualInterest,
            this.repositoryItemCreditTermMonths,
            this.repositoryCreditTermYears});
            this.ribbonControl.Size = new System.Drawing.Size(790, 158);
            // 
            // barEditItemViewType
            // 
            this.barEditItemViewType.AutoFillWidthInMenu = DevExpress.Utils.DefaultBoolean.False;
            this.barEditItemViewType.Caption = "View type";
            this.barEditItemViewType.Edit = this.repositoryItemViewType;
            this.barEditItemViewType.EditValue = "";
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
            // fieldMoneyCost
            // 
            this.fieldMoneyCost.Caption = "Cost money";
            this.fieldMoneyCost.Edit = this.repositoryItemMoney;
            this.fieldMoneyCost.EditValue = 100000F;
            this.fieldMoneyCost.EditWidth = 80;
            this.fieldMoneyCost.Id = 3;
            this.fieldMoneyCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fieldMoneyCost.ImageOptions.SvgImage")));
            this.fieldMoneyCost.Name = "fieldMoneyCost";
            this.fieldMoneyCost.EditValueChanged += new System.EventHandler(this.FieldMoneyCost_EditValueChanged);
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
            this.repositoryItemMoney.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemMoney.EditFormat.FormatString = "c0";
            this.repositoryItemMoney.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
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
            this.repositoryItemAnnualInterest.DisplayFormat.FormatString = "n2";
            this.repositoryItemAnnualInterest.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemAnnualInterest.EditFormat.FormatString = "n2";
            this.repositoryItemAnnualInterest.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemAnnualInterest.Mask.EditMask = "n";
            this.repositoryItemAnnualInterest.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemAnnualInterest.Mask.UseMaskAsDisplayFormat = true;
            this.repositoryItemAnnualInterest.Name = "repositoryItemAnnualInterest";
            // 
            // fieldCreditTermMonths
            // 
            this.fieldCreditTermMonths.Caption = "Credit term (months)";
            this.fieldCreditTermMonths.Edit = this.repositoryItemCreditTermMonths;
            this.fieldCreditTermMonths.EditValue = ((short)(12));
            this.fieldCreditTermMonths.EditWidth = 48;
            this.fieldCreditTermMonths.Id = 4;
            this.fieldCreditTermMonths.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fieldCreditTermMonths.ImageOptions.SvgImage")));
            this.fieldCreditTermMonths.Name = "fieldCreditTermMonths";
            this.fieldCreditTermMonths.EditValueChanged += new System.EventHandler(this.BarEditItemCreditTermMonths_EditValueChanged);
            // 
            // repositoryItemCreditTermMonths
            // 
            this.repositoryItemCreditTermMonths.Appearance.Options.UseTextOptions = true;
            this.repositoryItemCreditTermMonths.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCreditTermMonths.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemCreditTermMonths.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCreditTermMonths.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemCreditTermMonths.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCreditTermMonths.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemCreditTermMonths.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemCreditTermMonths.AutoHeight = false;
            this.repositoryItemCreditTermMonths.DisplayFormat.FormatString = "n0";
            this.repositoryItemCreditTermMonths.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCreditTermMonths.EditFormat.FormatString = "n0";
            this.repositoryItemCreditTermMonths.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryItemCreditTermMonths.Mask.EditMask = "n0";
            this.repositoryItemCreditTermMonths.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryItemCreditTermMonths.Name = "repositoryItemCreditTermMonths";
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
            this.fieldMoneyOwn.EditValueChanged += new System.EventHandler(this.FieldMoneyCost_EditValueChanged);
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
            this.fieldCreditTermYears.Edit = this.repositoryCreditTermYears;
            this.fieldCreditTermYears.EditValue = 1;
            this.fieldCreditTermYears.EditWidth = 56;
            this.fieldCreditTermYears.Enabled = false;
            this.fieldCreditTermYears.Id = 9;
            this.fieldCreditTermYears.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("fieldCreditTermYears.ImageOptions.SvgImage")));
            this.fieldCreditTermYears.Name = "fieldCreditTermYears";
            // 
            // repositoryCreditTermYears
            // 
            this.repositoryCreditTermYears.Appearance.Options.UseTextOptions = true;
            this.repositoryCreditTermYears.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryCreditTermYears.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryCreditTermYears.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryCreditTermYears.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryCreditTermYears.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryCreditTermYears.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryCreditTermYears.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryCreditTermYears.AutoHeight = false;
            this.repositoryCreditTermYears.DisplayFormat.FormatString = "n1";
            this.repositoryCreditTermYears.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryCreditTermYears.EditFormat.FormatString = "n1";
            this.repositoryCreditTermYears.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.repositoryCreditTermYears.Mask.EditMask = "n1";
            this.repositoryCreditTermYears.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.repositoryCreditTermYears.Name = "repositoryCreditTermYears";
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
            this.ribbonPageGroupCalc,
            this.ribbonPageGroupSettings});
            this.ribbonPageCalc.Name = "ribbonPageCalc";
            this.ribbonPageCalc.Text = "Calc";
            // 
            // ribbonPageGroupCalc
            // 
            this.ribbonPageGroupCalc.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
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
            this.ribbonPageGroupCalc.Text = "Calculate";
            // 
            // ribbonPageGroupSettings
            // 
            this.ribbonPageGroupSettings.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroupSettings.ItemLinks.Add(this.barEditItemLocalization);
            this.ribbonPageGroupSettings.ItemLinks.Add(this.barEditItemViewType);
            this.ribbonPageGroupSettings.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.ThreeRows;
            this.ribbonPageGroupSettings.Name = "ribbonPageGroupSettings";
            this.ribbonPageGroupSettings.Text = "Settings";
            // 
            // chartControl
            // 
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram2;
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Location = new System.Drawing.Point(0, 158);
            this.chartControl.Name = "chartControl";
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical;
            series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;
            series4.LegendName = "Default Legend";
            series4.Name = "Series 1";
            series4.View = sideBySideStackedBarSeriesView4;
            series5.Name = "Series 2";
            series5.View = sideBySideStackedBarSeriesView5;
            series6.Name = "Series 3";
            series6.View = sideBySideStackedBarSeriesView6;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series4,
        series5,
        series6};
            this.chartControl.Size = new System.Drawing.Size(790, 437);
            this.chartControl.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 158);
            this.gridControl.MainView = this.gridView;
            this.gridControl.MenuManager = this.ribbonControl;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(790, 437);
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
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnNumber
            // 
            this.gridColumnNumber.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNumber.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnNumber.Caption = "Number";
            this.gridColumnNumber.DisplayFormat.FormatString = "n0";
            this.gridColumnNumber.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnNumber.FieldName = "Number";
            this.gridColumnNumber.Name = "gridColumnNumber";
            this.gridColumnNumber.OptionsColumn.AllowEdit = false;
            this.gridColumnNumber.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.gridColumnNumber.Visible = true;
            this.gridColumnNumber.VisibleIndex = 0;
            this.gridColumnNumber.Width = 45;
            // 
            // gridColumnPay
            // 
            this.gridColumnPay.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPay.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPay.Caption = "Pay";
            this.gridColumnPay.DisplayFormat.FormatString = "n0";
            this.gridColumnPay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPay.FieldName = "Pay";
            this.gridColumnPay.Name = "gridColumnPay";
            this.gridColumnPay.OptionsColumn.AllowEdit = false;
            this.gridColumnPay.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPay.Visible = true;
            this.gridColumnPay.VisibleIndex = 1;
            this.gridColumnPay.Width = 155;
            // 
            // gridColumnPercent
            // 
            this.gridColumnPercent.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnPercent.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPercent.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnPercent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnPercent.Caption = "Percent";
            this.gridColumnPercent.DisplayFormat.FormatString = "n0";
            this.gridColumnPercent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnPercent.FieldName = "Percent";
            this.gridColumnPercent.Name = "gridColumnPercent";
            this.gridColumnPercent.OptionsColumn.AllowEdit = false;
            this.gridColumnPercent.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnPercent.Visible = true;
            this.gridColumnPercent.VisibleIndex = 2;
            this.gridColumnPercent.Width = 155;
            // 
            // gridColumnCredit
            // 
            this.gridColumnCredit.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnCredit.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCredit.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnCredit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnCredit.Caption = "Credit";
            this.gridColumnCredit.DisplayFormat.FormatString = "n0";
            this.gridColumnCredit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnCredit.FieldName = "Credit";
            this.gridColumnCredit.Name = "gridColumnCredit";
            this.gridColumnCredit.OptionsColumn.AllowEdit = false;
            this.gridColumnCredit.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnCredit.Visible = true;
            this.gridColumnCredit.VisibleIndex = 3;
            this.gridColumnCredit.Width = 155;
            // 
            // gridColumnRemaining
            // 
            this.gridColumnRemaining.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnRemaining.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRemaining.AppearanceHeader.Options.UseTextOptions = true;
            this.gridColumnRemaining.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridColumnRemaining.Caption = "Remaining";
            this.gridColumnRemaining.DisplayFormat.FormatString = "n0";
            this.gridColumnRemaining.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumnRemaining.FieldName = "Remaining";
            this.gridColumnRemaining.Name = "gridColumnRemaining";
            this.gridColumnRemaining.OptionsColumn.AllowEdit = false;
            this.gridColumnRemaining.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumnRemaining.Visible = true;
            this.gridColumnRemaining.VisibleIndex = 4;
            this.gridColumnRemaining.Width = 162;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 595);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl;
            this.Text = "Credit-track.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemViewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLocalization)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAnnualInterest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCreditTermMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryCreditTermYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideStackedBarSeriesView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageCalc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCalc;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemLocalization;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraBars.BarEditItem barEditItemViewType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemViewType;
        private DevExpress.XtraBars.BarEditItem fieldMoneyCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemMoney;
        private DevExpress.XtraBars.BarEditItem fieldAnnualInterest;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemAnnualInterest;
        private DevExpress.XtraBars.BarEditItem fieldCreditTermMonths;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemCreditTermMonths;
        private DevExpress.XtraBars.BarEditItem fieldMoneyOwn;
        private DevExpress.XtraBars.BarEditItem fieldMoneyCredit;
        private DevExpress.XtraBars.BarEditItem fieldCreditTermYears;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCalc;
        private DevExpress.XtraBars.BarButtonItem barButtonItemClear;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCalcExe;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryCreditTermYears;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPercent;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCredit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnRemaining;
        private DevExpress.XtraBars.BarEditItem barEditItemLocalization;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSettings;
    }
}

