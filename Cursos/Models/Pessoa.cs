using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEntendendoC.Models {
    public class Pessoa {

        public Pessoa(string nome, string sobrenome, int idade) {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome {
            get => _nome;


            set {
                if (value == "") {
                    throw new ArgumentNullException(nameof(value), "Nome não pode ser nulo.");
                }

                _nome = value;
            }
        }
        public string Sobrenome {
            get => _sobrenome;

            set {
                if (value == "") {
                    throw new ArgumentNullException(nameof(value), "Nome não pode ser nulo.");
                }

                _sobrenome = value;
            }
        }
        public int Idade {
            get => _idade;

            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException(nameof(value), "Idade não pode ser negativa.");
                }

                _idade = value;
            }

        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public void Apresentar() {
            Console.WriteLine($"Olá, meu nome é {NomeCompleto} e tenho {Idade} anos.");
        }

    }
}