using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Metodos m = new Metodos();
            //m.Cumprimentar();
            //m.Somar(10, 5);
            //m.Apresentar("Reinaldo", 35);
            #region Metodo parametos por referencia
            //int valor1 = 100;
            //int valor2 = 100;

            //m.AumentarValor(valor1);
            //m.AumentarRef(ref valor2); //aqui tem q colocar ref antes senao da erro pq estamos usando por referencia

            //Console.WriteLine("valor 1: " + valor1);
            //Console.WriteLine("valor 2: " + valor2);
            //Console.ReadKey();
            #endregion

            string nomeCompleto = m.MontaNome("Reinaldo", "Rodrigues");// o m.MontaNome aqui é o metodo, m. significa q estamos chamando o metodo
            int codigoChar = m.CodigoChar('a');
            double pi = m.ValorPI();

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(codigoChar);
            Console.WriteLine(pi);

            Console.ReadKey();


        }
}
}
