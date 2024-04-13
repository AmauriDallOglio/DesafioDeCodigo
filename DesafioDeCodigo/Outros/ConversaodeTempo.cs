using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class ConversaodeTempo
    {
        public void Executar() {
            // Ler o tempo em segundos

            Console.WriteLine("Digite o valor: ");
            int tempoSegundos = int.Parse(Console.ReadLine());

            // Calcular as horas, minutos e segundos
            int horas = tempoSegundos / 3600;
            int minutos = (tempoSegundos % 3600) / 60;
            int segundos = (tempoSegundos % 3600) % 60;

            // Imprimir o resultado no formato horas:minutos:segundos
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}


/*
 * Desafio
Você terá o desafio de ler um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma loja, e informe-o expresso no formato horas:minutos:segundos.

Entrada
O arquivo de entrada contém um valor inteiro N.

Saída
Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

 
Exemplo de Entrada	Exemplo de Saída
556	0:9:16
1	0:0:1
 
 * 
 * 
 */