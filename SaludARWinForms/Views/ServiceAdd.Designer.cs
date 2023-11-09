namespace SaludARWinForms
{
    partial class ServiceAdd
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
            label1 = new Label();
            btnMedicamento = new Button();
            btnLaboratorio = new Button();
            btnInternacion = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(234, 69);
            label1.Name = "label1";
            label1.Size = new Size(324, 28);
            label1.TabIndex = 1;
            label1.Text = "Que tipo de servicio desea agregar?";
            label1.Click += label1_Click;
            // 
            // btnMedicamento
            // 
            btnMedicamento.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnMedicamento.Location = new Point(162, 123);
            btnMedicamento.Name = "btnMedicamento";
            btnMedicamento.Size = new Size(463, 63);
            btnMedicamento.TabIndex = 2;
            btnMedicamento.Text = "Medicamento";
            btnMedicamento.UseVisualStyleBackColor = true;
            btnMedicamento.Click += btnMedicamento_Click;
            // 
            // btnLaboratorio
            // 
            btnLaboratorio.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnLaboratorio.Location = new Point(162, 203);
            btnLaboratorio.Name = "btnLaboratorio";
            btnLaboratorio.Size = new Size(463, 63);
            btnLaboratorio.TabIndex = 3;
            btnLaboratorio.Text = "Laboratorio";
            btnLaboratorio.UseVisualStyleBackColor = true;
            // 
            // btnInternacion
            // 
            btnInternacion.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnInternacion.Location = new Point(162, 291);
            btnInternacion.Name = "btnInternacion";
            btnInternacion.Size = new Size(463, 63);
            btnInternacion.TabIndex = 4;
            btnInternacion.Text = "Internacion";
            btnInternacion.UseVisualStyleBackColor = true;
            // 
            // ServiceAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnInternacion);
            Controls.Add(btnLaboratorio);
            Controls.Add(btnMedicamento);
            Controls.Add(label1);
            Name = "ServiceAdd";
            Text = "ServiceAdd";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnMedicamento;
        private Button btnLaboratorio;
        private Button btnInternacion;
    }
}