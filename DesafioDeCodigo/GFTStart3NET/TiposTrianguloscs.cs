﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.GFTStart3NET
{
    public class TiposTrianguloscs
    {
        public void Ecexutar()
        {
            string[] s = Console.ReadLine().Split(' ');
            Console.WriteLine($"Digite o valor a:");
            double a = double.Parse(s[0]);
            Console.WriteLine($"Digite o valor b:");
            double b = double.Parse(s[1]);
            Console.WriteLine($"Digite o valor c:");
            double c = double.Parse(s[2]);

            // Ordenação dos valores em ordem decrescente
            double temp;
            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (b < c)
            {
                temp = b;
                b = c;
                c = temp;
            }

            // Verificação se forma um triângulo
            if (a >= b + c)
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
                return;
            }

            // Verificação do tipo de triângulo
            if (a * a == b * b + c * c)
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            if (a * a > b * b + c * c)
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            if (a * a < b * b + c * c)
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }
            if (a == b && b == c)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            }
            if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}


/*
 * 
 * Leia 3 valores de ponto flutuante A, B e C e ordene-os em ordem decrescente, de modo que o lado A representa o maior dos 3 lados. A seguir, determine o tipo de triângulo que estes três lados formam, com base nos seguintes casos, sempre escrevendo uma mensagem adequada:

se A ≥ B+C, apresente a mensagem: NAO FORMA TRIANGULO
se A2 = B2 + C2, apresente a mensagem: TRIANGULO RETANGULO
se A2 > B2 + C2, apresente a mensagem: TRIANGULO OBTUSANGULO
se A2 < B2 + C2, apresente a mensagem: TRIANGULO ACUTANGULO
se os três lados forem iguais, apresente a mensagem: TRIANGULO EQUILATERO
se apenas dois dos lados forem iguais, apresente a mensagem: TRIANGULO ISOSCELES
Entrada
A entrada contem três valores de ponto flutuante de dupla precisão A (0 < A) , B (0 < B) e C (0 < C).

Saída
Imprima todas as classificações do triângulo especificado na entrada.

 
Exemplos de Entrada	Exemplos de Saída
7.0 5.0 7.0

TRIANGULO ACUTANGULO
TRIANGULO ISOSCELES

6.0 6.0 10.0

TRIANGULO OBTUSANGULO
TRIANGULO ISOSCELES

6.0 6.0 6.0     

TRIANGULO ACUTANGULO
TRIANGULO EQUILATERO

5.0 7.0 2.0        

NAO FORMA TRIANGULO

6.0 8.0 10.0     

TRIANGULO RETANGULO
 * 
 */