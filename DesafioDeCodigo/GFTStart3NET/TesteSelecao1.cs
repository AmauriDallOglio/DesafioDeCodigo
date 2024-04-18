namespace DesafioDeCodigo.GFTStart3NET
{
    internal class TesteSelecao1
    {
        public void Executar9()
        {
            string[] selections = Console.ReadLine().Split(' ');
            Console.WriteLine($"Digite o valor a:");
            int A = int.Parse(selections[0]);
            Console.WriteLine($"Digite o valor b:");
            int B = int.Parse(selections[1]);
            Console.WriteLine($"Digite o valor c:");
            int C = int.Parse(selections[2]);
            Console.WriteLine($"Digite o valor d:");
            int D = int.Parse(selections[3]);

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && (A % 2 == 0))
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
    /*
     * Desafio
Leia 4 valores inteiros A, B, C e D. Com base nisso, se o valor de B for maior do que de C e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se tanto C quanto D forem positivos e, ainda, se a variável A for par, escreva a mensagem "Valores aceitos", senão escrever "Valores nao aceitos".

Entrada
Quatro números inteiros A, B, C e D.

Saída
Imprima a mensagem corretamente esperada pela validação dos valores.

 
Exemplo de Entrada	Exemplo de Saída
5 6 7 8

Valores nao aceitos

2 3 2 6	Valores aceitos
     * 
     */
}
