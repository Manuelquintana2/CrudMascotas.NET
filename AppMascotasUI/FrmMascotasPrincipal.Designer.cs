namespace AppMascotasUI
{
    partial class FrmMascotasPrincipal
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
            lstMascotas = new ListBox();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lblUsuario = new Label();
            lblArchivo = new Label();
            btnUsuarios = new Button();
            gBoxOrden = new GroupBox();
            btnOrdenar = new Button();
            rBtnDescendentePeso = new RadioButton();
            rBtnAscendentePeso = new RadioButton();
            label2 = new Label();
            rBtnDescendenteEdad = new RadioButton();
            rBtnAscendenteEdad = new RadioButton();
            label1 = new Label();
            btnGuardar = new Button();
            btnObtenerDatos = new Button();
            btnSonido = new Button();
            btnEmitirSonido = new Button();
            gBoxOrden.SuspendLayout();
            SuspendLayout();
            // 
            // lstMascotas
            // 
            lstMascotas.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lstMascotas.FormattingEnabled = true;
            lstMascotas.ItemHeight = 17;
            lstMascotas.Location = new Point(12, 12);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(785, 293);
            lstMascotas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 347);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(130, 62);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(335, 347);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(130, 62);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(667, 347);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(130, 62);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsuario.Location = new Point(803, 18);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(182, 28);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuario Logueado";
            // 
            // lblArchivo
            // 
            lblArchivo.AutoSize = true;
            lblArchivo.Location = new Point(803, 65);
            lblArchivo.Name = "lblArchivo";
            lblArchivo.Size = new Size(0, 20);
            lblArchivo.TabIndex = 6;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(852, 347);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(130, 62);
            btnUsuarios.TabIndex = 7;
            btnUsuarios.Text = "Listar Usuarios anteriores";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // gBoxOrden
            // 
            gBoxOrden.Controls.Add(btnOrdenar);
            gBoxOrden.Controls.Add(rBtnDescendentePeso);
            gBoxOrden.Controls.Add(rBtnAscendentePeso);
            gBoxOrden.Controls.Add(label2);
            gBoxOrden.Controls.Add(rBtnDescendenteEdad);
            gBoxOrden.Controls.Add(rBtnAscendenteEdad);
            gBoxOrden.Controls.Add(label1);
            gBoxOrden.Location = new Point(802, 172);
            gBoxOrden.Name = "gBoxOrden";
            gBoxOrden.Size = new Size(283, 169);
            gBoxOrden.TabIndex = 8;
            gBoxOrden.TabStop = false;
            gBoxOrden.Text = "Ordenamiento";
            // 
            // btnOrdenar
            // 
            btnOrdenar.Location = new Point(94, 79);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(94, 29);
            btnOrdenar.TabIndex = 15;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // rBtnDescendentePeso
            // 
            rBtnDescendentePeso.AutoSize = true;
            rBtnDescendentePeso.Location = new Point(161, 142);
            rBtnDescendentePeso.Name = "rBtnDescendentePeso";
            rBtnDescendentePeso.Size = new Size(116, 24);
            rBtnDescendentePeso.TabIndex = 14;
            rBtnDescendentePeso.TabStop = true;
            rBtnDescendentePeso.Text = "Descendente";
            rBtnDescendentePeso.UseVisualStyleBackColor = true;
            // 
            // rBtnAscendentePeso
            // 
            rBtnAscendentePeso.AutoSize = true;
            rBtnAscendentePeso.Location = new Point(6, 142);
            rBtnAscendentePeso.Name = "rBtnAscendentePeso";
            rBtnAscendentePeso.Size = new Size(107, 24);
            rBtnAscendentePeso.TabIndex = 13;
            rBtnAscendentePeso.TabStop = true;
            rBtnAscendentePeso.Text = "Ascendente";
            rBtnAscendentePeso.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(102, 119);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 12;
            label2.Text = "Por peso";
            // 
            // rBtnDescendenteEdad
            // 
            rBtnDescendenteEdad.AutoSize = true;
            rBtnDescendenteEdad.Location = new Point(161, 46);
            rBtnDescendenteEdad.Name = "rBtnDescendenteEdad";
            rBtnDescendenteEdad.Size = new Size(116, 24);
            rBtnDescendenteEdad.TabIndex = 11;
            rBtnDescendenteEdad.TabStop = true;
            rBtnDescendenteEdad.Text = "Descendente";
            rBtnDescendenteEdad.UseVisualStyleBackColor = true;
            // 
            // rBtnAscendenteEdad
            // 
            rBtnAscendenteEdad.AutoSize = true;
            rBtnAscendenteEdad.Location = new Point(6, 46);
            rBtnAscendenteEdad.Name = "rBtnAscendenteEdad";
            rBtnAscendenteEdad.Size = new Size(107, 24);
            rBtnAscendenteEdad.TabIndex = 10;
            rBtnAscendenteEdad.TabStop = true;
            rBtnAscendenteEdad.Text = "Ascendente";
            rBtnAscendenteEdad.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 23);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 9;
            label1.Text = "Por edad";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(991, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Location = new Point(991, 47);
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(94, 51);
            btnObtenerDatos.TabIndex = 10;
            btnObtenerDatos.Text = "Obtener datos";
            btnObtenerDatos.UseVisualStyleBackColor = true;
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            // 
            // btnSonido
            // 
            btnSonido.Location = new Point(952, 104);
            btnSonido.Name = "btnSonido";
            btnSonido.Size = new Size(158, 62);
            btnSonido.TabIndex = 11;
            btnSonido.Text = "Mascota tipo(Seleccione una)";
            btnSonido.UseVisualStyleBackColor = true;
            btnSonido.Click += btnSonido_Click;
            // 
            // btnEmitirSonido
            // 
            btnEmitirSonido.Location = new Point(991, 347);
            btnEmitirSonido.Name = "btnEmitirSonido";
            btnEmitirSonido.Size = new Size(105, 62);
            btnEmitirSonido.TabIndex = 12;
            btnEmitirSonido.Text = "Emitir Sonido";
            btnEmitirSonido.UseVisualStyleBackColor = true;
            btnEmitirSonido.Click += btnEmitirSonido_Click;
            // 
            // FrmMascotasPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1122, 434);
            Controls.Add(btnEmitirSonido);
            Controls.Add(btnSonido);
            Controls.Add(btnObtenerDatos);
            Controls.Add(btnGuardar);
            Controls.Add(gBoxOrden);
            Controls.Add(btnUsuarios);
            Controls.Add(lblArchivo);
            Controls.Add(lblUsuario);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(lstMascotas);
            Name = "FrmMascotasPrincipal";
            Text = "FrmMascotasPrincipal";
            FormClosing += FrmMascotasPrincipal_FormClosing;
            Load += FrmMascotasPrincipal_Load;
            gBoxOrden.ResumeLayout(false);
            gBoxOrden.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMascotas;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Label lblUsuario;
        private Label lblArchivo;
        private Button btnUsuarios;
        private GroupBox gBoxOrden;
        private Button btnOrdenar;
        private RadioButton rBtnDescendentePeso;
        private RadioButton rBtnAscendentePeso;
        private Label label2;
        private RadioButton rBtnDescendenteEdad;
        private RadioButton rBtnAscendenteEdad;
        private Label label1;
        private Button btnGuardar;
        private Button btnObtenerDatos;
        private Button btnSonido;
        private Button btnEmitirSonido;
    }
}