using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(876, 86712540);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            // ContaCorrente.TotalDeContasCriadas++;

            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.NumeroConta);

            ContaCorrente contaDaGabriela = new ContaCorrente(867, 86745820);
            //ContaCorrente.TotalDeContasCriadas++;


            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.ReadLine();
        }
    }
}
