namespace ProjetoQuiz
{
    partial class Form2
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
            this.btnNext = new System.Windows.Forms.Button();
            this.cCerta = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(667, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qual dos seguintes atalhos é utilizado para copiar um item selecionado no Windows" +
    "? ";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(54, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pergunta: ";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnNext.Location = new System.Drawing.Point(610, 370);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 50);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Avançar";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cCerta
            // 
            this.cCerta.AutoSize = true;
            this.cCerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cCerta.Location = new System.Drawing.Point(110, 160);
            this.cCerta.Name = "cCerta";
            this.cCerta.Size = new System.Drawing.Size(97, 29);
            this.cCerta.TabIndex = 7;
            this.cCerta.TabStop = true;
            this.cCerta.Text = "Ctrl + C";
            this.cCerta.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton2.Location = new System.Drawing.Point(110, 220);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(148, 29);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Windows + C";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton3.Location = new System.Drawing.Point(110, 280);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(90, 29);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Alt + C";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton4.Location = new System.Drawing.Point(110, 340);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(96, 29);
            this.radioButton4.TabIndex = 10;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ctrl + V";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.cCerta);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton cCerta;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}