﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.EverisNewTalentsNET
{
    public class EncaixaOuNao
    {
        public void Executar()
        {
            Console.WriteLine($"Digite o número: ");
            int qt = int.Parse(Console.ReadLine());

            for (int i = 0; i < qt; ++i)
            {
                string[] v = Console.ReadLine().Split();
                string a = v[0];
                string b = v[1];

                if (b.Length > a.Length)
                {
                    Console.WriteLine("nao encaixa");
                }
                else if (a.Substring(a.Length - b.Length) == b)
                {
                    Console.WriteLine("encaixa");
                }
                else
                {
                    Console.WriteLine("nao encaixa");
                }
            }
        }
    }
}


/*
 * 
 * 
 * 
 * Desafio
Paulinho tem em suas mãos um novo problema. Agora a sua professora lhe pediu que construísse um programa para verificar, à partir de dois valores muito grandes A e B, se B corresponde aos últimos dígitos de A.

Entrada
A entrada consiste de vários casos de teste. A primeira linha de entrada contém um inteiro N que indica a quantidade de casos de teste. Cada caso de teste consiste de dois valores A e B maiores que zero, cada um deles podendo ter até 1000 dígitos.

Saída
Para cada caso de entrada imprima uma mensagem indicando se o segundo valor encaixa no primeiro valor, confome exemplo abaixo.

 
Exemplo de Entrada	Exemplo de Saída
4
56234523485723854755454545478690 78690
5434554 543
1243 1243
54 64545454545454545454545454545454554

encaixa
nao encaixa
encaixa
nao encaixa
 * 
 * 
 */