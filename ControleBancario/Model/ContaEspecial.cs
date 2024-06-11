using ControleBancario.Model.ControleBancario.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario.Model
{
    public class ContaEspecial : Conta
    {
        public double Limite { get; set; }

        public ContaEspecial(long numero, double saldo, Cliente titular, double limite) : base(numero, saldo, titular)
        {
            Limite = limite;
        }

        public override bool Sacar(double valor)
        {
            if (_saldo + Limite >= valor + 0.10)
            {
                _saldo -= (valor + 0.10); // 0.10 é a taxa de saque
                return true;
            }
            return false;
        }

        public override void Transferir(Conta destino, double valor)
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

