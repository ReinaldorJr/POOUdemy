using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos
{
     class Pessoa
    {
        //Atributos ou campos
        public string nome;
        public string sobrenome;
        public int anoNascimento;

        //Metodo Simples
        public void Cumprimentar()// void significa vazio, nao tem retorno,abrimos e fechamos parenteses para definir q é um metodo
                                   // e chaves para criar o escopo(corpo de execuçao)
        {
            Console.WriteLine("Ola eu sou " +  nome + " " + sobrenome);
        }
    }
}
