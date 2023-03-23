using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ativ1
{
    internal class ContaCorrente : Conta
    {
        public ContaCorrente(string nome, int nconta, int agencia, int senha) : base(nome, nconta, agencia, senha)
        {
        }

        public void DepositoCC()
        {
            Depositar();
        }

        public void SaqueCC()
        {
            Sacar();
        }

        public void ReceberSenhaCC()
        {
            ReceberSenha();
        }

    }
}
