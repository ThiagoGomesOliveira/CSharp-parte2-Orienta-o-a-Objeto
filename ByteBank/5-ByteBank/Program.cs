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

            ContaCorrente conta = new ContaCorrente(200,1661);
            Console.WriteLine(conta.Agencia);
            Console.WriteLine(conta.Conta);
            Console.WriteLine(ContaCorrente.QtdContaCorrentes);
            ContaCorrente conta2 = new ContaCorrente(300,1662);
            Console.WriteLine(ContaCorrente.QtdContaCorrentes);
            Console.ReadLine();
        }
    }
}
