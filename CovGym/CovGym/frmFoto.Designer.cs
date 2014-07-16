namespace CovGym
{
    partial class frmFoto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFoto));
            this.cbxDispositivos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EspacioCamara = new System.Windows.Forms.PictureBox();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxDispositivos
            // 
            this.cbxDispositivos.FormattingEnabled = true;
            this.cbxDispositivos.Location = new System.Drawing.Point(21, 227);
            this.cbxDispositivos.Name = "cbxDispositivos";
            this.cbxDispositivos.Size = new System.Drawing.Size(25, 21);
            this.cbxDispositivos.TabIndex = 5;
            this.cbxDispositivos.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.EspacioCamara);
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 209);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WebCams";
            // 
            // EspacioCamara
            // 
            this.EspacioCamara.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.EspacioCamara.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EspacioCamara.Location = new System.Drawing.Point(3, 16);
            this.EspacioCamara.Name = "EspacioCamara";
            this.EspacioCamara.Size = new System.Drawing.Size(209, 190);
            this.EspacioCamara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EspacioCamara.TabIndex = 0;
            this.EspacioCamara.TabStop = false;
            // 
            // btnCaptura
            // 
            this.btnCaptura.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCaptura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCaptura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaptura.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCaptura.FlatAppearance.BorderSize = 0;
            this.btnCaptura.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCaptura.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCaptura.Image = ((System.Drawing.Image)(resources.GetObject("btnCaptura.Image")));
            this.btnCaptura.Location = new System.Drawing.Point(189, 227);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(44, 28);
            this.btnCaptura.TabIndex = 6;
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // frmFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 264);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.cbxDispositivos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(278, 303);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(278, 303);
            this.Name = "frmFoto";
            this.Text = "Fotografía";
            this.Load += new System.EventHandler(this.frmFoto_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EspacioCamara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDispositivos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox EspacioCamara;
        private System.Windows.Forms.Button btnCaptura;
    }
}