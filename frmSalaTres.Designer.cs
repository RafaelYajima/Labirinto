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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaTres));
            this.armadilha = new System.Windows.Forms.Button();
            this.btnSala4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.armadilha2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // armadilha
            // 
            this.armadilha.Location = new System.Drawing.Point(831, 193);
            this.armadilha.Name = "armadilha";
            this.armadilha.Size = new System.Drawing.Size(35, 133);
            this.armadilha.TabIndex = 4;
            this.armadilha.Text = "P\r\no\r\nr\r\nt\r\na";
            this.armadilha.UseVisualStyleBackColor = true;
            this.armadilha.Click += new System.EventHandler(this.armadilha_Click);
            // 
            // btnSala4
            // 
            this.btnSala4.Location = new System.Drawing.Point(383, 498);
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
            this.label1.Location = new System.Drawing.Point(745, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Armadilha";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "sala4";
            this.label2.Visible = false;
            // 
            // armadilha2
            // 
            this.armadilha2.Location = new System.Drawing.Point(383, 12);
            this.armadilha2.Name = "armadilha2";
            this.armadilha2.Size = new System.Drawing.Size(113, 34);
            this.armadilha2.TabIndex = 8;
            this.armadilha2.Text = "Porta";
            this.armadilha2.UseVisualStyleBackColor = true;
            this.armadilha2.Click += new System.EventHandler(this.armadilha2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-29, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(914, 550);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Armadilha";
            this.label3.Visible = false;
            // 
            // frmSalaTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chartreuse;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.armadilha2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSala4);
            this.Controls.Add(this.armadilha);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSalaTres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala 3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button armadilha;
        private System.Windows.Forms.Button btnSala4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button armadilha2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}