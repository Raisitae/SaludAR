using SaludARWinForms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludARWinForms
{
    public partial class ServiceAdd : Form
    {
        public ServiceAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMedicamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formMedicamentoService = new MedicamentoService();
            formMedicamentoService.ShowDialog();
            formMedicamentoService = null;
            this.Show();
        }
    }
}
