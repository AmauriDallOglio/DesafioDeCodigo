using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class AlocacaoRecursosTreinamento
    {
        public void Executar()
        {
            // Leitura do orçamento
            int budget = int.Parse(Console.ReadLine());

            // Leitura dos custos de treinamento e ordenação crescente
            var costs = Console.ReadLine()
                                .Split(',')
                                .Select(int.Parse)
                                .OrderBy(x => x)
                                .ToList();

            List<int> selectedTrainings = new List<int>();
            int totalCost = 0;

            // Seleciona os treinamentos dentro do orçamento
            foreach (var cost in costs)
            {
                if (totalCost + cost <= budget)
                {
                    selectedTrainings.Add(cost);
                    totalCost += cost;
                }
            }

            // Imprime a lista de treinamentos selecionados
            Console.WriteLine(string.Join(",", selectedTrainings));
        }
    }
}


/*
 * 
 * Descrição
Desenvolva um algoritmo que otimize a alocação de recursos para treinamentos. O programa deve receber o orçamento total disponível e uma lista de custos de treinamentos, e retornar a combinação que maximize o número de treinamentos sem exceder o orçamento. Se houver múltiplas combinações possíveis com a mesma quantidade de treinamentos, o programa deve selecionar a combinação que tenha o menor custo total.

Entrada
A entrada é composta por duas linhas, sendo a primeira um número inteiro representando o orçamento, e a segunda uma lista de números inteiros separados por vírgula representando os custos dos treinamentos.

Saída
A saída deve ser uma lista de números inteiros separados por vírgula, representando os custos dos treinamentos selecionados. A lista deve conter a maior quantidade possível de treinamentos sem exceder o orçamento. Se houver várias combinações com a mesma quantidade de treinamentos, retorne aquela que tem o menor valor total.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
1000
300,400,200,350	200,300,350
500
100,200,300,150	100,150,200
2000
500,700,800,1000	500,700,800
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.


 * 
 * 
 * 
 * 
 */