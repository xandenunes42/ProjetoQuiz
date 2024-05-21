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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnAvancar_Click(object sender, EventArgs e)
        {
            if (cCerta.Checked)
            {
                Form1.acertos++;
                Form4 f4 = new Form4();
                f4.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                Form1.erros++;
                Form4 f4 = new Form4();
                f4.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Valores invalidos ! Selecione um checkbox");
            }
        }
    }
}
