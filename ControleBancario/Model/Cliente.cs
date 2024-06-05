using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBancario.Model
{
        public class Cliente
        {
            public string Email { get; set; }
            public int AnoNascimento { get; set; }
            public string Nome { get; set; }
            public string CPF { get; set; }

            public Cliente(string nome, string cpf, int anoNascimento, string email)
            {
                if (cpf.Length != 11)
                {
                    throw new ArgumentException("O CPF deve ter 11 dígitos.");
                }

                if (DateTime.Now.Year - anoNascimento < 18)
                {
                    throw new ArgumentException("O cliente deve ter mais de 18 anos.");
                }

                Nome = nome;
                CPF = cpf;
                AnoNascimento = anoNascimento;
                Email = email;
            }
        }
}
