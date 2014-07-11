namespace CovGym
{
    partial class frmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.rbName = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.txtForma = new System.Windows.Forms.TextBox();
            this.lbForma = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.lbTituloBus = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lvBuscar = new System.Windows.Forms.ListView();
            this.clmCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmResultado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbName
            // 
            this.rbName.AutoSize = true;
            this.rbName.BackColor = System.Drawing.Color.Transparent;
            this.rbName.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbName.Location = new System.Drawing.Point(160, 85);
            this.rbName.Name = "rbName";
            this.rbName.Size = new System.Drawing.Size(85, 25);
            this.rbName.TabIndex = 0;
            this.rbName.TabStop = true;
            this.rbName.Text = "Nombre";
            this.rbName.UseVisualStyleBackColor = false;
            this.rbName.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.BackColor = System.Drawing.Color.Transparent;
            this.rbCodigo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.rbCodigo.Location = new System.Drawing.Point(251, 85);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(79, 25);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = false;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // txtForma
            // 
            this.txtForma.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtForma.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtForma.Location = new System.Drawing.Point(119, 128);
            this.txtForma.Name = "txtForma";
            this.txtForma.Size = new System.Drawing.Size(296, 27);
            this.txtForma.TabIndex = 1;
            // 
            // lbForma
            // 
            this.lbForma.AutoSize = true;
            this.lbForma.BackColor = System.Drawing.Color.Transparent;
            this.lbForma.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForma.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbForma.Location = new System.Drawing.Point(19, 128);
            this.lbForma.Name = "lbForma";
            this.lbForma.Size = new System.Drawing.Size(0, 24);
            this.lbForma.TabIndex = 2;
            this.lbForma.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModificar.Location = new System.Drawing.Point(197, 375);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 38);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Transparent;
            this.btnVer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVer.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVer.Location = new System.Drawing.Point(101, 375);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(88, 38);
            this.btnVer.TabIndex = 3;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // lbTituloBus
            // 
            this.lbTituloBus.AutoSize = true;
            this.lbTituloBus.BackColor = System.Drawing.Color.Transparent;
            this.lbTituloBus.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTituloBus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbTituloBus.Location = new System.Drawing.Point(143, 19);
            this.lbTituloBus.Name = "lbTituloBus";
            this.lbTituloBus.Size = new System.Drawing.Size(0, 20);
            this.lbTituloBus.TabIndex = 25;
            this.lbTituloBus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminar.Location = new System.Drawing.Point(302, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 38);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Cancelar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lvBuscar
            // 
            this.lvBuscar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCode,
            this.clmName,
            this.clmFecha,
            this.clmHora,
            this.clmResultado});
            this.lvBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvBuscar.FullRowSelect = true;
            this.lvBuscar.GridLines = true;
            this.lvBuscar.Location = new System.Drawing.Point(45, 208);
            this.lvBuscar.MultiSelect = false;
            this.lvBuscar.Name = "lvBuscar";
            this.lvBuscar.Size = new System.Drawing.Size(469, 145);
            this.lvBuscar.TabIndex = 27;
            this.lvBuscar.UseCompatibleStateImageBehavior = false;
            this.lvBuscar.View = System.Windows.Forms.View.Details;
            this.lvBuscar.SelectedIndexChanged += new System.EventHandler(this.lvBuscar_SelectedIndexChanged);
            // 
            // clmCode
            // 
            this.clmCode.Text = "Código";
            this.clmCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCode.Width = 82;
            // 
            // clmName
            // 
            this.clmName.Text = "Nombre";
            this.clmName.Width = 380;
            // 
            // clmFecha
            // 
            this.clmFecha.Text = "";
            this.clmFecha.Width = 1;
            // 
            // clmHora
            // 
            this.clmHora.Text = "Hora";
            // 
            // clmResultado
            // 
            this.clmResultado.Text = "Resultado";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::CovGym.Properties.Resources._1402823985_search;
            this.btnBuscar.Location = new System.Drawing.Point(418, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(42, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(547, 438);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lvBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbTituloBus);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtForma);
            this.Controls.Add(this.lbForma);
            this.Controls.Add(this.rbCodigo);
            this.Controls.Add(this.rbName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtForma;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnVer;
        public System.Windows.Forms.RadioButton rbName;
        public System.Windows.Forms.RadioButton rbCodigo;
        public System.Windows.Forms.Label lbForma;
        public System.Windows.Forms.Label lbTituloBus;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ListView lvBuscar;
        private System.Windows.Forms.ColumnHeader clmCode;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ColumnHeader clmFecha;
        private System.Windows.Forms.ColumnHeader clmHora;
        private System.Windows.Forms.ColumnHeader clmResultado;
    }
}