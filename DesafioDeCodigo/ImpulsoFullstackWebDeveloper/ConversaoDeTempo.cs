using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.ImpulsoFullstackWebDeveloper
{
    public class ConversaoDeTempo
    {
        public void Executar()
        {
            Console.WriteLine("Digite o tempo em segundos: ");
            // Lê o tempo em segundos
            int tempoEmSegundos = int.Parse(Console.ReadLine());

            // Calcula as horas, minutos e segundos
            int horas = tempoEmSegundos / 3600;
            int minutos = (tempoEmSegundos % 3600) / 60;
            int segundos = tempoEmSegundos % 60;

            // Exibe o resultado
            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}

/*
 * 
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
 */