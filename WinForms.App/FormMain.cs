using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

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

            labelCreditAmount.Text = ResManager.GetString("labelCreditAmount");
            labelAnnualInterest.Text = ResManager.GetString("labelAnnualInterest");
            labelCreditTerm.Text = ResManager.GetString("labelCreditTerm");
            labelCreditTerm2.Text = ResManager.GetString("labelCreditTerm2");

            buttonCalc.Text = ResManager.GetString("buttonCalc");
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
            decimal creditAamount = fieldCreditAamount.Value;
            decimal annualInterest = fieldAnnualInterest.Value;
            decimal creditTerm = fieldCreditTerm.Value;

            // Check-list.
            if (creditAamount <= 0 || annualInterest <= 0 || creditTerm <= 0)
            {
                MessageBox.Show(ResManager.GetString("messageErrorZeroInFields"),
                    ResManager.GetString("formCaption"));
                return;
            }

            // Clear. 
            dataGridView.Rows.Clear();
            // Calc: Number, pay, percent, remaining
            //var n = 1;
            decimal i = creditTerm / 100 / 12;
            decimal j = (decimal) Math.Pow((double)(1 + i), 1);
            decimal pay = creditAamount * (i + (i / (j - 1)));
            decimal percent = 0;
            decimal remaining = 0;
            for (int row = 1; row <= creditTerm; row++)
            {
                dataGridView.Rows.Add(new object[] { row, pay, percent, remaining });
            }
        }
    }
}
