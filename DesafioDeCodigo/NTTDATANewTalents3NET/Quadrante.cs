using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.NTTDATANewTalents3NET
{
    public class Quadrante
    {
        public void Executar()
        {
            while (true)
            {
                string[] entrada = Console.ReadLine().Split();
                int x = int.Parse(entrada[0]);
                int y = int.Parse(entrada[1]);

                if (x == 0 || y == 0)
                    break;

                if (x > 0 && y > 0)
                    Console.WriteLine("primeiro");
                else if (x > 0 && y < 0)
                    Console.WriteLine("quarto");
                else if (x < 0 && y < 0)
                    Console.WriteLine("terceiro");
                else if (x < 0 && y > 0)
                    Console.WriteLine("segundo");
            }
        }
    }
}
