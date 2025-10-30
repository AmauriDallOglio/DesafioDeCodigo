using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.WEX_End_to_End_Engineering
{
    public class ControleLimiteCartaoCorporativo
    {

        public void Executar()
        {
            int quantidade = int.Parse(Console.ReadLine());
            List<int> despesas = new List<int>();

            for (int i = 0; i < quantidade; i++)
            {
                int valor = int.Parse(Console.ReadLine());
                // Adiciona o valor à lista somente se for maior que zero
                if (valor > 0)
                {
                    despesas.Add(valor);
                }
            }
            if (despesas.Count == 0)
            {
                Console.WriteLine("Sem despesas validas");
            }
            else
            {
                // Imprime cada valor da lista de despesas válidas
                foreach (int despesa in despesas)
                {
                    Console.WriteLine(despesa);
                }
            }
        }

    }
}


/*
 * 
 * 
 * Descrição
Em uma empresa de soluções financeiras, os dados de despesas são recebidos diariamente para análise. No entanto, somente despesas com valores positivos devem ser consideradas válidas para o relatório. Sua tarefa é criar um programa que filtre apenas essas despesas.

Entrada
A entrada deve conter a quantidade total de despesas registradas, seguida dos valores (inteiros) de cada uma.

O primeiro valor representa o número total de despesas.
Os valores seguintes representam cada despesa registrada.
Saída
Deverá exibir apenas os valores válidos (maiores que zero), um por linha. Caso nenhuma despesa válida seja encontrada, exibir “Sem despesas validas”.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
4
100
-20
0
90	100
90
3
-50
-10
0	Sem despesas validas
2
150
30	150
30
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.

Os desafios apresentados aqui têm como objetivo principal exercitar os conceitos aprendidos e proporcionar um primeiro contato com lógica de programação. Caso não tenha experiência em programação, utilize o template disponível e preencha com os conceitos aprendidos. Para resetar o template, basta clicar em “Restart Code”.



*/