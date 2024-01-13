﻿namespace DesafioDeCodigo.DecolaTech2024
{
    public class PrimeiroDesafioComPOO
    {
        public void Executar()
        {
            Console.WriteLine($"Digite o nome!");
            string nome = Console.ReadLine();
            Console.WriteLine($"Digite a idade!");
            int idade = int.Parse(Console.ReadLine());

            Pessoa pessoa = new Pessoa(nome, idade);

            Console.WriteLine($"Nome: {pessoa.GetNome()}, Idade: {pessoa.GetIdade()}");

        }

     

        public class Pessoa
        {
            public string Nome { get; set; } = string.Empty;
            public int Idade { get; set; } = 0;
            public Pessoa(string n, int i)
            {
                Nome = n;
                Idade = i;
            }
            public string GetNome()
            {
                return Nome;
            }

            public int GetIdade()
            {
                return Idade;
            }
        }
    }
}


/*
 * 
 * Desafio
Você acabou de aprender POO e foi desafiado a criar o seu primeiro projeto. Neste código, você deve criar uma classe chamada Pessoa com dois atributos: nome e idade. Em seguida, deve implementar dois métodos para obter esses atributos: getNome() e getIdade(). Por fim, deve criar um objeto do tipo Pessoa e exibir na tela o nome e a idade usando os métodos criados.

Requisitos:

Utilizar classes e métodos para implementar o programa;
Implementar a classe Pessoa com os atributos nome e idade, e o método get para cada atributo;
O programa deve solicitar que o usuário insira o nome e a idade da pessoa;
O programa deve exibir o nome e a idade da pessoa inserida pelo usuário.
Entrada
A entrada deverá receber as informações do objeto Pessoa, conforme exemplo abaixo:

nome (string)
idade (int)
Saída
O código deverá retornar uma mensagem (string) informando o nome e idade da pessoa, de acordo com o que foi recebido como entrada. Veja como exemplo a entrada recebida abaixo:

João
26

De acordo com esses valores de entrada, a saída ficará desta maneira:

Nome: João, Idade: 26

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Ana
17

Nome: Ana, Idade: 17
Paulo
44

Nome: Paulo, Idade: 44
Maria
32

Nome: Maria, Idade: 32
 * 
 */