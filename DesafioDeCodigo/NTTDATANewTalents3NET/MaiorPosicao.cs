using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.NTTDATANewTalents3NET
{
    public class MaiorPosicao
    {
        public void Executar()
        {
            int maior = int.MinValue;
            int posicao = 0;

            for (int i = 1; i <= 100; i++)
            {
                int valor = int.Parse(Console.ReadLine());

                if (valor > maior)
                {
                    maior = valor;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}


/*
 * 
 * Desafio
Você recebeu o desafio de ler 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

Entrada
O arquivo de entrada contém 100 números inteiros, positivos e distintos.

Saída
Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.

 
Exemplo de Entrada	Exemplo de Saída
2
113
45
34565
6
...
8
 

34565
4
 * 
 */