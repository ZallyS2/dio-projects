using ProjetoEntendendoC.Models;

Pessoa p1 = new Pessoa(nome: "Laila", sobrenome: "Zappiello", idade: 18);
Pessoa p2 = new Pessoa(nome: "Luana", sobrenome: "Costa", idade: 36);


Cursos cursoDeC = new Cursos(nome: "Curso de C#");
cursoDeC.Alunos = new List<Pessoa>();
cursoDeC.AdicionarAluno(p1);
cursoDeC.AdicionarAluno(p2);
cursoDeC.ListarAlunos();