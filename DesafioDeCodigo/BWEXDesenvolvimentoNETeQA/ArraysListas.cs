namespace DesafioDeCodigo.BWEXDesenvolvimentoNETeQA
{
    public class ArraysListas
    {
        public void Executar()
        {

            // Defina um array 'testes' para armazenar as complexidades dos testes:
            string[] testes = new string[3];

            // Defina um array 'complexidades' que contém as possíveis complexidades dos testes:
            string[] complexidades = { "baixa", "média", "alta" };

            for (int i = 0; i < 3; i++)
            {
                // Solicita ao usuário a complexidade do teste e armazena-o em testes[i]:
                Console.WriteLine($"Digite a complexidade do Teste {i + 1} (baixa, média ou alta):");
                testes[i] = Console.ReadLine().ToLower();
            }

            int maiorComplexidadeIndex = EncontrarMaiorComplexidadeIndex(testes, complexidades);
            string testePrioritario = $"Teste {maiorComplexidadeIndex + 1}";

            // Aqui é exibido o teste prioritário na tela:
            Console.WriteLine($"O teste a ser executado primeiro é o {testePrioritario}.");

            // Esse trecho aguarda a entrada do usuário antes de encerrar o programa
            Console.ReadLine();
        }

        static int EncontrarMaiorComplexidadeIndex(string[] testes, string[] complexidades)
        {
            int maiorIndex = 0;

            // Aqui é implementada a lógica necessária para encontrar o índice do teste com a maior complexidade:
            // Utiliza o "loop FOR" para encontrar o índice:
            for (int i = 1; i < testes.Length; i++)
            {
                // No trecho de código abaixo é comparada a complexidade de diferentes testes 
                // E encontra o índice do teste com a maior complexidade
                if (Array.IndexOf(complexidades, testes[i]) > Array.IndexOf(complexidades, testes[maiorIndex]))
                {
                    maiorIndex = i;
                }

            }
            return maiorIndex;
        }

    }
}


/*
 * 
 *Descrição
Neste desafio, o objetivo é criar um programa que ajude na priorização de testes de acordo com sua complexidade. O usuário deverá inserir a complexidade (baixa, media ou alta) de três testes distintos, utilizando conceitos de arrays ou listas. Com base nas complexidades fornecidas, o programa calculará e apresentará qual teste deve ser executado primeiro.

Entrada
O programa requer a entrada de três strings que representam os níveis de prioridade atribuídos aos três testes.

Saída
A saída do programa consiste na indicação do teste que deve ser priorizado com base nas complexidades fornecidas.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Alta
Media
Baixa	O teste a ser executado primeiro e o Teste 1.
Baixa
Alta
Media	O teste a ser executado primeiro e o Teste 2.
Media
Baixa
Alta	O teste a ser executado primeiro e o Teste 3.
 * 
 */