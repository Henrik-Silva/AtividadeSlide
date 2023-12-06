using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ATIVIDADE SLIDE 2
 
Questão 2: Pesquise como um criar um método específico dentro de uma classe em C#.
Crie dois métodos para a classe Carro criada na questão anterior. Um método chamado
Acelerar(), que retorna a string “O carro está em movimento” como resposta e outro método
Freiar() que também retorna uma string “O carro está parado” como resposta.*/

class Carro2
{
    public string Marca1;
    public string Modelo1;
    public int Ano1;
    public string Cor1;
    public int VelocidadeMax1;

    public Carro2(string marca1, string modelo1, int ano1, string cor1, int velocidadeMax1)
    {
        Marca1 = marca1;
        Modelo1 = modelo1;
        Ano1 = ano1;
        Cor1 = cor1;
        VelocidadeMax1 = velocidadeMax1;
    }

    public void ImprimirDados()
    {
        Console.WriteLine("Marca: {0}", Marca1);
        Console.WriteLine("Modelo: {0}", Modelo1);
        Console.WriteLine("Ano: {0}", Ano1);
        Console.WriteLine("Cor: {0}", Cor1);
        Console.WriteLine("Velocidade Máxima: {0} km/h", VelocidadeMax1);
        Console.WriteLine();
    }

    public string Acelerar()
    {
        return "O carro está em movimento";
    }

    public string Freiar()
    {
        return "O carro está parado";
    }
}

class Program2
{
    static void Main()
    {
        Carro2 carro1 = new Carro2("Toyota", "Hilux", 2022, "Preta", 180);
        Carro2 carro2 = new Carro2("Hyundai", "Creta", 2022, "Prata", 180);
        Carro2 carro3 = new Carro2("Volkswagen", "Fusca", 2023, "Azul", 210);

        carro1.ImprimirDados();
        carro2.ImprimirDados();
        carro3.ImprimirDados();

        Console.ReadKey();
    }
}