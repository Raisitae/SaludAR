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
            lblNombreMedicamento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreMedicamento.Location = new Point(81, 61);
            lblNombreMedicamento.Name = "lblNombreMedicamento";
            lblNombreMedicamento.Size = new Size(211, 28);
            lblNombreMedicamento.TabIndex = 0;
            lblNombreMedicamento.Text = "Nombre Medicamento";
            lblNombreMedicamento.Click += lblNombreMedicamento_Click;
            // 
            // lblGanancia
            // 
            lblGanancia.AutoSize = true;
            lblGanancia.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblGanancia.Location = new Point(81, 118);
            lblGanancia.Name = "lblGanancia";
            lblGanancia.Size = new Size(188, 28);
            lblGanancia.TabIndex = 1;
            lblGanancia.Text = "Porcentaje Ganancia";
            lblGanancia.Click += lblGanancia_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecio.Location = new Point(81, 174);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(66, 28);
            lblPrecio.TabIndex = 2;
            lblPrecio.Text = "Precio";
            lblPrecio.Click += lblPrecio_Click;
            // 
            // txtNombreMedicamento
            // 
            txtNombreMedicamento.Location = new Point(360, 66);
            txtNombreMedicamento.Name = "txtNombreMedicamento";
            txtNombreMedicamento.Size = new Size(182, 23);
            txtNombreMedicamento.TabIndex = 3;
            txtNombreMedicamento.TextChanged += txtNombreMedicamento_TextChanged;
            // 
            // txtGanancia
            // 
            txtGanancia.Location = new Point(360, 123);
            txtGanancia.Name = "txtGanancia";
            txtGanancia.Size = new Size(182, 23);
            txtGanancia.TabIndex = 4;
            txtGanancia.TextChanged += txtGanancia_TextChanged;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(360, 182);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(182, 23);
            txtPrecio.TabIndex = 5;
            txtPrecio.TextChanged += txtPrecio_TextChanged;
            // 
            // btnAgregarMedicamento
            // 
            btnAgregarMedicamento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarMedicamento.Location = new Point(113, 266);
            btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            btnAgregarMedicamento.Size = new Size(179, 50);
            btnAgregarMedicamento.TabIndex = 6;
            btnAgregarMedicamento.Text = "AGREGAR";
            btnAgregarMedicamento.UseVisualStyleBackColor = true;
            btnAgregarMedicamento.Click += btnAgregarMedicamento_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.Control;
            btnSalir.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(360, 266);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(179, 50);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // MedicamentoService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(625, 365);
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