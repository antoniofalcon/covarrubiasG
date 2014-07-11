namespace CovGym
{
    partial class frmEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntradas));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lbForma = new System.Windows.Forms.Label();
            this.btnCancelarEn = new System.Windows.Forms.Button();
            this.btnAceptarEn = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbValid = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbEnt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbValid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCodigo.Location = new System.Drawing.Point(140, 57);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(107, 27);
            this.txtCodigo.TabIndex = 5;
            // 
            // lbForma
            // 
            this.lbForma.AutoSize = true;
            this.lbForma.BackColor = System.Drawing.Color.Transparent;
            this.lbForma.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbForma.Location = new System.Drawing.Point(48, 56);
            this.lbForma.Name = "lbForma";
            this.lbForma.Size = new System.Drawing.Size(86, 24);
            this.lbForma.TabIndex = 4;
            this.lbForma.Text = "Código:";
            this.lbForma.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancelarEn
            // 
            this.btnCancelarEn.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarEn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelarEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarEn.FlatAppearance.BorderSize = 0;
            this.btnCancelarEn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarEn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarEn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelarEn.Location = new System.Drawing.Point(169, 314);
            this.btnCancelarEn.Name = "btnCancelarEn";
            this.btnCancelarEn.Size = new System.Drawing.Size(88, 38);
            this.btnCancelarEn.TabIndex = 26;
            this.btnCancelarEn.Text = "Cancelar";
            this.btnCancelarEn.UseVisualStyleBackColor = false;
            // 
            // btnAceptarEn
            // 
            this.btnAceptarEn.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarEn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptarEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarEn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarEn.FlatAppearance.BorderSize = 0;
            this.btnAceptarEn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptarEn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptarEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarEn.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarEn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarEn.Location = new System.Drawing.Point(73, 314);
            this.btnAceptarEn.Name = "btnAceptarEn";
            this.btnAceptarEn.Size = new System.Drawing.Size(88, 38);
            this.btnAceptarEn.TabIndex = 25;
            this.btnAceptarEn.Text = "Aceptar";
            this.btnAceptarEn.UseVisualStyleBackColor = false;
            this.btnAceptarEn.Click += new System.EventHandler(this.btnAceptarEn_Click);
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtFecha.Location = new System.Drawing.Point(140, 90);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(107, 27);
            this.txtFecha.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(60, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtHora.Location = new System.Drawing.Point(140, 123);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(107, 27);
            this.txtHora.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(70, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Hora:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbValid
            // 
            this.pbValid.BackColor = System.Drawing.Color.Transparent;
            this.pbValid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbValid.Location = new System.Drawing.Point(93, 169);
            this.pbValid.Name = "pbValid";
            this.pbValid.Size = new System.Drawing.Size(154, 128);
            this.pbValid.TabIndex = 31;
            this.pbValid.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbEnt
            // 
            this.lbEnt.AutoSize = true;
            this.lbEnt.BackColor = System.Drawing.Color.Transparent;
            this.lbEnt.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbEnt.Location = new System.Drawing.Point(48, 9);
            this.lbEnt.Name = "lbEnt";
            this.lbEnt.Size = new System.Drawing.Size(0, 24);
            this.lbEnt.TabIndex = 32;
            this.lbEnt.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(331, 359);
            this.Controls.Add(this.lbEnt);
            this.Controls.Add(this.pbValid);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarEn);
            this.Controls.Add(this.btnAceptarEn);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lbForma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.frmEntradas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbValid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lbForma;
        private System.Windows.Forms.Button btnCancelarEn;
        private System.Windows.Forms.Button btnAceptarEn;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbValid;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbEnt;
    }
}