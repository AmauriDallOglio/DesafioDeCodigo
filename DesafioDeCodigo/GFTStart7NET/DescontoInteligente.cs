using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.GFTStart7NET
{
    public class DescontoInteligente
    {
        public void Executar()
        {
            // Define a cultura para garantir a leitura correta de doubles (importante para sistemas de avaliação)
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Lê o valor original do produto
            double valorOriginal = Convert.ToDouble(Console.ReadLine());

            // Lê a porcentagem de desconto
            double porcentagemDesconto = Convert.ToDouble(Console.ReadLine());

            // TODO: Verifique se o desconto está dentro de um intervalo válido
            if (porcentagemDesconto >= 0 && porcentagemDesconto <= 100)
            {
                // Se o desconto for válido, calcula o valor final

                // Converte a porcentagem para um fator de desconto (ex: 10% -> 0.10)
                double fatorDesconto = porcentagemDesconto / 100.0;

                // O valor final é o valor original menos o valor do desconto.
                // Alternativamente: valorOriginal * (1 - fatorDesconto)
                double valorDesconto = valorOriginal * fatorDesconto;

                // TODO: Calcule o valor final do produto
                double valorFinal = valorOriginal - valorDesconto;

                // Exibe o valor com duas casas decimais
                // Usa o formatador "F2" para garantir duas casas decimais.
                // É recomendável usar CultureInfo.InvariantCulture na formatação também,
                // ou usar a interpolação com CultureInfo.CurrentCulture ajustada.
                Console.WriteLine(valorFinal.ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                // Se o desconto for inválido, exibe a mensagem de erro
                Console.WriteLine("Desconto invalido");
            }
        }
    }
}

/*
 * 
 * Descrição
Uma loja online deseja calcular o valor final de um produto após aplicar um desconto percentual.

Entrada
A entrada deve conter:

O valor original do produto (double).
A porcentagem de desconto (double).
Saída
Deverá retornar o valor final do produto, formatado com duas casas decimais. Caso a porcentagem de desconto seja inválida (menor que 0 ou maior que 100), deverá retornar a mensagem Desconto invalido

Retorno numérico formatado ou mensagem de erro: Desconto invalido
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
100
10	90.00
250
15	212.50
80
5	76.00
50
150	Desconto invalido
 * 
 * 
 */