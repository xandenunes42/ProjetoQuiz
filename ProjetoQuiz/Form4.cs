using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cCerta.Checked)
            {
                Form1.acertos++;
                Form5 f5 = new Form5();
                f5.ShowDialog();
                this.Dispose();
                Form1.acertos++;
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                Form1.erros++;
                Form5 f5 = new Form5();
                f5.ShowDialog();
                this.Dispose();
           }
            else
            {
                MessageBox.Show("Valores invalidos ! Selecione um checkbox");
            }
        }
    }  
}
