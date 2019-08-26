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
            this.barEditItemMoneyCost = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMoney = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItemAnnualInterest = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemAnnualInterest = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItemCreditTermMonths = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemCreditTerm = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.barEditItemMoneyOwn = new DevExpress.XtraBars.BarEditItem();
            this.barEditItemMoneyCredit = new DevExpress.XtraBars.BarEditItem();
            this.barEditItemCreditTermYears = new DevExpress.XtraBars.BarEditItem();
            this.ribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSettings = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroupCalc = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
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
            this.barEditItemMoneyCost,
            this.barEditItemAnnualInterest,
            this.barEditItemCreditTermMonths,
            this.barEditItemMoneyOwn,
            this.barEditItemMoneyCredit,
            this.barEditItemCreditTermYears});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 10;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage});
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
            this.barEditItemLocalization.EditWidth = 82;
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
            // barEditItemMoneyCost
            // 
            this.barEditItemMoneyCost.Caption = "Cost money";
            this.barEditItemMoneyCost.Edit = this.repositoryItemMoney;
            this.barEditItemMoneyCost.EditValue = 100000F;
            this.barEditItemMoneyCost.EditWidth = 80;
            this.barEditItemMoneyCost.Id = 3;
            this.barEditItemMoneyCost.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEditItemMoneyCost.ImageOptions.SvgImage")));
            this.barEditItemMoneyCost.Name = "barEditItemMoneyCost";
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
            // barEditItemAnnualInterest
            // 
            this.barEditItemAnnualInterest.Caption = "Annual interest";
            this.barEditItemAnnualInterest.Edit = this.repositoryItemAnnualInterest;
            this.barEditItemAnnualInterest.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.barEditItemAnnualInterest.EditWidth = 75;
            this.barEditItemAnnualInterest.Id = 3;
            this.barEditItemAnnualInterest.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEditItemAnnualInterest.ImageOptions.SvgImage")));
            this.barEditItemAnnualInterest.Name = "barEditItemAnnualInterest";
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
            // barEditItemCreditTermMonths
            // 
            this.barEditItemCreditTermMonths.Caption = "Credit term (months)";
            this.barEditItemCreditTermMonths.Edit = this.repositoryItemCreditTerm;
            this.barEditItemCreditTermMonths.EditValue = ((short)(12));
            this.barEditItemCreditTermMonths.EditWidth = 48;
            this.barEditItemCreditTermMonths.Id = 4;
            this.barEditItemCreditTermMonths.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEditItemCreditTermMonths.ImageOptions.SvgImage")));
            this.barEditItemCreditTermMonths.Name = "barEditItemCreditTermMonths";
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
            // barEditItemMoneyOwn
            // 
            this.barEditItemMoneyOwn.Caption = "Own money";
            this.barEditItemMoneyOwn.Edit = this.repositoryItemMoney;
            this.barEditItemMoneyOwn.EditValue = 50000;
            this.barEditItemMoneyOwn.EditWidth = 80;
            this.barEditItemMoneyOwn.Id = 6;
            this.barEditItemMoneyOwn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEditItemMoneyOwn.ImageOptions.SvgImage")));
            this.barEditItemMoneyOwn.Name = "barEditItemMoneyOwn";
            // 
            // barEditItemMoneyCredit
            // 
            this.barEditItemMoneyCredit.Caption = "Credit money";
            this.barEditItemMoneyCredit.Edit = this.repositoryItemMoney;
            this.barEditItemMoneyCredit.EditValue = 50000;
            this.barEditItemMoneyCredit.EditWidth = 73;
            this.barEditItemMoneyCredit.Id = 7;
            this.barEditItemMoneyCredit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEditItemMoneyCredit.ImageOptions.SvgImage")));
            this.barEditItemMoneyCredit.Name = "barEditItemMoneyCredit";
            // 
            // barEditItemCreditTermYears
            // 
            this.barEditItemCreditTermYears.Caption = "Credit term (years)";
            this.barEditItemCreditTermYears.Edit = this.repositoryItemCreditTerm;
            this.barEditItemCreditTermYears.Id = 9;
            this.barEditItemCreditTermYears.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barEditItemCreditTermYears.ImageOptions.SvgImage")));
            this.barEditItemCreditTermYears.Name = "barEditItemCreditTermYears";
            // 
            // ribbonPage
            // 
            this.ribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSettings,
            this.ribbonPageGroupCalc});
            this.ribbonPage.Name = "ribbonPage";
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
            // ribbonPageGroupCalc
            // 
            this.ribbonPageGroupCalc.ItemLinks.Add(this.barEditItemMoneyCost);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.barEditItemMoneyOwn);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.barEditItemMoneyCredit);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.barEditItemAnnualInterest);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.barEditItemCreditTermMonths);
            this.ribbonPageGroupCalc.ItemLinks.Add(this.barEditItemCreditTermYears);
            this.ribbonPageGroupCalc.Name = "ribbonPageGroupCalc";
            this.ribbonPageGroupCalc.ShowCaptionButton = false;
            this.ribbonPageGroupCalc.Text = "Calculate";
            // 
            // chartControl
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl.Diagram = xyDiagram1;
            this.chartControl.Legend.Name = "Default Legend";
            this.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartControl.Location = new System.Drawing.Point(12, 149);
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
            this.chartControl.Size = new System.Drawing.Size(616, 484);
            this.chartControl.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 645);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.ribbonControl);
            this.MaximumSize = new System.Drawing.Size(1400, 1400);
            this.MinimumSize = new System.Drawing.Size(650, 650);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl;
            this.Text = "Credit-track.";
            this.Load += new System.EventHandler(this.FormMain_Load);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSettings;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupCalc;
        private DevExpress.XtraBars.BarEditItem barEditItemLocalization;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemLocalization;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraBars.BarEditItem barEditItemViewType;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemViewType;
        private DevExpress.XtraBars.BarEditItem barEditItemMoneyCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemMoney;
        private DevExpress.XtraBars.BarEditItem barEditItemAnnualInterest;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemAnnualInterest;
        private DevExpress.XtraBars.BarEditItem barEditItemCreditTermMonths;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemCreditTerm;
        private DevExpress.XtraBars.BarEditItem barEditItemMoneyOwn;
        private DevExpress.XtraBars.BarEditItem barEditItemMoneyCredit;
        private DevExpress.XtraBars.BarEditItem barEditItemCreditTermYears;
    }
}

