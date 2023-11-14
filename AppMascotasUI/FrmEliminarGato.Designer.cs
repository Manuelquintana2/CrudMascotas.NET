namespace AppMascotasUI
{
    partial class FrmEliminarGato
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
            label5 = new Label();
            numReaccion = new NumericUpDown();
            label6 = new Label();
            numSalto = new NumericUpDown();
            gBoxRaza = new GroupBox();
            rBtnBambino = new RadioButton();
            rBtnBritanico = new RadioButton();
            rBtnPersa = new RadioButton();
            rBtnSiames = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReaccion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSalto).BeginInit();
            gBoxRaza.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(249, 253);
            label5.Name = "label5";
            label5.Size = new Size(303, 28);
            label5.TabIndex = 17;
            label5.Text = "Tiempo de reaccion(Segundos)";
            // 
            // numReaccion
            // 
            numReaccion.Location = new Point(249, 284);
            numReaccion.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numReaccion.Name = "numReaccion";
            numReaccion.Size = new Size(242, 27);
            numReaccion.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(287, 314);
            label6.Name = "label6";
            label6.Size = new Size(160, 28);
            label6.TabIndex = 19;
            label6.Text = "Metros de salto";
            // 
            // numSalto
            // 
            numSalto.Location = new Point(249, 345);
            numSalto.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numSalto.Name = "numSalto";
            numSalto.Size = new Size(242, 27);
            numSalto.TabIndex = 20;
            // 
            // gBoxRaza
            // 
            gBoxRaza.Controls.Add(rBtnBambino);
            gBoxRaza.Controls.Add(rBtnBritanico);
            gBoxRaza.Controls.Add(rBtnPersa);
            gBoxRaza.Controls.Add(rBtnSiames);
            gBoxRaza.Location = new Point(3, 40);
            gBoxRaza.Name = "gBoxRaza";
            gBoxRaza.Size = new Size(240, 320);
            gBoxRaza.TabIndex = 21;
            gBoxRaza.TabStop = false;
            gBoxRaza.Text = "Raza";
            // 
            // rBtnBambino
            // 
            rBtnBambino.AutoSize = true;
            rBtnBambino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnBambino.Location = new Point(7, 235);
            rBtnBambino.Name = "rBtnBambino";
            rBtnBambino.Size = new Size(93, 24);
            rBtnBambino.TabIndex = 3;
            rBtnBambino.TabStop = true;
            rBtnBambino.Text = "Bambino";
            rBtnBambino.UseVisualStyleBackColor = true;
            // 
            // rBtnBritanico
            // 
            rBtnBritanico.AutoSize = true;
            rBtnBritanico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnBritanico.Location = new Point(7, 174);
            rBtnBritanico.Name = "rBtnBritanico";
            rBtnBritanico.Size = new Size(93, 24);
            rBtnBritanico.TabIndex = 2;
            rBtnBritanico.TabStop = true;
            rBtnBritanico.Text = "Britanico";
            rBtnBritanico.UseVisualStyleBackColor = true;
            // 
            // rBtnPersa
            // 
            rBtnPersa.AutoSize = true;
            rBtnPersa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnPersa.Location = new Point(7, 113);
            rBtnPersa.Name = "rBtnPersa";
            rBtnPersa.Size = new Size(68, 24);
            rBtnPersa.TabIndex = 1;
            rBtnPersa.TabStop = true;
            rBtnPersa.Text = "Persa";
            rBtnPersa.UseVisualStyleBackColor = true;
            // 
            // rBtnSiames
            // 
            rBtnSiames.AutoSize = true;
            rBtnSiames.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rBtnSiames.Location = new Point(7, 52);
            rBtnSiames.Name = "rBtnSiames";
            rBtnSiames.Size = new Size(79, 24);
            rBtnSiames.TabIndex = 0;
            rBtnSiames.TabStop = true;
            rBtnSiames.Text = "Siames";
            rBtnSiames.UseVisualStyleBackColor = true;
            // 
            // FrmEliminarGato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gBoxRaza);
            Controls.Add(numSalto);
            Controls.Add(label6);
            Controls.Add(numReaccion);
            Controls.Add(label5);
            Name = "FrmEliminarGato";
            Text = "FrmEliminarGato";
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(numEdad, 0);
            Controls.SetChildIndex(numPeso, 0);
            Controls.SetChildIndex(numPatas, 0);
            Controls.SetChildIndex(btnEliminar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(numReaccion, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(numSalto, 0);
            Controls.SetChildIndex(gBoxRaza, 0);
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReaccion).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSalto).EndInit();
            gBoxRaza.ResumeLayout(false);
            gBoxRaza.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private NumericUpDown numReaccion;
        private Label label6;
        private NumericUpDown numSalto;
        private GroupBox gBoxRaza;
        private RadioButton rBtnBambino;
        private RadioButton rBtnBritanico;
        private RadioButton rBtnPersa;
        private RadioButton rBtnSiames;
    }
}