namespace ShaolinMatadorDePorco
{
    partial class Form2
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
            this.pColorMSG = new System.Windows.Forms.Panel();
            this.lblTituloMSG = new System.Windows.Forms.Label();
            this.lblDescMSG = new System.Windows.Forms.Label();
            this.pbImgMSG = new System.Windows.Forms.PictureBox();
            this.TimerMSG = new System.Windows.Forms.Timer(this.components);
            this.timerTchauMSG = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgMSG)).BeginInit();
            this.SuspendLayout();
            // 
            // pColorMSG
            // 
            this.pColorMSG.BackColor = System.Drawing.Color.BlueViolet;
            this.pColorMSG.Dock = System.Windows.Forms.DockStyle.Left;
            this.pColorMSG.Location = new System.Drawing.Point(0, 0);
            this.pColorMSG.Name = "pColorMSG";
            this.pColorMSG.Size = new System.Drawing.Size(10, 59);
            this.pColorMSG.TabIndex = 0;
            // 
            // lblTituloMSG
            // 
            this.lblTituloMSG.AutoSize = true;
            this.lblTituloMSG.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloMSG.Location = new System.Drawing.Point(73, 7);
            this.lblTituloMSG.Name = "lblTituloMSG";
            this.lblTituloMSG.Size = new System.Drawing.Size(51, 20);
            this.lblTituloMSG.TabIndex = 2;
            this.lblTituloMSG.Text = "MAPA";
            // 
            // lblDescMSG
            // 
            this.lblDescMSG.AutoSize = true;
            this.lblDescMSG.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescMSG.Location = new System.Drawing.Point(75, 27);
            this.lblDescMSG.Name = "lblDescMSG";
            this.lblDescMSG.Size = new System.Drawing.Size(174, 26);
            this.lblDescMSG.TabIndex = 3;
            this.lblDescMSG.Text = "Cheque seu mapa! \r\nInimigos podem estar por perto!";
            // 
            // pbImgMSG
            // 
            this.pbImgMSG.Image = global::ShaolinMatadorDePorco.Properties.Resources._4ec8a504104f380be70180fbd38b34df;
            this.pbImgMSG.Location = new System.Drawing.Point(17, 6);
            this.pbImgMSG.Name = "pbImgMSG";
            this.pbImgMSG.Size = new System.Drawing.Size(50, 46);
            this.pbImgMSG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImgMSG.TabIndex = 1;
            this.pbImgMSG.TabStop = false;
            // 
            // TimerMSG
            // 
            this.TimerMSG.Enabled = true;
            this.TimerMSG.Interval = 10;
            this.TimerMSG.Tick += new System.EventHandler(this.TimerMSG_Tick);
            // 
            // timerTchauMSG
            // 
            this.timerTchauMSG.Interval = 20;
            this.timerTchauMSG.Tick += new System.EventHandler(this.timerTchauMSG_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 59);
            this.Controls.Add(this.lblDescMSG);
            this.Controls.Add(this.lblTituloMSG);
            this.Controls.Add(this.pbImgMSG);
            this.Controls.Add(this.pColorMSG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImgMSG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pColorMSG;
        private System.Windows.Forms.PictureBox pbImgMSG;
        private System.Windows.Forms.Label lblTituloMSG;
        private System.Windows.Forms.Label lblDescMSG;
        private System.Windows.Forms.Timer TimerMSG;
        private System.Windows.Forms.Timer timerTchauMSG;
    }
}