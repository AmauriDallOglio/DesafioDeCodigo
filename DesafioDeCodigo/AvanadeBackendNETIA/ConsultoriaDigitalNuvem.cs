﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AvanadeBackendNETIA
{
    public class ConsultoriaDigitalNuvem
    {
        public void Executar()
        {
            // Lê a entrada do usuário
            string entrada = Console.ReadLine();

            // Divide a entrada em partes usando espaço como separador
            string[] partes = entrada.Split(' ');

            // O primeiro elemento representa a quantidade de interações
            string quantidade = partes[0];

            // Retorna a saída no formato especificado
            Console.WriteLine($"{quantidade} interacoes");
        }
    }
}


/*
 * 
 * 
 * Desafio
Você é um consultor digital que ajuda empresas a otimizar seus serviços na nuvem. Seu cliente precisa de um relatório que exiba a quantidade total de interações com seus serviços ao longo de um período. Cada interação é registrada em uma lista e você deve calcular o total com base em um número de dias informado.

Entrada
A entrada deve receber uma string contendo um número inteiro que representa a quantidade de dias e, em seguida, uma lista de interações, onde cada interação é uma string contendo um identificador único. As interações devem ser separadas por espaço. Por exemplo: "7 id1 id2 id3 id4 id5 id6 id7".

Saída
Deverá retornar uma string com a quantidade total de interações registradas, seguida da palavra "interacoes". Exemplo: "7 interacoes".

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
3 id1 id2 id3	3 interacoes
5 id1 id2 id3 id4 id5	5 interacoes
2 id1 id2	2 interacoes
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descrições do desafio de código.  
 * 
 * 
 */