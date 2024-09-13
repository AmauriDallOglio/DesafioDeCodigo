using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class AvaliandoDesempenhoAnualDosFuncionarios
    {
        public void Executar()
        {
            // Entrada das notas
            string entrada = Console.ReadLine();

            // Separar os valores e convertê-los para inteiros
            string[] notasString = entrada.Split(',');
            int produtividade = int.Parse(notasString[0]);
            int qualidade = int.Parse(notasString[1]);
            int pontualidade = int.Parse(notasString[2]);

            // TODO: Calcule a média

            double media = (produtividade + qualidade + pontualidade) / 3.0;
            // TODO: Verifique a elegibilidade para bônus
            string elegivelParaBonus = media >= 7.0 ? "Sim" : "Nao";

            // Exibir os resultados
            Console.WriteLine($"Media: {media}");
            Console.WriteLine($"Elegivel para bonus: {elegivelParaBonus}");
        }
    }
}


/*
 * 
 * Descrição
Uma empresa realiza uma avaliação anual de desempenho de seus funcionários, utilizando três critérios principais: produtividade, qualidade do trabalho e pontualidade. Cada critério recebe uma nota que varia de 0 a 10. O objetivo do sistema é calcular a média das notas e determinar se o funcionário é elegível para receber um bônus anual.

Para ser elegível ao bônus, o funcionário precisa obter uma média igual ou superior a 7,0.

Entrada
Você receberá uma string contendo três valores inteiros separados por vírgula (,). Esses valores representam as notas atribuídas a cada critério, na seguinte ordem:

Produtividade
Qualidade do Trabalho
Pontualidade
Saída
O programa deve imprimir duas linhas:

A primeira linha deve mostrar a média das três notas, formatada com duas casas decimais.
A segunda linha deve informar se o funcionário é elegível para o bônus, exibindo Sim ou Nao.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
8,7,9	Media: 8
Elegivel para bonus: Sim
6,5,7	Media: 6
Elegivel para bonus: Nao
10,9,8	Media: 9
Elegivel para bonus: Sim
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.
 * 
 */