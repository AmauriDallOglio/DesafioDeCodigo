using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesafioDeCodigo.GFTStart7NET
{
    public class ValidcaoParametrosConsultaAPI
    {
        public void Executar()
        {
            // Solicita a entrada da URL
            string url = Console.ReadLine();

            // Chama o método para validar a URL
            string resultado = ValidarParametros(url);

            // Exibe o resultado
            Console.WriteLine(resultado);
        }

        // Método para validar os parametros da URL
        public static string ValidarParametros(string url)
        {
            // Valida se a URL começa com '?'
            if (!url.StartsWith("?"))
            {
                return "Parametros invalidos";
            }

            // Remove o '?' da URL para analisar os parametros
            url = url.Substring(1);

            // Se a string estiver vazia após remover o '?', é inválida (URL "?")
            if (string.IsNullOrEmpty(url))
            {
                return "Parametros invalidos";
            }

            // Divide a URL pelos '&' para obter cada parametro
            string[] parametros = url.Split('&');

            // TODO: Verifique cada parametro individualmente:
            foreach (string parametro in parametros)
            {
                // Se o parâmetro for vazio (ex: "&&" ou "&" no final), é inválido
                if (string.IsNullOrEmpty(parametro))
                {
                    return "Parametros invalidos";
                }

                // TODO: Divida cada parametro pelo '='
                string[] chaveValor = parametro.Split('=');

                // TODO: Verifique se há exatamente um '='
                // Deve ter 2 partes (chave e valor)
                if (chaveValor.Length != 2)
                {
                    return "Parametros invalidos";
                }

                string nomeParametro = chaveValor[0];
                string valorParametro = chaveValor[1];

                // TODO: Valide o nome do parametro (alfanumerico)
                // Regra: Nome do parâmetro deve ser alfanumérico (letras A-Z, a-z, e números 0-9)
                // Regex: "^[a-zA-Z0-9]+$"
                if (!Regex.IsMatch(nomeParametro, @"^[a-zA-Z0-9]+$"))
                {
                    return "Parametros invalidos";
                }

                // Valida o valor do parametro (alfanumerico ou numero, ou valores como e-mail)
                // Permite caracteres especiais como @ e . para casos como email (conforme o exemplo 2)
                // No entanto, se quisermos ser estritos com "alfanumérico ou inteiro" conforme a descrição,
                // usaremos uma regra mais restrita ou uma única que englobe ambos de forma simples.
                // Para cobrir o exemplo '?nome=ana&email=ana@mail.com', que tem caracteres especiais no valor,
                // vamos usar a verificação fornecida, garantindo que não há espaços ou outros caracteres proibidos.

                // Regra da descrição: O valor do parâmetro PODE ser alfanumérico ou um número inteiro.
                // O exemplo 2, no entanto, sugere que valores de e-mail com '@' e '.' também são válidos.

                // Vamos usar a regex mais inclusiva (conforme o esqueleto) que cobre alfanumérico, '@' e '.',
                // e garante que o valor não seja uma string vazia.

                if (string.IsNullOrEmpty(valorParametro))
                {
                    return "Parametros invalidos";
                }

                // Valida se o valor é composto apenas por alfanumérico, '@' ou '.'
                // A regex original: @"^[a-zA-Z0-9@.]+$"
                if (!Regex.IsMatch(valorParametro, @"^[a-zA-Z0-9@.]+$"))
                {
                    // Se o valor contiver caracteres fora do conjunto permitido (como espaços ou outros símbolos),
                    // ele é considerado inválido.
                    return "Parametros invalidos";
                }
            }

            // Se passar em todas as validacoes, os parametros são validos
            return "Parametros validos";
        }
    }
}


/*
 * 
 * 
 * 
 * Descrição
Você está desenvolvendo uma API que recebe parâmetros de consulta na URL. O desafio é criar um algoritmo que valide se os parâmetros estão no formato correto, de acordo com as regras especificadas. Os parâmetros devem seguir a seguinte regra de formato:

Formato Padrão: ?parametro1=valor1&parametro2=valor2
Regras:
O nome do parâmetro deve ser alfanumérico (sem espaços ou caracteres especiais).
O valor do parâmetro pode ser alfanumérico ou um número inteiro.
O separador entre os parâmetros deve ser o caractere &.
O parâmetro e seu valor devem ser separados por =.
A tarefa é criar uma função que verifique se a URL está no formato correto. Se estiver, deve retornar "Parametros validos", caso contrário, "Parametros invalidos".

Entrada
A entrada será uma string representando a URL com parâmetros de consulta.

Uma string representando a URL com parâmetros de consulta no formato ?parametro1=valor1&parametro2=valor 
Saída
Deverá retornar uma mensagem indicando se os parâmetros da URL estão no formato correto.

Parâmetros válidos se a URL de parâmetros segue o formato correto.
Parâmetros inválidos se a URL não segue o formato esperado.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
?usuario=joao&idade=30	Parametros validos
?nome=ana&email=ana@mail.com	Parametros validos
usuario=joao&idade=abc	Parametros invalidos
?usuario=sabrina idade=30	Parametros invalidos
 * 
 * 
 * 
 */