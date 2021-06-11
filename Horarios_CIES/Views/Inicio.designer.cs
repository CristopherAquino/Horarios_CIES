
namespace Horarios_CIES.Views
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblHora = new System.Windows.Forms.Label();
            this.lbFecha = new System.Windows.Forms.Label();
            this.ImgLogo = new System.Windows.Forms.PictureBox();
            this.timerH = new System.Windows.Forms.Timer(this.components);
            this.timerF = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblHora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblHora.Location = new System.Drawing.Point(482, 451);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(133, 37);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00: 00: 00";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lbFecha.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbFecha.Location = new System.Drawing.Point(326, 500);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(254, 45);
            this.lbFecha.TabIndex = 1;
            this.lbFecha.Text = "                          ";
            this.lbFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImgLogo
            // 
            this.ImgLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ImgLogo.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo.Image")));
            this.ImgLogo.Location = new System.Drawing.Point(333, 182);
            this.ImgLogo.Name = "ImgLogo";
            this.ImgLogo.Size = new System.Drawing.Size(431, 256);
            this.ImgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo.TabIndex = 2;
            this.ImgLogo.TabStop = false;
            // 
            // timerH
            // 
            this.timerH.Enabled = true;
            this.timerH.Tick += new System.EventHandler(this.timerHF_Tick);
            // 
            // timerF
            // 
            this.timerF.Enabled = true;
            this.timerF.Tick += new System.EventHandler(this.timerF_Tick);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1097, 621);
            this.Controls.Add(this.ImgLogo);
            this.Controls.Add(this.lbFecha);
            this.Controls.Add(this.lblHora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.PictureBox ImgLogo;
        private System.Windows.Forms.Timer timerH;
        private System.Windows.Forms.Timer timerF;
    }
}