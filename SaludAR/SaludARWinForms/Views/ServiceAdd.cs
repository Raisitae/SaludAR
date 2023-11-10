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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLaboratorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formLaboratorioService = new LaboratorioService();
            formLaboratorioService.ShowDialog();
            formLaboratorioService = null;
            this.Show();
        }

        private void btnInternacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formInternacionService = new InternacionService();
            formInternacionService.ShowDialog();
            formInternacionService = null;
            this.Show();
        }
    }
}
