using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.EverisNewTalentsNET
{
    public class TempoJogoComMinutos
    {
        public void Executar()
        {
            Console.WriteLine("Digite o valor:");
            string[] input = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(input[0]);
            int minutoInicial = int.Parse(input[1]);
            int horaFinal = int.Parse(input[2]);
            int minutoFinal = int.Parse(input[3]);

            int duracaoEmMinutos = 0;

            if (horaInicial == horaFinal && minutoInicial == minutoFinal)
            {
                // Caso os horários iniciais e finais sejam iguais, o jogo durou 24 horas
                duracaoEmMinutos = 24 * 60;
            }
            else if (horaInicial == horaFinal)
            {
                // Caso as horas iniciais e finais sejam iguais, mas os minutos sejam diferentes
                duracaoEmMinutos = minutoFinal - minutoInicial;
            }
            else
            {
                // Calcula a duração do jogo em minutos
                duracaoEmMinutos = ((horaFinal - horaInicial) * 60) + (minutoFinal - minutoInicial);
            }

            if (duracaoEmMinutos <= 0)
            {
                // Se a duração for negativa ou igual a zero, ajusta para 24 horas
                duracaoEmMinutos += 24 * 60;
            }

            int duracaoEmHoras = duracaoEmMinutos / 60;
            int duracaoRestanteEmMinutos = duracaoEmMinutos % 60;

            Console.WriteLine($"O JOGO DUROU {duracaoEmHoras} HORA(S) E {duracaoRestanteEmMinutos} MINUTO(S)");
        }
    
    }
}

/*
 * 
 * 
 * Desafio
Leia a hora inicial, minuto inicial, hora final e minuto final de um jogo. A seguir calcule a duração do jogo.

Obs: O jogo tem duração mínima de um (1) minuto e duração máxima de 24 horas.

Entrada
Quatro números inteiros representando a hora de início e fim do jogo.

Saída
Mostre a seguinte mensagem: “O JOGO DUROU XXX HORA(S) E YYY MINUTO(S)” .

 
Exemplo de Entrada	Exemplo de Saída
7 8 9 10

O JOGO DUROU 2 HORA(S) E 2 MINUTO(S)

7 7 7 7

O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)

7 10 8 9

O JOGO DUROU 0 HORA(S) E 59 MINUTO(S)
 * 
 * 
 */