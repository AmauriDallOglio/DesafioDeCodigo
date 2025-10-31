using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AkadFullstackDeveloper
{
    public class CalculadoraPremiosSeguro
    {
        public void Executar()
        {
      
 
         
                // Lê as entradas do usuário
                string tipoCobertura = Console.ReadLine().ToLower();
                string perfilMotorista = Console.ReadLine().ToLower();

                // Chama a função para calcular o prêmio
                string resultado = CalcularPremio(tipoCobertura, perfilMotorista);

                // Exibe o resultado
                Console.WriteLine(resultado);
          

            static string CalcularPremio(string tipo, string perfil)
            {
                int premio = 0;

                // Define o valor do prêmio com base na combinação de tipo e perfil
                if (tipo == "basica")
                {
                    if (perfil == "novato") premio = 200;
                    else if (perfil == "experiente") premio = 150;
                    else if (perfil == "profissional") premio = 100;
                }
                else if (tipo == "intermediaria")
                {
                    if (perfil == "novato") premio = 300;
                    else if (perfil == "experiente") premio = 250;
                    else if (perfil == "profissional") premio = 200;
                }
                else if (tipo == "completa")
                {
                    if (perfil == "novato") premio = 500;
                    else if (perfil == "experiente") premio = 400;
                    else if (perfil == "profissional") premio = 300;
                }

                return premio.ToString();
            }
        }

    }
}


/*
 * 
 * Desafio
Você é um desenvolvedor em uma seguradora digital que precisa ajudar a calcular o valor do prêmio de um seguro de carro. Dependendo do tipo de cobertura escolhida e do perfil do motorista, o valor pode variar. Sua missão é implementar essa lógica!

Entrada
A entrada deve receber duas strings: a primeira representando o tipo de cobertura ("basica", "intermediaria" ou "completa") e a segunda representando o perfil do motorista ("novato", "experiente" ou "profissional").

Saída
Deverá retornar uma string informando o valor do prêmio do seguro. Os valores são:
- Para cobertura basica: novato (200), experiente (150), profissional (100)
- Para cobertura intermediaria: novato (300), experiente (250), profissional (200)
- Para cobertura completa: novato (500), experiente (400), profissional (300)

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
basica
novato	200
completa
experiente	400
intermediaria
profissional	200
 * 
 */