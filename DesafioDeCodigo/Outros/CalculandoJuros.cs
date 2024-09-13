using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class CalculandoJuros
    {
        public void executar()
        {
            // Solicita ao usuário para inserir os valores
            Console.WriteLine("Insira o valor inicial do investimento (P):");
            string P_input = Console.ReadLine();
            Console.WriteLine("Insira a taxa de juros anual (i) (por exemplo, 0.05 para 5%):");
            string i_input = Console.ReadLine();
            Console.WriteLine("Insira o número de anos (n):");
            string n_input = Console.ReadLine();

            // Converte as entradas para os tipos apropriados
            double P = Convert.ToDouble(P_input);
            double i = Convert.ToDouble(i_input);
            int n = Convert.ToInt32(n_input);

            // Calcula o montante final utilizando a função CalcularJurosSimples
            double montanteFinal = CalcularJurosSimples(P, i, n);

            // Exibe o resultado
            Console.WriteLine("Montante final: " + montanteFinal); // Mostra o montante final calculado
        }

        public static double CalcularJurosSimples(double P, double i, int n)
        {
            // Calcula e retorna o montante final com juros simples
            double A = P + (P * i * n);
            return A;
        }
 
    }
}
