using System.Globalization;

namespace DesafioDeCodigo.GFTStart7NET
{
    public class CalculoFreteRapido
    {
        public void Executar()
        {
            // Define a cultura para garantir o formato de ponto flutuante (opcional, mas boa prática)
            // Usando InvariantCulture para ler e converter doubles
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            // Lê o peso em quilos
            double peso = Convert.ToDouble(Console.ReadLine());

            // TODO: Leia o valor do frete por quilo
            double valorPorQuilo = Convert.ToDouble(Console.ReadLine());

            // TODO: Calcule o valor total do frete
            double valorTotalFrete = peso * valorPorQuilo;

            // TODO: Exiba o valor formatado com duas casas decimais
            // O especificador "F2" garante duas casas decimais.
            // O CultureInfo.InvariantCulture é usado aqui para garantir que o separador decimal seja o '.' (ponto)
            // ou o formato esperado pelo sistema de avaliação. Se o sistema esperar ',', use CultureInfo("pt-BR").
            Console.WriteLine(valorTotalFrete.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}


/*
 * 
 * Descrição
Uma empresa de logística precisa calcular o valor total de um frete com base no peso da carga e no valor do frete por quilo.

Entrada
A entrada deve conter:

O peso em quilos (double).
O valor do frete por quilo (double).
Saída
O programa deverá retornar o valor total do frete, formatado com duas casas decimais.

Retorno numérico formatado.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
10
5	50.00
3.5
12	42.00
7
7.5	52.50
 * 
 * 
 */