namespace Labirinto
{
    partial class frmSalaTres
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
            this.armadilha = new System.Windows.Forms.Button();
            this.btnSala4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.armadilha2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // armadilha
            // 
            this.armadilha.Location = new System.Drawing.Point(753, 153);
            this.armadilha.Name = "armadilha";
            this.armadilha.Size = new System.Drawing.Size(35, 133);
            this.armadilha.TabIndex = 4;
            this.armadilha.Text = "P\r\no\r\nr\r\nt\r\na";
            this.armadilha.UseVisualStyleBackColor = true;
            this.armadilha.Click += new System.EventHandler(this.armadilha_Click);
            // 
            // btnSala4
            // 
            this.btnSala4.Location = new System.Drawing.Point(339, 404);
            this.btnSala4.Name = "btnSala4";
            this.btnSala4.Size = new System.Drawing.Size(113, 34);
            this.btnSala4.TabIndex = 5;
            this.btnSala4.Text = "Porta";
            this.btnSala4.UseVisualStyleBackColor = true;
            this.btnSala4.Click += new System.EventHandler(this.btnSala4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Armadilha";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "sala4";
            this.label2.Visible = false;
            // 
            // armadilha2
            // 
            this.armadilha2.Location = new System.Drawing.Point(339, 12);
            this.armadilha2.Name = "armadilha2";
            this.armadilha2.Size = new System.Drawing.Size(113, 34);
            this.armadilha2.TabIndex = 8;
            this.armadilha2.Text = "Porta";
            this.armadilha2.UseVisualStyleBackColor = true;
            this.armadilha2.Click += new System.EventHandler(this.armadilha2_Click);
            // 
            // frmSalaTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.armadilha2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSala4);
            this.Controls.Add(this.armadilha);
            this.Name = "frmSalaTres";
            this.Text = "Sala 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button armadilha;
        private System.Windows.Forms.Button btnSala4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button armadilha2;
    }
}