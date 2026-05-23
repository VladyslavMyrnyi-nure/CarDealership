using CarDealership.Enums;
using CarDealership.Models;
using CarDealership.Services;

namespace CarDealership.Forms
{
    public partial class CarForm : Form
    {
        public Car NewCar { get; private set; }
        private Guid carId;

        private CarFormService carFormService;

        // Конструктор для додавання нового автомобіля
        public CarForm()
        {
            InitializeComponent();

            carFormService = new CarFormService();
            carFormService.LoadComboBoxes(cmbFuel, cmbTransmission, cmbCondition, cmbBodyType);
        }

        // Конструктор для редагування автомобіля
        public CarForm(Car car)
        {
            InitializeComponent();

            carFormService = new CarFormService();
            carFormService.LoadComboBoxes(cmbFuel, cmbTransmission, cmbCondition, cmbBodyType);

            FillFields(car);
        }

        
        private void FillFields(Car car)
        {
            carId = car.Id;
            txtBrand.Text = car.Brand;
            txtModel.Text = car.Model;
            nudYear.Value = car.Year;
            nudEngine.Value = (decimal)car.EngineVolume;
            nudHorsePower.Value = car.HorsePower;
            nudMileage.Value = car.Mileage;
            txtCountry.Text = car.Country;
            rtbFeatures.Text = car.Features;
            cmbFuel.SelectedItem = car.FuelType;
            cmbTransmission.SelectedItem = car.Transmission;
            cmbCondition.SelectedItem = car.Condition;
            cmbBodyType.SelectedItem = car.BodyType;
            txtLocation.Text = car.Location;
            chkIsNew.Checked = car.IsNew;
            nudPrice.Value = car.Price;
        }

        private void LoadConditions()
        {
            cmbCondition.DataSource =
                Enum.GetValues(typeof(TechnicalCondition));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void nudPrice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudYear_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbCondition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            bool valid = carFormService.ValidateData(txtBrand.Text,txtModel.Text);

            if (!valid)
            {
                MessageBox.Show("Заповніть марку та модель");

                return;
            }

            NewCar = carFormService.CreateCar(
                txtBrand.Text,
                txtModel.Text,
                (int)nudYear.Value,
                (double)nudEngine.Value,
                (int)nudHorsePower.Value,
                (int)nudMileage.Value,
                txtCountry.Text,
                rtbFeatures.Text,
                (FuelType)cmbFuel.SelectedItem!,
                (TransmissionType)cmbTransmission.SelectedItem!,
                (TechnicalCondition)cmbCondition.SelectedItem!,
                (BodyType)cmbBodyType.SelectedItem!,
                txtLocation.Text,
                chkIsNew.Checked,
                nudPrice.Value);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            Close();
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void nudEngine_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudHorsePower_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudMileage_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbFuel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTransmission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkIsNew_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rtbFeatures_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBodyType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }
    }
}