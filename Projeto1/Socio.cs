using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Socio
    {
        public string nome;
        public string sobre_nome;
        public int idade;

        public Socio()
        {

        }
        public Socio(string n, string sn, int i)
        {
            nome = n;
            sobre_nome = sn;
            idade = i;
        }

    }
}
