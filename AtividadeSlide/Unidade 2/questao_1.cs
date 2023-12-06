using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  ATIVIDADE SLIDE 2

Questão 1: Crie uma classe de nome Carro e atribua a ela todas as propriedades que você
acredita que um carro possua. Instancie a classe Carro e preencha 3 objetos distintos.
Imprima na tela do usuário todos os atributos dos três carros.*/

class Carro
{
    public string Marca;
    public string Modelo;
    public int Ano;
    public string Cor;
    public int VelocidadeMax;

    public Carro(string marca, string modelo, int ano, string cor, int velocidadeMax)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Cor = cor;
        VelocidadeMax = velocidadeMax;
    }

    public void ImprimirDados()
    {
        Console.WriteLine("Marca: {0}", Marca);
        Console.WriteLine("Modelo: {0}", Modelo);
        Console.WriteLine("Ano: {0}", Ano);
        Console.WriteLine("Cor: {0}", Cor);
        Console.WriteLine("Velocidade Máxima: {0} km/h", VelocidadeMax);
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Carro carro1 = new Carro("Toyota", "Hilux", 2022, "Preta", 180);
        Carro carro2 = new Carro("Hyundai", "Creta", 2022, "Prata", 180);
        Carro carro3 = new Carro("Volkswagen", "Fusca", 2023, "Azul", 210);

        carro1.ImprimirDados();
        carro2.ImprimirDados();
        carro3.ImprimirDados();

        Console.ReadKey();
    }
}