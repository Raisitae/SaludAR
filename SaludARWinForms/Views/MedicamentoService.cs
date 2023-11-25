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
using System.Drawing.Drawing2D;

namespace SaludARWinForms.Views
{
    public partial class MedicamentoService : Form
    {


        public MedicamentoService()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate(); // Activa repaint cuando se activa resize
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);


            Color lavenderColor = Color.FromArgb(176, 156, 215);
            Color lightPinkColor = Color.FromArgb(242, 136, 182);

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                lavenderColor,
                lightPinkColor,
                LinearGradientMode.Horizontal))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            Administrador admin = Administrador.GetInstance();


            if (string.IsNullOrEmpty(txtNombreMedicamento.Text) | string.IsNullOrEmpty(txtGanancia.Text) | string.IsNullOrEmpty(txtPrecio.Text))
            {

                MessageBox.Show("Por favor, es obligatorio rellenar todos los campos");

            }
            else
            {
                string nombre = txtNombreMedicamento.Text;
                double ganancia = Double.Parse(txtGanancia.Text);
                double precio = Double.Parse(txtPrecio.Text);

                Medicamento medicamento1 = new Medicamento(nombre, ganancia, precio);
                admin.addMedicamento(medicamento1);

                MessageBox.Show("Medicamento añadido exitosamente");

                txtNombreMedicamento.Clear();
                txtGanancia.Clear();
                txtPrecio.Clear();
            }
        }



        private void flecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
