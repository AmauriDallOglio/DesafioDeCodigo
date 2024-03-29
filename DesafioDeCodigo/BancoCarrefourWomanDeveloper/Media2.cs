using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.BancoCarrefourWomanDeveloper
{
    public class Media2
    {
        public void Executar()
        {
            double A, B, C;

            // Lendo as notas do aluno
            Console.WriteLine($"Digite o número: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o número: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite o número: ");
            C = double.Parse(Console.ReadLine());

            // Calculando a média ponderada
            double MEDIA = ((A * 2) + (B * 3) + (C * 5)) / (2 + 3 + 5);

            // Imprimindo a média com uma casa decimal
            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1"));
        }
    }
}

/*
 * 
 * Saída
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
 */