using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 18;
            bool acompanhado = true;
            string mensagemAdicional;
            if (acompanhado == true)
            {
                mensagemAdicional = "João está acompanhado!";
            }
            else

                mensagemAdicional = ("João não está acompanhado.");
    

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("Pode entrar.");
                Console.WriteLine(mensagemAdicional);
            }
            else
            {
                Console.WriteLine("Não pode entrar.");
            }

            Console.WriteLine("Execução acabou. Tecle enter para sair...");
            Console.ReadLine();

        }
    }
}
