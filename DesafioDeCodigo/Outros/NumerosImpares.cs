using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class NumerosImpares
    {
        public void Executar()
        {
            Console.WriteLine("Digite o valor: ");
            // Lê o valor de X
            int X = int.Parse(Console.ReadLine());

            // Itera de 1 até X
            for (int i = 1; i <= X; i++)
            {
                // Verifica se o número é ímpar
                if (i % 2 != 0)
                {
                    // Imprime o número ímpar
                    Console.WriteLine(i);
                }
            }
        }
    }
}
