namespace Labirinto
{
    partial class frmSalaDois
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
            this.btnSala3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // armadilha
            // 
            this.armadilha.Location = new System.Drawing.Point(12, 159);
            this.armadilha.Name = "armadilha";
            this.armadilha.Size = new System.Drawing.Size(35, 133);
            this.armadilha.TabIndex = 4;
            this.armadilha.Text = "P\r\no\r\nr\r\nt\r\na";
            this.armadilha.UseVisualStyleBackColor = true;
            this.armadilha.Click += new System.EventHandler(this.armadilha_Click);
            // 
            // btnSala3
            // 
            this.btnSala3.Location = new System.Drawing.Point(753, 159);
            this.btnSala3.Name = "btnSala3";
            this.btnSala3.Size = new System.Drawing.Size(35, 133);
            this.btnSala3.TabIndex = 5;
            this.btnSala3.Text = "P\r\no\r\nr\r\nt\r\na";
            this.btnSala3.UseVisualStyleBackColor = true;
            this.btnSala3.Click += new System.EventHandler(this.btnSala3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Armadilha";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(700, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "sala3";
            this.label2.Visible = false;
            // 
            // frmSalaDois
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSala3);
            this.Controls.Add(this.armadilha);
            this.Name = "frmSalaDois";
            this.Text = "Sala 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button armadilha;
        private System.Windows.Forms.Button btnSala3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}