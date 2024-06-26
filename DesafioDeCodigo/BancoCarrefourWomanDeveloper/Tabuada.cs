﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.BancoCarrefourWomanDeveloper
{
    public class Tabuada
    {
        public void Executar()
        {
   
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"Digite o número: ");
                Console.WriteLine($"{i} x {n} = {i * n}");
            }
        }
    }
}

/*
 * 
 * Leia 1 valor inteiro N (2 < N < 1000). A seguir, mostre a tabuada de N:      
1 x N = N      2 x N = 2N        ...       10 x N = 10N

Entrada
A entrada contém um valor inteiro N (2 < N < 1000).

Saída
Imprima a tabuada de N, conforme o exemplo fornecido.

 
Exemplo de Entrada	Exemplo de Saída
140

1 x 140 = 140
2 x 140 = 280
3 x 140 = 420
4 x 140 = 560
5 x 140 = 700
6 x 140 = 840
7 x 140 = 980
8 x 140 = 1120
9 x 140 = 1260
10 x 140 = 1400
 * 
 * 
 */