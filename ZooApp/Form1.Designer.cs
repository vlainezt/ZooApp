namespace ZooApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlControlLogin = new System.Windows.Forms.Panel();
            this.pnlContentLogin = new System.Windows.Forms.Panel();
            this.lblAppName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLogin = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUserNameLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txxPasswordLogin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnLogear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMInimizedLogin = new System.Windows.Forms.PictureBox();
            this.btnExitLogin = new System.Windows.Forms.PictureBox();
            this.pnlControlLogin.SuspendLayout();
            this.pnlContentLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMInimizedLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControlLogin
            // 
            this.pnlControlLogin.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlControlLogin.Controls.Add(this.lblAppName);
            this.pnlControlLogin.Controls.Add(this.btnMInimizedLogin);
            this.pnlControlLogin.Controls.Add(this.btnExitLogin);
            this.pnlControlLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlControlLogin.Name = "pnlControlLogin";
            this.pnlControlLogin.Size = new System.Drawing.Size(600, 49);
            this.pnlControlLogin.TabIndex = 0;
            // 
            // pnlContentLogin
            // 
            this.pnlContentLogin.Controls.Add(this.btnLogear);
            this.pnlContentLogin.Controls.Add(this.txxPasswordLogin);
            this.pnlContentLogin.Controls.Add(this.txtUserNameLogin);
            this.pnlContentLogin.Controls.Add(this.lblLogin);
            this.pnlContentLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentLogin.Location = new System.Drawing.Point(0, 49);
            this.pnlContentLogin.Name = "pnlContentLogin";
            this.pnlContentLogin.Size = new System.Drawing.Size(600, 351);
            this.pnlContentLogin.TabIndex = 1;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(12, 17);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(122, 20);
            this.lblAppName.TabIndex = 0;
            this.lblAppName.Text = "Tukano Zoo ";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(253, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(75, 29);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "login";
            // 
            // txtUserNameLogin
            // 
            this.txtUserNameLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameLogin.ForeColor = System.Drawing.Color.White;
            this.txtUserNameLogin.HintForeColor = System.Drawing.Color.White;
            this.txtUserNameLogin.HintText = "Ingrese su usuario";
            this.txtUserNameLogin.isPassword = false;
            this.txtUserNameLogin.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUserNameLogin.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserNameLogin.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUserNameLogin.LineThickness = 4;
            this.txtUserNameLogin.Location = new System.Drawing.Point(90, 97);
            this.txtUserNameLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserNameLogin.Name = "txtUserNameLogin";
            this.txtUserNameLogin.Size = new System.Drawing.Size(416, 52);
            this.txtUserNameLogin.TabIndex = 5;
            this.txtUserNameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txxPasswordLogin
            // 
            this.txxPasswordLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txxPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txxPasswordLogin.ForeColor = System.Drawing.Color.White;
            this.txxPasswordLogin.HintForeColor = System.Drawing.Color.White;
            this.txxPasswordLogin.HintText = "Ingrese su contraseña";
            this.txxPasswordLogin.isPassword = false;
            this.txxPasswordLogin.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txxPasswordLogin.LineIdleColor = System.Drawing.Color.Gray;
            this.txxPasswordLogin.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txxPasswordLogin.LineThickness = 4;
            this.txxPasswordLogin.Location = new System.Drawing.Point(90, 175);
            this.txxPasswordLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txxPasswordLogin.Name = "txxPasswordLogin";
            this.txxPasswordLogin.Size = new System.Drawing.Size(416, 52);
            this.txxPasswordLogin.TabIndex = 6;
            this.txxPasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogear
            // 
            this.btnLogear.ActiveBorderThickness = 1;
            this.btnLogear.ActiveCornerRadius = 20;
            this.btnLogear.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogear.ActiveForecolor = System.Drawing.Color.White;
            this.btnLogear.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnLogear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogear.BackgroundImage")));
            this.btnLogear.ButtonText = "Iniciar Sesión";
            this.btnLogear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogear.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogear.ForeColor = System.Drawing.Color.Gray;
            this.btnLogear.IdleBorderThickness = 1;
            this.btnLogear.IdleCornerRadius = 20;
            this.btnLogear.IdleFillColor = System.Drawing.Color.White;
            this.btnLogear.IdleForecolor = System.Drawing.Color.Gray;
            this.btnLogear.IdleLineColor = System.Drawing.Color.Gray;
            this.btnLogear.Location = new System.Drawing.Point(200, 263);
            this.btnLogear.Margin = new System.Windows.Forms.Padding(5);
            this.btnLogear.Name = "btnLogear";
            this.btnLogear.Size = new System.Drawing.Size(181, 45);
            this.btnLogear.TabIndex = 10;
            this.btnLogear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogear.Click += new System.EventHandler(this.btnLogear_Click);
            // 
            // btnMInimizedLogin
            // 
            this.btnMInimizedLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMInimizedLogin.Image = global::ZooApp.Properties.Resources.minimize;
            this.btnMInimizedLogin.Location = new System.Drawing.Point(531, 12);
            this.btnMInimizedLogin.Name = "btnMInimizedLogin";
            this.btnMInimizedLogin.Size = new System.Drawing.Size(25, 25);
            this.btnMInimizedLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMInimizedLogin.TabIndex = 1;
            this.btnMInimizedLogin.TabStop = false;
            this.btnMInimizedLogin.Click += new System.EventHandler(this.btnMInimizedLogin_Click);
            // 
            // btnExitLogin
            // 
            this.btnExitLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitLogin.Image = global::ZooApp.Properties.Resources.close;
            this.btnExitLogin.Location = new System.Drawing.Point(562, 12);
            this.btnExitLogin.Name = "btnExitLogin";
            this.btnExitLogin.Size = new System.Drawing.Size(25, 25);
            this.btnExitLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExitLogin.TabIndex = 0;
            this.btnExitLogin.TabStop = false;
            this.btnExitLogin.Click += new System.EventHandler(this.btnExitLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.pnlContentLogin);
            this.Controls.Add(this.pnlControlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlControlLogin.ResumeLayout(false);
            this.pnlControlLogin.PerformLayout();
            this.pnlContentLogin.ResumeLayout(false);
            this.pnlContentLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMInimizedLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControlLogin;
        private System.Windows.Forms.PictureBox btnExitLogin;
        private System.Windows.Forms.Panel pnlContentLogin;
        private System.Windows.Forms.PictureBox btnMInimizedLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAppName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserNameLogin;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txxPasswordLogin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLogear;
    }
}

