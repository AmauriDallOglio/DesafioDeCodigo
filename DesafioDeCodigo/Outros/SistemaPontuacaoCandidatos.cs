using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class SistemaPontuacaoCandidatos
    {
        public void Executar()
        {
            // Ler os pesos dos critérios
            var weights = Console.ReadLine().Split(',').Select(double.Parse).ToArray();

            // Ler a quantidade de candidatos
            int numberOfCandidates = int.Parse(Console.ReadLine());

            // Inicializar variáveis para armazenar o nome do candidato com a maior pontuação e a pontuação máxima
            string topCandidate = "";
            double maxScore = double.MinValue;

            // Processar cada candidato
            for (int i = 0; i < numberOfCandidates; i++)
            {
                // Ler os dados do candidato
                var input = Console.ReadLine().Split(',');
                string name = input[0].Trim();
                var scores = input.Skip(1).Select(double.Parse).ToArray();

                // Calcular a pontuação total
                double totalScore = CalculateTotalScore(scores, weights);

                // Verificar se este candidato tem a maior pontuação
                if (totalScore > maxScore)
                {
                    maxScore = totalScore;
                    topCandidate = name;
                }
            }

            // Imprimir o nome do candidato com a maior pontuação
            Console.WriteLine($"Candidato {topCandidate}");
        }
        static double CalculateTotalScore(double[] scores, double[] weights)
        {
            // Calcular a pontuação total como a soma dos produtos das pontuações pelos pesos
            double totalScore = 0.0;
            for (int i = 0; i < scores.Length; i++)
            {
                totalScore += scores[i] * weights[i];
            }
            return totalScore;
        }
    }
}


/*
 * 
 * 
 * Descrição
Desenvolva um sistema para avaliar candidatos com base em múltiplos critérios de pontuação. Cada critério possui um peso específico que determina a importância relativa do critério na pontuação total do candidato. O sistema deve calcular a pontuação total para cada candidato, considerando os pesos dos critérios fornecidos, e retornar o nome do candidato com a maior pontuação total precedido pela palavra "Candidato".

Entrada
A entrada é composta pelos seguintes valores:

Pesos dos Critérios: Uma string representando uma lista de pesos para cada critério, separados por vírgula.
Quantidade de Candidatos: Um número inteiro representando a quantidade de candidatos.
Dados dos Candidatos: Para cada candidato, uma string que contém:
O nome do candidato.
Uma lista de pontuações para cada critério, separados por vírgula.
Cada linha subsequente após a quantidade de candidatos contém essas informações para um candidato.
Saída
O sistema deve retornar o nome do candidato com a maior pontuação total, precedido pela palavra "Candidato".

A pontuação total de um candidato é calculada como a soma do produto de cada pontuação pelo seu peso correspondente.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
0.6, 0.5
2
A, 80, 90
B, 90, 60	Candidato A

0.4, 0.3
3
A, 85, 75
B, 80, 90
C, 75, 85	Candidato B

0.6, 0.4
3
X, 70, 85
Y, 80, 85
Z, 70, 80	Candidato Y

Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.
 * 
 * 
 */