namespace AppMascotasUI
{
    partial class FrmAgregarMascotas
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
            gBoxMascotas = new GroupBox();
            btnAgregar = new Button();
            rButtonGato = new RadioButton();
            rButtonLoro = new RadioButton();
            rButtonPerro = new RadioButton();
            lblMascotas = new Label();
            gBoxMascotas.SuspendLayout();
            SuspendLayout();
            // 
            // gBoxMascotas
            // 
            gBoxMascotas.Controls.Add(btnAgregar);
            gBoxMascotas.Controls.Add(rButtonGato);
            gBoxMascotas.Controls.Add(rButtonLoro);
            gBoxMascotas.Controls.Add(rButtonPerro);
            gBoxMascotas.Controls.Add(lblMascotas);
            gBoxMascotas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gBoxMascotas.Location = new Point(12, 12);
            gBoxMascotas.Name = "gBoxMascotas";
            gBoxMascotas.Size = new Size(552, 426);
            gBoxMascotas.TabIndex = 4;
            gBoxMascotas.TabStop = false;
            gBoxMascotas.Text = "Mascotas";
            gBoxMascotas.Enter += gBoxMascotas_Enter;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(204, 329);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // rButtonGato
            // 
            rButtonGato.AutoSize = true;
            rButtonGato.Location = new Point(52, 193);
            rButtonGato.Name = "rButtonGato";
            rButtonGato.Size = new Size(64, 24);
            rButtonGato.TabIndex = 6;
            rButtonGato.TabStop = true;
            rButtonGato.Text = "Gato";
            rButtonGato.UseVisualStyleBackColor = true;
            // 
            // rButtonLoro
            // 
            rButtonLoro.AutoSize = true;
            rButtonLoro.Location = new Point(52, 236);
            rButtonLoro.Name = "rButtonLoro";
            rButtonLoro.Size = new Size(62, 24);
            rButtonLoro.TabIndex = 5;
            rButtonLoro.TabStop = true;
            rButtonLoro.Text = "Loro";
            rButtonLoro.UseVisualStyleBackColor = true;
            // 
            // rButtonPerro
            // 
            rButtonPerro.AutoSize = true;
            rButtonPerro.Location = new Point(52, 147);
            rButtonPerro.Name = "rButtonPerro";
            rButtonPerro.Size = new Size(68, 24);
            rButtonPerro.TabIndex = 4;
            rButtonPerro.TabStop = true;
            rButtonPerro.Text = "Perro";
            rButtonPerro.UseVisualStyleBackColor = true;
            // 
            // lblMascotas
            // 
            lblMascotas.AutoSize = true;
            lblMascotas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblMascotas.Location = new Point(157, 40);
            lblMascotas.Name = "lblMascotas";
            lblMascotas.Size = new Size(207, 28);
            lblMascotas.TabIndex = 0;
            lblMascotas.Text = "¿Que desea agregar?";
            // 
            // FrmAgregarMascotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 450);
            Controls.Add(gBoxMascotas);
            Name = "FrmAgregarMascotas";
            Text = "Mascotas";
            gBoxMascotas.ResumeLayout(false);
            gBoxMascotas.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBoxMascotas;
        private RadioButton rButtonGato;
        private RadioButton rButtonLoro;
        private RadioButton rButtonPerro;
        private Label lblMascotas;
        private Button btnAgregar;
    }
}