using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AvanadeBackendNETIA
{
    public class SistemaAvaliacaoProjetos
    {
        public void Executar()
        {
          
             
       
            // Leitura e extração do Nome do Projeto
            string linhaProjeto = Console.ReadLine();
            string nomeProjeto = linhaProjeto.Substring(9);

            // Leitura e extração do Nome do Consultor
            string linhaConsultor = Console.ReadLine();
            string nomeConsultor = linhaConsultor.Substring(11);

            // Leitura e extração das Notas
            string linhaNotas = Console.ReadLine();
            string notasApenas = linhaNotas.Substring(7);
            string[] partes = notasApenas.Split(", ");

            // Criação do objeto Projeto com os dados extraídos
            Projeto projeto = new Projeto
            {
                Nome = nomeProjeto,
                Consultor = nomeConsultor,
                Qualidade = int.Parse(partes[0]),
                Prazo = int.Parse(partes[1]),
                Satisfacao = int.Parse(partes[2])
            };

            // Exibe as informações do projeto no formato de saída solicitado
            projeto.ExibirInformacoes();
  
        }

        // TODO: Crie a Classe que representa um Projeto com suas informações
        public class Projeto
        {
            // Propriedades para armazenar os dados do projeto
            public string Nome { get; set; }
            public string Consultor { get; set; }
            public int Qualidade { get; set; }
            public int Prazo { get; set; }
            public int Satisfacao { get; set; }

            // TODO: Crie o método que calcula a média das notas
            // A soma das notas é dividida por 3.0 para garantir uma divisão de ponto flutuante.
            public double CalcularMedia()
            {
                return (Qualidade + Prazo + Satisfacao) / 3.0;
            }

            // Método que imprime as informações no formato solicitado
            public void ExibirInformacoes()
            {
                Console.WriteLine($"Projeto: {Nome}");
                Console.WriteLine($"Consultor: {Consultor}");
                Console.WriteLine($"Notas: Qualidade: {Qualidade}, Prazo: {Prazo}, Satisfacao: {Satisfacao}");
                // Formata a média para ter duas casas decimais, usando InvariantCulture para garantir o ponto decimal
                Console.WriteLine($"Media: {CalcularMedia().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}


/*
 * 
 * Descrição
Uma empresa de consultoria deseja implementar um sistema para armazenar avaliações dos projetos entregues. Cada projeto é avaliado em três critérios: qualidade, prazo e satisfação do cliente, com notas de 1 a 10. O objetivo é criar um sistema orientado a objetos que:

Cadastre um projeto e seu consultor;

Armazene as três notas;

Calcule a média final do projeto;

Exiba os dados no formato de saída exato especificado.

Entrada
Os dados de entrada incluem:

Nome do projeto
Nome do consultor
Notas: qualidade, prazo, satisfação (de 1 a 10)
Saída
O programa deve exibir:

Nome do projeto
Consultor responsável
Notas individuais
Média final do projeto (com duas casas decimais)
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Projeto: Sistema ERP
Consultor: Joao
Notas: 8, 9, 10	Projeto: Sistema ERP
Consultor: Joao
Notas: Qualidade: 8, Prazo: 9, Satisfacao: 10
Media: 9,00
Projeto: Plataforma EAD
Consultor: Ana
Notas: 7, 6, 8	Projeto: Plataforma EAD
Consultor: Ana
Notas: Qualidade: 7, Prazo: 6, Satisfacao: 8
Media: 7,00
Projeto: App Mobile
Consultor: Eliana
Notas: 9, 10, 9	Projeto: App Mobile
Consultor: Eliana
Notas: Qualidade: 9, Prazo: 10, Satisfacao: 9
Media: 9,33
 * 
 * 
 */