﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.NTTDATANewTalents3NET
{
    public class PUM
    {
        public void Executar() 
        {
            static void Main(string[] args)
            {

                int N = int.Parse(Console.ReadLine());

                int primeiro = 1;
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine($"{primeiro} {primeiro + 1} {primeiro + 2} PUM");
                    primeiro += 4;
                }
            }
        }
    }
}

/*
 * Desafio
Desenvolva um programa que leia um valor inteiro N. Este N refere-se à quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada
O arquivo de entrada contém um número inteiro positivo N.

Saída
Imprima a saída conforme o exemplo fornecido.

 
Exemplo de Entrada	Exemplo de Saída
7

1 2 3 PUM
5 6 7 PUM
9 10 11 PUM
13 14 15 PUM
17 18 19 PUM
21 22 23 PUM
25 26 27 PUM
 * 
 * 
 */