using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoQuiz
{
    public partial class Form1 : Form
    {
        public static string nome_Global = "";
        public static string ra_Global = "";
        public static int acertos = 0;
        public static int erros = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            nome_Global = txtNome.Text;
            ra_Global = txtRa.Text;

            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Dispose();
        }
    }
}
