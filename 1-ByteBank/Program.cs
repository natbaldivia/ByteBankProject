using System;

namespace _1_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.numeroAgencia = 863;
            contaDaGabriela.numeroConta = 863452;
            contaDaGabriela.saldo = 100;

            Console.WriteLine("Nome do titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agência: " + contaDaGabriela.numeroAgencia);
            Console.WriteLine("Conta Corrente: " + contaDaGabriela.numeroConta);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;

            Console.WriteLine("Saldo atual: " + contaDaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
