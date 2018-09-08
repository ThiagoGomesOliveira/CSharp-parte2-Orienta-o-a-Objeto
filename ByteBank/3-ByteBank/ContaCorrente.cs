using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ByteBank
{
    public  class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int conta;
        public double saldo;



        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (VerificarSaldo(valor))
            {
                this.saldo -= valor;
            }

        }

        public bool VerificarSaldo(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            return true;
        }


        public void Transferir(double valor, ContaCorrente conta)
        {
            if (VerificarSaldo(valor))
            {
                this.saldo -= valor;
                conta.Depositar(valor);
            }
        }

    }
}
