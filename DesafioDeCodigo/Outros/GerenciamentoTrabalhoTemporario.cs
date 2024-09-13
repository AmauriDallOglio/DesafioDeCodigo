using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class GerenciamentoTrabalhoTemporario
    {
        public void Executar()
        {
            // Leitura do orçamento a partir da entrada do usuário e conversão para decimal.
            decimal orcamento = decimal.Parse(Console.ReadLine());

            // Leitura dos contratos, separados por ';', a partir da entrada do usuário.
            string[] contratos = Console.ReadLine().Split(';');

            // Criação de uma lista de objetos do tipo Contrato a partir dos dados fornecidos.
            List<Contrato> listaContratos = contratos.Select(c =>
            {
                // Divisão dos dados do contrato individual por ','.
                var dados = c.Split(',');
                return new Contrato
                {
                    Nome = dados[0].Trim(),                  // Atribui o nome do contrato
                    Departamento = dados[1].Trim(),          // Atribui o departamento
                    Dias = int.Parse(dados[2].Trim()),       // Atribui o número de dias do contrato
                    ValorDiaria = decimal.Parse(dados[3].Trim()) // Atribui o valor diário do contrato
                };
            }).ToList();

            // Cálculo do custo total de todos os contratos na lista.
            decimal custoTotal = listaContratos.Sum(c => c.Dias * c.ValorDiaria);

            // Agrupa os contratos por departamento e calcula o custo total por departamento.
            var custoPorDepartamento = listaContratos
                .GroupBy(c => c.Departamento)              // Agrupa por departamento
                .Select(g => new
                {
                    Departamento = g.Key,
                    Custo = g.Sum(c => c.Dias * c.ValorDiaria)
                }) // Calcula o custo por departamento
                .OrderByDescending(g => g.Custo)           // Ordena os departamentos pelo custo em ordem decrescente
                .First();                                  // Seleciona o departamento com o maior custo

            // Exibe o custo total formatado com duas casas decimais.
            Console.WriteLine($"{custoTotal:F2}");

            // Verifica se o custo total excede o orçamento e exibe a mensagem apropriada.
            Console.WriteLine(custoTotal > orcamento ? "Orcamento excedido" : "Dentro do orcamento");

            // Exibe o departamento com o maior custo.
            Console.WriteLine(custoPorDepartamento.Departamento);
        }

        private class Contrato
        {
            public string Nome { get; set; }          // Nome do contrato
            public string Departamento { get; set; }  // Departamento associado ao contrato
            public int Dias { get; set; }             // Número de dias do contrato
            public decimal ValorDiaria { get; set; }  // Valor diário do contrato
        }

    }
}


/*
 * 
 * 
 * 
O programa deve processar uma lista de contratos temporários, cada um contendo o nome do funcionário, o departamento, o número de dias de trabalho e o valor da diária. Além disso, o sistema deve considerar um orçamento pré-definido para trabalho temporário.

Entrada
A entrada consistirá em duas linhas:

Um número representando o orçamento total para trabalho temporário.
Uma string contendo informações sobre os contratos temporários no formato: "nome,departamento,dias,valor_diaria", separados por ponto e vírgula.
Saída
O programa deve retornar três linhas:

O custo total dos contratos temporários (com duas casas decimais).
"Orcamento excedido" se o custo total for maior que o orçamento, ou "Dentro do orcamento" caso contrário.
O nome do departamento que mais utilizou mão de obra temporária (em termos de custo total).
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
25000
Luiz,TI,30,200;Ana,Vendas,45,180;Caio,TI,20,220;Luna,RH,15,190	21350.00
Dentro do orcamento
TI
13000
Lucia,RH,20,230;Pedro,TI,15,250;Sofia,RH,30,200	14350.00
Orcamento excedido
RH
20000
Tiago,RH,30,200;Laura,Vendas,25,230;Ricardo,Vendas,15,240	15350.00
Dentro do orcamento
Vendas
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.



 * 
 */