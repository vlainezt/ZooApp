
namespace ZooApp
{
    partial class PasswordCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordCode));
            this.pnlControllerRecPass = new System.Windows.Forms.Panel();
            this.lblAppName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClosePassCode = new System.Windows.Forms.PictureBox();
            this.txtPassCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPassCode = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pnlControllerRecPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePassCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlControllerRecPass
            // 
            this.pnlControllerRecPass.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlControllerRecPass.Controls.Add(this.lblAppName);
            this.pnlControllerRecPass.Controls.Add(this.btnClosePassCode);
            this.pnlControllerRecPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControllerRecPass.Location = new System.Drawing.Point(0, 0);
            this.pnlControllerRecPass.Name = "pnlControllerRecPass";
            this.pnlControllerRecPass.Size = new System.Drawing.Size(189, 35);
            this.pnlControllerRecPass.TabIndex = 1;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(3, 12);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(150, 16);
            this.lblAppName.TabIndex = 13;
            this.lblAppName.Text = "Revisa tu correo...";
            // 
            // btnClosePassCode
            // 
            this.btnClosePassCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClosePassCode.Image = global::ZooApp.Properties.Resources.close;
            this.btnClosePassCode.Location = new System.Drawing.Point(161, 7);
            this.btnClosePassCode.Name = "btnClosePassCode";
            this.btnClosePassCode.Size = new System.Drawing.Size(25, 25);
            this.btnClosePassCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClosePassCode.TabIndex = 1;
            this.btnClosePassCode.TabStop = false;
            this.btnClosePassCode.Click += new System.EventHandler(this.btnCloseRevEmail_Click);
            // 
            // txtPassCode
            // 
            this.txtPassCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassCode.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassCode.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassCode.HintForeColor = System.Drawing.Color.DimGray;
            this.txtPassCode.HintText = "Codigo...";
            this.txtPassCode.isPassword = false;
            this.txtPassCode.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassCode.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassCode.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPassCode.LineThickness = 4;
            this.txtPassCode.Location = new System.Drawing.Point(13, 71);
            this.txtPassCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassCode.Name = "txtPassCode";
            this.txtPassCode.Size = new System.Drawing.Size(163, 52);
            this.txtPassCode.TabIndex = 7;
            this.txtPassCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnPassCode
            // 
            this.btnPassCode.ActiveBorderThickness = 1;
            this.btnPassCode.ActiveCornerRadius = 20;
            this.btnPassCode.ActiveFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPassCode.ActiveForecolor = System.Drawing.Color.White;
            this.btnPassCode.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPassCode.BackColor = System.Drawing.SystemColors.Control;
            this.btnPassCode.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPassCode.BackgroundImage")));
            this.btnPassCode.ButtonText = "Aceptar";
            this.btnPassCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPassCode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassCode.ForeColor = System.Drawing.Color.Gray;
            this.btnPassCode.IdleBorderThickness = 1;
            this.btnPassCode.IdleCornerRadius = 20;
            this.btnPassCode.IdleFillColor = System.Drawing.Color.White;
            this.btnPassCode.IdleForecolor = System.Drawing.Color.Gray;
            this.btnPassCode.IdleLineColor = System.Drawing.Color.Gray;
            this.btnPassCode.Location = new System.Drawing.Point(5, 133);
            this.btnPassCode.Margin = new System.Windows.Forms.Padding(5);
            this.btnPassCode.Name = "btnPassCode";
            this.btnPassCode.Size = new System.Drawing.Size(181, 45);
            this.btnPassCode.TabIndex = 12;
            this.btnPassCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPassCode.Click += new System.EventHandler(this.btnPassCode_Click);
            // 
            // PasswordCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 187);
            this.Controls.Add(this.btnPassCode);
            this.Controls.Add(this.txtPassCode);
            this.Controls.Add(this.pnlControllerRecPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordCode";
            this.pnlControllerRecPass.ResumeLayout(false);
            this.pnlControllerRecPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClosePassCode)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControllerRecPass;
        private System.Windows.Forms.PictureBox btnClosePassCode;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassCode;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPassCode;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAppName;
    }
}