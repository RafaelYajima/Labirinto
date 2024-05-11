namespace Labirinto
{
    partial class frmSalaQuatro
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
            this.btnSala5 = new System.Windows.Forms.Button();
            this.btnSala1 = new System.Windows.Forms.Button();
            this.armadilha = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSala5
            // 
            this.btnSala5.Location = new System.Drawing.Point(382, 498);
            this.btnSala5.Name = "btnSala5";
            this.btnSala5.Size = new System.Drawing.Size(113, 34);
            this.btnSala5.TabIndex = 3;
            this.btnSala5.Text = "Porta";
            this.btnSala5.UseVisualStyleBackColor = true;
            this.btnSala5.Click += new System.EventHandler(this.btnSala5_Click);
            // 
            // btnSala1
            // 
            this.btnSala1.Location = new System.Drawing.Point(12, 190);
            this.btnSala1.Name = "btnSala1";
            this.btnSala1.Size = new System.Drawing.Size(35, 133);
            this.btnSala1.TabIndex = 4;
            this.btnSala1.Text = "P\r\no\r\nr\r\nt\r\na";
            this.btnSala1.UseVisualStyleBackColor = true;
            this.btnSala1.Click += new System.EventHandler(this.btnSala1_Click);
            // 
            // armadilha
            // 
            this.armadilha.Location = new System.Drawing.Point(831, 190);
            this.armadilha.Name = "armadilha";
            this.armadilha.Size = new System.Drawing.Size(35, 133);
            this.armadilha.TabIndex = 5;
            this.armadilha.Text = "P\r\no\r\nr\r\nt\r\na";
            this.armadilha.UseVisualStyleBackColor = true;
            this.armadilha.Click += new System.EventHandler(this.armadilha_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Labirinto.Properties.Resources.fundo1;
            this.pictureBox1.Location = new System.Drawing.Point(-33, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(912, 552);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmSalaQuatro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.armadilha);
            this.Controls.Add(this.btnSala1);
            this.Controls.Add(this.btnSala5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSalaQuatro";
            this.Text = "Sala 4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSala5;
        private System.Windows.Forms.Button btnSala1;
        private System.Windows.Forms.Button armadilha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}