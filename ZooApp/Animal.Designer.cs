
namespace ZooApp
{
    partial class Animal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Animal));
            this.btnExitAnimal = new System.Windows.Forms.PictureBox();
            this.lblAnimal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblIdAnimal = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.controllerAnimalForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtAnimalName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtAnimalNameC = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbHabitat = new System.Windows.Forms.ComboBox();
            this.cbSpecies = new System.Windows.Forms.ComboBox();
            this.btnSaveAnimal = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtFecha = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.btnExitAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExitAnimal
            // 
            this.btnExitAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExitAnimal.Image = global::ZooApp.Properties.Resources.close;
            this.btnExitAnimal.Location = new System.Drawing.Point(305, 2);
            this.btnExitAnimal.Name = "btnExitAnimal";
            this.btnExitAnimal.Size = new System.Drawing.Size(25, 25);
            this.btnExitAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExitAnimal.TabIndex = 3;
            this.btnExitAnimal.TabStop = false;
            this.btnExitAnimal.Click += new System.EventHandler(this.btnExitAnimal_Click);
            // 
            // lblAnimal
            // 
            this.lblAnimal.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.ForeColor = System.Drawing.Color.White;
            this.lblAnimal.Location = new System.Drawing.Point(4, 30);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(327, 24);
            this.lblAnimal.TabIndex = 13;
            this.lblAnimal.Text = "Agregar Animal";
            this.lblAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdAnimal
            // 
            this.lblIdAnimal.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdAnimal.ForeColor = System.Drawing.Color.White;
            this.lblIdAnimal.Location = new System.Drawing.Point(12, 9);
            this.lblIdAnimal.Name = "lblIdAnimal";
            this.lblIdAnimal.Size = new System.Drawing.Size(15, 32);
            this.lblIdAnimal.TabIndex = 14;
            this.lblIdAnimal.Text = "0";
            this.lblIdAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIdAnimal.Visible = false;
            // 
            // controllerAnimalForm
            // 
            this.controllerAnimalForm.Fixed = true;
            this.controllerAnimalForm.Horizontal = true;
            this.controllerAnimalForm.TargetControl = this;
            this.controllerAnimalForm.Vertical = true;
            // 
            // txtAnimalName
            // 
            this.txtAnimalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnimalName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnimalName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalName.ForeColor = System.Drawing.Color.White;
            this.txtAnimalName.HintForeColor = System.Drawing.Color.White;
            this.txtAnimalName.HintText = "Nombre";
            this.txtAnimalName.isPassword = false;
            this.txtAnimalName.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAnimalName.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAnimalName.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAnimalName.LineThickness = 4;
            this.txtAnimalName.Location = new System.Drawing.Point(16, 90);
            this.txtAnimalName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnimalName.Name = "txtAnimalName";
            this.txtAnimalName.Size = new System.Drawing.Size(303, 38);
            this.txtAnimalName.TabIndex = 15;
            this.txtAnimalName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAnimalNameC
            // 
            this.txtAnimalNameC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnimalNameC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnimalNameC.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnimalNameC.ForeColor = System.Drawing.Color.White;
            this.txtAnimalNameC.HintForeColor = System.Drawing.Color.White;
            this.txtAnimalNameC.HintText = "Nombre cientifico";
            this.txtAnimalNameC.isPassword = false;
            this.txtAnimalNameC.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAnimalNameC.LineIdleColor = System.Drawing.Color.Gray;
            this.txtAnimalNameC.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtAnimalNameC.LineThickness = 4;
            this.txtAnimalNameC.Location = new System.Drawing.Point(17, 153);
            this.txtAnimalNameC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAnimalNameC.Name = "txtAnimalNameC";
            this.txtAnimalNameC.Size = new System.Drawing.Size(303, 34);
            this.txtAnimalNameC.TabIndex = 16;
            this.txtAnimalNameC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbSex.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.ForeColor = System.Drawing.Color.White;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Macho",
            "Hembra"});
            this.cbSex.Location = new System.Drawing.Point(17, 221);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(303, 27);
            this.cbSex.TabIndex = 17;
            // 
            // cbHabitat
            // 
            this.cbHabitat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbHabitat.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHabitat.ForeColor = System.Drawing.Color.White;
            this.cbHabitat.FormattingEnabled = true;
            this.cbHabitat.Items.AddRange(new object[] {
            "Terrestre",
            "Aereo",
            "Acuatico"});
            this.cbHabitat.Location = new System.Drawing.Point(16, 326);
            this.cbHabitat.Name = "cbHabitat";
            this.cbHabitat.Size = new System.Drawing.Size(303, 27);
            this.cbHabitat.TabIndex = 19;
            // 
            // cbSpecies
            // 
            this.cbSpecies.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cbSpecies.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpecies.ForeColor = System.Drawing.Color.White;
            this.cbSpecies.FormattingEnabled = true;
            this.cbSpecies.Items.AddRange(new object[] {
            "Mamifero",
            "Ave",
            "Reptil",
            "Anfibio"});
            this.cbSpecies.Location = new System.Drawing.Point(16, 273);
            this.cbSpecies.Name = "cbSpecies";
            this.cbSpecies.Size = new System.Drawing.Size(303, 27);
            this.cbSpecies.TabIndex = 20;
            // 
            // btnSaveAnimal
            // 
            this.btnSaveAnimal.ActiveBorderThickness = 1;
            this.btnSaveAnimal.ActiveCornerRadius = 20;
            this.btnSaveAnimal.ActiveFillColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveAnimal.ActiveForecolor = System.Drawing.Color.White;
            this.btnSaveAnimal.ActiveLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveAnimal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSaveAnimal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAnimal.BackgroundImage")));
            this.btnSaveAnimal.ButtonText = "Guardar";
            this.btnSaveAnimal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAnimal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAnimal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveAnimal.IdleBorderThickness = 1;
            this.btnSaveAnimal.IdleCornerRadius = 20;
            this.btnSaveAnimal.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveAnimal.IdleForecolor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveAnimal.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.btnSaveAnimal.Location = new System.Drawing.Point(70, 403);
            this.btnSaveAnimal.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveAnimal.Name = "btnSaveAnimal";
            this.btnSaveAnimal.Size = new System.Drawing.Size(181, 41);
            this.btnSaveAnimal.TabIndex = 21;
            this.btnSaveAnimal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveAnimal.Click += new System.EventHandler(this.btnSaveAnimal_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFecha.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.Color.White;
            this.txtFecha.HintForeColor = System.Drawing.Color.White;
            this.txtFecha.HintText = "Fecha de Nacimiento";
            this.txtFecha.isPassword = false;
            this.txtFecha.LineFocusedColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFecha.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFecha.LineMouseHoverColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtFecha.LineThickness = 4;
            this.txtFecha.Location = new System.Drawing.Point(16, 361);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(303, 34);
            this.txtFecha.TabIndex = 22;
            this.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Animal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(332, 458);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnSaveAnimal);
            this.Controls.Add(this.cbSpecies);
            this.Controls.Add(this.cbHabitat);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtAnimalNameC);
            this.Controls.Add(this.txtAnimalName);
            this.Controls.Add(this.lblIdAnimal);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.btnExitAnimal);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Animal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Animal";
            this.Load += new System.EventHandler(this.Animal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnExitAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnExitAnimal;
        public Bunifu.Framework.UI.BunifuCustomLabel lblAnimal;
        public Bunifu.Framework.UI.BunifuCustomLabel lblIdAnimal;
        private Bunifu.Framework.UI.BunifuDragControl controllerAnimalForm;
        public System.Windows.Forms.ComboBox cbSex;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtAnimalNameC;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtAnimalName;
        public System.Windows.Forms.ComboBox cbSpecies;
        public System.Windows.Forms.ComboBox cbHabitat;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txtFecha;
        public Bunifu.Framework.UI.BunifuThinButton2 btnSaveAnimal;
    }
}