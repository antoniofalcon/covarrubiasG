﻿namespace CovGym
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnAcceso = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCancelAcc = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(75, 205);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(194, 27);
            this.txtUser.TabIndex = 0;
            this.txtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUser_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(75, 246);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(194, 27);
            this.txtPass.TabIndex = 1;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // btnAcceso
            // 
            this.btnAcceso.BackColor = System.Drawing.Color.Transparent;
            this.btnAcceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAcceso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAcceso.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcceso.FlatAppearance.BorderSize = 0;
            this.btnAcceso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAcceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAcceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceso.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcceso.ForeColor = System.Drawing.Color.White;
            this.btnAcceso.Location = new System.Drawing.Point(63, 293);
            this.btnAcceso.Name = "btnAcceso";
            this.btnAcceso.Size = new System.Drawing.Size(88, 38);
            this.btnAcceso.TabIndex = 2;
            this.btnAcceso.Text = "Entrar";
            this.btnAcceso.UseVisualStyleBackColor = false;
            this.btnAcceso.Click += new System.EventHandler(this.btnAcceso_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(42, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(42, 246);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnCancelAcc
            // 
            this.btnCancelAcc.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelAcc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAcc.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelAcc.FlatAppearance.BorderSize = 0;
            this.btnCancelAcc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAcc.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAcc.ForeColor = System.Drawing.Color.White;
            this.btnCancelAcc.Location = new System.Drawing.Point(157, 293);
            this.btnCancelAcc.Name = "btnCancelAcc";
            this.btnCancelAcc.Size = new System.Drawing.Size(88, 38);
            this.btnCancelAcc.TabIndex = 5;
            this.btnCancelAcc.Text = "Cancelar";
            this.btnCancelAcc.UseVisualStyleBackColor = false;
            this.btnCancelAcc.Click += new System.EventHandler(this.btnCancelAcc_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(63, 12);
            this.pictureBox3.MaximumSize = new System.Drawing.Size(206, 187);
            this.pictureBox3.MinimumSize = new System.Drawing.Size(206, 187);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 187);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(316, 353);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnCancelAcc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAcceso);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 392);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(332, 392);
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acceso al Sistema";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAcceso_FormClosing);
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnAcceso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCancelAcc;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}