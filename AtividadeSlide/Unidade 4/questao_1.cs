using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ATIVIDADE SLIDE 4

Questão 1: Faça um programa em C# (com a estrutura do...while) que leia 20 valores
inteiros e:
- Encontre e mostre o maior valor;
- Encontre e mostre o menor valor;
- Calcule e mostre a média dos números lidos;*/

class Program
{
    static void Main()
    {
        int i = 0, sum = 0, min = int.MaxValue, max = int.MinValue;

        Console.WriteLine("Digite 20 números inteiros:");

        do
        {
            int number = int.Parse(Console.ReadLine());
            sum += number;
            if (number < min)
                min = number;
            if (number > max)
                max = number;
            i++;
        } while (i < 20);

        Console.WriteLine("O maior valor é: " + max);
        Console.WriteLine("O menor valor é: " + min);
        Console.WriteLine("A média dos números é: " + (sum / 20.0));

        Console.ReadKey();
    }
}