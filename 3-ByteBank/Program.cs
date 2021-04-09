using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.numeroAgencia = 863;
            contaDaGabriela.numeroConta = 863452;
            

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.numeroAgencia = 863;
            contaDaGabrielaCosta.numeroConta = 863452;
            contaDaGabrielaCosta.saldo = 300;
            Console.WriteLine("Igualdade do tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));
            //vai imprimir false pois ContaCorrente é uma variável de tipo de referência

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade do tipo de valor: " + (idade == idadeMaisUmaVez));
            //vai imprimir true, pois agora estamos falando de uma variável de tipo de valor, que é o int

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);


            
            //Console.WriteLine(contaDaGabrielaCosta.numeroAgencia);
            Console.WriteLine(contaDaGabriela.saldo);


            Console.ReadLine();
        }
    }
}
