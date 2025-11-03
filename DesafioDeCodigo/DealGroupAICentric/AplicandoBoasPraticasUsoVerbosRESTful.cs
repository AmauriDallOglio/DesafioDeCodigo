using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.DealGroupAICentric
{
    public class AplicandoBoasPraticasUsoVerbosRESTful
    {
        public void Executar()
        {



 
      
            // Lê a entrada do usuário no formato "ação recurso" (ex: "list user")
            string input = Console.ReadLine();

            // Divide a entrada em duas partes: ação e recurso
            string[] parts = input.Split(' ');
            string action = parts[0].ToLower();
            string resource = parts[1].ToLower();

            // 1. Preencha o dicionário que mapeia as ações para os verbos HTTP correspondentes
            Dictionary<string, string> httpVerbs = new Dictionary<string, string>()
            {
                { "list", "GET" },
                { "create", "POST" },
                { "update", "PUT" },
                { "delete", "DELETE" }
            };

            // Obtém o verbo HTTP correspondente à ação fornecida
            string verb = httpVerbs[action];
            string endpoint;

            // 2. Defina o endpoint conforme a ação
            if (action == "list" || action == "create")
            {
                // Para list e create: use o recurso no plural, ex: /users
                string pluralResource = Pluralize(resource);
                endpoint = $"/{pluralResource}";
            }
            else // Ações update e delete
            {
                // Para update e delete: use o recurso no singular com /{id}, ex: /user/{id}
                endpoint = $"/{resource}/{{id}}";
            }

            // Imprime o verbo HTTP e o endpoint no formato especificado
            Console.WriteLine(verb);
            Console.WriteLine(endpoint);
         

            /// <summary>
            /// Método estático que pluraliza a palavra conforme regras básicas do inglês.
            /// Esta função já estava pronta e cobre os exemplos (user -> users, category -> categories, order -> orders).
            /// </summary>
            static string Pluralize(string word)
            {
                // Se a palavra termina em 'y' precedida de consoante, troca por 'ies'
                // Ex: category -> categories
                if (word.EndsWith("y") && word.Length > 1 && "aeiou".IndexOf(word[word.Length - 2]) == -1)
                {
                    return word.Substring(0, word.Length - 1) + "ies";
                }
                // Se termina em s, x, z, ch ou sh, adiciona 'es'
                // Ex: box -> boxes
                else if (word.EndsWith("s") || word.EndsWith("x") || word.EndsWith("z")
                         || word.EndsWith("ch") || word.EndsWith("sh"))
                {
                    return word + "es";
                }
                else
                {
                    // Para os demais casos, adiciona 's'
                    // Ex: user -> users, product -> products
                    return word + "s";
                }
            }
        }




    }
    }
}


/*
 * 
 * Desafio
Você está desenvolvendo uma API RESTful e precisa garantir que os endpoints sigam boas práticas. Uma delas é o uso apropriado dos verbos HTTP e o formato correto dos nomes dos recursos em singular ou plural.

Seu objetivo é escrever um programa que, com base em uma ação (como list, create, update, delete) e um recurso (como user, product, order), retorne:

O verbo HTTP correto
O endpoint RESTful adequado, com uso correto de plural ou singular conforme a operação.
Entrada
Uma string representando a operação desejada, no formato: ação recurso

Onde:

ação pode ser: list, create, update, delete
recurso é o nome do recurso no singular (ex: user, product, order, client)
Saída
Duas linhas:

O verbo HTTP correspondente à ação:
list → GET
create → POST
update → PUT
delete → DELETE
O endpoint RESTful formatado:
Para list e create: use o recurso no plural, ex: /users
Para update e delete: use o recurso no singular com /{id}, ex: /user/{id}
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
list user	GET
/users
create category	POST
/categories
update order	PUT
/order/{id}
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.
 * 
 * 
 */