using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AvanadeBackendNETIA
{
    public class ConsultorDigitalEmAcao
    {
        public void Executar()
        {


            string entrada = Console.ReadLine();

            if (entrada == "basico")
            {
                Console.WriteLine("Recomendado: plano basico");
            }
            else if (entrada == "intermediario")
            {
                Console.WriteLine("Recomendado: plano intermediario");
            }
            else if (entrada == "avancado" || entrada == "premium")
            {
                Console.WriteLine("Recomendado: plano avancado");
            }



        }
    }
}


/*
 * 
 * Desafio
Você é um consultor digital que ajuda empresas a escolherem o melhor plano de serviços na nuvem. Com base nas necessidades do cliente, você deve determinar se eles precisam de um plano basico, intermediario ou avancado. Pronto para o desafio?

Entrada
A entrada deve receber uma string que representa o tipo de serviço que o cliente deseja: "basico", "intermediario", "avancado" ou "premium".

Saída
Deverá retornar uma string com a recomendação do plano: "Recomendado: plano basico", "Recomendado: plano intermediario" ou "Recomendado: plano avancado". Lembrando que o plano "premium", deverá ser indicado o plano avancado.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
basico	Recomendado: plano basico
intermediario	Recomendado: plano intermediario
avancado	Recomendado: plano avancado
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descrições do desafio de código.  
 * 
 * 
 */