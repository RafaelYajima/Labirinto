﻿namespace Labirinto
{
    partial class frmSalaCinco
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
            this.btnSala6 = new System.Windows.Forms.Button();
            this.armadilha2 = new System.Windows.Forms.Button();
            this.armadilha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSala6
            // 
            this.btnSala6.Location = new System.Drawing.Point(12, 161);
            this.btnSala6.Name = "btnSala6";
            this.btnSala6.Size = new System.Drawing.Size(35, 133);
            this.btnSala6.TabIndex = 4;
            this.btnSala6.Text = "P\r\no\r\nr\r\nt\r\na";
            this.btnSala6.UseVisualStyleBackColor = true;
            this.btnSala6.Click += new System.EventHandler(this.btnSala6_Click);
            // 
            // armadilha2
            // 
            this.armadilha2.Location = new System.Drawing.Point(753, 161);
            this.armadilha2.Name = "armadilha2";
            this.armadilha2.Size = new System.Drawing.Size(35, 133);
            this.armadilha2.TabIndex = 5;
            this.armadilha2.Text = "P\r\no\r\nr\r\nt\r\na";
            this.armadilha2.UseVisualStyleBackColor = true;
            this.armadilha2.Click += new System.EventHandler(this.armadilha2_Click);
            // 
            // armadilha
            // 
            this.armadilha.Location = new System.Drawing.Point(344, 404);
            this.armadilha.Name = "armadilha";
            this.armadilha.Size = new System.Drawing.Size(113, 34);
            this.armadilha.TabIndex = 6;
            this.armadilha.Text = "Porta";
            this.armadilha.UseVisualStyleBackColor = true;
            this.armadilha.Click += new System.EventHandler(this.armadilha_Click);
            // 
            // frmSalaCinco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.armadilha);
            this.Controls.Add(this.armadilha2);
            this.Controls.Add(this.btnSala6);
            this.Name = "frmSalaCinco";
            this.Text = "Sala 5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSala6;
        private System.Windows.Forms.Button armadilha2;
        private System.Windows.Forms.Button armadilha;
    }
}