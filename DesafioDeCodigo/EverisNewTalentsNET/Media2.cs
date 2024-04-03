using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.EverisNewTalentsNET
{
    public class Media2
    {
        public void Executar()
        {
            double A, B, C;

            // Ler as notas do aluno
            Console.WriteLine($"Digite o número 1: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o número 2: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o número 3: ");
            C = double.Parse(Console.ReadLine());

            // Calcular a média ponderada
            double media = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);

            // Imprimir o resultado formatado
            Console.WriteLine("MEDIA = " + String.Format("{0:0.0}", media));
            Console.ReadKey();
        }
    }
}


/*
 * 
 * Leia 3 valores, no caso, variáveis A, B e C, que são as três notas de um aluno. A seguir, calcule a média do aluno, sabendo que a nota A tem peso 2, a nota B tem peso 3 e a nota C tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

Entrada
O arquivo de entrada contém 3 valores com uma casa decimal, de dupla precisão (double).

Saída
Imprima a variável MEDIA conforme exemplo abaixo, com 1 dígito após o ponto decimal e com um espaço em branco antes e depois da igualdade. Assim como todos os problemas, não esqueça de imprimir o fim de linha após o resultado, caso contrário, você receberá "Presentation Error".

 
Exemplos de Entrada	Exemplos de Saída
5.0
6.0
7.0

MEDIA = 6.3

5.0
10.0
10.0

MEDIA = 9.0

10.0
10.0
5.0

MEDIA = 7.5
 * 
 * 
 */