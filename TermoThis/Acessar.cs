using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TermoThis
{
    internal class Acessar
    {
        string senha = "abc123";

        public bool Login(string senha)
        {
            return this.senha == senha;//onde tem o this faz referencia ao campo senha da classe...
                                       //string senha = "abc123";
                                       //depois do == referencia public bool Login(string senha)
                                       //por isso usamos o termo this para diferencia-los.
        }
    }
}
