using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e textos");

            char primeiraLetra = 'a'; // aspas simples para caracter diferente de "" para textos

            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            primeiraLetra = (char)(primeiraLetra + 1);

            Console.WriteLine(primeiraLetra);

            string titulo = "Alura Cursos de tecnologia " + 2020;
            Console.WriteLine(titulo);

            string cursosProgramacao =  //Para listar uma string em forma de lista, inicio com @"..."
@"- .NET
- Java
- Javascript";


            Console.WriteLine(cursosProgramacao);

            Console.WriteLine("Execução acabou. Tecle enter para sair...");
            Console.ReadLine();
            
        }
    }
}
