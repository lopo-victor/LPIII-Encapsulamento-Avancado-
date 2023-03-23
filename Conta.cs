using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ativ1
{
    abstract class Conta
    {
        private string _nome;
        private int _nconta;
        private int _agencia;
        private int _senha;
        private double _saldo = 0;
        private bool _AcessoRemoto = true;


        public Conta(string nome, int nconta, int agencia, int senha)
        {
            this._nome = nome;
            this._nconta = nconta;
            this._agencia = agencia;
            this._senha = senha;
        }

        //getters
        public string Nome { get { return _nome; } }

        public int Nconta { get { return _nconta; } }

        public int Agencia { get { return _agencia; } }

        public double Saldo { get { return _saldo; } }

        private  int Senha  { get { return _senha; } }

        public bool AcessoRemoto { get { return _AcessoRemoto; } }

        //setters
        private double Movimento { set { _saldo += value; }  }

        




        //metodos

        private void deposito(double value) 
        {
            Movimento = value;
        }

        private void saque(double value)
        {
            if (value > _saldo) Console.WriteLine("seu saldo é insuficiente"); 

            else  Movimento = -value; 
        }

      
        protected void Depositar()
        {
            Console.Write("informe o valor do deposito: ");
            deposito(Convert.ToDouble(Console.ReadLine()));
        }

        protected void Sacar()
        {
            Console.Write("informe o valor do saque: ");
            saque(Convert.ToDouble(Console.ReadLine()));
        }


        protected void ReceberSenha()
        {

            Console.Write("Digite a senha de acesso: ");
            VerificarSenha(Convert.ToInt32(Console.ReadLine()));

        }

        private void VerificarSenha(int Vsenha)
        {
            if (Vsenha != _senha)
            {
                _AcessoRemoto = false;
            }
            else if (Vsenha.Equals(_senha))
            {
                _AcessoRemoto = true;
            }
        }




        public void revelaSenha() { Console.WriteLine(Senha); }

        public void infConta() {
            Console.WriteLine("Cliente:");
            Console.WriteLine(Nome);
            Console.WriteLine(" ");

            Console.WriteLine("Conta:");
            Console.WriteLine(Nconta);
            Console.WriteLine(" ");

            Console.WriteLine("Agencia:");
            Console.WriteLine(Agencia);
            Console.WriteLine(" ");

            Console.WriteLine("Saldo Atual:");
            Console.WriteLine(Saldo);
            Console.WriteLine(" ");
        }

    }
}