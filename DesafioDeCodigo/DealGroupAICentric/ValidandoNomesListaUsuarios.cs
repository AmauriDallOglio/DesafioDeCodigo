using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.DealGroupAICentric
{
    public class ValidandoNomesListaUsuarios
    {
        public void Executar()
        {
            try
            {
                // Lê uma linha de entrada do usuário
                string inputLine = Console.ReadLine();

                // Separa os nomes por vírgula, remove espaços e aspas extras
                var names = inputLine.Split(',')
                                     .Select(n => n.Trim().Trim('"'))
                                     .ToList();

                // Lista para armazenar nomes válidos
                var validNames = new List<string>();
                // Lista para armazenar mensagens de erro
                var errors = new List<string>();

                // Itera sobre cada nome processado
                foreach (var name in names)
                {
                    try
                    {
                        // Verifica se o nome é "null"
                        if (name.Equals("null", StringComparison.OrdinalIgnoreCase))
                            throw new ArgumentNullException();

                        // Verifica se o nome está vazio ou contém apenas espaços
                        if (string.IsNullOrWhiteSpace(name))
                            throw new ArgumentException();

                        // Se o nome passou pelas validações, adiciona à lista de válidos
                        validNames.Add(name);
                    }
                    catch (ArgumentNullException)
                    {
                        errors.Add("Erro: nome nulo");
                    }
                    catch (ArgumentException)
                    {
                        errors.Add("Erro: nome invalido");
                    }
                }

                // Exibe a saída formatada
                if (errors.Any())
                    Console.WriteLine($"{string.Join(", ", validNames)} / {string.Join(", ", errors)}");
                else
                    Console.WriteLine(string.Join(", ", validNames));
            }
            catch (Exception ex)
            {
                // Captura e exibe qualquer erro inesperado
                Console.WriteLine($"Erro inesperado: {ex.Message}");
            }
        }
    }
}


/*
 * 
 * Desafio
Você está desenvolvendo uma funcionalidade para um sistema que exibe uma lista de usuários cadastrados. Sua tarefa é implementar um programa que leia uma lista de nomes, valide cada um deles e apresente os resultados de forma clara, separando os nomes válidos dos inválidos.

Entrada
Uma única linha de texto, com nomes separados por vírgulas.

Saída
Se todos os nomes forem válidos, exiba apenas os nomes, separados por vírgulas.
Se houver nomes inválidos ou nulos, exiba:
Os nomes válidos (na ordem em que aparecem), seguidos de
Uma barra / e das respectivas mensagens de erro.
Mensagens de erro possíveis:
Erro: nome invalido — quando o nome estiver vazio ou em branco.
Erro: nome nulo — quando o nome for null. 
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
"João", "Maria", ""	João, Maria / Erro: nome invalido
"Carlos", "Ana", null	Carlos, Ana / Erro: nome nulo
"Mairo", ""	Mairo / Erro: nome invalido
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.



 * 
 * 
 */