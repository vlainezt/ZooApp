﻿
namespace ZooApp
{
    partial class registerFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registerFrom));
            this.pnlContentRegister = new System.Windows.Forms.Panel();
            this.btnRegisterUser = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtUserRoll = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtEmailUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtRepeatPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtUserNameRegister = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblRegister = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlContentRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContentRegister
            // 
            this.pnlContentRegister.Controls.Add(this.btnRegisterUser);
            this.pnlContentRegister.Controls.Add(this.txtUserRoll);
            this.pnlContentRegister.Controls.Add(this.txtEmailUser);
            this.pnlContentRegister.Controls.Add(this.txtRepeatPassword);
            this.pnlContentRegister.Controls.Add(this.txtUserPassword);
            this.pnlContentRegister.Controls.Add(this.txtUserNameRegister);
            this.pnlContentRegister.Controls.Add(this.lblRegister);
            this.pnlContentRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentRegister.Location = new System.Drawing.Point(0, 0);
            this.pnlContentRegister.Name = "pnlContentRegister";
            this.pnlContentRegister.Size = new System.Drawing.Size(600, 611);
            this.pnlContentRegister.TabIndex = 0;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.ActiveBorderThickness = 1;
            this.btnRegisterUser.ActiveCornerRadius = 20;
            this.btnRegisterUser.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegisterUser.ActiveForecolor = System.Drawing.Color.White;
            this.btnRegisterUser.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.btnRegisterUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegisterUser.BackgroundImage")));
            this.btnRegisterUser.ButtonText = "Crear Cuenta";
            this.btnRegisterUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterUser.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterUser.ForeColor = System.Drawing.Color.Gray;
            this.btnRegisterUser.IdleBorderThickness = 1;
            this.btnRegisterUser.IdleCornerRadius = 20;
            this.btnRegisterUser.IdleFillColor = System.Drawing.Color.White;
            this.btnRegisterUser.IdleForecolor = System.Drawing.Color.Gray;
            this.btnRegisterUser.IdleLineColor = System.Drawing.Color.Gray;
            this.btnRegisterUser.Location = new System.Drawing.Point(201, 525);
            this.btnRegisterUser.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(181, 45);
            this.btnRegisterUser.TabIndex = 18;
            this.btnRegisterUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserRoll
            // 
            this.txtUserRoll.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserRoll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserRoll.ForeColor = System.Drawing.Color.White;
            this.txtUserRoll.HintForeColor = System.Drawing.Color.White;
            this.txtUserRoll.HintText = "Ingresa el cargo del usuario";
            this.txtUserRoll.isPassword = false;
            this.txtUserRoll.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUserRoll.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserRoll.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUserRoll.LineThickness = 4;
            this.txtUserRoll.Location = new System.Drawing.Point(92, 445);
            this.txtUserRoll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserRoll.Name = "txtUserRoll";
            this.txtUserRoll.Size = new System.Drawing.Size(416, 52);
            this.txtUserRoll.TabIndex = 17;
            this.txtUserRoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtEmailUser
            // 
            this.txtEmailUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailUser.ForeColor = System.Drawing.Color.White;
            this.txtEmailUser.HintForeColor = System.Drawing.Color.White;
            this.txtEmailUser.HintText = "Ingresa el correo del usuario";
            this.txtEmailUser.isPassword = false;
            this.txtEmailUser.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEmailUser.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmailUser.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtEmailUser.LineThickness = 4;
            this.txtEmailUser.Location = new System.Drawing.Point(92, 355);
            this.txtEmailUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmailUser.Name = "txtEmailUser";
            this.txtEmailUser.Size = new System.Drawing.Size(416, 52);
            this.txtEmailUser.TabIndex = 16;
            this.txtEmailUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtRepeatPassword
            // 
            this.txtRepeatPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepeatPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeatPassword.ForeColor = System.Drawing.Color.White;
            this.txtRepeatPassword.HintForeColor = System.Drawing.Color.White;
            this.txtRepeatPassword.HintText = "Repite la contraseña";
            this.txtRepeatPassword.isPassword = false;
            this.txtRepeatPassword.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtRepeatPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRepeatPassword.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtRepeatPassword.LineThickness = 4;
            this.txtRepeatPassword.Location = new System.Drawing.Point(92, 271);
            this.txtRepeatPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRepeatPassword.Name = "txtRepeatPassword";
            this.txtRepeatPassword.Size = new System.Drawing.Size(416, 52);
            this.txtRepeatPassword.TabIndex = 15;
            this.txtRepeatPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserPassword.ForeColor = System.Drawing.Color.White;
            this.txtUserPassword.HintForeColor = System.Drawing.Color.White;
            this.txtUserPassword.HintText = "Ingrese la contraseña";
            this.txtUserPassword.isPassword = false;
            this.txtUserPassword.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUserPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserPassword.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUserPassword.LineThickness = 4;
            this.txtUserPassword.Location = new System.Drawing.Point(92, 193);
            this.txtUserPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(416, 52);
            this.txtUserPassword.TabIndex = 14;
            this.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtUserNameRegister
            // 
            this.txtUserNameRegister.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserNameRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNameRegister.ForeColor = System.Drawing.Color.White;
            this.txtUserNameRegister.HintForeColor = System.Drawing.Color.White;
            this.txtUserNameRegister.HintText = "Ingrese el nombre de usuario";
            this.txtUserNameRegister.isPassword = false;
            this.txtUserNameRegister.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUserNameRegister.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserNameRegister.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtUserNameRegister.LineThickness = 4;
            this.txtUserNameRegister.Location = new System.Drawing.Point(92, 113);
            this.txtUserNameRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserNameRegister.Name = "txtUserNameRegister";
            this.txtUserNameRegister.Size = new System.Drawing.Size(416, 52);
            this.txtUserNameRegister.TabIndex = 13;
            this.txtUserNameRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.White;
            this.lblRegister.Location = new System.Drawing.Point(171, 41);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(234, 29);
            this.lblRegister.TabIndex = 12;
            this.lblRegister.Text = "Registrar usuario";
            // 
            // registerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(600, 611);
            this.Controls.Add(this.pnlContentRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registerFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerFrom";
            this.pnlContentRegister.ResumeLayout(false);
            this.pnlContentRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContentRegister;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRegisterUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserRoll;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmailUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRepeatPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserNameRegister;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRegister;
    }
}