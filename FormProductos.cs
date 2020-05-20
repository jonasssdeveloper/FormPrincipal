using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace FormPrincipal
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            MostrarColor();
            MostrarTalla();
        }
        private void MostrarColor()
        {
            CD_Productos objColor = new CD_Productos();
            CmbColor.DataSource = objColor.MostrarColor();
            CmbColor.DisplayMember = "Tipo_color";
            CmbColor.ValueMember = "Id_color";
        }
        private void MostrarTalla()
        {
            CD_Productos objTalla = new CD_Productos();
            CmbTalla.DataSource = objTalla.MostrarTalla();
            CmbTalla.DisplayMember = "Num_Talla";
            CmbTalla.ValueMember = "Id_talla";
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form Formulario = new FormProdDescripcion();
            Formulario.Show();
        }
    }
}
