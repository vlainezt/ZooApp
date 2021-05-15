
namespace ZooApp
{
    partial class RecoverEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoverEmail));
            this.pnlControllerRecPass = new System.Windows.Forms.Panel();
            this.lblnaamee = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtRecoverEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Controller = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnSendRecoverEmail = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnCloseRevEmail = new System.Windows.Forms.PictureBox();
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
            // txtRecoverEmail
            // 
            this.txtRecoverEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRecoverEmail.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecoverEmail.ForeColor = System.Drawing.Color.White;
            this.txtRecoverEmail.HintForeColor = System.Drawing.Color.White;
            this.txtRecoverEmail.HintText = "Ingrese su correo ";
            this.txtRecoverEmail.isPassword = false;
            this.txtRecoverEmail.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtRecoverEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRecoverEmail.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtRecoverEmail.LineThickness = 4;
            this.txtRecoverEmail.Location = new System.Drawing.Point(26, 69);
            this.txtRecoverEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRecoverEmail.Name = "txtRecoverEmail";
            this.txtRecoverEmail.Size = new System.Drawing.Size(473, 52);
            this.txtRecoverEmail.TabIndex = 6;
            this.txtRecoverEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Controller
            // 
            this.Controller.Fixed = true;
            this.Controller.Horizontal = true;
            this.Controller.TargetControl = this.pnlControllerRecPass;
            this.Controller.Vertical = true;
            // 
            // btnSendRecoverEmail
            // 
            this.btnSendRecoverEmail.ActiveBorderThickness = 1;
            this.btnSendRecoverEmail.ActiveCornerRadius = 20;
            this.btnSendRecoverEmail.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendRecoverEmail.ActiveForecolor = System.Drawing.Color.White;
            this.btnSendRecoverEmail.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSendRecoverEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSendRecoverEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSendRecoverEmail.BackgroundImage")));
            this.btnSendRecoverEmail.ButtonText = "Enviar Código";
            this.btnSendRecoverEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendRecoverEmail.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRecoverEmail.ForeColor = System.Drawing.Color.Gray;
            this.btnSendRecoverEmail.IdleBorderThickness = 1;
            this.btnSendRecoverEmail.IdleCornerRadius = 20;
            this.btnSendRecoverEmail.IdleFillColor = System.Drawing.Color.White;
            this.btnSendRecoverEmail.IdleForecolor = System.Drawing.Color.Gray;
            this.btnSendRecoverEmail.IdleLineColor = System.Drawing.Color.Gray;
            this.btnSendRecoverEmail.Location = new System.Drawing.Point(169, 131);
            this.btnSendRecoverEmail.Margin = new System.Windows.Forms.Padding(5);
            this.btnSendRecoverEmail.Name = "btnSendRecoverEmail";
            this.btnSendRecoverEmail.Size = new System.Drawing.Size(181, 45);
            this.btnSendRecoverEmail.TabIndex = 11;
            this.btnSendRecoverEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSendRecoverEmail.Click += new System.EventHandler(this.btnSendRecoverEmail_Click);
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
            this.btnCloseRevEmail.Click += new System.EventHandler(this.btnCloseRevEmail_Click);
            // 
            // RecoverEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(527, 199);
            this.Controls.Add(this.btnSendRecoverEmail);
            this.Controls.Add(this.txtRecoverEmail);
            this.Controls.Add(this.pnlControllerRecPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecoverEmail";
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRecoverEmail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSendRecoverEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel lblnaamee;
        private Bunifu.Framework.UI.BunifuDragControl Controller;
    }
}