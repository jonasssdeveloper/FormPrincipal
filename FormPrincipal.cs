using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace FormPrincipal
{
    public partial class FormPrincipal : Form
    {    
        //Campos
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentFormHijo;
        //constructor
        public FormPrincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            BuPanelMenu.Controls.Add(leftBorderBtn);
            //Formulario
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        //estrucutra colores rgb
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        //metodos
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icono Actual Formualrio Hijo
                IconCurrentFormHijo.IconChar = currentBtn.IconChar;
                IconCurrentFormHijo.IconColor = color;

            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenFormHijo(Form FormHijo)
        {
            if(currentFormHijo != null)
            {
                //Abrir Solo Formulario
                currentFormHijo.Close();
            }
            currentFormHijo = FormHijo;
            FormHijo.TopLevel = false;
            FormHijo.FormBorderStyle = FormBorderStyle.None;
            FormHijo.Dock = DockStyle.Fill;
            PanelEscritorio.Controls.Add(FormHijo);
            PanelEscritorio.Tag = FormHijo;
            FormHijo.BringToFront();
            FormHijo.Show();
            LblTituloFormHijo.Text = FormHijo.Text;
        }


        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenFormHijo(new FormUsuarios());
        }

        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenFormHijo(new FormProveedor());
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenFormHijo(new FormCompras());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenFormHijo(new FormProductos());
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            OpenFormHijo(new FormClientes());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            OpenFormHijo(new FormVentas());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            OpenFormHijo(new FormReportes());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Application.Exit();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            currentFormHijo.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            IconCurrentFormHijo.IconChar = IconChar.Home;
            IconCurrentFormHijo.IconColor = Color.MediumPurple;
            LblTituloFormHijo.Text = "Inicio";

        }
        //arrastrar formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        int lx, ly;
        int sw, sh;
        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {

            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
        }

        private void PanelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        

       
    }
}
