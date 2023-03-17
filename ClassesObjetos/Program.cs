using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
     class Program
    {
        static void Main(string[] args)
        {
            #region Classes e objetos
            //MinhaClasse mClasse = new MinhaClasse(); 
            //MinhaClasse m2 = null;

            //OutraClasse outra =  new OutraClasse();
            //OutraClasse outra2 = outra;
            #endregion

            #region Atributos da Classe

            //nas linhas 26, 27, 28 foi atribuido os valores do atributo p1

            Pessoa p1 = new Pessoa();
            p1.nome = "Reinaldo";
            p1.sobrenome = "Rodrigues";
            p1.anoNascimento = 1984;

            // aqui foi feito a atribuiçao de uma forma diferente da primeira, onde os valores foram atribuidos dentro da propria instancia 
            Pessoa p2 = new Pessoa() // aqui ; foi colocado no final das chaves, tudo q esta dentro das chaves foi separado por , pois esta sendo definido dentro da instancia
            {
                nome = "Henrique",
                sobrenome = "Rodrigues",
                anoNascimento = 2023
            };

            //aqui um exemplo de como mudar os valores apenas referenciando o objeto em qualquer parte do codigo.
            p1.nome = "Estela";

            Console.WriteLine("Pessoa 1: " + p1.nome);
            Console.WriteLine("Pessoa 1: " + p1.sobrenome);
            Console.WriteLine("Pessoa 1: " + p1.anoNascimento);

            p1.Cumprimentar(); //assim q referenciamos os metodos da nossa classe
            

            Console.WriteLine(); //  apenas para quebra de linha

            Console.WriteLine("Pessoa 2: " + p2.nome);
            Console.WriteLine("Pessoa 2: " + p2.sobrenome);
            Console.WriteLine("Pessoa 2: " + p2.anoNascimento);
            p2.Cumprimentar();

            Console.ReadKey(); //para fazer a pausa

            #endregion

           

        }
    }
    class MinhaClasse
    {

    }
}
