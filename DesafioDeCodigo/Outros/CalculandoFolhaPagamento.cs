using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class CalculandoFolhaPagamento
    {
        public void Executar()
        {
            // Leitura da entrada como uma string
            string entrada = Console.ReadLine();

            // Separar a string e converter para uma lista de números
            decimal[] valores = entrada.Split(',').Select(decimal.Parse).ToArray();

            // Atribuir os valores às variáveis correspondentes
            decimal salarioBase = valores[0];
            int horasExtras = (int)valores[1];
            decimal valorHoraExtra = valores[2];
            decimal descontoIR = valores[3];
            decimal descontoINSS = valores[4];

            // Calcular o salário líquido
            decimal salarioLiquido = salarioBase + (horasExtras * valorHoraExtra) - descontoIR - descontoINSS;

            // Exibição do resultado
            Console.WriteLine($"{salarioLiquido:F2}");
        }
    }
}


/*
 * 
 * 
 * Descrição
Você foi contratado para desenvolver uma aplicação que automatize o cálculo da folha de pagamento de uma empresa. A aplicação deve considerar o salário base do funcionário, as horas extras trabalhadas e descontos, como imposto de renda e contribuição previdenciária. O objetivo é calcular o salário líquido de cada funcionário ao final do mês.

Para o cálculo considere a fórmula:

Salário Líquido = Salário Base + (Horas Extras Trabalhadas * Valor por Hora Extra) - Desconto de Imposto de Renda - Desconto de Contribuição Previdenciária

Entrada
A entrada é uma string representando uma lista com cinco valores numéricos separados por vírgula (,), na seguinte ordem:

Salário base (um valor decimal que representa o salário fixo do funcionário).
Horas extras trabalhadas (um valor inteiro que indica o número de horas extras realizadas pelo funcionário).
Valor por hora extra (um valor decimal que representa quanto o funcionário ganha por hora extra trabalhada).
Desconto de imposto de renda (um valor decimal que representa o valor do imposto a ser descontado do salário).
Desconto de contribuição previdenciária (um valor decimal que representa a contribuição previdenciária a ser descontada).
Saída
A saída deverá retornar o salário líquido do funcionário com duas casas decimais.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
2500, 0, 50, 250, 150
2100.00
4000, 8, 40, 400, 300	3620.00
4500, 5, 60, 450, 350	4000.00
 * 
 * 
 */