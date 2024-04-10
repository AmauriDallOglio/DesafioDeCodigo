using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.NTTDATANewTalents3NET
{
    public class PoligonosRegularesSimples
    {
        public void Executar()
        {
            string[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]);
            int L = int.Parse(input[1]);

            long perimeter = (long)N * L;
            Console.WriteLine(perimeter);
        }
    }
}
/*
 * 
 * 
 * 
 * A entrada tem dois inteiros positivos: N e L, que são, respectivamente, o número de lados e o comprimento de cada lado de um polígono regular (3 ≤ N ≤ 1000000 and 1 ≤ L ≤ 4000).

Saída
A saída é o perímetro P do polígono regular em uma única linha.

 
Exemplos de Entrada	Exemplos de Saída
3 1

3

 
9 8

72

 
1000000 1000

1000000000

Prova 1 de Programação de Computadores da UNILA (2015/2)
 * 
 * 
 * 
 */