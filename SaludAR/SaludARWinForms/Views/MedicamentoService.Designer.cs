namespace SaludARWinForms.Views
{
    partial class MedicamentoService
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
            lblNombreMedicamento = new Label();
            lblGanancia = new Label();
            lblPrecio = new Label();
            txtNombreMedicamento = new TextBox();
            txtGanancia = new TextBox();
            txtPrecio = new TextBox();
            btnAgregarMedicamento = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNombreMedicamento
            // 
            lblNombreMedicamento.AutoSize = true;
            lblNombreMedicamento.Location = new Point(119, 68);
            lblNombreMedicamento.Name = "lblNombreMedicamento";
            lblNombreMedicamento.Size = new Size(128, 15);
            lblNombreMedicamento.TabIndex = 0;
            lblNombreMedicamento.Text = "Nombre Medicamento";
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Location = new Point(119, 109);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new Size(115, 15);
            lblGanancia.TabIndex = 1;
            lblGanancia.Text = "Porcentaje Ganancia";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(119, 161);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new Point(298, 65);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new Size(182, 23);
            txtNombreMedicamento.TabIndex = 3;
            // 
            // txtGanancia
            // 
            txtGanancia.Location = new Point(298, 106);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(182, 23);
            txtGanancia.TabIndex = 4;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(298, 153);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(182, 23);
            txtPrecio.TabIndex = 5;
            // 
            // btnAgregarMedicamento
            // 
            btnAgregarMedicamento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarMedicamento.Location = new Point(542, 61);
            btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            btnAgregarMedicamento.Size = new Size(179, 50);
            btnAgregarMedicamento.TabIndex = 6;
            btnAgregarMedicamento.Text = "AGREGAR";
            btnAgregarMedicamento.UseVisualStyleBackColor = true;
            btnAgregarMedicamento.Click += btnAgregarMedicamento_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(542, 134);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(179, 50);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // MedicamentoService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregarMedicamento);
            Controls.Add(txtPrecio);
            Controls.Add(txtGanancia);
            Controls.Add(txtNombreMedicamento);
            Controls.Add(lblPrecio);
            Controls.Add(lblGanancia);
            Controls.Add(lblNombreMedicamento);
            Name = "MedicamentoService";
            Text = "MedicamentoService";
            Load += MedicamentoService_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreMedicamento;
        private Label lblGanancia;
        private Label lblPrecio;
        private TextBox txtNombreMedicamento;
        private TextBox txtGanancia;
        private TextBox txtPrecio;
        private Button btnAgregarMedicamento;
        private Button btnSalir;
    }
}