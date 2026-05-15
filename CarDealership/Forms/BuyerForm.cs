using CarDealership.Enums;
using CarDealership.Models;
using CarDealership.Services;

namespace CarDealership.Forms
{
    public partial class BuyerForm : Form
    {
        private BuyerFormService buyerFormService;

        public Buyer? NewBuyer { get; private set; }

        public BuyerForm()
        {
            InitializeComponent();

            buyerFormService = new BuyerFormService();

            buyerFormService.LoadComboBox(
                cmbCondition);
        }

        public BuyerForm(Buyer buyer)
        {
            InitializeComponent();

            buyerFormService = new BuyerFormService();

            buyerFormService.LoadComboBox(
                cmbCondition);

            FillFields(buyer);
        }

        private void FillFields(Buyer buyer)
        {
            txtFullName.Text = buyer.FullName;
            txtPhone.Text = buyer.Phone;
            txtEmail.Text = buyer.Email;
            txtDesiredBrand.Text = buyer.DesiredBrand;

            nudMinYear.Value = buyer.MinYear;
            nudMaxPrice.Value = buyer.MaxPrice;

            rtbRequirements.Text =
                buyer.Requirements;

            cmbCondition.SelectedItem =
                buyer.RequiredCondition;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDesiredBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void nudMinYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rtbRequirements_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool valid = buyerFormService.Validate(txtFullName.Text);

            if (!valid)
            {
                MessageBox.Show("Введіть ПІБ");
                return;
            }

            NewBuyer = buyerFormService.CreateBuyer(
                txtFullName.Text,
                txtPhone.Text,
                txtEmail.Text,
                txtDesiredBrand.Text,
                (int)nudMinYear.Value,
                nudMaxPrice.Value,
                rtbRequirements.Text,
                (TechnicalCondition)cmbCondition.SelectedItem!);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void nudMaxPrice_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
