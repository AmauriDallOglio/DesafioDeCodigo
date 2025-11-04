using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.GFTStart7NET
{
    public class VerificacaoVeiculoApto
    {
        public void Executar()
        {

   

            // TODO: Calcule a idade do carro
            int idadeCarro = anoAtual - anoFabricacao;

            // TODO: Verifique se o carro tem até 10 anos
            string status;

            // Critério: Um carro é considerado apto se tiver ATÉ 10 anos de uso (idade <= 10)
            if (idadeCarro <= 10)
            {
                status = "Apto";
            }
            else
            {
                status = "Nao apto";
            }

            // Retorna a mensagem formatada
            return $"{modelo}: {status}";
        }

        static void Main()
        {
            // Lendo os dados de entrada
            string modelo = Console.ReadLine();
            int anoFabricacao = int.Parse(Console.ReadLine());
            int anoAtual = int.Parse(Console.ReadLine());

            // TODO: Implemente a chamada do método para verificar se o carro está apto
            // Chamada do método estático diretamente usando o nome da classe.
            string resultado = VerificarAptidao(modelo, anoFabricacao, anoAtual);

            // Exibindo o resultado
            Console.WriteLine(resultado);
        }
    }
}

/*
 * 
 * Descrição
Um aplicativo de monitoramento de carros precisa verificar se um carro está apto para rodar com base no ano de fabricação e no ano atual. Um carro é considerado apto se tiver até 10 anos de uso. Para resolver este desafio, você deve utilizar conceitos de Programação Orientada a Objetos (POO), como a definição de métodos estáticos, para realizar a verificação da aptidão do carro sem a necessidade de instanciar objetos. A aplicação de POO deve ser utilizada para organizar a lógica de verificação do carro e para retornar o resultado da aptidão de forma estruturada.

Entrada
A entrada deve conter:

O modelo do carro (String).
O ano de fabricação (int).
O ano atual (int).
Saída
Deverá retornar uma mensagem indicando se o carro está apto ou não.

Retorno em formato de mensagem.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Civic
2015
2025	Civic: Apto
Gol
2012
2025	Gol: Nao apto
Corolla
2018
2025	Corolla: Apt
 * 
 * 
 * 
 */