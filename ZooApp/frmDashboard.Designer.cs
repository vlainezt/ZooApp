
namespace ZooApp
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.pnlControllerDash = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.lblAppName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMInimizedDash = new System.Windows.Forms.PictureBox();
            this.btnExitDash = new System.Windows.Forms.PictureBox();
            this.pnlSidebarMenu = new System.Windows.Forms.Panel();
            this.pnlMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.line = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnPerfil = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnimales = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInicio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pnlContentDash = new System.Windows.Forms.Panel();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.animationMenuMIn = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.animationMenuMax = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.borderMenu = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.borderForms = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.animationFroms = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.contrrollerDash = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlControllerDash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMInimizedDash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitDash)).BeginInit();
            this.pnlSidebarMenu.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.pnlContentDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControllerDash
            // 
            this.pnlControllerDash.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlControllerDash.Controls.Add(this.btnMenu);
            this.pnlControllerDash.Controls.Add(this.lblAppName);
            this.pnlControllerDash.Controls.Add(this.btnMInimizedDash);
            this.pnlControllerDash.Controls.Add(this.btnExitDash);
            this.animationMenuMIn.SetDecoration(this.pnlControllerDash, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.pnlControllerDash, BunifuAnimatorNS.DecorationType.None);
            this.animationFroms.SetDecoration(this.pnlControllerDash, BunifuAnimatorNS.DecorationType.None);
            this.pnlControllerDash.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControllerDash.Location = new System.Drawing.Point(0, 0);
            this.pnlControllerDash.Name = "pnlControllerDash";
            this.pnlControllerDash.Size = new System.Drawing.Size(1000, 58);
            this.pnlControllerDash.TabIndex = 0;
            // 
            // btnMenu
            // 
            this.animationFroms.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = global::ZooApp.Properties.Resources.menu;
            this.btnMenu.Location = new System.Drawing.Point(34, 18);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(32, 29);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 1;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.animationFroms.SetDecoration(this.lblAppName, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.lblAppName, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this.lblAppName, BunifuAnimatorNS.DecorationType.None);
            this.lblAppName.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(72, 21);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(154, 26);
            this.lblAppName.TabIndex = 4;
            this.lblAppName.Text = "Tukano Zoo ";
            // 
            // btnMInimizedDash
            // 
            this.btnMInimizedDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationFroms.SetDecoration(this.btnMInimizedDash, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.btnMInimizedDash, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this.btnMInimizedDash, BunifuAnimatorNS.DecorationType.None);
            this.btnMInimizedDash.Image = global::ZooApp.Properties.Resources.minimize;
            this.btnMInimizedDash.Location = new System.Drawing.Point(933, 21);
            this.btnMInimizedDash.Name = "btnMInimizedDash";
            this.btnMInimizedDash.Size = new System.Drawing.Size(25, 25);
            this.btnMInimizedDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMInimizedDash.TabIndex = 3;
            this.btnMInimizedDash.TabStop = false;
            this.btnMInimizedDash.Click += new System.EventHandler(this.btnMInimizedDash_Click);
            // 
            // btnExitDash
            // 
            this.btnExitDash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationFroms.SetDecoration(this.btnExitDash, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.btnExitDash, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this.btnExitDash, BunifuAnimatorNS.DecorationType.None);
            this.btnExitDash.Image = global::ZooApp.Properties.Resources.close;
            this.btnExitDash.Location = new System.Drawing.Point(964, 21);
            this.btnExitDash.Name = "btnExitDash";
            this.btnExitDash.Size = new System.Drawing.Size(25, 25);
            this.btnExitDash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExitDash.TabIndex = 2;
            this.btnExitDash.TabStop = false;
            this.btnExitDash.Click += new System.EventHandler(this.btnExitDash_Click);
            // 
            // pnlSidebarMenu
            // 
            this.pnlSidebarMenu.Controls.Add(this.pnlMenu);
            this.animationMenuMIn.SetDecoration(this.pnlSidebarMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.pnlSidebarMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationFroms.SetDecoration(this.pnlSidebarMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlSidebarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebarMenu.Location = new System.Drawing.Point(0, 58);
            this.pnlSidebarMenu.Name = "pnlSidebarMenu";
            this.pnlSidebarMenu.Size = new System.Drawing.Size(300, 592);
            this.pnlSidebarMenu.TabIndex = 1;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMenu.BackgroundImage")));
            this.pnlMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMenu.Controls.Add(this.line);
            this.pnlMenu.Controls.Add(this.btnPerfil);
            this.pnlMenu.Controls.Add(this.btnEmpleados);
            this.pnlMenu.Controls.Add(this.btnAnimales);
            this.pnlMenu.Controls.Add(this.btnInicio);
            this.pnlMenu.Controls.Add(this.imgLogo);
            this.animationMenuMIn.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.animationFroms.SetDecoration(this.pnlMenu, BunifuAnimatorNS.DecorationType.None);
            this.pnlMenu.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.pnlMenu.GradientBottomRight = System.Drawing.SystemColors.HotTrack;
            this.pnlMenu.GradientTopLeft = System.Drawing.SystemColors.MenuHighlight;
            this.pnlMenu.GradientTopRight = System.Drawing.SystemColors.HotTrack;
            this.pnlMenu.Location = new System.Drawing.Point(26, 27);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Quality = 10;
            this.pnlMenu.Size = new System.Drawing.Size(250, 542);
            this.pnlMenu.TabIndex = 0;
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.Transparent;
            this.animationMenuMIn.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.animationFroms.SetDecoration(this.line, BunifuAnimatorNS.DecorationType.None);
            this.line.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.line.LineThickness = 1;
            this.line.Location = new System.Drawing.Point(0, 87);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(250, 1);
            this.line.TabIndex = 0;
            this.line.Transparency = 255;
            this.line.Vertical = false;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Activecolor = System.Drawing.Color.Transparent;
            this.btnPerfil.BackColor = System.Drawing.Color.Transparent;
            this.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerfil.BorderRadius = 0;
            this.btnPerfil.ButtonText = "Perfil";
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationFroms.SetDecoration(this.btnPerfil, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.btnPerfil, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this.btnPerfil, BunifuAnimatorNS.DecorationType.None);
            this.btnPerfil.DisabledColor = System.Drawing.Color.Gray;
            this.btnPerfil.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPerfil.Iconimage = global::ZooApp.Properties.Resources.perfil;
            this.btnPerfil.Iconimage_right = null;
            this.btnPerfil.Iconimage_right_Selected = null;
            this.btnPerfil.Iconimage_Selected = null;
            this.btnPerfil.IconMarginLeft = 0;
            this.btnPerfil.IconMarginRight = 0;
            this.btnPerfil.IconRightVisible = true;
            this.btnPerfil.IconRightZoom = 0D;
            this.btnPerfil.IconVisible = true;
            this.btnPerfil.IconZoom = 60D;
            this.btnPerfil.IsTab = false;
            this.btnPerfil.Location = new System.Drawing.Point(8, 338);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPerfil.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnPerfil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPerfil.selected = false;
            this.btnPerfil.Size = new System.Drawing.Size(230, 48);
            this.btnPerfil.TabIndex = 3;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPerfil.Textcolor = System.Drawing.Color.White;
            this.btnPerfil.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Activecolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleados.BorderRadius = 0;
            this.btnEmpleados.ButtonText = "Empleados";
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationFroms.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this.btnEmpleados, BunifuAnimatorNS.DecorationType.None);
            this.btnEmpleados.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Iconimage = global::ZooApp.Properties.Resources.perfil;
            this.btnEmpleados.Iconimage_right = null;
            this.btnEmpleados.Iconimage_right_Selected = null;
            this.btnEmpleados.Iconimage_Selected = null;
            this.btnEmpleados.IconMarginLeft = 0;
            this.btnEmpleados.IconMarginRight = 0;
            this.btnEmpleados.IconRightVisible = true;
            this.btnEmpleados.IconRightZoom = 0D;
            this.btnEmpleados.IconVisible = true;
            this.btnEmpleados.IconZoom = 60D;
            this.btnEmpleados.IsTab = false;
            this.btnEmpleados.Location = new System.Drawing.Point(8, 272);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpleados.selected = false;
            this.btnEmpleados.Size = new System.Drawing.Size(230, 48);
            this.btnEmpleados.TabIndex = 2;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEmpleados.Textcolor = System.Drawing.Color.White;
            this.btnEmpleados.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnAnimales
            // 
            this.btnAnimales.Activecolor = System.Drawing.Color.Transparent;
            this.btnAnimales.BackColor = System.Drawing.Color.Transparent;
            this.btnAnimales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnimales.BorderRadius = 0;
            this.btnAnimales.ButtonText = "animales";
            this.btnAnimales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationFroms.SetDecoration(this.btnAnimales, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.btnAnimales, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this.btnAnimales, BunifuAnimatorNS.DecorationType.None);
            this.btnAnimales.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnimales.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnimales.Iconimage = global::ZooApp.Properties.Resources.animal;
            this.btnAnimales.Iconimage_right = null;
            this.btnAnimales.Iconimage_right_Selected = null;
            this.btnAnimales.Iconimage_Selected = null;
            this.btnAnimales.IconMarginLeft = 0;
            this.btnAnimales.IconMarginRight = 0;
            this.btnAnimales.IconRightVisible = true;
            this.btnAnimales.IconRightZoom = 0D;
            this.btnAnimales.IconVisible = true;
            this.btnAnimales.IconZoom = 60D;
            this.btnAnimales.IsTab = false;
            this.btnAnimales.Location = new System.Drawing.Point(8, 206);
            this.btnAnimales.Name = "btnAnimales";
            this.btnAnimales.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAnimales.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnAnimales.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnimales.selected = false;
            this.btnAnimales.Size = new System.Drawing.Size(230, 48);
            this.btnAnimales.TabIndex = 1;
            this.btnAnimales.Text = "animales";
            this.btnAnimales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnimales.Textcolor = System.Drawing.Color.White;
            this.btnAnimales.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimales.Click += new System.EventHandler(this.btnAnimales_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Activecolor = System.Drawing.Color.Transparent;
            this.btnInicio.BackColor = System.Drawing.Color.Transparent;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInicio.BorderRadius = 0;
            this.btnInicio.ButtonText = "Inicio";
            this.btnInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animationFroms.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this.btnInicio, BunifuAnimatorNS.DecorationType.None);
            this.btnInicio.DisabledColor = System.Drawing.Color.Gray;
            this.btnInicio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInicio.Iconimage = global::ZooApp.Properties.Resources.dashboard;
            this.btnInicio.Iconimage_right = null;
            this.btnInicio.Iconimage_right_Selected = null;
            this.btnInicio.Iconimage_Selected = null;
            this.btnInicio.IconMarginLeft = 0;
            this.btnInicio.IconMarginRight = 0;
            this.btnInicio.IconRightVisible = true;
            this.btnInicio.IconRightZoom = 0D;
            this.btnInicio.IconVisible = true;
            this.btnInicio.IconZoom = 60D;
            this.btnInicio.IsTab = false;
            this.btnInicio.Location = new System.Drawing.Point(8, 141);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Normalcolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnInicio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInicio.selected = false;
            this.btnInicio.Size = new System.Drawing.Size(230, 48);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInicio.Textcolor = System.Drawing.Color.White;
            this.btnInicio.TextFont = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.animationFroms.SetDecoration(this.imgLogo, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.imgLogo, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this.imgLogo, BunifuAnimatorNS.DecorationType.None);
            this.imgLogo.Image = global::ZooApp.Properties.Resources.logo;
            this.imgLogo.Location = new System.Drawing.Point(8, 20);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(230, 50);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pnlContentDash
            // 
            this.pnlContentDash.Controls.Add(this.pnlForms);
            this.animationMenuMIn.SetDecoration(this.pnlContentDash, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.pnlContentDash, BunifuAnimatorNS.DecorationType.None);
            this.animationFroms.SetDecoration(this.pnlContentDash, BunifuAnimatorNS.DecorationType.None);
            this.pnlContentDash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentDash.Location = new System.Drawing.Point(300, 58);
            this.pnlContentDash.Name = "pnlContentDash";
            this.pnlContentDash.Size = new System.Drawing.Size(700, 592);
            this.pnlContentDash.TabIndex = 2;
            // 
            // pnlForms
            // 
            this.pnlForms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.animationMenuMIn.SetDecoration(this.pnlForms, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this.pnlForms, BunifuAnimatorNS.DecorationType.None);
            this.animationFroms.SetDecoration(this.pnlForms, BunifuAnimatorNS.DecorationType.None);
            this.pnlForms.Location = new System.Drawing.Point(27, 27);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Size = new System.Drawing.Size(645, 542);
            this.pnlForms.TabIndex = 0;
            // 
            // animationMenuMIn
            // 
            this.animationMenuMIn.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlideAndRotate;
            this.animationMenuMIn.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(50);
            animation3.RotateCoeff = 0.3F;
            animation3.RotateLimit = 0.2F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.animationMenuMIn.DefaultAnimation = animation3;
            // 
            // animationMenuMax
            // 
            this.animationMenuMax.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.animationMenuMax.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.animationMenuMax.DefaultAnimation = animation2;
            // 
            // borderMenu
            // 
            this.borderMenu.ElipseRadius = 10;
            this.borderMenu.TargetControl = this.pnlMenu;
            // 
            // borderForms
            // 
            this.borderForms.ElipseRadius = 10;
            this.borderForms.TargetControl = this.pnlForms;
            // 
            // animationFroms
            // 
            this.animationFroms.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.animationFroms.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.animationFroms.DefaultAnimation = animation1;
            // 
            // contrrollerDash
            // 
            this.contrrollerDash.Fixed = true;
            this.contrrollerDash.Horizontal = true;
            this.contrrollerDash.TargetControl = this.pnlControllerDash;
            this.contrrollerDash.Vertical = true;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.pnlContentDash);
            this.Controls.Add(this.pnlSidebarMenu);
            this.Controls.Add(this.pnlControllerDash);
            this.animationFroms.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMIn.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.animationMenuMax.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.pnlControllerDash.ResumeLayout(false);
            this.pnlControllerDash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMInimizedDash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitDash)).EndInit();
            this.pnlSidebarMenu.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.pnlContentDash.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControllerDash;
        private System.Windows.Forms.PictureBox btnMInimizedDash;
        private System.Windows.Forms.PictureBox btnExitDash;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAppName;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel pnlSidebarMenu;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlMenu;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Panel pnlContentDash;
        private Bunifu.Framework.UI.BunifuFlatButton btnInicio;
        private Bunifu.Framework.UI.BunifuFlatButton btnPerfil;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnimales;
        private Bunifu.Framework.UI.BunifuSeparator line;
        private BunifuAnimatorNS.BunifuTransition animationMenuMIn;
        private BunifuAnimatorNS.BunifuTransition animationMenuMax;
        private Bunifu.Framework.UI.BunifuElipse borderMenu;
        private System.Windows.Forms.Panel pnlForms;
        private Bunifu.Framework.UI.BunifuElipse borderForms;
        private BunifuAnimatorNS.BunifuTransition animationFroms;
        private Bunifu.Framework.UI.BunifuDragControl contrrollerDash;
    }
}