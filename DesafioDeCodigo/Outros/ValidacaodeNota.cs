using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class ValidacaodeNota
    {

        public void Executar()
        {
            double somaDasNotas = 0;
            int contador = 0;

            do
            {
                Console.WriteLine($"Digite o valor:");
                double notaEntradaConsole = double.Parse(Console.ReadLine());

                if (notaEntradaConsole < 0 || notaEntradaConsole > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    contador++;
                    somaDasNotas += notaEntradaConsole;
                }
            } while (contador < 2);

            Console.WriteLine("media = " + (somaDasNotas / 2).ToString("F2"));
        }
    }
}
