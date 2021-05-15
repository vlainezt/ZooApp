
namespace ZooApp
{
    partial class frmChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePass));
            this.pnlControllerRecPass = new System.Windows.Forms.Panel();
            this.lblnaamee = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCloseRevEmail = new System.Windows.Forms.PictureBox();
            this.txtNewPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Controller = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnUpdatePass = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtRepeatPass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlControllerRecPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseRevEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControllerRecPass
            // 
            this.pnlControllerRecPass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlControllerRecPass.Controls.Add(this.lblnaamee);
            this.pnlControllerRecPass.Controls.Add(this.btnCloseRevEmail);
            this.pnlControllerRecPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControllerRecPass.Location = new System.Drawing.Point(0, 0);
            this.pnlControllerRecPass.Name = "pnlControllerRecPass";
            this.pnlControllerRecPass.Size = new System.Drawing.Size(527, 35);
            this.pnlControllerRecPass.TabIndex = 0;
            // 
            // lblnaamee
            // 
            this.lblnaamee.AutoSize = true;
            this.lblnaamee.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnaamee.ForeColor = System.Drawing.Color.White;
            this.lblnaamee.Location = new System.Drawing.Point(12, 9);
            this.lblnaamee.Name = "lblnaamee";
            this.lblnaamee.Size = new System.Drawing.Size(251, 20);
            this.lblnaamee.TabIndex = 12;
            this.lblnaamee.Text = "rEcuperando Contraseña...";
            // 
            // btnCloseRevEmail
            // 
            this.btnCloseRevEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseRevEmail.Image = global::ZooApp.Properties.Resources.close;
            this.btnCloseRevEmail.Location = new System.Drawing.Point(499, 5);
            this.btnCloseRevEmail.Name = "btnCloseRevEmail";
            this.btnCloseRevEmail.Size = new System.Drawing.Size(25, 25);
            this.btnCloseRevEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCloseRevEmail.TabIndex = 1;
            this.btnCloseRevEmail.TabStop = false;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPass.ForeColor = System.Drawing.Color.White;
            this.txtNewPass.HintForeColor = System.Drawing.Color.White;
            this.txtNewPass.HintText = "Ingrese la nueva contraseña";
            this.txtNewPass.isPassword = false;
            this.txtNewPass.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNewPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNewPass.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNewPass.LineThickness = 4;
            this.txtNewPass.Location = new System.Drawing.Point(26, 69);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(473, 52);
            this.txtNewPass.TabIndex = 6;
            this.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Controller
            // 
            this.Controller.Fixed = true;
            this.Controller.Horizontal = true;
            this.Controller.TargetControl = this.pnlControllerRecPass;
            this.Controller.Vertical = true;
            // 
            // btnUpdatePass
            // 
            this.btnUpdatePass.ActiveBorderThickness = 1;
            this.btnUpdatePass.ActiveCornerRadius = 20;
            this.btnUpdatePass.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdatePass.ActiveForecolor = System.Drawing.Color.White;
            this.btnUpdatePass.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdatePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnUpdatePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdatePass.BackgroundImage")));
            this.btnUpdatePass.ButtonText = "Cambiar contraseña";
            this.btnUpdatePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePass.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePass.ForeColor = System.Drawing.Color.Gray;
            this.btnUpdatePass.IdleBorderThickness = 1;
            this.btnUpdatePass.IdleCornerRadius = 20;
            this.btnUpdatePass.IdleFillColor = System.Drawing.Color.White;
            this.btnUpdatePass.IdleForecolor = System.Drawing.Color.Gray;
            this.btnUpdatePass.IdleLineColor = System.Drawing.Color.Gray;
            this.btnUpdatePass.Location = new System.Drawing.Point(170, 224);
            this.btnUpdatePass.Margin = new System.Windows.Forms.Padding(5);
            this.btnUpdatePass.Name = "btnUpdatePass";
            this.btnUpdatePass.Size = new System.Drawing.Size(181, 45);
            this.btnUpdatePass.TabIndex = 11;
            this.btnUpdatePass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdatePass.Click += new System.EventHandler(this.btnSendRecoverEmail_Click);
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepeatPass.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRepeatPass.ForeColor = System.Drawing.Color.White;
            this.txtRepeatPass.HintForeColor = System.Drawing.Color.White;
            this.txtRepeatPass.HintText = "Repita de nuevo la contraseña";
            this.txtRepeatPass.isPassword = false;
            this.txtRepeatPass.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtRepeatPass.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRepeatPass.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtRepeatPass.LineThickness = 4;
            this.txtRepeatPass.Location = new System.Drawing.Point(26, 162);
            this.txtRepeatPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.Size = new System.Drawing.Size(473, 52);
            this.txtRepeatPass.TabIndex = 12;
            this.txtRepeatPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(527, 283);
            this.Controls.Add(this.txtRepeatPass);
            this.Controls.Add(this.btnUpdatePass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.pnlControllerRecPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecoverEmail";
            this.pnlControllerRecPass.ResumeLayout(false);
            this.pnlControllerRecPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseRevEmail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControllerRecPass;
        private System.Windows.Forms.PictureBox btnCloseRevEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNewPass;
        private Bunifu.Framework.UI.BunifuThinButton2 btnUpdatePass;
        private Bunifu.Framework.UI.BunifuCustomLabel lblnaamee;
        private Bunifu.Framework.UI.BunifuDragControl Controller;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRepeatPass;
    }
}