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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(391, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Armadilha";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sala FIm";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(405, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sala 1";
            this.label3.Visible = false;
            // 
            // frmSalaSeis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalaFim);
            this.Controls.Add(this.armadilha);
            this.Controls.Add(this.btnSala1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmSalaSeis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sala 6";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSala1;
        private System.Windows.Forms.Button armadilha;
        private System.Windows.Forms.Button btnSalaFim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}