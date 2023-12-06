using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* ATIVIDADE SLIDE 4

Questão 2: Faça o seguinte programa em C#. Uma loja utiliza o código V para compras à
vista e o código P para compras a prazo. Faça um algoritmo que recebe ao código (V ou P)
e o valor de 15 transações. Calcule e mostre:
- O valor total das compras à vista.
- O valor total das compras a prazo.
- O valor total das compras efetuadas.*/

class Program
{
    static void Main()
    {
        char codigo;
        double valor;
        double totalAVista = 0;
        double totalAPrazo = 0;
        double totalGeral = 0;

        for (int i = 1; i <= 15; i++)
        {
            Console.WriteLine("Digite o código (V ou P) da transação {0}: ", i);
            codigo = char.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da transação {0}: ", i);
            valor = double.Parse(Console.ReadLine());
            if (codigo == 'V' || codigo == 'v')
            {
                totalAVista += valor;
            }
            else if (codigo == 'P' || codigo == 'p')
            {
                totalAPrazo += valor;
            }
            totalGeral += valor;
        }

        Console.WriteLine("Valor total das compras à vista: " + totalAVista);
        Console.WriteLine("Valor total das compras a prazo: " + totalAPrazo);
        Console.WriteLine("Valor total das compras efetuadas: " + totalGeral);

        Console.ReadKey();
    }
}