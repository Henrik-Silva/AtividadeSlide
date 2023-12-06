using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Atividade Slide 5

Questão 3: Escreva um programa em C# que deverá ter as seguintes opções:
    - Carregar Vetor.
    - Listar Vetor.
    - Exibir apenas os números pares do vetor.
    - Exibir apenas os números ímpares do vetor.
    - Exibir a quantidade de números pares existentes nas posições ímpares do vetor.
    - Exibir a quantidade de números ímpares existentes nas posições pares do vetor.
    - Sair*/

class Program
{
    static int[] vetor;

    static void Main(string[] args)
    {
        int opcao;
        do
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Carregar Vetor");
            Console.WriteLine("2 - Listar Vetor");
            Console.WriteLine("3 - Exibir apenas os números pares do vetor");
            Console.WriteLine("4 - Exibir apenas os números ímpares do vetor");
            Console.WriteLine("5 - Exibir a quantidade de números pares existentes nas posições ímpares do vetor");
            Console.WriteLine("6 - Exibir a quantidade de números ímpares existentes nas posições pares do vetor");
            Console.WriteLine("7 - Sair");
            Console.WriteLine("Opção escolhida: ");

            opcao = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcao)
            {
                case 1:
                    CarregarVetor();
                    break;

                case 2:
                    ListarVetor();
                    break;

                case 3:
                    ExibirPares();
                    break;

                case 4:
                    ExibirImpares();
                    break;

                case 5:
                    QuantidadeParesPosicoesImpares();
                    break;

                case 6:
                    QuantidadeImparesPosicoesPares();
                    break;

                case 7:
                    Console.WriteLine("Programa encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        } while (opcao != 7);
    }

    static void CarregarVetor()
    {
        Console.WriteLine("Digite o tamanho do vetor: ");
        int tamanho = int.Parse(Console.ReadLine());

        vetor = new int[tamanho];

        for (int i = 0; i < tamanho; i++)
        {
            Console.WriteLine("Digite o valor da posição {0}: ", i);
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vetor carregado com sucesso!");
    }

    static void ListarVetor()
    {
        if (vetor == null)
        {
            Console.WriteLine("Vetor não carregado.");
        }
        else
        {
            Console.WriteLine("Valores do vetor:");

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine($"Posição {i}: {vetor[i]}");
            }
        }
    }

    static void ExibirPares()
    {
        if (vetor == null)
        {
            Console.WriteLine("Vetor não carregado.");
        }
        else
        {
            Console.WriteLine("Números pares do vetor:");

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }
    }

    static void ExibirImpares()
    {
        if (vetor == null)
        {
            Console.WriteLine("Vetor não carregado.");
        }
        else
        {
            Console.WriteLine("Números ímpares do vetor:");

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] % 2 != 0)
                {
                    Console.WriteLine(vetor[i]);
                }
            }
        }
    }

    static void QuantidadeParesPosicoesImpares()
    {
        if (vetor == null)
        {
            Console.WriteLine("O vetor está vazio, primeiro carregue ele");
            return;
        }

        int contador = 0;

        for (int i = 0; i < vetor.Length; i += 2)
        {
            if (vetor[i] % 2 == 0)
            {
                contador++;
            }
        }

        Console.WriteLine("Quantidade de números pares nas posições ímpares: {0}", contador);
        Console.WriteLine("");
    }

    static void QuantidadeImparesPosicoesPares()
    {
        if (vetor == null)
        {
            Console.WriteLine("O vetor está vazio, primeiro carregue ele");
            return;
        }

        int contador = 0;

        for (int i = 1; i < vetor.Length; i += 2)
        {
            if (vetor[i] % 2 != 0)
            {
                contador++;
            }
        }
        Console.WriteLine("Quantidade de números ímpares nas posições pares: {0}", contador);
        Console.WriteLine("");
    }
}