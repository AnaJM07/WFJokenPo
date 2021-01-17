using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int jogador1;
                int jogador2;

                jogador1 = String.IsNullOrEmpty(txtJogada1.Text) ? 0 : Convert.ToInt32(txtJogada1.Text);
                jogador2 = String.IsNullOrEmpty(txtJogada2.Text) ? 0 : Convert.ToInt32(txtJogada2.Text);


                do
                {
                    if ((jogador1 == 2 && jogador2 == 1) || (jogador1 == 1 && jogador2 == 3) || (jogador1 == 3 && jogador2 == 2))
                    {
                        MessageBox.Show("Jogador 1 venceu !!!");
                        txtJogada1.Clear();
                        break;
                    }
                    else if ((jogador1 == 1 && jogador2 == 2) || (jogador1 == 3 && jogador2 == 1) || (jogador1 == 2 && jogador2 == 3))
                    {
                        MessageBox.Show("Jogador 2 venceu !!!");
                        txtJogada1.Clear();
                        break;
                       
                    }
                    else
                    {
                        MessageBox.Show("Empatou !!!");
                        txtJogada1.Clear();
                    
                        
                    }
                } while (jogador1 < 4 && jogador2 < 4);
            }
            catch (Exception)
            {
                MessageBox.Show("Jogada Invalida, tente novamente ");
            }
        }
    }
}
