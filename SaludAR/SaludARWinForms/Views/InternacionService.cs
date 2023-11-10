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
    public partial class InternacionService : Form
    {
        public InternacionService()
        {
            InitializeComponent();
        }

        private void btnAgregarServicioInter_Click(object sender, EventArgs e)
        {
            Administrador admin = Administrador.GetInstance();

            string nombre_especialidad = txtNombreServicioInter.Text;
            int dias = int.Parse(txtCantidadDias.Text);// Aquí asumimos que se ingresará un número válido
            double precio = 0;

            if (nombre_especialidad != "")
            {
                ServicioInternacion servicioInter = new ServicioInternacion(dias, nombre_especialidad, precio);

                precio = servicioInter.calcularPrecio(dias);
                admin.addServicio();

                //Limpiar casillas despues de agregar servicio
                txtNombreServicioInter.Clear();
                txtCantidadDias.Clear();

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
