using Microsoft.Win32;
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
    public partial class ServiceDetail : Form
    {
        private Administrador mostrarServicio;
        public ServiceDetail()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formAdd = new ServiceAdd();
            formAdd.ShowDialog();
            formAdd = null;
            this.Show();
        }

        private void ServiceDetail_Load(object sender, EventArgs e)
        {
            mostrarServicio = new Administrador();
            mostrarServicio.showAll();
        }
    }
}
