namespace ProjetoQuiz
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muito bem ! ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label2.Location = new System.Drawing.Point(43, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resultado: ";
            // 
            // lblNome
            // 
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblNome.Location = new System.Drawing.Point(230, 28);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(558, 58);
            this.lblNome.TabIndex = 3;
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.Location = new System.Drawing.Point(177, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 58);
            this.label3.TabIndex = 4;
            this.label3.Text = "Você conclui o formulário";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblResult.Location = new System.Drawing.Point(43, 304);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 39);
            this.lblResult.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label4.Location = new System.Drawing.Point(34, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 39);
            this.label4.TabIndex = 6;
            this.label4.Text = "RA: ";
            // 
            // lblRa
            // 
            this.lblRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblRa.Location = new System.Drawing.Point(123, 72);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(430, 39);
            this.lblRa.TabIndex = 7;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRa;
    }
}