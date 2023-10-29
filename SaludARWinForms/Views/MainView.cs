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
            this.Hide();
            Form formDetail = new ServiceDetail();
            formDetail.ShowDialog();
            formDetail = null;
            this.Show();
        }
    }
}