﻿namespace DesafioDeCodigo.TechWomanSummitAvanadeNET
{
    public class FusoHorario
    {
        public void Executar()
        {
            Console.WriteLine("Digite 3 valores inteiros: ");
            String[] entrada = Console.ReadLine().Split(" ");
            int horaSaida = int.Parse(entrada[0]);
            int tempoViagem = int.Parse(entrada[1]);
            int fusoDestino = int.Parse(entrada[2]);
            int horaChegada;

            horaChegada = horaSaida + tempoViagem + fusoDestino;

            if (horaChegada >= 24)
            {
                horaChegada -= 24;
            }

            if (horaChegada < 0)
            {
                horaChegada += 24;
            }

            Console.WriteLine(horaChegada);

        }
    }
    
}


/*
 * 
 * 
 * Desafio
Romeu e Julieta acabaram de casar e estão planejamendo a Lua de Mel na Europa. Como vão visitar vários países, o fuso horário de cada um é diferente, por isso eles precisam ficar atento às escalas.

Para que a Lua de Mel deles seja um sucesso, ele pediram que você desenvolva um aplicativo que, a partir da hora de saída, tempo de viagem e fuso horário do destino comparado ao país de origem, informe a hora de chegada de cada vôo no destino. 

Por exemplo, se eles partirem às 10 horas da manhã para uma viagem de 4 horas rumo a um destino que fica à leste, em um fuso horário com uma hora a mais com relação ao fuso horário do ponto de partida, a hora de chegada terá que ser: 10 horas + 4 horas de viagem + 1 hora de deslocamento pelo fuso, ou seja, chegarão às 15 horas. Note que se a hora calculada for igual a 24, seu programa deverá imprimir 0 (zero).

Entrada
A entrada contém 3 inteiros: S (0 ≤ S ≤ 23), T (1 ≤ T ≤ 12) e F (-5 ≤ F ≤ 5), separados por um espaço, indicando respectivamente a hora da saída, o tempo de viagem e o fuso horário do destino com relação à origem.

Saída
Imprima um inteiro que indica a hora local prevista no destino, conforme os exemplos abaixo.

 
Exemplos de Entrada	Exemplos de Saída
10 7 3

20

 
22 6 -2

2
0 3 -4

23
 * 
 */