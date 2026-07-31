// Desafio 3 (Remoção Segura): Imagine que você precisa fechar um
// departamento. Crie um laço while que remova todos os cursos da coleção
// enquanto a contagem (Count) for maior que zero


// LMEBRANDO QUE EU NÃO HAVIA ESTUDADO ESTE METODO AINDA
// LOGO FIZ COM A AJUDA DA IA

using System;
using System.Collections.Generic;

public class Program
{
    // Criamos a lista como static para que o método FecharDepartamento possa enxergá-la
    public static List<Curso> listaCursos = new List<Curso>() {
        new Curso { Id = 1, Nome = "Engenharia", Duracao = 5 },
        new Curso { Id = 2, Nome = "Medicina", Duracao = 6 },
        new Curso { Id = 3, Nome = "Direito", Duracao = 4 },
        new Curso { Id = 4, Nome = "Arquitetura", Duracao = 5 },
        new Curso { Id = 5, Nome = "Administração", Duracao = 4 },
    };

    public static void Main()
    {
        Console.WriteLine("Quantidade de cursos antes: " + listaCursos.Count);
        
        // Chamamos o método que você criou
        FecharDepartamento();
        
        Console.WriteLine("Quantidade de cursos depois: " + listaCursos.Count);
    }

    public static void FecharDepartamento() {
        // CORREÇÃO: Mudamos de 'Cursos' para 'listaCursos' para bater com o nome da variável
        while (listaCursos.Count > 0) {
            listaCursos.RemoveAt(0);
        }
        
        Console.WriteLine("Todos os cursos foram removidos com sucesso!");
    }
}

// Criamos a classe Curso para o código funcionar por completo
public class Curso 
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Duracao { get; set; }
}
