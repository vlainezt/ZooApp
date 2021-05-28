
namespace ZooApp
{
    partial class HistorialAnimales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistorialAnimales));
            this.lblAnimals = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvRecordAnimals = new System.Windows.Forms.DataGridView();
            this.btnVolver = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimals
            // 
            this.lblAnimals.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAnimals.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimals.ForeColor = System.Drawing.Color.White;
            this.lblAnimals.Location = new System.Drawing.Point(0, 0);
            this.lblAnimals.Name = "lblAnimals";
            this.lblAnimals.Size = new System.Drawing.Size(645, 60);
            this.lblAnimals.TabIndex = 13;
            this.lblAnimals.Text = "Historial de registro de animales";
            this.lblAnimals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvRecordAnimals
            // 
            this.dgvRecordAnimals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRecordAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecordAnimals.Location = new System.Drawing.Point(24, 72);
            this.dgvRecordAnimals.Name = "dgvRecordAnimals";
            this.dgvRecordAnimals.Size = new System.Drawing.Size(594, 407);
            this.dgvRecordAnimals.TabIndex = 14;
            // 
            // btnVolver
            // 
            this.btnVolver.ActiveBorderThickness = 1;
            this.btnVolver.ActiveCornerRadius = 20;
            this.btnVolver.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.ActiveForecolor = System.Drawing.Color.White;
            this.btnVolver.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnVolver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVolver.BackgroundImage")));
            this.btnVolver.ButtonText = "Volver";
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVolver.IdleBorderThickness = 1;
            this.btnVolver.IdleCornerRadius = 20;
            this.btnVolver.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.btnVolver.IdleForecolor = System.Drawing.SystemColors.ButtonFace;
            this.btnVolver.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnVolver.Location = new System.Drawing.Point(437, 487);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(5);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(181, 41);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HistorialAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(645, 542);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvRecordAnimals);
            this.Controls.Add(this.lblAnimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistorialAnimales";
            this.Text = "AllAnimals";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecordAnimals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnVolver;
        private System.Windows.Forms.DataGridView dgvRecordAnimals;
        private Bunifu.Framework.UI.BunifuCustomLabel lblAnimals;
    }
}