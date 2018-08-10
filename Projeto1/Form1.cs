using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Projeto1 : Form
    {
        public Projeto1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbResultado.Text = "Olá mundo";
        }

        private void BtSair_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void BtExecutar_Click(object sender, EventArgs e)
        {
            Socio socio = new Socio();
            socio.nome = "Jose";
            socio.sobre_nome = "da Silva";
            socio.idade = 28;
            
            Socio socio2 = new Socio() {
                nome = "Antonio",
                sobre_nome = "Rodrigues",
                idade = 29
            };

            Socio socio3 = new Socio("Joao", "Remião", 30);

            lbResultado.Text = "Usuario: " + socio.nome + " " + socio.sobre_nome + " tem " + socio.idade + " anos de idade.";
            lbResultado.Text = lbResultado.Text + "\nUsuario2: " + socio2.nome + " " + socio2.sobre_nome + " tem " + socio2.idade + " anos de idade.";
            lbResultado.Text = lbResultado.Text + "\nUsuario3: " + socio3.nome + " " + socio3.sobre_nome + " tem " + socio3.idade + " anos de idade.";


            /*int variavel1 = 10, variavel2 = 20, idade = 30;
            double peso;

            int valor = 10;

            string nome = "Nome";

            //lbResultado.Text = valor++.ToString();
            lbResultado.Text = (++valor).ToString();


            int parcela = 2;

            lbResultado.Text = parcela++ < 3 ? "Operação Verdadeira." : "Operação Falsa";

            int parcela2 = 0;

            if (parcela2 == 0)
                goto etapa1;
            else
                goto etapa2;

            
            etapa1:
                lbResultado.Text = "Etapa 1";
            etapa2:
                lbResultado.Text = "Etapa 2";*/

            int parcela = 1;
            do
            {
                lboxResultado.Items.Add(parcela++);
            } while (parcela <= 10);

            lboxResultado.Items.Add("--------------");

            while (parcela < 20)
            {
                lboxResultado.Items.Add(parcela++);
                if(parcela == 17)
                {
                    lboxResultado.Items.Add("**********");
                    return;
                }
                else if (parcela == 16)
                {
                    lboxResultado.Items.Add("##########");
                    break;
                }
                else if (parcela == 15)
                {
                    lboxResultado.Items.Add("@@@@@@@@@@");
                    continue;
                }
            }

            lboxResultado.Items.Add("--------------");

            List<int> listaInt = new List<int>(10);

            for (int i = parcela; i < parcela + 10 ; i++)
            {
                lboxResultado.Items.Add(i);
                listaInt.Add(i + 10);
            }

            lboxResultado.Items.Add("--------------");

            foreach (int i in listaInt)
            {
                lboxResultado.Items.Add(i);
            }

            /*long parcela2 = 100;

            int parcela3 = Convert.ToInt32(parcela2);

            lbResultado.Text = parcela2.ToString();*/


            /*int valor = 0;
            bool condicao = Convert.ToBoolean(valor);
            lbResultado.Text = condicao.ToString();*/

            /*string palavra = "false";
            bool condicao = Convert.ToBoolean(palavra);
            lbResultado.Text = condicao.ToString();*/

            /*bool valor = false;
            int condicao = Convert.ToInt16(valor);
            lbResultado.Text = condicao.ToString();*/
        }
    }
}

