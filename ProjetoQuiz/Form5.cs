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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            lblNome.Text = Form1.nome_Global.ToString();
            lblRa.Text = Form1.ra_Global.ToString();
            lblResult.Text = $"Acertos: {Form1.acertos}".ToString();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
