using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AvanadeFullstackDeveloper
{
    public class QuadradoAoCubo
    {
        public void Executar()
        {
            Console.WriteLine("Digite o número: ");
            var numero = Console.ReadLine();

            if (int.TryParse(numero, out int n) && n > 0 && n < 1000)
            {
                for (int i = 1; i <= n; i++)
                {
                    var numeros = $"{i} {i * i} {i * i * i}";
                    Console.WriteLine(numeros);
                }
            }
            else
            {
                Console.WriteLine("Insira um número válido!");
            }
        }
    }
}


/*
 * 
 * 
 * Desafio
Você terá o desafio de escrever um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.

Entrada
O arquivo de entrada contém um número inteiro positivo N.

Saída
Imprima a saída conforme o exemplo fornecido.

 
Exemplo de Entrada	Exemplo de Saída
5

1 1 1
2 4 8
3 9 27
4 16 64
5 25 125


 * 
 * 
 * 
 */