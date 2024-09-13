using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class FiltrandoCurriculosPalavrasChave
    {
        public void Executar()
        {
            // Leitura da entrada do usuário
            string input = Console.ReadLine();

            // Processamento da entrada
            var partes = input.Split(';').Select(p => p.Trim()).ToArray();

            // Divide as partes em currículos e palavras-chave
            List<string> curriculos = partes[0].Split(',').Select(c => c.Trim()).ToList();
            List<string> palavrasChave = partes[1].Split(',').Select(p => p.Trim().ToLower()).ToList();

            // Filtragem dos currículos com base nas palavras-chave
            List<string> curriculosRelevantes = FiltrarCurriculosPorPalavrasChave(curriculos, palavrasChave);

            // Verificação se há currículos relevantes
            if (curriculosRelevantes.Count == 0)
            {
                Console.WriteLine("Nenhum curriculo encontrado");
            }
            else
            {
                // Formatação da saída
                string resultado = string.Join("; ", curriculosRelevantes);
                Console.WriteLine(resultado);
            }
        }

        private static List<string> FiltrarCurriculosPorPalavrasChave(List<string> curriculos, List<string> palavrasChave)
        {
            List<string> curriculosRelevantes = new List<string>();

            foreach (string curriculo in curriculos)
            {
                // Verifica se todas as palavras-chave estão presentes no currículo
                bool contemTodasPalavrasChave = palavrasChave.All(palavra => curriculo.ToLower().Contains(palavra));

                if (contemTodasPalavrasChave)
                {
                    curriculosRelevantes.Add(curriculo);
                }
            }

            return curriculosRelevantes;
        }
    }
}


/*
 * 
 * 
 * 
 * Descrição
Desenvolva um sistema que filtre currículos com base em palavras-chave fornecidas. O sistema deve analisar uma lista de currículos e identificar quais currículos contêm todas as palavras-chave especificadas. Um currículo é considerado relevante apenas se contiver todas as palavras-chave fornecidas. Se nenhum currículo atender a todos os critérios, o sistema deve informar que nenhum currículo foi encontrado.

Entrada
A entrada consiste em uma única linha contendo duas partes separadas por um ponto e vírgula (;):

Uma lista de currículos, onde cada currículo é uma string separada por vírgula (,).
Uma lista de palavras-chave, onde cada palavra-chave é uma string separada por vírgula (,).
Saída
O sistema deve retornar uma lista de currículos que contenham todas as palavras-chave especificadas.

Se nenhum currículo atender a todos os critérios, o sistema deve retornar "Nenhum curriculo encontrado".
Os currículos relevantes devem ser apresentados em uma única string, separados por ponto e vírgula (;).
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Analista de Dados, Gerente de Projetos; dados, analista	Analista de Dados
Gerente de Produto, Analista de Mercado; analista, dados	Nenhum curriculo encontrado
Engenheiro de Software Java, Desenvolvedor de Software Java; software, Java	Engenheiro de Software Java; Desenvolvedor de Software Java
 * 
 * 
 * 
 */