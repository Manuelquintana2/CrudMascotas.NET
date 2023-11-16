namespace AppMascotasUI
{
    partial class FrmEliminar
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
            txtNombre = new TextBox();
            label2 = new Label();
            numEdad = new NumericUpDown();
            label3 = new Label();
            numPeso = new NumericUpDown();
            label4 = new Label();
            numPatas = new NumericUpDown();
            btnEliminar = new Button();
            btnCancelar = new Button();
            numId = new NumericUpDown();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numId).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(334, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(249, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(242, 27);
            txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(343, 70);
            label2.Name = "label2";
            label2.Size = new Size(58, 28);
            label2.TabIndex = 4;
            label2.Text = "Edad";
            // 
            // numEdad
            // 
            numEdad.Location = new Point(249, 101);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(242, 27);
            numEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(346, 131);
            label3.Name = "label3";
            label3.Size = new Size(55, 28);
            label3.TabIndex = 6;
            label3.Text = "Peso";
            // 
            // numPeso
            // 
            numPeso.Location = new Point(249, 162);
            numPeso.Name = "numPeso";
            numPeso.Size = new Size(242, 27);
            numPeso.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(302, 192);
            label4.Name = "label4";
            label4.Size = new Size(145, 28);
            label4.TabIndex = 8;
            label4.Text = "Total de patas";
            // 
            // numPatas
            // 
            numPatas.Location = new Point(249, 223);
            numPatas.Name = "numPatas";
            numPatas.Size = new Size(242, 27);
            numPatas.TabIndex = 9;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(249, 383);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(96, 55);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(395, 383);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 55);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // numId
            // 
            numId.Location = new Point(532, 162);
            numId.Name = "numId";
            numId.Size = new Size(242, 27);
            numId.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(584, 131);
            label5.Name = "label5";
            label5.Size = new Size(131, 28);
            label5.TabIndex = 18;
            label5.Text = "Id a eliminar";
            // 
            // FrmEliminar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(numId);
            Controls.Add(btnCancelar);
            Controls.Add(btnEliminar);
            Controls.Add(numPatas);
            Controls.Add(label4);
            Controls.Add(numPeso);
            Controls.Add(label3);
            Controls.Add(numEdad);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "FrmEliminar";
            Text = "FrmEliminar";
            Load += FrmEliminar_Load;
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        protected TextBox txtNombre;
        private Label label2;
        protected NumericUpDown numEdad;
        private Label label3;
        protected NumericUpDown numPeso;
        private Label label4;
        protected NumericUpDown numPatas;
        protected Button btnEliminar;
        protected Button btnCancelar;
        protected NumericUpDown numId;
        private Label label5;
    }
}