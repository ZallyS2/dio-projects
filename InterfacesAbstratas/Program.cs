using InterfacesAbstratas.Models;
using InterfacesAbstratas.Interfaces;

Conta conta = new Corrente();
conta.Creditar(100);
conta.ExibirSaldo();
conta.Creditar(100234);
conta.ExibirSaldo();


// Aluno aluno = new Aluno("João");
// aluno.Idade = 20;
// aluno.Curso = "Engenharia de Software";
// aluno.Apresentar();

ICalculadora calculadora = new Calculadora();
Console.WriteLine("Soma: " + calculadora.somar(10, 20, 30));

