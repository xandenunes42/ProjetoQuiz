namespace ProjetoQuiz
{
    partial class Form4
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
            this.btnNext = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cCerta = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNext.Location = new System.Drawing.Point(610, 370);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 52);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Avançar";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(68, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 41);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pergunta: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(67, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Qual a tecla de atalho para suspender o Windows 10:";
            // 
            // cCerta
            // 
            this.cCerta.AutoSize = true;
            this.cCerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cCerta.Location = new System.Drawing.Point(110, 340);
            this.cCerta.Name = "cCerta";
            this.cCerta.Size = new System.Drawing.Size(144, 29);
            this.cCerta.TabIndex = 18;
            this.cCerta.TabStop = true;
            this.cCerta.Text = "Windows + L";
            this.cCerta.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton3.Location = new System.Drawing.Point(110, 280);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(93, 29);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Crtl + L";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton2.Location = new System.Drawing.Point(110, 220);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(147, 29);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Windows + D";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton4.Location = new System.Drawing.Point(110, 160);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(156, 29);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ctrl + Alt + Del";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cCerta);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton cCerta;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}