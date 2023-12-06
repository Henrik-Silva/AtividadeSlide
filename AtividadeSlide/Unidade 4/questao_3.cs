using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ATIVIDADE SLIDE 4
 
Questão 3: Faça o seguinte programa em C#. A prefeitura de Luziânia fez uma pesquisa
com 200 pessoas, coletando dados sobre o salário e o número de filhos. A prefeitura deseja
saber:
- A média do salário dessas pessoas.
- A média do número de filhos.
- O maior salário.
- O menor salário.
- A porcentagem de pessoas com salários até R$1500,00*/

class Program
{
    static void Main()
    {
        int numPessoas = 200;
        double salario;
        int numFilhos;
        double somaSalario = 0;
        int somaFilhos = 0;
        double maiorSalario = double.MinValue;
        double menorSalario = double.MaxValue;
        int numSalariosAte1500 = 0;

        for (int i = 1; i <= numPessoas; i++)
        {
            Console.WriteLine("Digite o salário da pessoa {0}: ", i);
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de filhos da pessoa {0}: ", i);
            numFilhos = int.Parse(Console.ReadLine());

            somaSalario += salario;
            somaFilhos += numFilhos;

            if (salario > maiorSalario)
            {
                maiorSalario = salario;
            }
            if (salario < menorSalario)
            {
                menorSalario = salario;
            }
            if (salario <= 1500)
            {
                numSalariosAte1500++;
            }
        }

        double mediaSalario = somaSalario / numPessoas;
        double mediaFilhos = (double)somaFilhos / numPessoas;
        double percentualSalariosAte1500 = (double)numSalariosAte1500 / numPessoas * 100;

        Console.WriteLine("Média do salário: " + mediaSalario);
        Console.WriteLine("Média do número de filhos: " + mediaFilhos);
        Console.WriteLine("Maior salário: " + maiorSalario);
        Console.WriteLine("Menor salário: " + menorSalario);
        Console.WriteLine("Percentual de pessoas com salários até R$1500,00: " + percentualSalariosAte1500 + "%");

        Console.ReadKey();
    }
}