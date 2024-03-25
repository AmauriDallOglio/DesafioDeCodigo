﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesafioDeCodigo.DecolaTech2024.ControleDeVelocidadeDoRobo;

namespace DesafioDeCodigo.NETDeveloper
{
    public class ConstruindoUmExercitoDeRobos
    {
        public void Executar()
        {
            string nome, modelo;
            int ano;

            Console.WriteLine($"Digite nome: ");
            nome = Console.ReadLine();

            Console.WriteLine($"Digite modelo: ");
            modelo = Console.ReadLine();

            Console.WriteLine($"Digite ano: ");
            ano = int.Parse(Console.ReadLine());

            // Instanciando um Robo passando os valores lidos em seu construtor
            Robo robo = new Robo(nome, modelo, ano);

            // Invocando o método "ExibirInformacoes"
            robo.ExibirInformacoes();
        }

        public class Robo
        {
            private string nome;
            private string modelo;
            private int anoFabricacao;

            public Robo(string nome, string modelo, int anoFabricacao)
            {
                this.nome = nome;
                this.modelo = modelo;
                this.anoFabricacao = anoFabricacao;
            }

            public void ExibirInformacoes()
            {
                Console.WriteLine($"O robô {nome}, modelo {modelo}, foi fabricado em {anoFabricacao}.");
            }
        }
    }
}

/*
 * 
 * Desafio
Você é um inventor de robôs excêntrico e engraçado, que decidiu criar seu próprio exército de robôs para ajudá-lo em suas tarefas diárias. Para isso, você precisa desenvolver uma classe Robô que permita que cada um dos seus robôs tenha características únicas. Crie seu próprio robô personalizado, escolhendo seu nome, modelo e ano de fabricação, e veja seu exército de robôs engraçados tomar forma diante dos seus olhos!

Você precisa criar uma classe Robo que possua um construtor que inicialize a classe com as características do robô (nome, modelo e ano de fabricação). Além disso, você precisa implementar métodos para exibir as características do robô.

Escreva uma classe Robo, que possua os seguintes atributos e métodos:

Três atributos: nome, modelo e ano de fabricação;
Construtor: deverá inicializar a classe com o nome, modelo e ano de fabricação;
Método chamado exibirInformações: que não receba parâmetros e exiba na tela as características do robô.
Seu programa deve solicitar ao usuário o nome, modelo e ano de fabricação do robô e criar um objeto Robo com essas informações. Em seguida, deve chamar o método exibirInformacoes para exibir as características do robô.

Entrada:
A entrada deverá receber os atributos do robô, conforme exemplo abaixo:

nome: referente ao nome do robô (string).
modelo: referente ao modelo do robô (string).
ano: referente ao ano da criação do robô (int).
IMPORTANTE: A entrada deverá seguir a ordem informada acima.

Saída:
O código deverá retornar uma mensagem (string) informando o nome, modelo e ano do robô criado, de acordo com o que foi recebido como entrada. Veja como exemplo a entrada recebida abaixo:

DioBot
DIO
2020

De acordo com esses valores de entrada, a saída ficará desta maneira:

O robô DioBOT, modelo DIO, foi fabricado em 2020.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Robozão
RBZ1000
2022
O robô Robozão, modelo RBZ1000, foi fabricado em 2022.
DioBot
DIO
2020
O robô DioBot, modelo DIO, foi fabricado em 2020.
Megazord
PR-2000
2017
O robô Megazord, modelo PR-2000, foi fabricado em 2017.
 * 
 * 
 */
