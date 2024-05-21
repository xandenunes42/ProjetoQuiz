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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (cCerta.Checked)
            {
                Form1.acertos++;
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                Form1.erros++;
                Form3 f3 = new Form3();
                f3.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Valores invalidos ! Selecione um checkbox");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
