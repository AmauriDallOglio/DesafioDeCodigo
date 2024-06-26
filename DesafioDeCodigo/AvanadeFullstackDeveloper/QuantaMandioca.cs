﻿namespace DesafioDeCodigo.AvanadeFullstackDeveloper
{
    public class QuantaMandioca
    {
        public void Executar()
        {
            int chico = 300 * Int32.Parse(Console.ReadLine());
            int bento = 1500 * Int32.Parse(Console.ReadLine());
            int bernardo = 600 * Int32.Parse(Console.ReadLine());
            int marina = 1000 * Int32.Parse(Console.ReadLine());
            int iara = 150 * Int32.Parse(Console.ReadLine());
            int marlene = 225;

            int total = chico + bento + bernardo + marina + iara + marlene;
            Console.WriteLine(total);
        }
    }
}

/*
 * 
 * Desafio
Os meses de Junho e Julho são tradicionalmente conhecidos por todo Brasil por suas festas típicas, e para o grupo de amigos da Marlene não é diferente, toda segunda quinzena do mês de Julho ela e seus amigos se reunem para tradicional mandiocada! Na festiva sempre se reúnem na casa da Marlene, o Chico, o Beto, o Bernardo, a Marina e a Iara. E como não poderia ser diferente o prato principal dessa reunião é a mandioca. Cada um deles come de uma a dez porções de mandioca e eles sempre avisam a Marlene com antecedência a respeito de quantas porções irão comer nesse dia. O tamanho da porção de cada um é diferente, mas sempre são os mesmos. As porções são as seguintes (em gramas):

O Chico come 300

O Bento come 1500

O Bernardo come 600

A Marina 1000

A Iara come 150

Marlene por sua vez sempre come 225 gramas de mandioca. Cansada de todo ano ter que calcular quanta mandioca preparar ela te desafiou para escrever um programa que informe quanta mandioca deve ser preparada em gramas.

Entrada
A entrada consiste de 5 inteiros cada um representando as porções que os convidados de dona Chica vão consumir. O primeiro inteiro representa as porções do Chico, o segundo do Bento, o terceiro do Bernardo, o quarto da Marina e o quinto a da Iara.

Saída
A saída consiste de um único inteiro que representa quanta mandioca Marlene deve preparar em gramas.

 
Exemplos de Entrada	Exemplos de Saída
1
1
1
1
1

3775

 
2
2
2
2
2

7325
 * 
 * 
 */