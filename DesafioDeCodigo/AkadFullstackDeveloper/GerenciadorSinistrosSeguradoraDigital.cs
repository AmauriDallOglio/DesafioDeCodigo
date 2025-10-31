using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AkadFullstackDeveloper
{
    public class GerenciadorSinistrosSeguradoraDigital
    {
        public void Executar()
        {
            // Lê a entrada do usuário
            string entrada = Console.ReadLine();

            // Divide os sinistros usando a vírgula como delimitador
            string[] sinistros = entrada.Split(',');

            // Lista para armazenar os sinistros processados
            List<Sinistro> listaSinistros = new List<Sinistro>();

            // Processa cada sinistro
            foreach (string sinistro in sinistros)
            {
                // Divide a string do sinistro usando o ponto e vírgula como delimitador
                string[] partes = sinistro.Split(';');

                // Cria um objeto Sinistro e adiciona à lista
                listaSinistros.Add(new Sinistro
                {
                    Id = int.Parse(partes[0]), // Converte o ID para inteiro
                    NomeCliente = partes[1],    // Nome do cliente
                    ValorSinistro = decimal.Parse(partes[2]) // Converte o valor para decimal
                });
            }

            // Ordena a lista de sinistros pelo ID
            var sinistrosOrdenados = listaSinistros.OrderBy(s => s.Id);

            // Monta a saída no formato desejado
            string saida = string.Join(",", sinistrosOrdenados.Select(s => $"{s.Id}:{s.NomeCliente}:{s.ValorSinistro}"));

            // Exibe a saída
            Console.WriteLine(saida);
        }
        // Classe para representar um sinistro
        class Sinistro
        {
            public int Id { get; set; }              // ID do sinistro
            public string NomeCliente { get; set; }  // Nome do cliente
            public decimal ValorSinistro { get; set; } // Valor do sinistro
        }

    }
}


/*
 * 
 * 
 * Desafio
Você é um programador que trabalha em uma seguradora digital. Sua tarefa é desenvolver um sistema que gerencie os sinistros de seus clientes. O sistema deve organizar e exibir informações sobre os sinistros de forma eficiente, garantindo que todos os dados sejam acessíveis rapidamente.

Entrada
A entrada deve receber uma string contendo informações sobre sinistros, no formato: "ID_SINISTRO;NOME_CLIENTE;VALOR_SINISTRO". Os sinistros são separados por vírgulas. Exemplo: "1;John;1000,2;Maria;1500". Cada sinistro deve ser processado e armazenado em uma estrutura de dados adequada.

Saída
Deverá retornar uma string com os sinistros organizados em ordem crescente pelo ID do sinistro, no formato: "ID_SINISTRO:NOME_CLIENTE:VALOR_SINISTRO". Os sinistros devem ser separados por vírgulas. Exemplo: "1:John:1000,2:Maria:1500".

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
1;John;1000,2;Maria;1500	1:John:1000,2:Maria:1500
3;Carlos;2000,1;Ana;2500	1:Ana:2500,3:Carlos:2000
2;Pedro;800,4;Luiza;1200,1;Rafael;950	1:Rafael:950,2:Pedro:800,4:Luiza:1200

 * 
 * 
 */