using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipo        variavel          do tipo
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Titular: "+contaDaGabriela.titular);
            Console.WriteLine("Agencia: "+ contaDaGabriela.agencia);
            Console.WriteLine("Numero: "+contaDaGabriela.numero);
            Console.WriteLine("Saldo: "+contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Novo saldo: "+contaDaGabriela.saldo);

            Console.ReadLine();

        }
    }
}
