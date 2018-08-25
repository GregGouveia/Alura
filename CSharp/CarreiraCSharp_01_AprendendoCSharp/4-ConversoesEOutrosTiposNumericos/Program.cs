using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4 Conversoes e Outros Tipos Numericos");

            short quantidadeProdutos = 150; ; // o short é um tipo de variável que suporta áté 16 bits
            Console.WriteLine(quantidadeProdutos);

            double salario = 1200.50; ; // o double é um tipo de variável que suporta até 32 bits
            Console.WriteLine(salario);

            int salarioEmInteiro = (int)salario; // Cast // o int é um tipo de variável que suporta até 32 bits
            Console.WriteLine(salarioEmInteiro + " Variavel salario perdendo precisão decimal.");

            long idade = 100000000000; ; // o long é um tipo de variável que suporta até  64 bits
            Console.WriteLine(idade);
                     
            float altura = 1.80f; // o float tem uma precisão menor precisão decimal comparado ao double
            Console.WriteLine(altura);

            Console.WriteLine("A execução acabou. Tecle Enter para sair...");
            Console.ReadLine();
        }
    }
}
