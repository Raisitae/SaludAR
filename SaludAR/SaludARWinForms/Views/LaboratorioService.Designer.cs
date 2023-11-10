namespace SaludARWinForms.Views
{
    partial class LaboratorioService
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSalir = new Button();
            btnAgregarServicioLab = new Button();
            txtCantidadDias = new TextBox();
            txtNombreServicioLab = new TextBox();
            lblPrecio = new Label();
            lblGanancia = new Label();
            lblNombreServicioLab = new Label();
            cboComplejidad = new ComboBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(425, 264);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(179, 50);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregarServicioLab
            // 
            btnAgregarServicioLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarServicioLab.Location = new Point(178, 264);
            btnAgregarServicioLab.Name = "btnAgregarServicioLab";
            btnAgregarServicioLab.Size = new Size(179, 50);
            btnAgregarServicioLab.TabIndex = 14;
            btnAgregarServicioLab.Text = "AGREGAR";
            btnAgregarServicioLab.UseVisualStyleBackColor = true;
            btnAgregarServicioLab.Click += btnAgregarServicioLab_Click;
            // 
            // txtCantidadDias
            // 
            txtCantidadDias.Location = new Point(425, 121);
            txtCantidadDias.Name = "txtCantidadDias";
            txtCantidadDias.Size = new Size(182, 23);
            txtCantidadDias.TabIndex = 12;
            txtCantidadDias.TextChanged += txtCantidadDias_TextChanged;
            // 
            // txtNombreServicioLab
            // 
            txtNombreServicioLab.Location = new Point(425, 64);
            txtNombreServicioLab.Name = "txtNombreServicioLab";
            txtNombreServicioLab.Size = new Size(182, 23);
            txtNombreServicioLab.TabIndex = 11;
            txtNombreServicioLab.TextChanged += txtNombreServicioLab_TextChanged;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(146, 172);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(198, 28);
            lblPrecio.TabIndex = 10;
            lblPrecio.Text = "Nivel de complejidad";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblGanancia.Location = new Point(146, 116);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new Size(265, 28);
            lblGanancia.TabIndex = 9;
            lblGanancia.Text = "Cantidad de dias del servicio:";
            lblGanancia.Click += lblGanancia_Click;
            // 
            // lblNombreServicioLab
            // 
            lblNombreServicioLab.AutoSize = true;
            lblNombreServicioLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreServicioLab.Location = new Point(146, 59);
            lblNombreServicioLab.Name = "lblNombreServicioLab";
            lblNombreServicioLab.Size = new Size(192, 28);
            lblNombreServicioLab.TabIndex = 8;
            lblNombreServicioLab.Text = "Nombre del servicio:";
            lblNombreServicioLab.Click += lblNombreServicioLab_Click;
            // 
            // cboComplejidad
            // 
            cboComplejidad.FormattingEnabled = true;
            cboComplejidad.Location = new Point(425, 177);
            cboComplejidad.Name = "cboComplejidad";
            cboComplejidad.Size = new Size(76, 23);
            cboComplejidad.TabIndex = 16;
            // 
            // LaboratorioService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboComplejidad);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregarServicioLab);
            Controls.Add(txtCantidadDias);
            Controls.Add(txtNombreServicioLab);
            Controls.Add(lblPrecio);
            Controls.Add(lblGanancia);
            Controls.Add(lblNombreServicioLab);
            Name = "LaboratorioService";
            Text = "LaboratorioService";
            Load += LaboratorioService_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnAgregarServicioLab;
        private TextBox txtCantidadDias;
        private TextBox txtNombreServicioLab;
        private Label lblPrecio;
        private Label lblGanancia;
        private Label lblNombreServicioLab;
        private ComboBox cboComplejidad;
    }
}