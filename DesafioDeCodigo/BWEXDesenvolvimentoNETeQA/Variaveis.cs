using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.BWEXDesenvolvimentoNETeQA
{
    public class Variaveis
    { 
    public void executar()
    {
        // Solicita ao usuário a entrada para o número de testes passados
        int testesPassados = Convert.ToInt32(Console.ReadLine());

        // Solicita ao usuário a entrada para o número total de testes
        int totalTestes = Convert.ToInt32(Console.ReadLine());

        // TODO: Calcule a taxa de sucesso e armazená-la na variável taxaSucesso:
        double taxaSucesso = (double)testesPassados / totalTestes * 100;

        // Exibe a taxa de sucesso com 2 casas decimais
        Console.WriteLine($"Taxa de sucesso: {taxaSucesso:F2}%");
    }
}
}


/*
 * 
 * Descrição
Neste desafio, seu objetivo é criar um algoritmo que avalie o desempenho de testes automatizados. O algoritmo deve receber como entrada o número de testes automatizados bem-sucedidos e o número total de testes automatizados realizados. Com base nessas informações, ele determinará a taxa de sucesso do teste.

Críterios da taxa:
Taxa de Sucesso = (Número de Testes Automatizados Bem-sucedidos / Número Total de Testes Automatizados Realizados) * 100

Entrada
A entrada consiste em dois números inteiros: o número de testes automatizados bem-sucedidos e o número total de testes automatizados realizados.

Saída
A saída é uma string que informa a porcentagem ( taxaSucesso) da taxa de sucesso dos testes automatizados, indicando se a funcionalidade testada está estável. A saída deve considerar duas casas decimais para essa solução.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
10
20	Taxa de sucesso: 50.00%
10
25	Taxa de sucesso: 40.00%
3
5	Taxa de sucesso: 60.00%
 */