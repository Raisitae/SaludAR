using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SaludARWinForms.Views;
using System.Windows.Forms;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SaludARWinForms.Views
{
    public partial class MedicamentoService : Form
    {
        

        public MedicamentoService()
        {
            InitializeComponent();
        }

        private void MedicamentoService_Load(object sender, EventArgs e)
        {

        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            Administrador admin = Administrador.GetInstance();

            string nombre = txtNombreMedicamento.Text;
            double ganancia = Double.Parse(txtGanancia.Text);// Aquí asumimos que se ingresará un número válido
            double precio = Double.Parse(txtPrecio.Text);

            if (nombre != "")
            {
                Medicamento medicamento1 = new Medicamento(nombre, ganancia, precio);
                admin.addMedicamento(medicamento1);
                txtNombreMedicamento.Clear();
                txtGanancia.Clear();
                txtPrecio.Clear();
               

            }
            else
            {
                MessageBox.Show("Por favor, completa los campos para registrar el medicamento.");
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
