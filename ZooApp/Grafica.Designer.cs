
namespace ZooApp
{
    partial class Grafica
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
            this.pieCharH = new LiveCharts.WinForms.PieChart();
            this.pieChartE = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // pieCharH
            // 
            this.pieCharH.ForeColor = System.Drawing.Color.White;
            this.pieCharH.Location = new System.Drawing.Point(99, 61);
            this.pieCharH.Name = "pieCharH";
            this.pieCharH.Size = new System.Drawing.Size(413, 196);
            this.pieCharH.TabIndex = 1;
            this.pieCharH.Text = "pieChart2";
            // 
            // pieChartE
            // 
            this.pieChartE.ForeColor = System.Drawing.Color.White;
            this.pieChartE.Location = new System.Drawing.Point(99, 317);
            this.pieChartE.Name = "pieChartE";
            this.pieChartE.Size = new System.Drawing.Size(413, 196);
            this.pieChartE.TabIndex = 2;
            this.pieChartE.Text = "pieChart2";
            // 
            // Grafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(645, 542);
            this.Controls.Add(this.pieChartE);
            this.Controls.Add(this.pieCharH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grafica";
            this.Text = "Grafica";
            this.Load += new System.EventHandler(this.Grafica_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart pieCharH;
        private LiveCharts.WinForms.PieChart pieChartE;
    }
}