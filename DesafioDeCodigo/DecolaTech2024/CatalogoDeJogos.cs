﻿ 
namespace DesafioDeCodigo.DecolaTech2024
{
    public class CatalogoDeJogos
    {
        public void Executar()
        {
            string[] nomesJogos  = null;
            int quantidadeJogos = 0;

            // Pergunta ao usuário quantos jogos deseja adicionar:
            Console.WriteLine($"Quantos jogos deseja adicionar!");
            quantidadeJogos = int.Parse(Console.ReadLine());

            // TODO: Inicializa os arrays com base na quantidade informada pelo usuário:
            nomesJogos = new string[quantidadeJogos];

            // TODO: Crei um Loop para adicionar jogos conforme a quantidade especificada:
            for (int i = 0; i < quantidadeJogos; i++)
            {
                //TODO: Chame a função AdicionarJogo para obter o nome do jogo e armazená-lo no array:
                AdicionarJogo(i, nomesJogos);
            }

            // Exibe o resumo da adição de jogos
            ExibirResumoAdicaoJogos(quantidadeJogos, nomesJogos);
        }

        private static void AdicionarJogo(int indice, string[] nomes)
        {
            // Entrada do nome do jogo
            int quantidadeJogo = indice + 1;
            Console.WriteLine($"Adicione o {quantidadeJogo}° jogo!");
            nomes[indice] = Console.ReadLine();
        }

        private static void ExibirResumoAdicaoJogos(int quantidadeJogos, string[] nomes)
        {
            string nomesFormatados = string.Join(", ", nomes);
            Console.WriteLine($"Foi adicionado '{quantidadeJogos}' jogos: {nomesFormatados} ao catalogo.");
        }
    }
}


/*
 * 
 * 
 * 
 * 
 * Descrição
Neste desafio, o objetivo é criar um catálogo de jogos que permita ao usuário adicionar uma quantidade específica de jogos. Inicie solicitando a quantidade desejada e, em seguida, peça o nome de cada jogo individualmente, armazenando-os em um array chamado nomesJogos. Utilize um loop `for` para facilitar a adição dos jogos. Após a conclusão, exiba um resumo em uma única linha, indicando a quantidade total de jogos adicionados e a lista de nomes no catálogo.

Entrada
O programa inicia solicitando ao usuário que insira a quantidade de jogos que deseja adicionar ao catálogo. Em seguida, para cada jogo, o usuário é solicitado a inserir o nome do jogo.

Saída
Ao final da adição dos jogos, o programa exibe um resumo que inclui a quantidade total de jogos adicionados e uma lista com os nomes dos jogos separados por vírgulas. Este resumo fornece uma visão geral dos jogos que foram incluídos no catálogo.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
2
SimCity
Prince of Persia	Foi adicionado '2' jogos: SimCity, Prince of Persia ao catalogo.
3
Tetris
Doom
Pong	Foi adicionado '3' jogos: Tetris, Doom, Pong ao catalogo.
2
Portal
Limbo	Foi adicionado '2' jogos: Portal, Limbo ao catalogo.


 * */