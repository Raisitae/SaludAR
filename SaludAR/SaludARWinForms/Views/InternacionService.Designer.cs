namespace SaludARWinForms.Views
{
    partial class InternacionService
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
            btnAgregarServicioInter = new Button();
            txtCantidadDias = new TextBox();
            txtNombreServicioInter = new TextBox();
            lblPrecio = new Label();
            lblGanancia = new Label();
            lblNombreServicioLab = new Label();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ControlLight;
            btnSalir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(436, 224);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(179, 50);
            btnSalir.TabIndex = 22;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregarServicioInter
            // 
            btnAgregarServicioInter.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarServicioInter.Location = new Point(179, 224);
            btnAgregarServicioInter.Name = "btnAgregarServicioInter";
            btnAgregarServicioInter.Size = new Size(179, 50);
            btnAgregarServicioInter.TabIndex = 21;
            btnAgregarServicioInter.Text = "AGREGAR";
            btnAgregarServicioInter.UseVisualStyleBackColor = true;
            btnAgregarServicioInter.Click += btnAgregarServicioInter_Click;
            // 
            // txtCantidadDias
            // 
            txtCantidadDias.Location = new Point(433, 140);
            txtCantidadDias.Name = "txtCantidadDias";
            txtCantidadDias.Size = new Size(182, 23);
            txtCantidadDias.TabIndex = 20;
            // 
            // txtNombreServicioInter
            // 
            txtNombreServicioInter.Location = new Point(433, 83);
            txtNombreServicioInter.Name = "txtNombreServicioInter";
            txtNombreServicioInter.Size = new Size(182, 23);
            txtNombreServicioInter.TabIndex = 19;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(139, 193);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(0, 28);
            lblPrecio.TabIndex = 18;
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblGanancia.Location = new Point(139, 135);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new Size(292, 28);
            lblGanancia.TabIndex = 17;
            lblGanancia.Text = "Cantidad de dias de internacion:";
            // 
            // lblNombreServicioLab
            // 
            lblNombreServicioLab.AutoSize = true;
            lblNombreServicioLab.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreServicioLab.Location = new Point(139, 75);
            lblNombreServicioLab.Name = "lblNombreServicioLab";
            lblNombreServicioLab.Size = new Size(249, 28);
            lblNombreServicioLab.TabIndex = 16;
            lblNombreServicioLab.Text = "Nombre de la especialidad:";
            // 
            // InternacionService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregarServicioInter);
            Controls.Add(txtCantidadDias);
            Controls.Add(txtNombreServicioInter);
            Controls.Add(lblPrecio);
            Controls.Add(lblGanancia);
            Controls.Add(lblNombreServicioLab);
            Name = "InternacionService";
            Text = "InternacionService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnAgregarServicioInter;
        private TextBox txtCantidadDias;
        private TextBox txtNombreServicioInter;
        private Label lblPrecio;
        private Label lblGanancia;
        private Label lblNombreServicioLab;
    }
}