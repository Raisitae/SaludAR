using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludARWinForms.Views
{
    public partial class AdmittionService : Form
    {
        public AdmittionService()
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
       

        private void flecha_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregarInternacion_Click_1(object sender, EventArgs e)
        {
            Administrador admin = Administrador.GetInstance();


            if (string.IsNullOrEmpty(txtCantDias.Text) | string.IsNullOrEmpty(txtEspecialidad.Text))
            {

                MessageBox.Show("Por favor, es obligatorio rellenar todos los campos");

            }
            else
            {

                int cantDias = Int32.Parse(txtCantDias.Text);
                string especialidad = txtEspecialidad.Text;

                ServicioInternacion internacion = new ServicioInternacion(cantDias, especialidad);
                admin.addServicio(internacion);

                MessageBox.Show("Servicio añadido exitosamente");

                txtCantDias.Clear();
                txtEspecialidad.Clear();
            }
        }
    }
}
