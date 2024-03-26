using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AvanadeFullstackDeveloper
{
    public class DividindoXporY
    {
        public void Executar()
        {
            Console.WriteLine("Digite o número inteiro: ");
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);
                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine(Math.Round(X / Y, 1).ToString("F1"));
                }
            }
        }
    }
}
