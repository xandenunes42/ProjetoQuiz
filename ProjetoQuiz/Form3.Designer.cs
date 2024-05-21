namespace ProjetoQuiz
{
    partial class Form3
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
            this.btnAvancar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cCerta = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnAvancar
            // 
            this.btnAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnAvancar.Location = new System.Drawing.Point(610, 370);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(125, 50);
            this.btnAvancar.TabIndex = 0;
            this.btnAvancar.Text = "Avançar";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(53, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 112);
            this.label1.TabIndex = 1;
            this.label1.Text = "Um usuário de MS Windows 10 em português deseja, via teclas de atalho, alternar e" +
    "ntre aplicativos abertos.";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(54, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pergunta:";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton4.Location = new System.Drawing.Point(110, 340);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(162, 29);
            this.radioButton4.TabIndex = 14;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ctrl + Alt + Tab";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton3.Location = new System.Drawing.Point(110, 280);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(117, 29);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Ctrl + Tab";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.radioButton2.Location = new System.Drawing.Point(110, 160);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(168, 29);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Windows + Tab";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // cCerta
            // 
            this.cCerta.AutoSize = true;
            this.cCerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cCerta.Location = new System.Drawing.Point(110, 220);
            this.cCerta.Name = "cCerta";
            this.cCerta.Size = new System.Drawing.Size(110, 29);
            this.cCerta.TabIndex = 11;
            this.cCerta.TabStop = true;
            this.cCerta.Text = "Alt + Tab";
            this.cCerta.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.cCerta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAvancar);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton cCerta;
    }
}