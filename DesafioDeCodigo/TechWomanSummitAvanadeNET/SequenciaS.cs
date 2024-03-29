namespace DesafioDeCodigo.TechWomanSummitAvanadeNET
{
    public class SequenciaS
    {
        public void Executar()
        {
            double S = 0;

            for (double a = 1; a <= 100; a++)
            {
                S += 1.0 / a;
            }

            double roundedS = Math.Round(S, 2);
            Console.WriteLine(roundedS);
        }
    }
}

/*
 * 
 * 
 * 
 * Desafio
Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100

Entrada
Não há nenhuma entrada neste problema.

Saída
A saída contém um valor correspondente ao valor de S.
O valor deve ser impresso com dois dígitos após o ponto decimal.

 
Exemplo de Entrada	Exemplo de Saída
No need input, check output only!	5.19
 
 * 
 */