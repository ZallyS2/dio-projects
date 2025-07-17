using ProjetoEntendendoC.Models;

Pessoa p1 = new Pessoa("Laila", "Zappiello", 18);
Pessoa p2 = new Pessoa("Maria", "Silva", 22);


Cursos cursoDeC = new Cursos("Curso de C#");
cursoDeC.Alunos = new List<Pessoa>();
cursoDeC.AdicionarAluno(p1);
cursoDeC.AdicionarAluno(p2);
cursoDeC.ListarAlunos();