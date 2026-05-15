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
        private CarSearchService carSearchService;

        private BuyerService buyerService;
        private BuyerGridService buyerGridService;
        private BuyerSelectionService buyerSelectionService;
        private BuyerSearchService buyerSearchService;

        // Конструктор форми
        public MainForm()
        {
            InitializeComponent();

            carService = new CarService();
            carGridService = new CarGridService();
            carSelectionService = new CarSelectionService();
            carSearchService = new CarSearchService();

            buyerService = new BuyerService();
            buyerGridService = new BuyerGridService();

            buyerSelectionService = new BuyerSelectionService();
            buyerSearchService = new BuyerSearchService();

            LoadCars();
            LoadBuyers();
        }

        // Метод для завантаження автомобілів у таблицю
        private void LoadCars()
        {
            string searchText = txtCarSearch.Text;

            List<Car> cars = carSearchService.SearchCars(carService.Cars, searchText);

            dgvCars.DataSource = null;
            dgvCars.DataSource = carGridService.GetCarsForGrid(cars);
            dgvCars.Columns["Id"].Visible = false;

            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCars.Columns["Особливості"].FillWeight = 180;

            dgvCars.Columns["Марка"].FillWeight = 70;
            dgvCars.Columns["Модель"].FillWeight = 70;
            dgvCars.Columns["Рік"].FillWeight = 50;
            dgvCars.Columns["Ціна"].FillWeight = 70;

            dgvCars.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvCars.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        // Метод для завантаження покупців у таблицю
        private void LoadBuyers()
        {
            string text = txtBuyerSearch.Text;
            var buyers = buyerSearchService.SearchBuyers(buyerService.Buyers, text);

            dgvBuyers.DataSource = null;
            dgvBuyers.DataSource = buyerGridService.GetBuyersForGrid(buyers);
            dgvBuyers.Columns["Id"].Visible = false;

            dgvBuyers.Columns["Id"].Visible = false;

            dgvBuyers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvBuyers.Columns["Вимоги"].FillWeight = 220;

            dgvBuyers.Columns["Покупець"].FillWeight = 110;
            dgvBuyers.Columns["Телефон"].FillWeight = 110;
            dgvBuyers.Columns["Марка"].FillWeight = 80;
            dgvBuyers.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBuyers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

            CarForm form = new CarForm(car);

            if (form.ShowDialog() == DialogResult.OK)
            {
                carService.UpdateCar(id, form.NewCar!);

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
            LoadCars();
        }

        private void dgvCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBuyerSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBuyers();
        }

        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            BuyerForm form =
            new BuyerForm();

            if (form.ShowDialog()
                == DialogResult.OK)
            {
                buyerService.AddBuyer(form.NewBuyer!);

                LoadBuyers();
            }
        }

        private void btnEditBuyer_Click(object sender, EventArgs e)
        {
            Guid id = buyerSelectionService.GetSelectedId(dgvBuyers);

            Buyer? buyer = buyerService.Buyers.FirstOrDefault(x => x.Id == id);

            if (buyer == null)
                return;

            BuyerForm form = new BuyerForm(buyer);

            if (form.ShowDialog() == DialogResult.OK)
            {
                buyerService.UpdateBuyer(id, form.NewBuyer!);

                LoadBuyers();
            }


           
        }

        private void btnDeleteBuyer_Click(object sender, EventArgs e)
        {
            Guid id =
                buyerSelectionService.GetSelectedId(
                    dgvBuyers);

            if (id == Guid.Empty)
            {
                MessageBox.Show(
                    "Оберіть покупця");

                return;
            }

            DialogResult result = MessageBox.Show(
                    "Видалити покупця?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            buyerService.DeleteBuyer(id);

            LoadBuyers();
        }

        private void dgvBuyers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
