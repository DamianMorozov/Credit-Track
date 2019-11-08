using System;
using System.Windows.Forms;

namespace LibDevExpress
{
    public sealed class DevExpressHelper
    {
        #region Design pattern "Singleton"

        private static readonly Lazy<DevExpressHelper> _instance = new Lazy<DevExpressHelper>(() => new DevExpressHelper());
        public static DevExpressHelper Instance { get { return _instance.Value; } }
        private DevExpressHelper()
        {
            //
        }

        #endregion

        #region Public methods

        public DevExpress.XtraCharts.BarGrowUpAnimation GetBarGrowUpAnimation()
        {
            return new DevExpress.XtraCharts.BarGrowUpAnimation
            {
                BeginTime = TimeSpan.Parse("00:00:01.0"),
                Enabled = true,
                Duration = TimeSpan.Parse("00:00:05.0"),
            };
        }

        public void BaseControl_SetEnabled(DevExpress.XtraEditors.BaseControl control, bool enabled)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.Enabled = enabled;
                }));
            }
            else
            {
                control.Enabled = enabled;
            }
        }

        public void BaseControl_SetVisible(DevExpress.XtraEditors.BaseControl control, bool visible)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.Visible = visible;
                }));
            }
            else
            {
                control.Visible = visible;
            }
        }

        public void BaseControl_SetText(DevExpress.XtraEditors.BaseControl control, string text)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.Text = text;
                }));
            }
            else
            {
                control.Text = text;
            }
        }

        public void BaseEdit_SetEditValue(DevExpress.XtraEditors.BaseEdit baseEdit, object value)
        {
            if (baseEdit.InvokeRequired)
            {
                baseEdit.Invoke(new Action(() =>
                {
                    baseEdit.EditValue = value;
                }));
            }
            else
            {
                baseEdit.EditValue = value;
            }
        }

        public void ComboBoxEdit_SetSelectedIndex(DevExpress.XtraEditors.ComboBoxEdit control, int index)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.SelectedIndex = index;
                }));
            }
            else
            {
                control.SelectedIndex = index;
            }
        }

        public void CheckedComboBoxEdit_ClearItems(DevExpress.XtraEditors.CheckedComboBoxEdit control)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.Properties.Items.Clear();
                }));
            }
            else
            {
                control.Properties.Items.Clear();
            }
        }

        public void CheckedComboBoxEdit_AddItems(DevExpress.XtraEditors.CheckedComboBoxEdit control,
            object value, string description, CheckState checkState, bool enabled)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new Action(() =>
                {
                    control.Properties.Items.Add(value, description, checkState, enabled);
                }));
            }
            else
            {
                control.Properties.Items.Add(value, description, checkState, enabled);
            }
        }

        public void XtraTabControl_SetSelectedTabPageIndex(DevExpress.XtraTab.XtraTabControl xtraTabControl, int index)
        {
            if (xtraTabControl.InvokeRequired)
            {
                xtraTabControl.Invoke(new Action(() =>
                {
                    xtraTabControl.SelectedTabPageIndex = index;
                }));
            }
            else
            {
                xtraTabControl.SelectedTabPageIndex = index;
            }
        }

        public void XtraTabPage_ControlsAdd(DevExpress.XtraTab.XtraTabPage xtraTabPage, Control control)
        {
            if (xtraTabPage.InvokeRequired)
            {
                xtraTabPage.Invoke(new Action(() =>
                {
                    xtraTabPage.Controls.Add(control);
                }));
            }
            else
            {
                xtraTabPage.Controls.Add(control);
            }
        }

        public void XtraForm_ControlsAdd(DevExpress.XtraEditors.XtraForm xtraForm, Control control)
        {
            if (xtraForm.InvokeRequired)
            {
                xtraForm.Invoke(new Action(() =>
                {
                    xtraForm.Controls.Add(control);
                }));
            }
            else
            {
                xtraForm.Controls.Add(control);
            }
        }

        public void XtraForm_ControlsRemove(DevExpress.XtraEditors.XtraForm xtraForm, Control control)
        {
            if (xtraForm.InvokeRequired)
            {
                xtraForm.Invoke(new Action(() =>
                {
                    xtraForm.Controls.Remove(control);
                }));
            }
            else
            {
                xtraForm.Controls.Remove(control);
            }
        }

        public void XtraTabPage_ControlsRemove(DevExpress.XtraTab.XtraTabPage xtraTabPage, Control control)
        {
            if (xtraTabPage.InvokeRequired)
            {
                xtraTabPage.Invoke(new Action(() =>
                {
                    xtraTabPage.Controls.Remove(control);
                }));
            }
            else
            {
                xtraTabPage.Controls.Remove(control);
            }
        }

        public void GridControl_ViewRemove(DevExpress.XtraGrid.GridControl gridControl)
        {
            if (gridControl.InvokeRequired)
            {
                gridControl.Invoke(new Action(() =>
                {
                    gridControl.DataSource = null;
                    var view = new DevExpress.XtraGrid.Views.Grid.GridView(gridControl);
                    view.OptionsView.ShowGroupPanel = false;
                    view.OptionsView.ShowColumnHeaders = false;
                    gridControl.MainView = view;
                }));
            }
            else
            {
                gridControl.DataSource = null;
                var view = new DevExpress.XtraGrid.Views.Grid.GridView(gridControl);
                view.OptionsView.ShowGroupPanel = false;
                view.OptionsView.ShowColumnHeaders = false;
                gridControl.MainView = view;
            }
        }

        public void GridControl_Refresh(DevExpress.XtraGrid.GridControl gridControl)
        {
            if (gridControl.InvokeRequired)
            {
                gridControl.Invoke(new Action(() =>
                {
                    gridControl.Refresh();
                    gridControl.RefreshDataSource();
                }));
            }
            else
            {
                gridControl.Refresh();
                gridControl.RefreshDataSource();
            }
        }

        public void XtraTabPage_SetText(DevExpress.XtraTab.XtraTabPage xtraTabPage, string text)
        {
            if (xtraTabPage.InvokeRequired)
            {
                xtraTabPage.Invoke(new Action(() =>
                {
                    xtraTabPage.Text = text;
                }));
            }
            else
            {
                xtraTabPage.Text = text;
            }
        }

        public void XtraForm_SetText(DevExpress.XtraEditors.XtraForm xtraForm, string text)
        {
            if (xtraForm.InvokeRequired)
            {
                xtraForm.Invoke(new Action(() =>
                {
                    xtraForm.Text = text;
                }));
            }
            else
            {
                xtraForm.Text = text;
            }
        }

        public void GridControl_Dispose(DevExpress.XtraGrid.GridControl gridControl)
        {
            if (gridControl.InvokeRequired)
            {
                gridControl.Invoke(new Action(() =>
                {
                    gridControl.Dispose();
                }));
            }
            else
            {
                gridControl.Dispose();
            }
            gridControl = null;
        }

        public void ChartControl_Dispose(DevExpress.XtraCharts.ChartControl chartControl)
        {
            if (chartControl.InvokeRequired)
            {
                chartControl.Invoke(new Action(() =>
                {
                    chartControl.Dispose();
                }));
            }
            else
            {
                chartControl.Dispose();
            }
            chartControl = null;
        }

        public void ChartControl_EndInit(DevExpress.XtraCharts.ChartControl chartControl)
        {
            if (chartControl.InvokeRequired)
            {
                chartControl.Invoke(new Action(() =>
                {
                    ((System.ComponentModel.ISupportInitialize)chartControl).EndInit();
                }));
            }
            else
            {
                ((System.ComponentModel.ISupportInitialize)chartControl).EndInit();
            }
        }

        public void GridControl_EndInit(DevExpress.XtraGrid.GridControl gridControl)
        {
            if (gridControl.InvokeRequired)
            {
                gridControl.Invoke(new Action(() =>
                {
                    ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
                }));
            }
            else
            {
                ((System.ComponentModel.ISupportInitialize)gridControl).EndInit();
            }
        }

        public void GridControl_SetDataMember(DevExpress.XtraGrid.GridControl gridControl, string name)
        {
            if (gridControl.InvokeRequired)
            {
                gridControl.Invoke(new Action(() =>
                {
                    gridControl.DataMember = name;
                }));
            }
            else
            {
                gridControl.DataMember = name;
            }
        }

        #endregion
    }
}
