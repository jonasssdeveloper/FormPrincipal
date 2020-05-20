namespace FormPrincipal
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.PanelEscritorio = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PanelBarraTitulo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnMaximizar = new System.Windows.Forms.PictureBox();
            this.BtnRestaurar = new System.Windows.Forms.PictureBox();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.LblTituloFormHijo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.IconCurrentFormHijo = new FontAwesome.Sharp.IconPictureBox();
            this.BuPanelMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnSalir = new FontAwesome.Sharp.IconButton();
            this.BtnReportes = new FontAwesome.Sharp.IconButton();
            this.BtnVentas = new FontAwesome.Sharp.IconButton();
            this.BtnClientes = new FontAwesome.Sharp.IconButton();
            this.BtnProductos = new FontAwesome.Sharp.IconButton();
            this.BtnCompras = new FontAwesome.Sharp.IconButton();
            this.BtnProveedor = new FontAwesome.Sharp.IconButton();
            this.BtnUsuarios = new FontAwesome.Sharp.IconButton();
            this.BuPanelLogo = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnInicio = new System.Windows.Forms.PictureBox();
            this.PanelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentFormHijo)).BeginInit();
            this.BuPanelMenu.SuspendLayout();
            this.BuPanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEscritorio
            // 
            this.PanelEscritorio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelEscritorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelEscritorio.BackgroundImage")));
            this.PanelEscritorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEscritorio.GradientBottomLeft = System.Drawing.Color.White;
            this.PanelEscritorio.GradientBottomRight = System.Drawing.Color.White;
            this.PanelEscritorio.GradientTopLeft = System.Drawing.Color.White;
            this.PanelEscritorio.GradientTopRight = System.Drawing.Color.White;
            this.PanelEscritorio.Location = new System.Drawing.Point(220, 48);
            this.PanelEscritorio.Name = "PanelEscritorio";
            this.PanelEscritorio.Quality = 10;
            this.PanelEscritorio.Size = new System.Drawing.Size(660, 573);
            this.PanelEscritorio.TabIndex = 2;
            // 
            // PanelBarraTitulo
            // 
            this.PanelBarraTitulo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelBarraTitulo.BackgroundImage")));
            this.PanelBarraTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelBarraTitulo.Controls.Add(this.BtnMaximizar);
            this.PanelBarraTitulo.Controls.Add(this.BtnRestaurar);
            this.PanelBarraTitulo.Controls.Add(this.BtnMinimizar);
            this.PanelBarraTitulo.Controls.Add(this.BtnCerrar);
            this.PanelBarraTitulo.Controls.Add(this.LblTituloFormHijo);
            this.PanelBarraTitulo.Controls.Add(this.IconCurrentFormHijo);
            this.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelBarraTitulo.GradientBottomLeft = System.Drawing.Color.White;
            this.PanelBarraTitulo.GradientBottomRight = System.Drawing.Color.White;
            this.PanelBarraTitulo.GradientTopLeft = System.Drawing.Color.White;
            this.PanelBarraTitulo.GradientTopRight = System.Drawing.Color.White;
            this.PanelBarraTitulo.Location = new System.Drawing.Point(220, 0);
            this.PanelBarraTitulo.Name = "PanelBarraTitulo";
            this.PanelBarraTitulo.Quality = 10;
            this.PanelBarraTitulo.Size = new System.Drawing.Size(660, 48);
            this.PanelBarraTitulo.TabIndex = 1;
            this.PanelBarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBarraTitulo_Paint);
            this.PanelBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelBarraTitulo_MouseDown);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Image = global::FormPrincipal.Properties.Resources.maxi;
            this.BtnMaximizar.Location = new System.Drawing.Point(619, 3);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(16, 17);
            this.BtnMaximizar.TabIndex = 5;
            this.BtnMaximizar.TabStop = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Image = global::FormPrincipal.Properties.Resources.arrows__1_;
            this.BtnRestaurar.Location = new System.Drawing.Point(619, 3);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(16, 17);
            this.BtnRestaurar.TabIndex = 4;
            this.BtnRestaurar.TabStop = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Image = global::FormPrincipal.Properties.Resources.inside;
            this.BtnMinimizar.Location = new System.Drawing.Point(597, 3);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(16, 17);
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.Image = global::FormPrincipal.Properties.Resources.shapes_and_symbols;
            this.BtnCerrar.Location = new System.Drawing.Point(641, 3);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(16, 17);
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblTituloFormHijo
            // 
            this.LblTituloFormHijo.AutoSize = true;
            this.LblTituloFormHijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.LblTituloFormHijo.Location = new System.Drawing.Point(41, 22);
            this.LblTituloFormHijo.Name = "LblTituloFormHijo";
            this.LblTituloFormHijo.Size = new System.Drawing.Size(32, 13);
            this.LblTituloFormHijo.TabIndex = 1;
            this.LblTituloFormHijo.Text = "Inicio";
            // 
            // IconCurrentFormHijo
            // 
            this.IconCurrentFormHijo.BackColor = System.Drawing.SystemColors.Control;
            this.IconCurrentFormHijo.ForeColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentFormHijo.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentFormHijo.IconColor = System.Drawing.Color.MediumPurple;
            this.IconCurrentFormHijo.Location = new System.Drawing.Point(6, 9);
            this.IconCurrentFormHijo.Name = "IconCurrentFormHijo";
            this.IconCurrentFormHijo.Size = new System.Drawing.Size(32, 32);
            this.IconCurrentFormHijo.TabIndex = 0;
            this.IconCurrentFormHijo.TabStop = false;
            // 
            // BuPanelMenu
            // 
            this.BuPanelMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuPanelMenu.BackgroundImage")));
            this.BuPanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuPanelMenu.Controls.Add(this.BtnSalir);
            this.BuPanelMenu.Controls.Add(this.BtnReportes);
            this.BuPanelMenu.Controls.Add(this.BtnVentas);
            this.BuPanelMenu.Controls.Add(this.BtnClientes);
            this.BuPanelMenu.Controls.Add(this.BtnProductos);
            this.BuPanelMenu.Controls.Add(this.BtnCompras);
            this.BuPanelMenu.Controls.Add(this.BtnProveedor);
            this.BuPanelMenu.Controls.Add(this.BtnUsuarios);
            this.BuPanelMenu.Controls.Add(this.BuPanelLogo);
            this.BuPanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.BuPanelMenu.GradientBottomLeft = System.Drawing.Color.Red;
            this.BuPanelMenu.GradientBottomRight = System.Drawing.Color.Maroon;
            this.BuPanelMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BuPanelMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BuPanelMenu.Location = new System.Drawing.Point(0, 0);
            this.BuPanelMenu.Name = "BuPanelMenu";
            this.BuPanelMenu.Quality = 10;
            this.BuPanelMenu.Size = new System.Drawing.Size(220, 621);
            this.BuPanelMenu.TabIndex = 0;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnSalir.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.BtnSalir.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnSalir.IconSize = 32;
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(0, 560);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnSalir.Rotation = 0D;
            this.BtnSalir.Size = new System.Drawing.Size(220, 60);
            this.BtnSalir.TabIndex = 8;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnReportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnReportes.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.BtnReportes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnReportes.IconSize = 32;
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(0, 500);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnReportes.Rotation = 0D;
            this.BtnReportes.Size = new System.Drawing.Size(220, 60);
            this.BtnReportes.TabIndex = 7;
            this.BtnReportes.Text = "REPORTES";
            this.BtnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReportes.UseVisualStyleBackColor = true;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnVentas
            // 
            this.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnVentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnVentas.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            this.BtnVentas.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnVentas.IconSize = 32;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(0, 440);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnVentas.Rotation = 0D;
            this.BtnVentas.Size = new System.Drawing.Size(220, 60);
            this.BtnVentas.TabIndex = 6;
            this.BtnVentas.Text = "VENTAS";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnVentas.UseVisualStyleBackColor = true;
            this.BtnVentas.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnClientes.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnClientes.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnClientes.IconSize = 32;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 380);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnClientes.Rotation = 0D;
            this.BtnClientes.Size = new System.Drawing.Size(220, 60);
            this.BtnClientes.TabIndex = 5;
            this.BtnClientes.Text = "CLIENTES";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // BtnProductos
            // 
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnProductos.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnProductos.IconChar = FontAwesome.Sharp.IconChar.ShoePrints;
            this.BtnProductos.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnProductos.IconSize = 32;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(0, 320);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnProductos.Rotation = 0D;
            this.BtnProductos.Size = new System.Drawing.Size(220, 60);
            this.BtnProductos.TabIndex = 4;
            this.BtnProductos.Text = "PRODUCTOS";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnCompras
            // 
            this.BtnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompras.FlatAppearance.BorderSize = 0;
            this.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCompras.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnCompras.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnCompras.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.BtnCompras.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnCompras.IconSize = 32;
            this.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.Location = new System.Drawing.Point(0, 260);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnCompras.Rotation = 0D;
            this.BtnCompras.Size = new System.Drawing.Size(220, 60);
            this.BtnCompras.TabIndex = 3;
            this.BtnCompras.Text = "COMPRAS";
            this.BtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCompras.UseVisualStyleBackColor = true;
            this.BtnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            // 
            // BtnProveedor
            // 
            this.BtnProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProveedor.FlatAppearance.BorderSize = 0;
            this.BtnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedor.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnProveedor.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnProveedor.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.BtnProveedor.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnProveedor.IconSize = 32;
            this.BtnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.Location = new System.Drawing.Point(0, 200);
            this.BtnProveedor.Name = "BtnProveedor";
            this.BtnProveedor.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnProveedor.Rotation = 0D;
            this.BtnProveedor.Size = new System.Drawing.Size(220, 60);
            this.BtnProveedor.TabIndex = 2;
            this.BtnProveedor.Text = "PROVEEDOR";
            this.BtnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProveedor.UseVisualStyleBackColor = true;
            this.BtnProveedor.Click += new System.EventHandler(this.BtnProveedor_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnUsuarios.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.User;
            this.BtnUsuarios.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnUsuarios.IconSize = 32;
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 140);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnUsuarios.Rotation = 0D;
            this.BtnUsuarios.Size = new System.Drawing.Size(220, 60);
            this.BtnUsuarios.TabIndex = 1;
            this.BtnUsuarios.Text = "USUARIOS";
            this.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUsuarios.UseVisualStyleBackColor = true;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BuPanelLogo
            // 
            this.BuPanelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuPanelLogo.BackgroundImage")));
            this.BuPanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuPanelLogo.Controls.Add(this.BtnInicio);
            this.BuPanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BuPanelLogo.GradientBottomLeft = System.Drawing.Color.White;
            this.BuPanelLogo.GradientBottomRight = System.Drawing.Color.White;
            this.BuPanelLogo.GradientTopLeft = System.Drawing.Color.White;
            this.BuPanelLogo.GradientTopRight = System.Drawing.Color.White;
            this.BuPanelLogo.Location = new System.Drawing.Point(0, 0);
            this.BuPanelLogo.Name = "BuPanelLogo";
            this.BuPanelLogo.Quality = 10;
            this.BuPanelLogo.Size = new System.Drawing.Size(220, 140);
            this.BuPanelLogo.TabIndex = 0;
            // 
            // BtnInicio
            // 
            this.BtnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnInicio.Image = global::FormPrincipal.Properties.Resources.manaco;
            this.BtnInicio.Location = new System.Drawing.Point(0, 0);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(220, 73);
            this.BtnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BtnInicio.TabIndex = 0;
            this.BtnInicio.TabStop = false;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 621);
            this.Controls.Add(this.PanelEscritorio);
            this.Controls.Add(this.PanelBarraTitulo);
            this.Controls.Add(this.BuPanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.PanelBarraTitulo.ResumeLayout(false);
            this.PanelBarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentFormHijo)).EndInit();
            this.BuPanelMenu.ResumeLayout(false);
            this.BuPanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel BuPanelMenu;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnReportes;
        private FontAwesome.Sharp.IconButton BtnVentas;
        private FontAwesome.Sharp.IconButton BtnClientes;
        private FontAwesome.Sharp.IconButton BtnProductos;
        private FontAwesome.Sharp.IconButton BtnCompras;
        private FontAwesome.Sharp.IconButton BtnProveedor;
        private FontAwesome.Sharp.IconButton BtnUsuarios;
        private Bunifu.Framework.UI.BunifuGradientPanel BuPanelLogo;
        private System.Windows.Forms.PictureBox BtnInicio;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelBarraTitulo;
        private FontAwesome.Sharp.IconPictureBox IconCurrentFormHijo;
        private Bunifu.Framework.UI.BunifuCustomLabel LblTituloFormHijo;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelEscritorio;
        private System.Windows.Forms.PictureBox BtnMaximizar;
        private System.Windows.Forms.PictureBox BtnRestaurar;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
    }
}

