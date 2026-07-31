
using System; //Faltou add isso 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== SISTEMA BANCÁRIO - RESIDÊNCIA MPRN ===\n");

        // 1. Criando uma Conta Corrente (Titular, Número, Limite de Empréstimo)
        ContaCorrente cc = new ContaCorrente("Maria Silva", 1001, 5000.00m);
        cc.Depositar(1000.00m);
        cc.Sacar(200.00m);
        
        Console.WriteLine($"[Conta Corrente] Titular: {cc.Titular}");
        // Chamando o método polimórfico da Conta Corrente
        cc.CalcularRendimento(); 

        Console.WriteLine("\n-------------------------------------------\n");

        // 2. Criando uma Conta Poupança (Titular, Número, Taxa de Juros de 5%)
        ContaPoupanca cp = new ContaPoupanca("João Souza", 2002, 0.05m);
        cp.Depositar(1000.00m); // Saldo inicial para render
        
        Console.WriteLine($"[Conta Poupança] Titular: {cp.Titular}");
        // Chamando o mesmo método, mas que executa uma lógica totalmente diferente!
        cp.CalcularRendimento(); 
        
        Console.ReadKey();
    }
}

// Vou corrigir o código, vendo o que acertei ou faltou ou erro

// 1. CLASSE BASE (Abstração e Encapsulamento)
public class ContaBancaria
{
    public string Titular { get; set; }
    public int NumeroConta { get; set; }


    // Saldo protegido: Só a classe pai e as filhas alteram. 
    // Ninguém de fora mexe diretamente.
    protected decimal Saldo { get; set; } 

    // Construtor da Classe Pai
    // Faltou esta parte: (string titular, int numeroConta)
    public ContaBancaria(string titular, int numeroConta)
    {
        // Removi o void que coloquei errado, pois construtor não tem tipo de retorno
        public ContaCorrente(string titular, int numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
            // Faltou esta parte 
            Saldo = 0; // Toda conta começa com saldo zerado
        }

        // Nada disso que esta abaixo, consegui pensar/fazer
        // Métodos para alterar o saldo de forma segura (Encapsulamento)
    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }

    public void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
        }
    }

    // Polimorfismo: Método virtual que pode ser sobrescrito pelas filhas
    public virtual void CalcularRendimento()
    {
        // Comportamento padrão (será modificado nas subclasses)
    }
}

// 2. CLASSE FILHA: CONTA CORRENTE (Herança e Polimorfismo)
// O ":" significa que ContaCorrente HERDA de ContaBancaria
public class ContaCorrente : ContaBancaria
{
    public decimal LimiteEmprestimo { get; set; }

    // Construtor chamando o construtor do pai usando o ": base()"
    public ContaCorrente(string titular, int numeroConta, decimal limite) : base(titular, numeroConta)
    {
        LimiteEmprestimo = limite;
    }

    // Polimorfismo: Override para reescrever o comportamento
    public override void CalcularRendimento()
    {
        Console.WriteLine("Conta Corrente não possui rendimento.");
    }
}

// 3. CLASSE FILHA: CONTA POUPANÇA (Herança e Polimorfismo)
public class ContaPoupanca : ContaBancaria
{
    public decimal TaxaDeJuros { get; set; }

    // Construtor chamando o pai com ": base()"
    public ContaPoupanca(string titular, int numeroConta, decimal taxa) : base(titular, numeroConta)
    {
        TaxaDeJuros = taxa;
    }

    // Polimorfismo: Override para calcular o rendimento real
    public override void CalcularRendimento()
    {
        decimal rendimento = Saldo * TaxaDeJuros;
        Saldo += rendimento;
        Console.WriteLine($"Rendimento aplicado! Novo Saldo: {Saldo}");
    }
    }
}
