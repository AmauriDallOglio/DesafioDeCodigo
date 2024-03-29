using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DesafioDeCodigo.AvanadeCodeAnywhereNET
{
    public class FormulaDeBhaskara
    {
        public void Executar()
        {
            double a, b, c, delta, r1, r2;
            Console.WriteLine($"Digite o número: ");
            string[] valor = Console.ReadLine().Split();

            a = Convert.ToDouble(valor[0]);
            b = Convert.ToDouble(valor[1]);
            c = Convert.ToDouble(valor[2]);
            delta = Math.Pow(b, 2) - 4 * a * c;

            // Verifica se a é diferente de zero e se delta é maior ou igual a zero
            if (a != 0 && delta >= 0)
            {
                // Calcula as raízes
                r1 = (-b + Math.Sqrt(delta)) / (2 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2 * a);

                // Imprime as raízes com cinco dígitos após o ponto
                Console.WriteLine($"R1 = {r1:F5}");
                Console.WriteLine($"R2 = {r2:F5}");
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}


/*
 * 
 * 
 * Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.

Entrada
Leia três valores de ponto flutuante (double) A, B e C.

Saída
Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.

 
Exemplos de Entrada	Exemplos de Saída
10.0 20.1 5.1

R1 = -0.29788
R2 = -1.71212

0.0 20.0 5.0

Impossivel calcular

10.3 203.0 5.0

R1 = -0.02466
R2 = -19.68408

10.0 3.0 5.0

Impossivel calcular
 * 
 * 
 * 
 */