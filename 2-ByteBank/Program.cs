using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaPadrao = new ContaCorrente();

            //o saldo a ser impresso aqui é o mesmo de quando foi declarado pela primeira vez na classe ContaCorrente.
            Console.WriteLine(contaPadrao.saldo);

            Console.ReadLine();
        }
    }
}
