namespace DesafioDeCodigo.DecolaTech2024
{
    public class CriandoUmJogadorDeFutebol
    {
        public void Executar()
        {
            string nome = string.Empty;
            string nacionalidade = string.Empty;
            int idade = 0;
            string posicao = string.Empty;


            Console.WriteLine($"Digite o nome do jogador!");
            nome = Console.ReadLine();
            Console.WriteLine($"Digite a nacionalidade do jogador!");
            nacionalidade = Console.ReadLine();
            Console.WriteLine($"Digite a idade do jogador!");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite a posição do jogador!");
            posicao = Console.ReadLine();

            Jogador j1 = new Jogador(nome, nacionalidade, idade, posicao);
            j1.Novo();
        }

        class Jogador
        {
            public string Nome { get; set; }
            public string Nacionalidade { get; set; }
            public int Idade { get; set; }
            public string Posicao { get; set; }

            public Jogador()
            {
            }

            public Jogador(string nome, string nacionalidade, int idade, string posicao)
            {
                Nome = nome;
                Nacionalidade = nacionalidade;
                Idade = idade;
                Posicao = posicao;
            }

            public void Novo()
            {
                Console.WriteLine("Jogador criado!");
                Console.WriteLine($"{Nome}");
                Console.WriteLine($"{Nacionalidade}");
                Console.WriteLine($"{Idade}");
                Console.WriteLine($"Posição: {Posicao}");
            }
        }
    }
}


/*
 * 
 * Desafio
Você deve criar um programa que crie um objeto jogador com nome, nacionalidade, idade e posição. O jogador deve ser criado a partir de uma classe "Jogador" com o método "novo" e os atributos mencionados.

Entrada
O programa deve ler as informações do jogador nessa ordem: 

nome: string
nacionalidade: string
idade: inteiro
posição: strig
Saída
O programa deve imprimir as informações do jogador criado, uma por linha, com a mensagem "Jogador criado!" no início. As informações devem ser exibidas na seguinte ordem: nome, nacionalidade, idade e posição (com a mensagem "Posição:" na frente). Veja a estrutura abaixo:

Jogador criado!
[nome]
[nacionalidade]
[idade]
Posição: [posição]
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Ronaldo
Brasil
46
Atacante

Jogador criado!
Ronaldo
Brasil
46
Posição: Atacante

Puyol
Espanha
20
Zagueiro

Jogador criado!
Puyol
Espanha
20
Posição: Zagueiro
John
EUA
28
Meio-campo

IJogador criado!
John
EUA
28
Posição: Meio-campo
 * 
 */