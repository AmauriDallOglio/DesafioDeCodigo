﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class Tuitando
    {
        public Tuitando() {

            Console.WriteLine("Digite o valor: ");
            string texto = Console.ReadLine();

            if (texto.Length <= 140)
            {
                Console.WriteLine("TWEET");
            }
            else
            {
                Console.WriteLine("MUTE");
            }

        }
    }
}


/*
 * 
 * DESAFIO
O microblog Twitter é conhecido por limitar as postagens em 140 caracteres. Conferir se um texto vai caber em um tuíte é sua tarefa.

Entrada
A entrada é uma linha de texto T (1 ≤ |T| ≤ 500).

Saída
A saída é dada em uma única linha. Ela deve ser "TWEET" (sem as aspas) se a linha de texto T tem até 140 caracteres. Se T tem mais de 140 caracteres, a saída deve ser "MUTE".

 
Exemplo de Entrada	Exemplo de Saída
RT @TheEllenShow: If only Bradley's arm was longer. Best photo ever. #oscars pic.twitter.com/C9U5NOtGap

TWEET
 * 
 * 
 */