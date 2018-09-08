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
            ContaCorrente conta = new ContaCorrente();
            conta.titular = new Cliente();
            conta.titular.nome = "thiago gomes";
            conta.titular.cpf =  "00000000";


        }
    }
}
