using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class OMaior
    {
        public void Executar()
        {
            Console.WriteLine("Digite o valor: ");
            string[] valores = Console.ReadLine().Split(' ');

            int a = int.Parse(valores[0]);
            int b = int.Parse(valores[1]);
            int c = int.Parse(valores[2]);

            int maiorAB = (a + b + Math.Abs(a - b)) / 2;
            int maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

            Console.WriteLine($"{maior} eh o maior");
        }
    }
}

/*
 * 
 * Exemplos de Entrada	Exemplos de Saída
7 14 106

106 eh o maior

217 14 6	217 eh o maior
 * 
 * 
 * 
 */