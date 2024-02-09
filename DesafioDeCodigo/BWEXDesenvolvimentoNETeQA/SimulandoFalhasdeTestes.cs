using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.BWEXDesenvolvimentoNETeQA
{
    public class SimulandoFalhasdeTestes
    {
        public void Executar()
        {
            Console.Write("Digite o nome do teste: ");
            string nomeDoTeste = Console.ReadLine();

            // Solicite ao usuário que digite a descrição do erro:
            Console.Write("Digite a descrição do erro: ");
            string descricaoDoErro = Console.ReadLine();

            // Use switch case para determinar a saída com base no nome do teste:
            switch (nomeDoTeste)
            {
                case "Teste de Compra Online O carrinho de compras nao atualiza":
                    Console.WriteLine($"O teste falhou: Descrição do erro: {descricaoDoErro}");
                    break;
                case "Teste de API Rest A solicitacao GET retornou erro 404":
                    Console.WriteLine($"O teste falhou: Descrição do erro: {descricaoDoErro}");
                    break;
                case "Teste de Envio de Formulario O formulario nao foi enviado":
                    Console.WriteLine($"O teste falhou: Descrição do erro: {descricaoDoErro}");
                    break;
            }

            //String nomeTeste = Console.ReadLine();
            //// TODO: Solicite ao usuário que digite a descrição do erro:
            //String descricaoDoErro = Console.ReadLine();
            //// Se o teste falhar, exibe a descrição do erro:
            //Console.WriteLine($"O teste falhou. Descricao: {descricaoDoErro}");


        }
    }
}

/*
 * 
 * Descrição
Neste desafio, vamos criar um programa que simula um algoritmo para registrar falhas em testes de um sistema. O programa solicitará ao usuário que insira o nome do teste e a descrição do erro correspondente. Em seguida, ele exibirá uma mensagem do erro formatado.

Entrada
A entrada do programa consiste em duas strings. A primeira string deve conter o nome do teste que falhou, e a segunda string deve conter a descrição do erro ocorrido durante o teste.

Saída
A saída do programa consiste em uma string formatada da seguinte maneira:
"O teste falhou: Descrição do erro: [descricaoDoErro]"

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Teste de Compra Online
O carrinho de compras nao atualiza	O teste falhou. Descricao: O carrinho de compras nao atualiza
Teste de API Rest
A solicitacao GET retornou erro 404	O teste falhou. Descricao: A solicitacao GET retornou erro 404
Teste de Envio de Formulario
O formulario nao foi enviado	O teste falhou. Descricao: O formulario nao foi enviado
 * 
 * */
