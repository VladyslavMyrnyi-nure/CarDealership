using CarDealership.Forms;
using CarDealership.Models;
using CarDealership.Services;
using System.Text.Json;


namespace CarDealership
{
    public partial class MainForm : Form
    {
        // Сервіси для роботи з машинами та логікою
        private CarService carService;
        private CarGridService carGridService;
        private CarSelectionService carSelectionService;
        private CarSearchService carSearchService;

        // Сервіси для роботи з покупцями та логікою
        private BuyerService buyerService;
        private BuyerGridService buyerGridService;
        private BuyerSelectionService buyerSelectionService;
        private BuyerSearchService buyerSearchService;

        // Сервіси для логіки підбору автомобілів покупцям
        private MatchingService matchingService;
        private MatchingGridService matchingGridService;

        // Сервіс для отримання індексу вибраного рядка у таблиці підбору
        private MatchSelectionService matchSelectionService;

        // Сервіси для роботи із заявками
        private RequestService requestService;
        private RequestGridService requestGridService;
        private RequestSelectionService requestSelectionService;

        // Сервіс для роботи з файлами
        private FileService fileService;
        private const string DataFile = @"..\..\..\Data\autosalon_backup.json";

        private readonly string projectDataPath = @"..\..\..\Data";

        // Конструктор форми
        public MainForm()
        {
            InitializeComponent();

            // Ініціалізація сервісів для роботи з автомобілями
            carService = new CarService();
            carGridService = new CarGridService();
            carSelectionService = new CarSelectionService();
            carSearchService = new CarSearchService();

            // Ініціалізація сервісів для роботи з покупцями
            buyerService = new BuyerService();
            buyerGridService = new BuyerGridService();
            buyerSelectionService = new BuyerSelectionService();
            buyerSearchService = new BuyerSearchService();

            // Ініціалізація сервісів для підбору автомобілів покупцям
            matchingService = new MatchingService();
            matchingGridService = new MatchingGridService();

            // Ініціалізація сервісу для отримання індексу вибраного рядка у таблиці підбору
            matchSelectionService = new MatchSelectionService();

            // Ініціалізація сервісів для роботи із заявками
            requestService = new RequestService();
            requestGridService = new RequestGridService();
            requestSelectionService = new RequestSelectionService();

            // Ініціалізація сервісу для роботи з файлами
            fileService = new FileService();

            LoadData();
        }

        // Метод для завантаження автомобілів у таблицю
        private void LoadCars()
        {
            string searchText = txtCarSearch.Text;

            List<Car> cars = carSearchService.SearchCars(carService.Cars, searchText);

            dgvCars.DataSource = null;
            dgvCars.DataSource = carGridService.GetCarsForGrid(cars);
            dgvCars.Columns["Id"].Visible = false;

            dgvCars.Columns["Особливості"].FillWeight = 180;
            dgvCars.Columns["Марка"].FillWeight = 70;
            dgvCars.Columns["Модель"].FillWeight = 70;
            dgvCars.Columns["Рік"].FillWeight = 50;
            dgvCars.Columns["Ціна"].FillWeight = 70;

            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dgvBuyers.Columns["Вимоги"].FillWeight = 220;
            dgvBuyers.Columns["Покупець"].FillWeight = 130;
            dgvBuyers.Columns["Телефон"].FillWeight = 120;
            dgvBuyers.Columns["Email"].FillWeight = 180;
            dgvBuyers.Columns["Марка"].FillWeight = 80;
            dgvBuyers.Columns["МінРік"].FillWeight = 60;

            dgvBuyers.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBuyers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void LoadBuyerCombo()
        {
            cmbBuyers.DataSource = null;
            cmbBuyers.DataSource = buyerService.Buyers;
            cmbBuyers.DisplayMember = "FullName";
        }

        // Метод для завантаження заявок у таблиці
        private void LoadRequests()
        {
            dgvSupplierRequests.DataSource = null;
            dgvTransportRequests.DataSource = null;

            var supplierRequests = requestService.Requests.Where(x => x.Type == "Постачальник").ToList();
            var transportRequests = requestService.Requests.Where(x => x.Type == "Перевізник").ToList();

            dgvSupplierRequests.DataSource = requestGridService.GetSupplierRequests(supplierRequests);
            dgvTransportRequests.DataSource = requestGridService.GetTransportRequests(transportRequests);
            dgvSupplierRequests.Columns["Id"].Visible = false;
            dgvTransportRequests.Columns["Id"].Visible = false;

            dgvSupplierRequests.Columns["Потрібний_автомобіль"].FillWeight = 220;
            dgvSupplierRequests.Columns["Коментар"].FillWeight = 140;
            dgvSupplierRequests.Columns["Номер"].FillWeight = 90;
            dgvTransportRequests.Columns["Автомобіль"].FillWeight = 220;
            dgvTransportRequests.Columns["Звідки"].FillWeight = 140;
            dgvTransportRequests.Columns["Куди"].FillWeight = 140;
        }

        // Метод для збереження даних у файли при закритті форми
        private void SaveData()
        {
            Directory.CreateDirectory(@"..\..\..\Data");

            AppData data = new AppData
                {
                    Cars =carService.Cars,
                    Buyers = buyerService.Buyers,
                    Requests = requestService.Requests
                };

            string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
                    {
                        WriteIndented = true
                    });

            File.WriteAllText(DataFile,json);
        }

        // Метод для завантаження даних з файлів при запуску форми
        private void LoadData()
        {
            if (!File.Exists(DataFile))
                return;

            string json =File.ReadAllText(DataFile);

            AppData? data = JsonSerializer.Deserialize<AppData>(json);

            if (data == null)
                return;

            carService.Cars = data.Cars;
            buyerService.Buyers = data.Buyers;
            requestService.Requests = data.Requests;

            LoadCars();
            LoadBuyers();
            LoadRequests();
            LoadBuyerCombo();
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
                SaveData();

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

                SaveData();
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

            DialogResult result = MessageBox.Show("Видалити авто?", "Підтвердження", MessageBoxButtons.YesNo);

            if (result != DialogResult.Yes) return;

            carService.DeleteCar(id);

            SaveData();
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

        // Обробник події для кнопки "Додати покупця"
        private void btnAddBuyer_Click(object sender, EventArgs e)
        {
            BuyerForm form = new BuyerForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                buyerService.AddBuyer(form.NewBuyer!);

                LoadBuyers();

                cmbBuyers.DataSource = null;
                cmbBuyers.DataSource = buyerService.Buyers;
                cmbBuyers.DisplayMember = "FullName";

                SaveData();
            }
        }

        // Обробник події для кнопки "Редагувати покупця"
        private void btnEditBuyer_Click(object sender, EventArgs e)
        {
            Guid id = buyerSelectionService.GetSelectedId(dgvBuyers);

            Buyer? buyer = buyerService.Buyers.FirstOrDefault( x => x.Id == id);

            if (buyer == null) return;

            BuyerForm form = new BuyerForm(buyer);

            if (form.ShowDialog()== DialogResult.OK)
            {
                buyerService.UpdateBuyer(id,form.NewBuyer!);

                LoadBuyers();

                cmbBuyers.DataSource = null;
                cmbBuyers.DataSource = buyerService.Buyers;
                cmbBuyers.DisplayMember = "FullName";

                SaveData();
            }
        }

        // Обробник події для кнопки "Видалити покупця"
        private void btnDeleteBuyer_Click(object sender, EventArgs e)
        {
            Guid id = buyerSelectionService.GetSelectedId(dgvBuyers);

            if (id == Guid.Empty)
            {
                MessageBox.Show("Оберіть покупця");

                return;
            }

            DialogResult result = MessageBox.Show("Видалити покупця?", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            buyerService.DeleteBuyer(id);

            LoadBuyerCombo();
            LoadBuyers();
            SaveData();
        }

        private void dgvBuyers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbBuyers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Обробник події для кнопки "Знайти автомобілі для покупця"
        private void btnFindCars_Click(object sender, EventArgs e)
        {
            Buyer? buyer = cmbBuyers.SelectedItem as Buyer;

            if (buyer == null)
            {
                MessageBox.Show("Оберіть покупця");

                return;
            }

            List<Car> cars =
                matchingService.FindCars(buyer, carService.Cars);

            dgvMatches.DataSource = null;

            dgvMatches.DataSource = matchingGridService.GetCars(cars);

            if (dgvMatches.Columns["Id"]!= null)
            {
                dgvMatches.Columns["Id"].Visible = false;
            }
        }


        // Обробник події для кнопки "Створити заявку постачальнику"
        private void btnSupplierRequest_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть авто");

                return;
            }

            Buyer buyer = (Buyer)cmbBuyers.SelectedItem;

            Guid carId = (Guid)dgvMatches.SelectedRows[0].Cells["Id"].Value;

            Car? car = carService.Cars.FirstOrDefault(x => x.Id == carId);

            if (car == null) return;

            Request request = new Request
            {
                Number = $"SUP-{DateTime.Now:yyyyMMdd-HHmmss}",
                Type = "Постачальник",
                BuyerName = buyer.FullName,
                CarInfo =
                        $"{car.Brand} {car.Model}, " +
                        $"{car.Year} р., " +
                        $"{car.EngineVolume} л, " +
                        $"{car.HorsePower} к.с., " +
                        $"{car.FuelType}, " +
                        $"{car.Transmission}",
                CarPrice = car.Price,
                Comment = "Підтвердити наявність автомобіля"
            };

            requestService.AddRequest(request);

            SaveData();
            LoadRequests();

            MessageBox.Show("Заявку створено");
        }

        private void btnTransportRequest_Click(object sender, EventArgs e)
        {
            if (dgvMatches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Оберіть авто");

                return;
            }

            Buyer buyer = (Buyer)cmbBuyers.SelectedItem;

            Guid carId = (Guid)dgvMatches.SelectedRows[0].Cells["Id"].Value;

            Car? car = carService.Cars.FirstOrDefault(x => x.Id == carId);

            if (car == null) return;

            Request request = new Request
            {
                Number = $"CAR-{DateTime.Now:yyyyMMdd-HHmmss}",
                Type = "Перевізник",
                BuyerName = buyer.FullName,
                CarInfo =
                        $"{car.Brand} {car.Model}, " +
                        $"{car.Year} р., " +
                        $"{car.EngineVolume} л",

                From = car.Location,
                To = "Автосалон або адреса покупця",

                DeliveryDate = DateTime.Now.AddDays(3)
            };

            requestService.AddRequest(request);

            SaveData();
            LoadRequests();

            MessageBox.Show("Заявку створено");
        }


        // Обробник події для кнопки "Видалити заявку постачальнику"
        private void btnDeleteSupplierRequest_Click(object sender, EventArgs e)
        {
            Guid id = requestSelectionService.GetSelectedId(dgvSupplierRequests);

            if (id == Guid.Empty)
            {
                MessageBox.Show("Оберіть заявку");

                return;
            }

            if (MessageBox.Show("Видалити заявку?", "Підтвердження", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            requestService.DeleteRequest(id);

            SaveData();
            LoadRequests();
        }

        private void dgvSupplierRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Обробник події для кнопки "Видалити заявку перевізнику"
        private void btnDeleteTransportRequest_Click(object sender, EventArgs e)
        {
            Guid id = requestSelectionService.GetSelectedId(dgvTransportRequests);

            if (id == Guid.Empty)
            {
                MessageBox.Show("Оберіть заявку");

                return;
            }

            if (MessageBox.Show("Видалити заявку?", "Підтвердження", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return;

            requestService.DeleteRequest(id);

            SaveData();
            LoadRequests();
        }

        private void dgvTransportRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Обробник події для кнопки "Зберегти в JSON"
        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            SaveData();

            MessageBox.Show("JSON збережено");
        }

        // Обробник події для кнопки "Завантажити з JSON"
        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "JSON files|*.json";
            dialog.InitialDirectory = Path.GetFullPath(@"..\..\..\Data");

            if (dialog.ShowDialog() != DialogResult.OK) return;

            File.Copy(dialog.FileName, DataFile, true);

            LoadData();

            MessageBox.Show("Файл завантажено");
        }
    }
}
