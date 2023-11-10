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
    public partial class LaboratorioService : Form
    {
        public LaboratorioService()
        {
            InitializeComponent();
        }

        private void LaboratorioService_Load(object sender, EventArgs e)
        {
            cboComplejidad.Items.Add(1);
            cboComplejidad.Items.Add(2);
            cboComplejidad.Items.Add(3);
            cboComplejidad.Items.Add(4);
            cboComplejidad.Items.Add(5);
        }

        private void btnAgregarServicioLab_Click(object sender, EventArgs e)
        {
            Administrador admin = Administrador.GetInstance();

            string nombre = txtNombreServicioLab.Text;
            int dias = int.Parse(txtCantidadDias.Text);// Aquí asumimos que se ingresará un número válido
            int complejidad = int.Parse(cboComplejidad.SelectedItem.ToString());
            double precio = 0;
            if (nombre != "")
            {
                ServicioLaboratorio servicioLab = new ServicioLaboratorio(dias, complejidad, nombre, precio);

                precio = servicioLab.calcularPrecio(dias, complejidad);
                admin.addServicio();

                //Limpiar casillas despues de agregar servicio
                txtNombreServicioLab.Clear();
                txtCantidadDias.Clear();
                cboComplejidad.SelectedIndex = -1;

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

        private void txtNombreServicioLab_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGanancia_Click(object sender, EventArgs e)
        {
        }

        private void txtCantidadDias_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblPrecio_Click(object sender, EventArgs e)
        {
        }

        private void lblNombreServicioLab_Click(object sender, EventArgs e)
        {
        }
    }
}
