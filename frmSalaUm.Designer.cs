namespace Labirinto
{
    partial class frmSalaUm
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
            this.btnSala2 = new System.Windows.Forms.Button();
            this.armadilha = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSala4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSala2
            // 
            this.btnSala2.Location = new System.Drawing.Point(382, 3);
            this.btnSala2.Name = "btnSala2";
            this.btnSala2.Size = new System.Drawing.Size(113, 34);
            this.btnSala2.TabIndex = 0;
            this.btnSala2.Text = "Porta";
            this.btnSala2.UseVisualStyleBackColor = true;
            this.btnSala2.Click += new System.EventHandler(this.btnSala2_Click);
            // 
            // armadilha
            // 
            this.armadilha.Location = new System.Drawing.Point(382, 498);
            this.armadilha.Name = "armadilha";
            this.armadilha.Size = new System.Drawing.Size(113, 34);
            this.armadilha.TabIndex = 1;
            this.armadilha.Text = "Porta";
            this.armadilha.UseVisualStyleBackColor = true;
            this.armadilha.Click += new System.EventHandler(this.armadilha_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Armadilha";
            this.label1.Visible = false;
            // 
            // btnSala4
            // 
            this.btnSala4.Location = new System.Drawing.Point(831, 205);
            this.btnSala4.Name = "btnSala4";
            this.btnSala4.Size = new System.Drawing.Size(35, 133);
            this.btnSala4.TabIndex = 3;
            this.btnSala4.Text = "P\r\no\r\nr\r\nt\r\na";
            this.btnSala4.UseVisualStyleBackColor = true;
            this.btnSala4.Click += new System.EventHandler(this.btnSala4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "sala2";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(778, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "sala4";
            this.label3.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Labirinto.Properties.Resources.fundo1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-29, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 546);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmSalaUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSala4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.armadilha);
            this.Controls.Add(this.btnSala2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSalaUm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSala2;
        private System.Windows.Forms.Button armadilha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSala4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}