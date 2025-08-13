using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfacesAbstratas.Models
{
    //sealed significa que a classe não pode ser herdada
    //abstract significa que a classe não pode ser instanciada diretamente e precisa ser herdada
    public sealed class Aluno : Pessoa
    {
        public Aluno(string nome) : base(nome)
        {
        }
        public string Curso { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou aluno do curso de {Curso}");
        }
    }

}