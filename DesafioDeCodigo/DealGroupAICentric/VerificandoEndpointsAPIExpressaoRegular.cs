using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioDeCodigo.DealGroupAICentric
{
    public class VerificandoEndpointsAPIExpressaoRegular
    {
        public void Executar()
        {
            string requestedEndpoint = Console.ReadLine();
            int numberOfAllowedPatterns = int.Parse(Console.ReadLine());
            List<string> allowedPatterns = new List<string>();

            // Lê os padrões autorizados e adiciona na lista
            for (int i = 0; i < numberOfAllowedPatterns; i++)
            {
                string pattern = Console.ReadLine();
                allowedPatterns.Add(pattern);
            }

            // Verifica se o formato do endpoint é válido
            bool formatoValido = IsValidEndpointFormat(requestedEndpoint);

            // Verifica se o endpoint está autorizado
            bool autorizado = IsAuthorized(requestedEndpoint, allowedPatterns);

            // Exibe o resultado conforme as regras
            if (formatoValido && autorizado)
                Console.WriteLine("valid");
            else
                Console.WriteLine("invalid");
        }

        // Função que valida o formato do endpoint com expressão regular
        static bool IsValidEndpointFormat(string endpoint)
        {
            // Expressão regular:
            // ^/api/  → deve começar com /api/
            // (?!.*//) → não permite barras duplas
            // ([a-zA-Z0-9]+(/([a-zA-Z0-9]+))*)?$ → segmentos alfanuméricos separados por /
            string pattern = @"^/api/(?!.*//)([a-zA-Z0-9]+(/([a-zA-Z0-9]+))*)?$";

            return Regex.IsMatch(endpoint, pattern);
        }


        // Função que verifica se o endpoint está dentro dos padrões autorizados
        static bool IsAuthorized(string endpoint, List<string> allowedPatterns)
        {
            foreach (string pattern in allowedPatterns)
            {
                if (pattern.EndsWith("/*"))
                {
                    string basePattern = pattern.Substring(0, pattern.Length - 1);

                    if (endpoint.StartsWith(basePattern))
                        return true;
                }
                else
                {
                    if (endpoint == pattern)
                        return true;
                }
            }
            return false;
        }
    }
}


/*
 * Desafio
Uma empresa de tecnologia está desenvolvendo um sistema de controle de acesso para sua API interna. Neste sistema, cada usuário possui permissão para acessar apenas determinados endpoints.

O sistema precisa realizar duas verificações antes de liberar o acesso ao endpoint solicitado:

Validação do formato do endpoint, para garantir que ele esteja seguro e conforme os padrões internos definidos pela equipe de segurança.
Verificação de autorização, checando se o endpoint solicitado está dentro dos padrões permitidos para o usuário atual.
Regras de Formato Válido
Um endpoint será considerado válido se seguir estas regras:

Deve começar com /api/
Deve conter um ou mais segmentos alfanuméricos (letras e números) separados por barras (/)
Não pode conter:
Espaços
Símbolos especiais
Letras com acento
Barras duplas (//)
Regras de Autorização
Cada usuário tem uma lista de padrões de endpoints autorizados. Um endpoint é autorizado se:

Corresponder exatamente a um dos padrões fornecidos, ou
Estiver dentro de um padrão com *, como por exemplo:
O padrão /api/orders/* permite:
/api/orders/2024
/api/orders/details/5
Mas não permite /api/products
O * só é aceito ao final do padrão, e representa "qualquer subcaminho".

Saiba mais sobre: Expressão Regular

Entrada
Uma string representando o endpoint solicitado pelo usuário.
Um número inteiro N representando a quantidade de padrões autorizados.
Em seguida, N strings, cada uma representando um endpoint ou padrão autorizado com ou sem *.
Saída
Imprima "valid" se:
O endpoint for formatado corretamente e
O usuário estiver autorizado a acessá-lo.
Caso contrário, imprima "invalid".
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
/api/orders/2024
2
/api/orders/*
/api/users	valid
/api/orders//2024
1
/api/orders/*	invalid
/api/users
1
/api/orders/*	invalid
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.
 * 
 */