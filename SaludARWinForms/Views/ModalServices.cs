using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludARWinForms.Views
{
    public partial class ModalServices : Form
    {
        public ModalServices()
        {
            InitializeComponent();
            Administrador admin = Administrador.GetInstance();

            dataGridView1.DataSource = admin.Medicamentos;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Administrador admin = Administrador.GetInstance();


        }
    }
}
