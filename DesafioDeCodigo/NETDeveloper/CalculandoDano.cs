namespace DesafioDeCodigo.NETDeveloper
{
    public class CalculandoDano
    {
        public void Executar()
        {
            Console.WriteLine($"Digite valor do ataque: ");
            int ataque = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite valor da defesa: ");
            int defesa = int.Parse(Console.ReadLine());

            int danoCausado = CalcularDano(ataque, defesa);
            Console.WriteLine("O dano causado pelo ataque foi: " + danoCausado);


            static int CalcularDano(int ataque, int defesa)
            {
                //TODO: Implemente a função calcular dano
                int dano = ataque - defesa;
                if (dano < 0)
                {
                    dano = 0;
                }
                return dano;
            }

        
       
        }
    }

    /*
     * 
     * 
     * Desafio
Em jogos de RPG, é comum haver ações de ataque dos personagens, que causam um certo dano ao inimigo. Este dano pode ser calculado de diferentes formas, dependendo do sistema do jogo. Neste desafio, você deve criar uma função que calcula o dano de um ataque, levando em consideração o valor do ataque e a defesa do inimigo.

Crie uma função chamada "calcular_dano" que recebe dois parâmetros: "ataque" e "defesa". A função deve retornar o valor do dano causado pelo ataque, utilizando a seguinte fórmula:

dano = ataque - defesa

Se o valor do dano for negativo, ele deve ser considerado zero.

Entrada:
Seu programa deverá receber uma  entrada para a função "calcular_dano", que irá solicitar ao usuário que insira dois valores: o valor do ataque e o valor da defesa do inimigo. Esses valores serão passados como parâmetros para a função.

Saída:
A saída deve ser exibida com a frase "O dano causado pelo ataque foi: " seguida do valor do dano calculado. Caso o valor do dano seja negativo, deve ser exibido zero.

Por exemplo, se o valor do ataque for 10 e o valor da defesa do inimigo for 8, a chamada da função "calcular_dano" deve resultar na seguinte saída:

"O dano causado pelo ataque foi: 2"
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
10
8

O dano causado pelo ataque foi: 2
3
9

O dano causado pelo ataque foi: 0
7
1

O dano causado pelo ataque foi: 6
     * 
     * 
     * 
     */
}
