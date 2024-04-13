using DesafioDeCodigo.AvanadeFullstackDeveloper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class Distancia
    {
        public Distancia() {
            Console.WriteLine("Digite o valor: ");
            int quilometros = Int32.Parse(Console.ReadLine());

            // Cálculo do tempo necessário para a moto Y alcançar a distância K da moto X
            int minutos = quilometros * 2; // Calcula os minutos necessários

            // Saída do resultado
            Console.WriteLine(minutos + " minutos");


        }
    }
}


/*
 * 
 * 
 * Desafio
Duas motos (X e Y) partem em uma mesma direção. A moto X sai com velocidade constante de 60 Km/h e a moto Y sai com velocidade constante de 90 Km/h.

Em uma hora (60 minutos) a moto Y consegue se distanciar 30 quilômetros da moto X, ou seja, consegue se afastar um quilômetro a cada 2 minutos.

O seu desafio é ler a distância (em Km) e calcular quanto tempo leva (em minutos) para a moto Y tomar essa distância da outra moto.

Entrada
O arquivo de entrada contém um número inteiro K que representa a quantidade de quilômetro que que a moto Y deve estar da moto X.

Saída
Imprima o tempo necessário para a moto Y ficar com a quantidade K de quilômetro da moto X, seguido da mensagem " minutos".

 
Exemplo de Entrada	Exemplo de Saída
30

60 minutos

110	220 minutos
 * 
 * 
 */