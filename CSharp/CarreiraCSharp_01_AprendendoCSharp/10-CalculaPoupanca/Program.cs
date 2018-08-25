using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _P10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

            double valorInvestido = 1000;

            Console.WriteLine("Investindo o equivalente a R$ "+valorInvestido+" na poupança, você terá: ");
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                // 0.36% = 0.0036
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " +contadorMes+" mês(es), R$: " + valorInvestido + ".");

                //contadorMes = contadorMes + 1;
                //contadorMes++;
                contadorMes += 1;
            }

            Console.WriteLine("Execução acabou. Tecle enter para continuar...");
            Console.ReadLine();
        }
    }
}
