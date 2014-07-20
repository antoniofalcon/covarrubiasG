namespace CovGym
{
    partial class frmMensualidad
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
            this.lbMensualidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClienteMen = new System.Windows.Forms.ComboBox();
            this.cmbMemMen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFecInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelMen = new System.Windows.Forms.Button();
            this.btnAceptarMen = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMensualidad
            // 
            this.lbMensualidad.AutoSize = true;
            this.lbMensualidad.BackColor = System.Drawing.Color.Transparent;
            this.lbMensualidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMensualidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMensualidad.Location = new System.Drawing.Point(141, 34);
            this.lbMensualidad.Name = "lbMensualidad";
            this.lbMensualidad.Size = new System.Drawing.Size(0, 26);
            this.lbMensualidad.TabIndex = 29;
            this.lbMensualidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(153, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbClienteMen
            // 
            this.cmbClienteMen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClienteMen.Enabled = false;
            this.cmbClienteMen.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClienteMen.FormattingEnabled = true;
            this.cmbClienteMen.Location = new System.Drawing.Point(244, 118);
            this.cmbClienteMen.Name = "cmbClienteMen";
            this.cmbClienteMen.Size = new System.Drawing.Size(263, 28);
            this.cmbClienteMen.TabIndex = 30;
            this.cmbClienteMen.SelectedIndexChanged += new System.EventHandler(this.cmbClienteMen_SelectedIndexChanged);
            // 
            // cmbMemMen
            // 
            this.cmbMemMen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMemMen.Enabled = false;
            this.cmbMemMen.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMemMen.FormattingEnabled = true;
            this.cmbMemMen.Location = new System.Drawing.Point(244, 151);
            this.cmbMemMen.Name = "cmbMemMen";
            this.cmbMemMen.Size = new System.Drawing.Size(263, 28);
            this.cmbMemMen.TabIndex = 34;
            this.cmbMemMen.SelectedIndexChanged += new System.EventHandler(this.cmbMemMen_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(116, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 33;
            this.label2.Text = "Membresía:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtFecInicio
            // 
            this.dtFecInicio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFecInicio.Enabled = false;
            this.dtFecInicio.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecInicio.Location = new System.Drawing.Point(244, 219);
            this.dtFecInicio.Name = "dtFecInicio";
            this.dtFecInicio.Size = new System.Drawing.Size(200, 27);
            this.dtFecInicio.TabIndex = 36;
            this.dtFecInicio.ValueChanged += new System.EventHandler(this.dtFecInicio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(9, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Fecha de Vencimiento:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtFecVencimiento
            // 
            this.dtFecVencimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFecVencimiento.Enabled = false;
            this.dtFecVencimiento.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFecVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecVencimiento.Location = new System.Drawing.Point(244, 252);
            this.dtFecVencimiento.Name = "dtFecVencimiento";
            this.dtFecVencimiento.Size = new System.Drawing.Size(200, 27);
            this.dtFecVencimiento.TabIndex = 38;
            this.dtFecVencimiento.ValueChanged += new System.EventHandler(this.dtFecVencimiento_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(73, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fecha de Inicio:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnCancelMen
            // 
            this.btnCancelMen.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelMen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelMen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelMen.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelMen.FlatAppearance.BorderSize = 0;
            this.btnCancelMen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelMen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelMen.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelMen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelMen.Location = new System.Drawing.Point(322, 300);
            this.btnCancelMen.Name = "btnCancelMen";
            this.btnCancelMen.Size = new System.Drawing.Size(88, 38);
            this.btnCancelMen.TabIndex = 40;
            this.btnCancelMen.Text = "Cancelar";
            this.btnCancelMen.UseVisualStyleBackColor = false;
            // 
            // btnAceptarMen
            // 
            this.btnAceptarMen.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarMen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptarMen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptarMen.Enabled = false;
            this.btnAceptarMen.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarMen.FlatAppearance.BorderSize = 0;
            this.btnAceptarMen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAceptarMen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAceptarMen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptarMen.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarMen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAceptarMen.Location = new System.Drawing.Point(129, 300);
            this.btnAceptarMen.Name = "btnAceptarMen";
            this.btnAceptarMen.Size = new System.Drawing.Size(88, 38);
            this.btnAceptarMen.TabIndex = 39;
            this.btnAceptarMen.Text = "Aceptar";
            this.btnAceptarMen.UseVisualStyleBackColor = false;
            this.btnAceptarMen.Click += new System.EventHandler(this.btnAceptarMen_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnImprimir.Location = new System.Drawing.Point(225, 300);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(88, 38);
            this.btnImprimir.TabIndex = 41;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CovGym.Properties.Resources._1402823985_search;
            this.btnBuscar.Location = new System.Drawing.Point(465, 84);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 29);
            this.btnBuscar.TabIndex = 59;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(244, 85);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 27);
            this.txtName.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(144, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 24);
            this.label11.TabIndex = 60;
            this.label11.Text = "Nombre:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCosto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCosto.Location = new System.Drawing.Point(244, 185);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(200, 27);
            this.txtCosto.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(165, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 62;
            this.label5.Text = "Costo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmMensualidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(529, 352);
            this.Controls.Add(this.txtCosto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelMen);
            this.Controls.Add(this.btnAceptarMen);
            this.Controls.Add(this.dtFecVencimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtFecInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbMemMen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClienteMen);
            this.Controls.Add(this.lbMensualidad);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(545, 391);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(545, 391);
            this.Name = "frmMensualidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Mensualidad";
            this.Load += new System.EventHandler(this.frmMensualidad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbMensualidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClienteMen;
        private System.Windows.Forms.ComboBox cmbMemMen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFecInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecVencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelMen;
        private System.Windows.Forms.Button btnAceptarMen;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label label5;
    }
}