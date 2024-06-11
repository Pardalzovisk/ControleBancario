using ControleBancario.Model.ControleBancario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario.Model
{
    public class ContaCaixinha : Conta
    {
        public ContaCaixinha(long numero, double saldo, Cliente titular)
            : base(numero, saldo, titular)
        {
        }

        public override void Depositar(double valor)
        {
            if (valor < 1.00)
            {
                throw new ArgumentException("Depósitos inferiores a R$1,00 não são permitidos.");
            }

            _saldo += valor + 1.00; // Incrementa o saldo em 1,00 a cada depósito
        }

        public override bool Sacar(double valor)
        {
            if (_saldo >= valor + 5.10) // 5.00 adicional de taxa e 0.10 de taxa padrão
            {
                _saldo -= (valor + 5.10); // Decrementa o saldo em 5,00 a cada saque, além da taxa padrão de 0.10
                return true;
            }
            return false;
        }
    }
}
