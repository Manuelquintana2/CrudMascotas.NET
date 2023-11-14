﻿namespace AppMascotasUI
{
    partial class FrmEliminarLoro
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
            numTiempoVuelo = new NumericUpDown();
            label6 = new Label();
            numAltura = new NumericUpDown();
            label8 = new Label();
            txtRepite = new TextBox();
            label7 = new Label();
            txtFrase = new TextBox();
            gBoxTipo = new GroupBox();
            rBtnEclecto = new RadioButton();
            rBtnAmazonico = new RadioButton();
            rBtnGuacamayo = new RadioButton();
            rBtnAfricano = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTiempoVuelo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).BeginInit();
            gBoxTipo.SuspendLayout();
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
            label5.Location = new Point(235, 253);
            label5.Name = "label5";
            label5.Size = new Size(267, 28);
            label5.TabIndex = 17;
            label5.Text = "Tiempo de vuelo(Semanas)";
            // 
            // numTiempoVuelo
            // 
            numTiempoVuelo.Location = new Point(249, 284);
            numTiempoVuelo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numTiempoVuelo.Name = "numTiempoVuelo";
            numTiempoVuelo.Size = new Size(242, 27);
            numTiempoVuelo.TabIndex = 18;
            numTiempoVuelo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(235, 314);
            label6.Name = "label6";
            label6.Size = new Size(267, 28);
            label6.TabIndex = 19;
            label6.Text = "Altura de vuelo(En metros)";
            // 
            // numAltura
            // 
            numAltura.Location = new Point(249, 345);
            numAltura.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            numAltura.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAltura.Name = "numAltura";
            numAltura.Size = new Size(242, 27);
            numAltura.TabIndex = 20;
            numAltura.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(532, 9);
            label8.Name = "label8";
            label8.Size = new Size(233, 28);
            label8.TabIndex = 21;
            label8.Text = "¿Repite palabras? Si/no";
            // 
            // txtRepite
            // 
            txtRepite.Location = new Point(532, 40);
            txtRepite.Name = "txtRepite";
            txtRepite.Size = new Size(242, 27);
            txtRepite.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(584, 70);
            label7.Name = "label7";
            label7.Size = new Size(148, 28);
            label7.TabIndex = 23;
            label7.Text = "Frase a repetir";
            // 
            // txtFrase
            // 
            txtFrase.Location = new Point(532, 100);
            txtFrase.Name = "txtFrase";
            txtFrase.Size = new Size(242, 27);
            txtFrase.TabIndex = 24;
            // 
            // gBoxTipo
            // 
            gBoxTipo.Controls.Add(rBtnEclecto);
            gBoxTipo.Controls.Add(rBtnAmazonico);
            gBoxTipo.Controls.Add(rBtnGuacamayo);
            gBoxTipo.Controls.Add(rBtnAfricano);
            gBoxTipo.Location = new Point(12, 40);
            gBoxTipo.Name = "gBoxTipo";
            gBoxTipo.Size = new Size(173, 307);
            gBoxTipo.TabIndex = 25;
            gBoxTipo.TabStop = false;
            gBoxTipo.Text = "Tipo";
            // 
            // rBtnEclecto
            // 
            rBtnEclecto.AutoSize = true;
            rBtnEclecto.Location = new Point(6, 247);
            rBtnEclecto.Name = "rBtnEclecto";
            rBtnEclecto.Size = new Size(78, 24);
            rBtnEclecto.TabIndex = 3;
            rBtnEclecto.TabStop = true;
            rBtnEclecto.Text = "Eclecto";
            rBtnEclecto.UseVisualStyleBackColor = true;
            // 
            // rBtnAmazonico
            // 
            rBtnAmazonico.AutoSize = true;
            rBtnAmazonico.Location = new Point(6, 186);
            rBtnAmazonico.Name = "rBtnAmazonico";
            rBtnAmazonico.Size = new Size(105, 24);
            rBtnAmazonico.TabIndex = 2;
            rBtnAmazonico.TabStop = true;
            rBtnAmazonico.Text = "Amazonico";
            rBtnAmazonico.UseVisualStyleBackColor = true;
            // 
            // rBtnGuacamayo
            // 
            rBtnGuacamayo.AutoSize = true;
            rBtnGuacamayo.Location = new Point(6, 120);
            rBtnGuacamayo.Name = "rBtnGuacamayo";
            rBtnGuacamayo.Size = new Size(108, 24);
            rBtnGuacamayo.TabIndex = 1;
            rBtnGuacamayo.TabStop = true;
            rBtnGuacamayo.Text = "Guacamayo";
            rBtnGuacamayo.UseVisualStyleBackColor = true;
            // 
            // rBtnAfricano
            // 
            rBtnAfricano.AutoSize = true;
            rBtnAfricano.Location = new Point(6, 64);
            rBtnAfricano.Name = "rBtnAfricano";
            rBtnAfricano.Size = new Size(86, 24);
            rBtnAfricano.TabIndex = 0;
            rBtnAfricano.TabStop = true;
            rBtnAfricano.Text = "Africano";
            rBtnAfricano.UseVisualStyleBackColor = true;
            // 
            // FrmEliminarLoro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gBoxTipo);
            Controls.Add(txtFrase);
            Controls.Add(label7);
            Controls.Add(txtRepite);
            Controls.Add(label8);
            Controls.Add(numAltura);
            Controls.Add(label6);
            Controls.Add(numTiempoVuelo);
            Controls.Add(label5);
            Name = "FrmEliminarLoro";
            Text = "FrmEliminarLoro";
            Controls.SetChildIndex(txtNombre, 0);
            Controls.SetChildIndex(numEdad, 0);
            Controls.SetChildIndex(numPeso, 0);
            Controls.SetChildIndex(numPatas, 0);
            Controls.SetChildIndex(btnEliminar, 0);
            Controls.SetChildIndex(btnCancelar, 0);
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(numTiempoVuelo, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(numAltura, 0);
            Controls.SetChildIndex(label8, 0);
            Controls.SetChildIndex(txtRepite, 0);
            Controls.SetChildIndex(label7, 0);
            Controls.SetChildIndex(txtFrase, 0);
            Controls.SetChildIndex(gBoxTipo, 0);
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPeso).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPatas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTiempoVuelo).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAltura).EndInit();
            gBoxTipo.ResumeLayout(false);
            gBoxTipo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private NumericUpDown numTiempoVuelo;
        private Label label6;
        private NumericUpDown numAltura;
        private Label label8;
        private TextBox txtRepite;
        private Label label7;
        private TextBox txtFrase;
        private GroupBox gBoxTipo;
        private RadioButton rBtnEclecto;
        private RadioButton rBtnAmazonico;
        private RadioButton rBtnGuacamayo;
        private RadioButton rBtnAfricano;
    }
}