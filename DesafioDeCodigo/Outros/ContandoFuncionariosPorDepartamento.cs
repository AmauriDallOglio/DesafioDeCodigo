using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class ContandoFuncionariosPorDepartamento
    {
        public void Executar()
        {
            // Leitura da entrada do usuário
            string input = Console.ReadLine();

            // Processamento da entrada
            List<string> departamentos = input.Split(',')
                                              .ToList();

            // Contagem de funcionários por departamento
            Dictionary<string, int> contagemDepartamentos = ContarFuncionariosPorDepartamento(departamentos);

            // Formatação da saída
            var resultado = string.Join(Environment.NewLine,
                                        contagemDepartamentos.OrderBy(depto => depto.Key)
                                                             .Select(depto => $"{depto.Key}: {depto.Value}"));

            Console.WriteLine(resultado);
        }

        /// <summary>
        /// Método que conta o número de funcionários em cada departamento.
        /// Itera sobre cada nome de departamento na lista 'departamentos'
        /// Se o departamento já existe no dicionário, incrementa a contagem
        /// Caso contrário, adiciona o departamento ao dicionário com valor 1
        /// </summary>
        /// <param name="departamentos"></param>
        /// <returns></returns>
        static Dictionary<string, int> ContarFuncionariosPorDepartamento(List<string> departamentos)
        {
            var contagem = new Dictionary<string, int>();

            // Itera sobre cada nome de departamento na lista 'departamentos'
            foreach (var departamento in departamentos)
            {
                // Se o departamento já existe no dicionário, incrementa a contagem
                if (contagem.ContainsKey(departamento))
                {
                    contagem[departamento]++;
                }
                else
                {
                    // Caso contrário, adiciona o departamento ao dicionário com valor 1
                    contagem[departamento] = 1;
                }
            }

            return contagem;
        }
    }
}


/*
 * 
 * Descrição
Você precisa desenvolver um sistema que conte o número de funcionários em cada departamento. Dada uma lista que representa o departamento de cada funcionário, seu objetivo é calcular a quantidade de funcionários em cada departamento e apresentar esse número.

Entrada
A entrada é uma string onde cada valor, separado por vírgulas, representa o nome do departamento ao qual um funcionário pertence.

Saída
Deverá retornar os nomes dos departamentos em ordem alfabética seguidos pela contagem de funcionários em cada departamento, um por linha.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
TI,RH,TI,Financeiro
Financeiro: 1
RH: 1
TI: 2
Financeiro,RH,RH,TI	Financeiro: 1
RH: 2
TI: 1
TI,TI,TI,RH,Financeiro,RH	Financeiro: 1
RH: 2
TI: 3
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.
 * 
 */