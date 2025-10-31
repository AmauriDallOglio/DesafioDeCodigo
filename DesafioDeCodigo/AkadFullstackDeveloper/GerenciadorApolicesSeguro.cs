using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AkadFullstackDeveloper
{
    public class GerenciadorApolicesSeguro
    {
        public void Executar()
        {
 
     
                // Lê a string de entrada que contém as apólices separadas por vírgulas  
                string input = Console.ReadLine();

                // Divide a string em um array de apólices  
                string[] apolices = input.Split(',');

                // Ordena as apólices pelo nome do cliente (parte antes do ":")  
                var apolicesOrdenadas = apolices
                    .OrderBy(apolice => apolice.Split(':')[0])
                    .ToArray();

                // Junta as apólices ordenadas em uma única string, separadas por vírgulas  
                string resultado = string.Join(",", apolicesOrdenadas);

                // Exibe o resultado final  
                Console.WriteLine(resultado);
            
        }

    }
}


/*
 * 
 * 
 * Desafio
Você foi contratado por uma seguradora digital para desenvolver um sistema que organiza as apólices de seguro de veículos. Cada apólice é representada por uma string que contém o nome do cliente e o número da apólice. Sua missão é receber várias apólices e retornar uma lista ordenada alfabeticamente pelo nome do cliente.

Entrada
A entrada consiste em uma única string que contém várias apólices separadas por vírgulas. Cada apólice é composta pelo nome do cliente seguido pelo número da apólice, no formato "NomeCliente:NumeroApolice".

Saída
A saída deve ser uma string que contém as apólices ordenadas por nome do cliente, separadas por vírgulas.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Ana:123,Beto:456,Carlos:789	Ana:123,Beto:456,Carlos:789
Maria:234,John:567,Ana:890	Ana:890,John:567,Maria:234
Pedro:345,Lucas:678,Mariana:012	Lucas:678,Mariana:012,Pedro:345



 * 
 * 
 */