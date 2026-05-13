namespace CarDealership
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCars_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма автомобілів буде додана пізніше.");
        }

        private void btnBuyers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма покупців буде додана пізніше.");
        }

        private void btnMatching_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма підбору автомобілів буде додана пізніше.");
        }

        private void btnRequests_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма заявок буде додана пізніше.");
        }
    }
}
