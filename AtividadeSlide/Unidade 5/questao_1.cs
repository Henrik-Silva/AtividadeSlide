using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Atividade Slide 5

Questão 1: Faça um programa em C# que leia uma quantidade indefinida de objetos Carro,
composto pelos atributos, marca, valor, cor, modelo e ano, e:
    - Ordene os carros pelo de maior valor;
    - Imprima na tela todos os carros ordenados do maior valor para o de menor valor;*/

public class Carro
{
    public string Marca { get; set; }
    public decimal Valor { get; set; }
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public Carro(string marca, decimal valor, string cor, string modelo, int ano)
    {
        Marca = marca;
        Valor = valor;
        Cor = cor;
        Modelo = modelo;
        Ano = ano;
    }

    public override string ToString()
    {
        return $"{Marca} {Modelo} - R$ {Valor}";
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        List<Carro> carros = new List<Carro>();
        string opcao;

        do
        {
            Console.WriteLine("Informe a marca do carro:");
            string marca = Console.ReadLine();

            Console.WriteLine("Informe o valor do carro:");
            decimal valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe a cor do carro:");
            string cor = Console.ReadLine();

            Console.WriteLine("Informe o modelo do carro:");
            string modelo = Console.ReadLine();

            Console.WriteLine("Informe o ano do carro:");
            int ano = int.Parse(Console.ReadLine());

            carros.Add(new Carro(marca, valor, cor, modelo, ano));

            Console.WriteLine("Deseja adicionar outro carro? (S/N)");
            opcao = Console.ReadLine().ToUpper();
        } while (opcao == "S");

        carros.Sort((a, b) => b.Valor.CompareTo(a.Valor));

        Console.WriteLine("Carros ordenados pelo maior valor para o menor valor:");
        foreach (Carro carro in carros)
        {
            Console.WriteLine(carro);
        }
        Console.ReadKey();
    }
}