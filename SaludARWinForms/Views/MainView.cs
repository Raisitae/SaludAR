using Microsoft.Win32;
using SaludARWinForms.Views;

namespace SaludARWinForms
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAddService = new ServiceAdd();
            formAddService.ShowDialog();
            formAddService = null;
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje");
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            Administrador admin = Administrador.GetInstance();

            Medicamento medicamento1 = new Medicamento("prueba",333,444);
            admin.addMedicamento(medicamento1);
            Medicamento medicamento2 = new Medicamento("prueba2", 333, 444);
            admin.addMedicamento(medicamento2);

            admin.showAll();
            this.Hide();
            Form formGrid = new ModalServices();
            formGrid.ShowDialog();
            formGrid = null;
            this.Show();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}