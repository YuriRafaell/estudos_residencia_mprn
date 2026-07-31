var listaAlunos = new List<Aluno>() {
    new Aluno { Id = 1, Nome = "João", Idade = 10 },
    new Aluno { Id = 2, Nome = "Maria", Idade = 12 },
    new Aluno { Id = 3, Nome = "Pedro", Idade = 11 },
    new Aluno { Id = 4, Nome = "Ana", Idade = 13 },
    new Aluno { Id = 5, Nome = "Lucas", Idade = 10 },
};

// Sem o LINQ
var listaMenor12 = new List<Aluno>();
foreach (var aluno in listaAlunos)
{
    if (aluno.Idade < 12)
    {
        listaMenor12.Add(aluno);
    }
}

// Com o LINQ
var listaMenor12 = listaAlunos
    .Where(aluno => aluno.Idade < 12)
    // .Where(x => x.Idade < 12) // Outra forma de escrever a mesma condição
    // Não importa o nome, pois ele sabe o parametro que está sendo passado
    .OrderBy(aluno => aluno.Nome) 
    .ToList();

// Where impoe uma condição para que seja aceito ou não


Console.WriteLine(value: "Fim!");

public class Aluno
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
}