using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMascotasUI
{
    /// <summary>
    /// Clase frmUsuarios
    /// </summary>
    public partial class FrmUsuarios : Form
    {
        private string[] usuarios;
        private string totalUsuarios;
        private List<string> listaUsuarios;
        public FrmUsuarios()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Tiene un constructor que recibe un string con todos los datos de los usuarios registrados
        /// Inicializa la lista
        /// </summary>
        /// <param name="archivo"></param>
        public FrmUsuarios(string archivo) : this()
        {
            this.totalUsuarios = archivo;
            this.listaUsuarios = new List<string>();
        }

        /// <summary>
        /// A la matriz usuarios le asigna el valor de totalUsuarios y usa el metodo Split, para separar
        /// los distintos usuarios por las comas(,) del archivo
        /// A la lista de usuarios le asigna el valor de usuarios usando el metodo,ToList()
        /// </summary>
        public void Listar()
        {
            this.usuarios = totalUsuarios.Split(',');
            this.listaUsuarios = usuarios.ToList();
        }
        /// <summary>
        /// LLama al metodo Listar
        /// Recorre la lista de usuarios y los agrega en la listBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            Listar();
            foreach(string usuarios in this.listaUsuarios)
            {
                lstUsuarios.Items.Add(usuarios);
            }
        }
    }
}
