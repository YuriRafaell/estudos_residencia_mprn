# O Desafio: Sistema Bancário

Tente criar um código que contemple os seguintes requisitos:
## 1. Abstração e Encapsulamento:

- Crie uma classe base chamada `ContaBancaria`.

- Ela deve ter propriedades para `Titular` e `NumeroConta`.

- O `Saldo` deve ser encapsulado: use um modificador de acesso que impeça que ele seja alterado diretamente de fora da classe (use `private` ou `protected`), permitindo alterações apenas através de métodos de `Depositar` e `Sacar`.
## 2. Herança:

- Crie duas classes que herdam de `ContaBancaria`: `ContaCorrente` e `ContaPoupanca`.

- A `ContaCorrente` pode ter um atributo adicional de `LimiteEmprestimo`.

- A `ContaPoupanca` pode ter uma `TaxaDeJuros`.

## 3. Polimorfismo:

- Na classe base, defina um método chamado `CalcularRendimento` (pode ser marcado como `virtual`).

- Nas classes filhas, use o `override` para que cada conta calcule o rendimento de forma diferente: a conta corrente não rende nada, enquanto a poupança rende com base na sua taxa.

## 4. Construtores:

- Lembre-se de que as classes filhas devem chamar o construtor da classe pai usando a palavra-chave: `base()`.


____________________

## Esta foi o código pensado por mim, antes da correção:

``` public class ContaBancaria
{
    public string Titular { get; set; }
    public int NumeroConta { get; set; }


    public private Saldo(decimal Depositar, decimal Sacar)
    {
        this.Depositar = Depositar;
        this.Sacar = Sacar;
    }

    public ContaBancaria
    {
        public void ContaCorrente(string titular, int numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
            LimiteEmprestimo = 1000;
        }

        public void ContaPoupanca(string titular, int numeroConta)
        {
            Titular = titular;
            NumeroConta = numeroConta;
            TaxaDeJuros = 0.05m;
        }
    }
} ```