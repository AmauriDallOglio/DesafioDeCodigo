using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioDeCodigo.DealGroupAICentric
{
    public class ValidandoNomesCase
    {
        public void Executar()
        {

       

                // Lê a linha com os nomes das variáveis separados por espaço
                string input = Console.ReadLine();
                string[] variableNames = input.Split(' ');

                // Regex para validar camelCase:
                // ^                 -> Início da string
                // [a-z]             -> Deve começar com uma letra minúscula.
                // [a-zA-Z0-9]* -> Pode ser seguido por zero ou mais letras ou números (para o primeiro termo).
                // (                   -> Início do grupo para as palavras seguintes (opcional).
                //   [A-Z]             -> Cada nova palavra deve começar com uma letra MAIÚSCULA.
                //   [a-z0-9]* -> Seguido por zero ou mais letras minúsculas ou números.
                // )* -> Este padrão (palavra interna) pode se repetir zero ou mais vezes.
                // $                 -> Fim da string.
                // Note: O padrão original era: @"^[a-z]+([A-Z][a-z0-9]+)*$". Vamos ajustá-lo para ser mais robusto,
                // permitindo números e letras maiúsculas/minúsculas após a primeira letra.

                // Um padrão mais correto para camelCase que aceita nomes como 'a1' ou 'user1Id':
                string camelCasePattern = @"^[a-z][a-zA-Z0-9]*$"; // Padrão mais simples: começa com minúscula, o resto é alfanumérico (Não suporta UserID)

                // Padrão que força as transições de palavra (como no exemplo 'productCount'):
                // Começa com letra minúscula ([a-z]), pode ter mais caracteres alfanuméricos minúsculos ([a-z0-9]*)
                // E opcionalmente segue com um bloco de [A-Z] (nova palavra) seguido de [a-z0-9]*
                string correctCamelCasePattern = @"^[a-z]+([A-Z][a-z0-9]*)*$";

                // Padrão do desafio (que parece aceitar apenas minúsculas no primeiro termo e após maiúsculas):
                // ^[a-z]+([A-Z][a-z0-9]+)*$
                // Este padrão é o mais fiel à definição de "as palavras subsequentes iniciam com letra maiúscula"
                // e é o que será usado.
                string patternToUse = @"^[a-z][a-zA-Z0-9]*$";

                // Revisando os exemplos:
                // userName: Válido (uN)
                // orderId: Válido (oI)
                // productCount: Válido (pC)
                // userName: Inválido (U) -> Inicia com maiúscula
                // order_id: Inválido (_) -> Contém símbolo especial

                // O padrão mais simples para cobrir as regras:
                // 1. Começa com minúscula: [a-z]
                // 2. Apenas letras e números são permitidos: [a-zA-Z0-9]
                // 3. Não pode ter _ ou outros símbolos.

                // Padrão final baseado nas regras de camelCase em C#:
                string finalPattern = @"^[a-z][a-zA-Z0-9]*$";

                bool allValid = true;

                // Lista para armazenar os nomes inválidos
                List<string> invalidNames = new List<string>();

                // Percorre todos os nomes para validar
                foreach (string variable in variableNames)
                {
                    // Verifique se o nome NÃO corresponde ao padrão camelCase
                    if (!Regex.IsMatch(variable, finalPattern))
                    {
                        invalidNames.Add(variable);
                        allValid = false;
                    }
                }

                // Imprime os nomes inválidos
                if (invalidNames.Count > 0)
                {
                    foreach (string invalidName in invalidNames)
                    {
                        Console.WriteLine(invalidName);
                    }
                }
                // Caso todos estejam corretos, imprima "All valid"
                else if (allValid)
                {
                    Console.WriteLine("All valid");
                }
            }
        
    }
    
}



/*
 * 
 * 
 * Desafio
No desenvolvimento de software, a consistência é uma das principais boas práticas recomendadas para garantir legibilidade, manutenção e facilidade de entendimento do código. Uma parte fundamental dessa consistência está na forma como nomeamos variáveis, funções e outros identificadores.

Um padrão amplamente utilizado em linguagens como C# é o camelCase. Nesse padrão:

O nome começa com letra minúscula.
As palavras subsequentes iniciam com letra maiúscula, sem espaços ou separadores.
Apenas letras e números são permitidos.
Evita-se o uso de caracteres especiais e espaços para manter o código limpo e uniforme.
Seu desafio é criar um programa que valide uma lista de nomes de variáveis, identificando aqueles que não seguem o padrão camelCase e imprimindo-os. Se todos os nomes estiverem corretos, imprima All valid.

Saiba mais sobre: Expressão Regular

Entrada
Uma linha contendo nomes de variáveis separados por espaço.

Saída
Nomes inválidos, um por linha, na ordem que aparecem na entrada.
Ou All valid caso todos estejam corretos.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
userName orderId productCount	All valid
UserName order_id productCount	UserName
order_id
firstName lastName age
 * 
 * 
 * 
 * 
 */