using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDasClasses
{
    internal class Metodos
    {
        //Metodos Simples
        public void Cumprimentar()
        {
            Console.WriteLine("Ola, seja bem vindo.");

        }

        //Metodos com Parametros

        public void Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            Console.WriteLine("A soma é: " + resultado);
        }

        public void Apresentar(string nome, int idade)
        {
            Console.WriteLine("Meu nome é " + nome + " e tenho " + idade + " anos ");
        }

        //Passagem de parametros por valor
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por valor) é: " +  valor);
        }


        //Passagem de parametros por referencia

        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine("Valor final (por referencia) é: " + valor);
        }
        
        //Metodos com retorno de valores
        public string  MontaNome(string nome, string sobrenome) //como é string preciso colocar o retur no final senao da erro se fosse void nao precisava

        {
            string nomeCompleto = nome + " " + sobrenome;
            // return nome + " " + sobrenome; (aqui poderia ser feito desse jeito ou do jeito acima)
            return "";
        }
        public int CodigoChar(char caractere)// aqui podemos retornar qualquer outro tipo
        {
            //int codigo = caractere; posso fazer dos dois jeitos
            return caractere;
        }
        public double ValorPI()
        {
            return 3.1415;
        }

    }
}
