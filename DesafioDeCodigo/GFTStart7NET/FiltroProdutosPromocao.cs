using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.GFTStart7NET
{
    public class FiltroProdutosPromocao
    {
        public void Executar()
        {

            // Lê a quantidade de produtos
            int n = int.Parse(Console.ReadLine());

            // Lê a linha com todos os produtos
            string linha = Console.ReadLine();

            // TODO: Crie a lista para armazenar os produtos
            List<Produto> listaDeProdutos = new List<Produto>();

            // Divide a linha por vírgula para obter os dados de cada produto
            string[] partes = linha.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            // Processa os dados de produtos
            // A lógica de controle do loop 'for' está correta para iterar sobre os grupos de 3 (nome, preço, estoque)
            for (int i = 0; i < n * 3; i += 3)
            {
                string nome = partes[i].Trim();
                // Tenta fazer o Parse com cultura invariável para evitar problemas de formatação regional
                // (embora os exemplos não usem separador decimal, é uma boa prática)
                double preco = double.Parse(partes[i + 1].Trim(), System.Globalization.CultureInfo.InvariantCulture);
                int quantidadeEmEstoque = int.Parse(partes[i + 2].Trim());

                // TODO: Adicione o produto na lista
                Produto novoProduto = new Produto(nome, preco, quantidadeEmEstoque);
                listaDeProdutos.Add(novoProduto);
            }

            // TODO: Crie a lista para armazenar os produtos com mais de 50 unidades em estoque
            // TODO: Filtre os produtos com mais de 50 unidades em estoque

            // Usando LINQ para filtrar e selecionar os nomes em uma única etapa
            IEnumerable<string> produtosEmPromocao = listaDeProdutos
                // Filtra produtos onde o estoque é maior que 50
                .Where(p => p.QuantidadeEmEstoque > 50)
                // Seleciona apenas o nome do produto filtrado
                .Select(p => p.Nome);

            // O resultado 'produtosEmPromocao' já é um IEnumerable<string> (uma coleção de nomes)

            // Exibe os nomes dos produtos com mais de 50 unidades em estoque
            // O método string.Join formata a saída como "Nome1, Nome2, Nome3"
            Console.WriteLine(string.Join(", ", produtosEmPromocao));

            // Classe Produto para armazenar as informações de cada produto
            public class Produto
            {
                public string Nome { get; }
                public double Preco { get; }
                public int QuantidadeEmEstoque { get; }

                // Construtor da classe Produto
                public Produto(string nome, double preco, int quantidadeEmEstoque)
                {
                    Nome = nome;
                    Preco = preco;
                    QuantidadeEmEstoque = quantidadeEmEstoque;
                }
            }
    }
 
    
    
}

/*
 * 
 * 
 * 
 * 
 * 
 * 
 */
