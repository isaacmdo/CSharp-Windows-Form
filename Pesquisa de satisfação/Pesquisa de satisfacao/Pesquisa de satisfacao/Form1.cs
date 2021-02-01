using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pesquisa_de_satisfacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsim_Click(object sender, EventArgs e)
        {
            int contador;
            contador = Convert.ToInt16(contsim.Text) + 1;

            contsim.Text = Convert.ToString(contador);
        }

        private void btnnao_Click(object sender, EventArgs e)
        {
            int contador;
            contador = Convert.ToInt16(contnao.Text) + 1;

            contnao.Text = Convert.ToString(contador);
        }
    }
}
