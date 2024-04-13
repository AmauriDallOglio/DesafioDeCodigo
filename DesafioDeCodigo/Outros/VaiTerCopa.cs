using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class VaiTerCopa
    {
        public void Executar()
        {
            string line;
            while ((line = Console.ReadLine()) != null)
            {
                int reclamacoes = int.Parse(line);
                if (reclamacoes == 0)
                {
                    Console.WriteLine("vai ter copa!");
                }
                else
                {
                    Console.WriteLine("vai ter duas!");
                }
            }
        }
    }
}
