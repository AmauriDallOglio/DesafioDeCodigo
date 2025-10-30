using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.WEX_End_to_End_Engineering
{
    public class SelecaoNomesPorLetra
    {
        public void executar()
        {
            string linhaDeNomes = Console.ReadLine();

            // Separa os nomes e remove espaços extras
            List<string> nomes = linhaDeNomes
                .Split(',')
                .Select(nome => nome.Trim())
                .ToList();

            char letraFiltro = char.Parse(Console.ReadLine());

            // Filtra a lista de nomes que começam com a letra (ignorando maiúsculas/minúsculas)
            var filtrados = nomes
                .Where(nome => nome.StartsWith(letraFiltro.ToString(), StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Exibe o resultado
            if (filtrados.Count == 0)
            {
                Console.WriteLine("Nenhum nome encontrado");
            }
            else
            {
                foreach (var nome in filtrados)
                {
                    Console.WriteLine(nome);
                }
            }
        }
    }
}


/*
 * 
 * 
 * Descrição
Uma empresa está desenvolvendo um sistema para triagem de candidatos. O objetivo é filtrar nomes que comecem com uma letra específica informada. Você deve implementar um algoritmo que receba uma lista de nomes em uma única linha (separados por vírgula) e uma letra, e retorne apenas os nomes que começam com essa letra.

Entrada
A entrada deve conter:

Uma linha com os nomes separados por vírgula e espaço (ex: Ana, Pedro, Amanda)
Uma linha com a letra usada como filtro
Saída
O programa deve exibir os nomes que começam com a letra fornecida. Se nenhum nome corresponder, exibir "Nenhum nome encontrado".

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Ana, Pedro, Amanda, Joao
A	Ana
Amanda
Lucas, Pedro, Lara, Leo, Samuel
L	Lucas
Lara
Leo
Carla, Bruno, Paula
J	Nenhum nome encontrado
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.

Os desafios apresentados aqui têm como objetivo principal exercitar os conceitos aprendidos e proporcionar um primeiro contato com lógica de programação. Caso não tenha experiência em programação, utilize o template disponível e preencha com os conceitos aprendidos. Para resetar o template, basta clicar em “Restart Code”.

 * 
 * 
 */