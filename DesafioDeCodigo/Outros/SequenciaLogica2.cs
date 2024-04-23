using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class SequenciaLogica2
    {
        public void Executar()
        {
            Console.WriteLine("Digite o valor: ");
            string[] valores = Console.ReadLine().Split(' ');

            int X = int.Parse(valores[0]);
            int Y = int.Parse(valores[1]);

            for (int i = 1; i <= Y; i++)
            {
                Console.Write(i);

                if (i % X == 0 || i == Y)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}

/*
 * 
 * Exemplo de Entrada	Exemplo de Saída
3 99

1 2 3
4 5 6
7 8 9
10 11 12
...
97 98 99
 * 
 */