using CarDealership.Forms;
using CarDealership.Models;
using CarDealership.Services;

namespace CarDealership
{
    public partial class MainForm : Form
    {
        private CarService carService;
        private CarGridService carGridService;
        private CarSelectionService carSelectionService;

        // Конструктор форми
        public MainForm()
        {
            InitializeComponent();

            carService = new CarService();
            carGridService = new CarGridService();
            carSelectionService = new CarSelectionService();

            LoadCars();
        }

        // Метод для завантаження автомобілів у таблицю
        private void LoadCars()
        {
            dgvCars.DataSource = null;
            dgvCars.DataSource = carGridService.GetCarsForGrid(carService.Cars);
            dgvCars.Columns["Id"].Visible = false;
        }

        private void tabCars_Click(object sender, EventArgs e)
        {

        }

        // Обробник події для кнопки "Додати автомобіль"
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            CarForm form = new CarForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                carService.AddCar(form.NewCar);

                LoadCars();
            }
        }

        // Обробник події для кнопки "Редагувати автомобіль"
        private void btnEditCar_Click(object sender, EventArgs e)
        {
            Guid id = carSelectionService.GetSelectedId(dgvCars);

            if (id == Guid.Empty)
            {
                MessageBox.Show("Оберіть авто");

                return;
            }

            Car? car = carService.Cars.FirstOrDefault(x => x.Id == id);

            if (car == null)
                return;

            CarForm form =new CarForm(car);

            if (form.ShowDialog() == DialogResult.OK)
            {
                carService.UpdateCar(id,form.NewCar!);

                LoadCars();
            }
        }

        // Обробник події для кнопки "Видалити автомобіль"
        private void btnDeleteCar_Click(object sender, EventArgs e)
        {
            Guid id = carSelectionService.GetSelectedId(dgvCars);

            if (id == Guid.Empty)
            {
                MessageBox.Show("Оберіть авто");

                return;
            }

            DialogResult result =
            MessageBox.Show("Видалити авто?", "Підтвердження", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes)
                return;

            carService.DeleteCar(id);

            LoadCars();
        }

        private void txtCarSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
