using CarDealership.Services;

namespace CarDealership
{
    public partial class MainForm : Form
    {
        private CarService carService;
        private CarGridService carGridService;

        public MainForm()
        {
            InitializeComponent();

            carService = new CarService();
            carGridService = new CarGridService();

            LoadCars();
        }

        private void LoadCars()
        {
            dgvCars.DataSource = null;

            dgvCars.DataSource =
                carGridService.GetCarsForGrid(carService.Cars);
        }

        private void tabCars_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCar_Click(object sender, EventArgs e)
        {

        }

        private void txtCarSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
