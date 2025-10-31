using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AvanadeBackendNETIA
{
    public class ValidadorTokenAcesso
    {
        public void Executar()
        {
    
                // Solicita ao usuário que insira o token de acesso
                string token = Console.ReadLine();

                // 1. Verifique se o token tem exatamente 10 caracteres
                bool temTamanhoCorreto = token.Length == 10;

                // 2. Verifica se o primeiro caractere é a letra 'A' maiúscula
                // Proteção contra token vazio ou nulo (apesar de ser improvável com Console.ReadLine)
                bool comecaComA = temTamanhoCorreto && token[0] == 'A';

                // 3. Verifica se há pelo menos um dígito numérico no token
                // Usa Linq para verificar se 'Any' caractere satisfaz a condição IsDigit
                bool contemDigito = token.Any(char.IsDigit);

                // Verifica se todas as condições foram satisfeitas
                if (temTamanhoCorreto && comecaComA && contemDigito)
                {
                    // Token válido
                    Console.WriteLine("Acesso permitido");
                }
                else
                {
                    // Token inválido
                    Console.WriteLine("Acesso negado");
                }
            
        }
    }
}


/*
 * 
 * Descrição
Na consultoria onde você atua, foi necessário criar uma camada de autenticação simples para simular uma API que apenas aceita requisições autenticadas. Sua missão é escrever um programa que valide um token de acesso.

Entrada
O programa deve receber uma string representando o token de acesso.

O token deve ter exatamente 10 caracteres
Deve começar com a letra "A" maiúscula
Deve conter pelo menos um dígito numérico
Saída
O programa deverá validar o token e exibir:

Acesso permitido caso o token seja válido
Acesso negado caso não seja
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
A123456789	Acesso permitido
B123456789	Acesso negado
A12345	Acesso negado
Aabcdefghi	Acesso negado
 * 
 * 
 */