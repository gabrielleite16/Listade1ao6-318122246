using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listade1ao6GabrielLeite318122246
{
    class Cliente
    {

        private int saldo;
        private int conta;
        private int cobranca_Total;
        private int credito_Total;
        private int limite_Credito;


        public Cliente()

        {
            saldo = 0;
            conta = 0;
            cobranca_Total = 0;
            credito_Total = 0;
            limite_Credito = 0;

        }



        public Cliente(int saldo, int conta, int cobranca_Total, int credito_Total, int limite_Credito)

        {
            this.saldo = saldo;
            this.conta = conta;
            this.cobrancatotal = cobranca_Total;
            this.creditototal = credito_Total;
            this.limitecredito = limite_Credito;

        }

        public int NovoSaldo()
        {
            return this.saldo + this.cobranca_Total - this.credito_Total;
        }

        public void AtualizaSaldo()
        {
            this.saldo = NovoSaldo();
        }

        public bool Limiteestourado()
        {
            return this.saldo > this.limite_Credito;
        }

    }
}