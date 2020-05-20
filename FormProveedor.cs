using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPrincipal
{
    public partial class FormProveedor : Form
    {
        public FormProveedor()
        {
            InitializeComponent();
        }

        private void txtRazonSocial_Enter(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "Razon Social:")
            {
                txtRazonSocial.Text = "";
                txtRazonSocial.ForeColor = Color.DimGray;
            }

        }

        private void txtRazonSocial_Leave(object sender, EventArgs e)
        {
            if (txtRazonSocial.Text == "")
            {
                txtRazonSocial.Text = "Razon Social:";
                txtRazonSocial.ForeColor = Color.Black;
            }

        }

        private void txtCI_Enter(object sender, EventArgs e)
        {
            if (txtCI.Text == "CI:")
            {
                txtCI.Text = "";
                txtCI.ForeColor = Color.DimGray;
            }
        }

        private void txtCI_Leave(object sender, EventArgs e)
        {
            if(txtCI.Text == "")
            {
                txtCI.Text = "CI:";
                txtCI.ForeColor = Color.Black;
            }

        }

        private void txtDirección_Enter(object sender, EventArgs e)
        {
            if(txtDirección.Text == "Dirección:")
            {
                txtDirección.Text = "";
                txtDirección.ForeColor = Color.DimGray;
            }
        }

        private void txtDirección_Leave(object sender, EventArgs e)
        {
            if (txtDirección.Text == "")
            {
                txtDirección.Text = "Dirección:";
                txtDirección.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email:")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.DimGray;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {

            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email:";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Telefono o Celular:")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.DimGray;
            }
        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Telefono o Celular:";
                txtTelefono.ForeColor = Color.Black;
            }
        }
    }
}
