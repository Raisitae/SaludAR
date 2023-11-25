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
    public partial class LabService : Form
    {
        public LabService()
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

        private void agregar_Click(object sender, EventArgs e)
        {
            Administrador admin = Administrador.GetInstance();


            if (string.IsNullOrEmpty(txtNombre.Text) | string.IsNullOrEmpty(txtCantDias.Text) | string.IsNullOrEmpty(txtComplejidad.Text))
            {

                MessageBox.Show("Por favor, es obligatorio rellenar todos los campos");

            }
            else
            {
                string nombre = txtNombre.Text;
                int cantDias = Int32.Parse(txtCantDias.Text);
                int complejidad = Int32.Parse(txtComplejidad.Text);

                ServicioLaboratorio lab1 = new ServicioLaboratorio(cantDias, complejidad, nombre);
                admin.addServicio(lab1);

                MessageBox.Show("Servicio añadido exitosamente");

                txtNombre.Clear();
                txtCantDias.Clear();
                txtComplejidad.Clear();
            }
        }
    }
}
