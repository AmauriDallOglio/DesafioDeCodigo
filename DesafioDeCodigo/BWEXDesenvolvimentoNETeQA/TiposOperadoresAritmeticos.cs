namespace DesafioDeCodigo.BWEXDesenvolvimentoNETeQA
{
    public class TiposOperadoresAritmeticos
    {
        public void Executar()
        {

            // Solicita ao usuário que insira a quantidade de testes bem-sucedidos e totais
            Console.WriteLine("Digite a quantidade de testes bem-sucedidos:");
            int testesBemSucedidos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade total de testes realizados:");
            int testesTotais = int.Parse(Console.ReadLine());

            // Calcula a taxa de sucesso
            double taxaSucesso = (double)testesBemSucedidos / testesTotais;

            // Verifica os critérios e exibe a mensagem correspondente
            if (taxaSucesso >= 0.8)
            {
                Console.WriteLine("A funcionalidade esta pronta para lancamento.");
            }
            else
            {
                Console.WriteLine("A funcionalidade nao esta pronta para lancamento.");
            }

        }
    }
}


/*
 * 
 * 
 * Descrição
Neste desafio de código, você será encarregado de criar um programa que avalia a prontidão de uma funcionalidade com base nos resultados de um conjunto de testes. O programa solicitará ao usuário que insira a quantidade de testes bem-sucedidos e a quantidade total de testes realizados. Em seguida, o programa calculará a taxa de sucesso dos testes e aplicará os seguintes critérios para determinar se a funcionalidade está pronta para ser lançada:

    * Se a taxa de sucesso for maior ou igual a 80%, o programa exibirá a mensagem "A funcionalidade esta pronta para lancamento."
    * Caso contrário, se a taxa de sucesso for menor que 80%, o programa exibirá a mensagem "A funcionalidade nao esta pronta para lancamento."

Lembre-se de que a taxa de sucesso é calculada como a proporção de testes bem-sucedidos em relação ao total de testes, usando a fórmula: taxaSucesso = (double)testesBemSucedidos / testesTotais.

Entrada
A entrada consiste em dois números inteiros separados por quebras de linha. O primeiro número representa a quantidade de testes bem-sucedidos, e o segundo número representa a quantidade total de testes realizados.

Saída
O programa exibirá uma mensagem que indicará se a funcionalidade está pronta para o lançamento ou não, de acordo com os critérios mencionados acima.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
7
12	A funcionalidade nao esta pronta para lancamento.
50
60	A funcionalidade esta pronta para lancamento.
4
5	A funcionalidade esta pronta para lancamento.

 salvo 7 minutos atrás
  class Program {


TESTES

/tmp/tmpmubqkg_s/test2340.cs(13,24): error CS1525: Unexpected symbol `taxaSucesso', expecting `,', `;', or `=' Compilation failed: 1 error(s), 0 warnings
Teste #1

Teste #2

Teste #3

Teste #4

Dúvidas ?
 * 
 * */