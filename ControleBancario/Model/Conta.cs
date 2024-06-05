using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario.Model
{
    namespace ControleBancario.Model
    {
        public class Conta
        {
            private long _numero;
            protected double _saldo;
            public Cliente Titular { get; set; }

            public Conta(double saldo, Cliente titular)
            {
                if (saldo <= 10.00)
                {
                    throw new ArgumentException("O saldo inicial deve ser superior a R$10,00.");
                }

                _saldo = saldo;
                Titular = titular ?? throw new ArgumentException("A conta deve ter um titular.");
            }

            public Conta(long numero, double saldo, Cliente titular)
            {
                if (saldo <= 10.00)
                {
                    throw new ArgumentException("O saldo inicial deve ser superior a R$10,00.");
                }

                _numero = numero;
                _saldo = saldo;
                Titular = titular ?? throw new ArgumentException("A conta deve ter um titular.");
            }

            public double Saldo => _saldo;

            public void Depositar(double valor)
            {
                if (valor > 0)
                {
                    _saldo += valor;
                }
            }

            public virtual bool Sacar(double valor)
            {
                if (_saldo >= valor + 0.10)
                {
                    _saldo -= (valor + 0.10); // 0.10 é a taxa de saque
                    return true;
                }
                return false;
            }

            public virtual void Transferir(Conta destino, double valor)
            {
                if (Sacar(valor))
                {
                    destino.Depositar(valor);
                }
                else
                {
                    throw new ArgumentException("Transferência não realizada. Saldo insuficiente.");
                }
            }
        }
    }

}
