using _2_ByteBank;
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
            ContaCorrente conta = new ContaCorrente();
            conta.nome = "Thiago";
            conta.saldo = 150;
            conta.Sacar(100);
            Console.WriteLine();
        }
    }
}
