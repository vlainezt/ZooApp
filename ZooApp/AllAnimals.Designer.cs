
namespace ZooApp
{
    partial class AllAnimals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllAnimals));
            this.lblAnimals = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dgvAnimalList = new System.Windows.Forms.DataGridView();
            this.btnAddAnimal = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalList)).BeginInit();
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
            this.lblAnimals.Text = "Animales";
            this.lblAnimals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvAnimalList
            // 
            this.dgvAnimalList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAnimalList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimalList.Location = new System.Drawing.Point(24, 72);
            this.dgvAnimalList.Name = "dgvAnimalList";
            this.dgvAnimalList.Size = new System.Drawing.Size(594, 407);
            this.dgvAnimalList.TabIndex = 14;
            this.dgvAnimalList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAnimalList_CellDoubleClick);
            // 
            // btnAddAnimal
            // 
            this.btnAddAnimal.ActiveBorderThickness = 1;
            this.btnAddAnimal.ActiveCornerRadius = 20;
            this.btnAddAnimal.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddAnimal.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddAnimal.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAddAnimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAnimal.BackgroundImage")));
            this.btnAddAnimal.ButtonText = "Agregar";
            this.btnAddAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAnimal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAnimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddAnimal.IdleBorderThickness = 1;
            this.btnAddAnimal.IdleCornerRadius = 20;
            this.btnAddAnimal.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.btnAddAnimal.IdleForecolor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddAnimal.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddAnimal.Location = new System.Drawing.Point(437, 487);
            this.btnAddAnimal.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddAnimal.Name = "btnAddAnimal";
            this.btnAddAnimal.Size = new System.Drawing.Size(181, 41);
            this.btnAddAnimal.TabIndex = 15;
            this.btnAddAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddAnimal.Click += new System.EventHandler(this.btnAddAnimal_Click);
            // 
            // AllAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(645, 542);
            this.Controls.Add(this.btnAddAnimal);
            this.Controls.Add(this.dgvAnimalList);
            this.Controls.Add(this.lblAnimals);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AllAnimals";
            this.Text = "AllAnimals";
            this.Load += new System.EventHandler(this.AllAnimals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblAnimals;
        private System.Windows.Forms.DataGridView dgvAnimalList;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddAnimal;
    }
}