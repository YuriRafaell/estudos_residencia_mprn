// Desafio 1 (Consulta com Filtro): Crie um método que utilize LINQ para 
// retornar todas as Disciplinas que tenham uma Carga Horária superior a 
// 60 horas.


var listaDisciplinas = new List<Disciplina>() {
    new Disciplina { Id = 1, Nome = "Matemática", CargaHoraria = 80 },
    new Disciplina { Id = 2, Nome = "Português", CargaHoraria = 50 },
    new Disciplina { Id = 3, Nome = "História", CargaHoraria = 70 },
    new Disciplina { Id = 4, Nome = "Geografia", CargaHoraria = 60 },
    new Disciplina { Id = 5, Nome = "Ciências", CargaHoraria = 90 },
};

var listaDisciplinasMais60 = listaDisciplinas
    .Where(disciplina => disciplina.CargaHoraria > 60)
    .ToList();


Console.WriteLine(value: "Fim!");

public class Disciplina
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int CargaHoraria { get; set; }
};