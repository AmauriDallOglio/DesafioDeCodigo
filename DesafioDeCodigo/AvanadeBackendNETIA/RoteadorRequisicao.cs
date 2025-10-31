using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AvanadeBackendNETIA
{
    public class RoteadorRequisicao
    {
        public void Executar()
        {
            

 
                // Lê uma linha do console e armazena na variável 'endpoint'.
                string endpoint = Console.ReadLine();

                // Utiliza a estrutura switch para rotear o endpoint para a ação correspondente.
                switch (endpoint)
                {
                    case "/clientes":
                        // Exibe mensagem informando que está listando clientes.
                        Console.WriteLine("Listando clientes...");
                        break;
                    case "/produtos":
                        // Exibe mensagem informando que está mostrando produtos disponíveis.
                        Console.WriteLine("Exibindo produtos disponiveis...");
                        break;
                    case "/relatorios":
                        // Exiba mensagem informando que está gerando relatório de desempenho.
                        Console.WriteLine("Gerando relatorio de desempenho...");
                        break;
                    default:
                        // Caso o endpoint não seja reconhecido exiba mensagem: Endpoint nao reconhecido.
                        Console.WriteLine("Endpoint nao reconhecido.");
                        break;
                }
            
        }

    }
}


/*
 * 
 * Descrição
Você trabalha em uma consultoria que está iniciando um projeto para simular uma API interna sem uso de frameworks. Sua tarefa é criar um sistema simples que receba um "endpoint" e retorne a ação correspondente, como se estivesse roteando a requisição para a função correta.

Entrada
A entrada deverá receber uma string representando o endpoint da requisição:

/clientes
/produtos
/relatorios
Saída
O programa deverá retornar uma mensagem correspondente ao endpoint:

Se for /clientes, retornar: Listando clientes...
Se for /produtos, retornar: Exibindo produtos disponiveis...
Se for /relatorios, retornar: Gerando relatorio de desempenho...
Caso o endpoint informado não corresponda aos definidos acima, retorne: Endpoint nao reconhecido.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
/clientes	Listando clientes...
/produtos	Exibindo produtos disponiveis...
/relatorios	Gerando relatorio de desempenho...
 * 
 */