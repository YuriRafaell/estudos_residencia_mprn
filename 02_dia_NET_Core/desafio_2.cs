// Desafio 2 (Identidade e Unicidade): Implemente uma lógica que use o método 
//.Contains() para verificar se uma disciplina já existe em um curso antes
// de adicioná-la. Lembre-se que, para isso funcionar, você deve ter
// sobrescrito os métodos Equals() e GetHashCode() na classe da disciplina

// LMEBRANDO QUE EU NÃO HAVIA ESTUDADO ESTE METODO AINDA
// LOGO FIZ COM A AJUDA DA IA

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // 1. Criamos a lista inicial
        var listaDisciplinas = new List<Disciplina>() {
            new Disciplina { Id = 1, Nome = "Matemática", CargaHoraria = 80 },
            new Disciplina { Id = 2, Nome = "Português", CargaHoraria = 50 }
        };

        // 2. Nova disciplina que queremos adicionar
        var novaDisciplina = new Disciplina { Id = 6, Nome = "Matemática", CargaHoraria = 100 };

        // 3. O Contains usa o seu Equals (compara pelo Nome)
        if (listaDisciplinas.Contains(novaDisciplina))
        {
            Console.WriteLine($"Erro: A disciplina '{novaDisciplina.Nome}' já existe no curso!");
        }
        else
        {
            listaDisciplinas.Add(novaDisciplina);
            Console.WriteLine("Disciplina adicionada com sucesso!");
        }
    }
}

// A classe Disciplina precisa conter os métodos Equals e GetHashCode
public class Disciplina 
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int CargaHoraria { get; set; }

    public override bool Equals(object obj) {
        if (obj is Disciplina d) {
            // Evita erro se o nome estiver nulo
            return this.Nome != null && this.Nome.Equals(d.Nome, StringComparison.OrdinalIgnoreCase); 
        }
        return false;
    }

    public override int GetHashCode() { 
        // Correção dos parênteses para o operador ternário funcionar
        return 11 + (this.Nome == null ? 0 : this.Nome.GetHashCode());
    }
}

// O método Contains():
// Ele percorre a lista e verifica se o objeto que você quer adicionar já
// está lá.


//Importante: O Contains() só funciona corretamente para objetos
// personalizados se você tiver implementado os métodos Equals e
// GetHashCode mencionados acima.
