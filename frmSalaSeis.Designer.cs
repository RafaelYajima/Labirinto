namespace Labirinto
{
    partial class frmSalaSeis
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
            this.btnSala1 = new System.Windows.Forms.Button();
            this.armadilha = new System.Windows.Forms.Button();
            this.btnSalaFim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSala1
            // 
            this.btnSala1.Location = new System.Drawing.Point(384, 12);
            this.btnSala1.Name = "btnSala1";
            this.btnSala1.Size = new System.Drawing.Size(113, 34);
            this.btnSala1.TabIndex = 1;
            this.btnSala1.Text = "Porta";
            this.btnSala1.UseVisualStyleBackColor = true;
            this.btnSala1.Click += new System.EventHandler(this.btnSala1_Click);
            // 
            // armadilha
            // 
            this.armadilha.Location = new System.Drawing.Point(384, 498);
            this.armadilha.Name = "armadilha";
            this.armadilha.Size = new System.Drawing.Size(113, 34);
            this.armadilha.TabIndex = 2;
            this.armadilha.Text = "Porta";
            this.armadilha.UseVisualStyleBackColor = true;
            this.armadilha.Click += new System.EventHandler(this.armadilha_Click);
            // 
            // btnSalaFim
            // 
            this.btnSalaFim.Location = new System.Drawing.Point(12, 214);
            this.btnSalaFim.Name = "btnSalaFim";
            this.btnSalaFim.Size = new System.Drawing.Size(35, 133);
            this.btnSalaFim.TabIndex = 4;
            this.btnSalaFim.Text = "P\r\no\r\nr\r\nt\r\na";
            this.btnSalaFim.UseVisualStyleBackColor = true;
            this.btnSalaFim.Click += new System.EventHandler(this.btnSalaFim_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Labirinto.Properties.Resources.fundo2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-32, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(916, 553);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmSalaSeis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.btnSalaFim);
            this.Controls.Add(this.armadilha);
            this.Controls.Add(this.btnSala1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSalaSeis";
            this.Text = "Sala 6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSala1;
        private System.Windows.Forms.Button armadilha;
        private System.Windows.Forms.Button btnSalaFim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}