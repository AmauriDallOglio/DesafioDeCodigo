using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.NTTDATANewTalents3NET
{
    public class Xenlonguinho
    {
        public void Executar()
        {
            Console.Write("Digite o valor: ");
            int N = Convert.ToInt32(Console.ReadLine());

            while (N-- > 0)
            {
                int val = Convert.ToInt32(Console.ReadLine());
                int newval = (int)Math.Sqrt(val);
                int resposta = val - newval;

                Console.WriteLine(resposta);
            }
        }
    }
}
