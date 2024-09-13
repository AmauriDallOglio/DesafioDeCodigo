using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class ClassificandoCurriculos
    {
        public void Executar()
        {
            // Leitura da entrada do usuário
            string input = Console.ReadLine();

            // Processamento da entrada
            List<int> anosExperiencia = input.Split(',')
                                              .Select(x => int.Parse(x))
                                              .ToList();

            // Classificação dos currículos
            List<string> classificacoes = ClassificarCurriculos(anosExperiencia);

            // Formatação da saída
            string resultado = string.Join(", ", classificacoes);
            Console.WriteLine(resultado);
        }

        private static List<string> ClassificarCurriculos(List<int> anosExperiencia)
        {
            List<string> classificacoes = new List<string>();

            // TODO: Itere sobre cada número de anos de experiência na lista 'anosExperiencia' e preencha a lista de classificações.
            foreach (int anos in anosExperiencia)
            {
                if (anos <= 3)
                {
                    classificacoes.Add("Junior");
                }
                else if (anos <= 5)
                {
                    classificacoes.Add("Pleno");
                }
                else
                {
                    classificacoes.Add("Senior");
                }
            }

            return classificacoes;
        }
    }
}


/*
 * 
 * 
 * Descrição
Você é responsável por auxiliar o departamento de recursos humanos de uma empresa a categorizar currículos de candidatos com base na experiência profissional. Seu desafio é criar um sistema que, ao receber uma lista de anos de experiência, classifique cada currículo como "Junior", "Pleno" ou "Senior".

“Junior”: Candidatos com até 3 anos de experiência.
“Pleno”: Candidatos com mais de 3 e até 5 anos de experiência.
“Senior”: Candidatos com mais de 5 anos de experiência.
Entrada
A entrada deve receber uma string representando uma lista de números inteiros separados por vírgulas, representando os anos de experiência de cada candidato.

Saída
Deverá retornar uma lista de classificações ("Junior", "Pleno" ou "Senior") correspondente a cada valor de entrada, também separada por vírgulas.
A saída deve manter a ordem dos currículos conforme a entrada.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
2,4,8,6	Junior, Pleno, Senior, Senior
1,3,5,9	Junior, Junior, Pleno, Senior
7,2,10,4	Senior, Junior, Senior, Pleno
 * 
 */