using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Atividade Slide 5
  
Questão 2: Baseado no programa anterior (Questão 1) Crie uma interface para Cadastrar,
Excluir e Listar os carros.
 - Cadastre um carro.
 - Exclua um carro.
 - Liste todos os carros do menor valor para o maior valor..*/

public class Carro {
    public string Marca { get; set; }
    public double Valor { get; set; }
    public string Cor { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}

public class CarroDAO {
    private List<Carro> carros = new List<Carro>();

    public void Cadastrar(Carro carro) {
        carros.Add(carro);
    }

    public void Excluir(Carro carro) {
        carros.Remove(carro);
    }

    public List<Carro> Listar() {
        carros.Sort((x, y) => x.Valor.CompareTo(y.Valor));
        return carros;
    }
}

public class Program {
    static void Main(string[] args) {
        CarroDAO dao = new CarroDAO();
        bool sair = false;

        while (!sair) {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Cadastrar carro");
            Console.WriteLine("2 - Excluir carro");
            Console.WriteLine("3 - Listar carros");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 1:
                    Console.WriteLine("Digite a marca:");
                    string marca = Console.ReadLine();

                    Console.WriteLine("Digite o valor:");
                    double valor = double.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a cor:");
                    string cor = Console.ReadLine();

                    Console.WriteLine("Digite o modelo:");
                    string modelo = Console.ReadLine();

                    Console.WriteLine("Digite o ano:");
                    int ano = int.Parse(Console.ReadLine());

                    Carro carro = new Carro();
                    carro.Marca = marca;
                    carro.Valor = valor;
                    carro.Cor = cor;
                    carro.Modelo = modelo;
                    carro.Ano = ano;

                    dao.Cadastrar(carro);

                    Console.WriteLine("Carro cadastrado com sucesso!");
                    break;

                case 2:
                    List<Carro> carros = dao.Listar();

                    if (carros.Count == 0) {
                        Console.WriteLine("Não há carros cadastrados!");
                        break;
                    }

                    Console.WriteLine("Escolha um carro para excluir:");

                    for (int i = 0; i < carros.Count; i++) {
                        Console.WriteLine($"{i + 1} - {carros[i].Marca} - {carros[i].Modelo} - {carros[i].Ano}");
                    }

                    int indice = int.Parse(Console.ReadLine()) - 1;

                    dao.Excluir(carros[indice]);

                    Console.WriteLine("Carro excluído com sucesso!");
                    break;

                case 3:
                    List<Carro> carrosOrdenados = dao.Listar();

                    if (carrosOrdenados.Count == 0) {
                        Console.WriteLine("Não há carros cadastrados!");
                        break;
                    }

                    Console.WriteLine("Carros cadastrados:");

                    foreach (Carro c in carrosOrdenados) {
                        Console.WriteLine($"{c.Marca} - {c.Modelo} - {c.Ano} - {c.Cor} - R${c.Valor}");
                    }

                    break;

                default:
                    sair = true;
                    break;

                    Console.ReadKey();
            }
        }
    }
}
