using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente gabriela = new Cliente();

            //gabriela.nome = "Gabriela";
            //gabriela.profissao = "Desenvolvedora C#";
            //gabriela.CPF = "434.562.838-20";

            ContaCorrente conta = new ContaCorrente();

            //conta.titular = gabriela;
            conta.titular = new Cliente();
            conta.titular.nome = "Gabriela Costa";
            conta.titular.CPF = "434.562.838 - 20";
            conta.titular.profissao = "Desenvolvedora C#";

            conta.saldo = 500;
            conta.numeroAgencia = 563;
            conta.numeroConta = 5634527;

            //Console.WriteLine(gabriela.nome);
            Console.WriteLine(conta.titular.nome);
            Console.WriteLine(conta.titular.CPF);
            Console.WriteLine(conta.titular.profissao);


            Console.ReadLine();
        }
    }
}
