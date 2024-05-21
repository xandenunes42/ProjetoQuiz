namespace ProjetoQuiz
{
    partial class Form1
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
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Projeto Quiz ";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(421, 419);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(167, 84);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = "Clique em Iniciar para começar responder o formulário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Informe seu nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Informe o RA: ";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(279, 136);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(495, 38);
            this.txtNome.TabIndex = 5;
            // 
            // txtRa
            // 
            this.txtRa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtRa.Location = new System.Drawing.Point(219, 270);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(466, 38);
            this.txtRa.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 590);
            this.Controls.Add(this.txtRa);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRa;
    }
}

