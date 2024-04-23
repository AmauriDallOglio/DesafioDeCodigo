using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class TipoCombustivel
    {
        public void Executar()
        {
            int alcool = 0, gasolina = 0, diesel = 0;
            int codigo;

            do
            {
                Console.WriteLine("Digite o valor: ");
                codigo = Convert.ToInt32(Console.ReadLine());

                switch (codigo)
                {
                    case 1:
                        alcool++;
                        break;
                    case 2:
                        gasolina++;
                        break;
                    case 3:
                        diesel++;
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Código inválido. Digite novamente.");
                        continue;
                }
            } while (codigo != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}


/*
 * 
 * 
 * Desafio
Você recebeu o desafio de determinar qual dos produtos é o preferencial dos clientes de um posto de abastecimento de combustível. Para isso, escreva um algoritmo que leia o tipo de combustível abastecido, codificado da seguinte forma:

1 - Álcool
2 - Gasolina
3 - Diesel
4 - Fim
Caso o usuário informe um código inválido (fora da faixa de 1 a 4), deve ser solicitado um novo código, até que seja válido. O programa será encerrado quando o código informado for o número 4.

Entrada
A entrada contém apenas valores inteiros e positivos, que representam os códigos correspondentes aos tipos de combustível.

Saída
Deve ser escrito a mensagem "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme exemplo abaixo:

Alcool: quantidade de clientes que abasteceram com álcool.
Gasolina: quantidade de clientes que abasteceram com gasolina.
Diesel: quantidade de clientes que abasteceram com diesel.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
8
1
7
2
2
4

MUITO OBRIGADO
Alcool: 1
Gasolina: 2
Diesel: 0

2
3
4

MUITO OBRIGADO
Alcool: 0
Gasolina: 1
Diesel: 1

1
1
1
1
2
2
2
3
3
3
3
3
3
3
4

MUITO OBRIGADO
Alcool: 4
Gasolina: 3
Diesel: 7
 * 
 * 
 */