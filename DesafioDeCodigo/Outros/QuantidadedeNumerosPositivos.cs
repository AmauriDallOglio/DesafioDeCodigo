using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class QuantidadedeNumerosPositivos
    {
        public void Executar()
        {
            // Variável para armazenar a quantidade de valores positivos
            int positivos = 0;

            // Lê os seis valores
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite o valor: ");
                double valor = double.Parse(Console.ReadLine());
                // Verifica se o valor é positivo e incrementa a contagem, se for o caso
                if (valor > 0)
                {
                    positivos++;
                }
            }

            // Exibe a quantidade de valores positivos
            Console.WriteLine(positivos + " valores positivos");

        }
    }
}


/*
 * 
 * Desafio
Crie um programa que leia 6 valores, os quais poderão ser negativos e/ou positivos. Em seguida, apresente a quantidade de valores positivos digitados.

Entrada
Você receberá seis valores, negativos e/ou positivos.

Saída
Exiba uma mensagem dizendo quantos valores positivos foram lidos. assim como é exibido abaixo no exemplo de saída. Não se esqueça de incluir na mensagem de saída o sufixo " valores positivos", conforme o exemplo abaixo:

 
Exemplo de Entrada	Exemplo de Saída
7
-5
6
-3.4
4.6
12

4 valores positivos
 * 
 * 
 * 
 * 
 */