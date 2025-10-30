using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.DealGroupAICentric
{
    public class IdentificandoMetodoHTTPMaisFrequente
    {
        public void Executar()
        {
            // Lê a string contendo os métodos HTTP separados por vírgula
            string input = Console.ReadLine();

            // Dicionário com métodos válidos e suas descrições
            Dictionary<string, string> methodDescriptions = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            {"GET", "busca ou recupera dados de um recurso"},
            {"POST", "envia dados para processamento"},
            {"PUT", "atualiza todos os dados de um recurso"},
            {"DELETE", "remove um recurso específico"}
        };

            // Divide a entrada em métodos, remove espaços e transforma em maiúsculas
            string[] methods = input.Split(',')
                                    .Select(m => m.Trim().ToUpper())
                                    .ToArray();

            // Dicionário para contar as ocorrências de cada método (case-insensitive)
            Dictionary<string, int> methodCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            foreach (var method in methods)
            {
                if (methodCounts.ContainsKey(method))
                    methodCounts[method]++;
                else
                    methodCounts[method] = 1;
            }

            // Encontra o método mais frequente
            int maxCount = methodCounts.Values.Max();
            string mostFrequentMethod = methodCounts.First(kv => kv.Value == maxCount).Key;
            int count = methodCounts[mostFrequentMethod];

            // Verifica se o método é válido
            if (methodDescriptions.ContainsKey(mostFrequentMethod))
            {
                string description = methodDescriptions[mostFrequentMethod];
                Console.WriteLine($"{mostFrequentMethod} - {description} - {count}");
            }
            else
            {
                // Método inválido
                Console.WriteLine($"{mostFrequentMethod} - metodo nao reconhecido - {count}");
            }
        }
    }
}


/*
 * 
 * 
 * 
 * Desafio
Você deve escrever um programa que analisa uma lista de métodos HTTP separados por vírgula. O programa deve contar quantas vezes cada método aparece, identificar o mais frequente e exibir sua descrição e contagem.

A entrada pode conter métodos com letras maiúsculas ou minúsculas e espaços desnecessários.

Métodos válidos e suas descrições
Método	Descrição
GET	busca ou recupera dados de um recurso
POST	envia dados para processamento
PUT	atualiza todos os dados de um recurso
DELETE	remove um recurso específico
Entrada
Uma string com métodos HTTP separados por vírgula.

Saída
Uma única linha com o método mais frequente no formato: MÉTODO - DESCRIÇÃO - X

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
GET, GET, POST, DELETE, PUT	GET - busca ou recupera dados de um recurso - 2
PUT, POST, PUT, DELETE, PUT	PUT - atualiza todos os dados de um recurso - 3
DEL, DEL	DEL - metodo nao reconhecido - 2
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.

 




*/