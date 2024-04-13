using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class SequenciaS
    {
        public void Executar()
        {

            double S = 0;

            for (int i = 1; i <= 100; i++)
            {
                S += 1.0 / i;
            }

            Console.WriteLine(S.ToString("F2"));
        }
    }
}


/*
 * 
 * Desafio
Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100

Entrada
Não há nenhuma entrada neste problema.

Saída
A saída contém um valor correspondente ao valor de S.
O valor deve ser impresso com dois dígitos após o ponto decimal.

 
Exemplo de Entrada	Exemplo de Saída
No need input, check output only!	5.19
 * 
 * 
 * 
 */