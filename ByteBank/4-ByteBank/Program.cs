using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();
            conta.Titular = new Cliente();
            conta.Titular.Nome = "Thiago Gomes Oliveira";
            conta.Titular._cpf = "xxx-xxx-xxx-xx";

            conta.Saldo = 100;
            conta.Sacar(50);

            Console.WriteLine("Saldo   " +conta.Saldo);
            Console.ReadLine();
        }
    }
}
