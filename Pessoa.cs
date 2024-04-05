using System;
class Pessoa
{
    // Atributos da classe
    public string Nome {get; set;}
    public int Idade {get; set;}
    public double Altura {get; set;}

    // Método para apresentar os dados da pessoa
    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Altura: {Altura} metros");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da classe pessoa
       Pessoa pessoa = new Pessoa();
       pessoa.Nome = "João";
       pessoa.Idade = 30;
       pessoa.Altura = 1.75;

        // Chamando o método Apresentar para exibir os dados da pessoa
        pessoa.Apresentar();
    }
}