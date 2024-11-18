using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contagem_de_233a456
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbResultado1.Items.Clear();
            for (int i = 233; i <= 456; i++)
            {
                lsbResultado1.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsbResultado2.Items.Clear();
            for (int i = 300; i <= 400; i += 3)
            {
                lsbResultado2.Items.Add(i);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbResultado1.Items.Clear();
            lsbResultado2.Items.Clear();
            lsbResultado3.Items.Clear();
        }

        private void btnMostrarR3_Click(object sender, EventArgs e)
        {
            for (int i = 233; i <=456; i += 5)
            {
                if (i>= 300 && i<= 400)
                {
                    continue;
                }

                lsbResultado3.Items.Add(i);
            }
        }
    }
}
