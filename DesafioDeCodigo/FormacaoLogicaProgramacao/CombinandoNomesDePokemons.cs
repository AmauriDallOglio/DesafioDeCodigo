namespace DesafioDeCodigo.FormacaoLogicaProgramacao
{
    public class CombinandoNomesDePokemons
    {
        public void Executar()
        {
            // Solicitando ao usuário que insira a parte inicial do nome do Pokémon
            Console.WriteLine("Digite a parte inicial do nome do Pokémon:");
            // Obtendo a entrada do usuário
            string nomeEntrada = Console.ReadLine();

            // Chamando a função combinandoNomesPokemons com o nome do Pokémon informado
            string palavraGerada = combinandoNomesPokemons(nomeEntrada);

            // Exibindo o nome gerado do Pokémon
            Console.WriteLine($"Nome completo do Pokémon: {palavraGerada}");
        }

        public static string combinandoNomesPokemons(string palavra)
        {
            // Concatenando a palavra com "saur" para formar o nome do Pokémon
            string palavraPokemon = palavra + "saur";
            // Retornando o nome do Pokémon
            return palavraPokemon;
        }
    }
}

/*
 * 
 * 
 * 
 * Descrição
Imagine um universo onde você é um Mestre Pokémon com o poder de criar novas criaturas através da combinação de nomes. Seu algoritmo é a chave para dar vida a esses seres incríveis. Você receberá uma primeira parte do nome de um Pokémon e sua tarefa é completá-la com o sufixo mágico adequado, revelando o nome completo do Pokémon.

Tarefa: Sua missão é criar uma função extraordinária chamada combinarNomePokemon. Essa função possui um toque mágico que transforma uma entrada simples em algo verdadeiramente especial.

Entrada
A entrada consistirá em uma única string representando a primeira parte do nome de um Pokémon.

Saída
A função deve retornar uma nova string que é a combinação da parte inicial(Préfixo) do nome do Pokémon com o sufixo final do nome, formando um nome de Pokémon completo.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Bulba	Bulbasaur
Ivy	Ivysaur
Venu	Venusaur
 * 
 * 
 */