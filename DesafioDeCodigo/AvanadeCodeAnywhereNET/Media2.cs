using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AvanadeCodeAnywhereNET
{
    public class Media2
    {
        public void Executar()
        {
            double A, B, C;

            Console.WriteLine($"Digite o número: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o número: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o número: ");
            C = double.Parse(Console.ReadLine());

            double media = (A * 2 + B * 3 + C * 5) / 10.0;

            Console.WriteLine("MEDIA = " + media.ToString("F1"));
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