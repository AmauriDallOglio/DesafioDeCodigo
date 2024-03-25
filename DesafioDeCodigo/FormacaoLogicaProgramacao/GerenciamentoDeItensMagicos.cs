using DesafioDeCodigo.NETDeveloper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.FormacaoLogicaProgramacao
{
    public class GerenciamentoDeItensMagicos
    {
        public void Executar()
        {
            // Solicita ao usuário para digitar o tipo do item mágico, o dano no item e a resistência do item
            Console.WriteLine("Digite o tipo do item mágico:");
            string tipoItem = Console.ReadLine();
            Console.WriteLine("Digite o dano do item:");
            int danoItem = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a resistência do item:");
            int resistenciaItem = int.Parse(Console.ReadLine());

            // Cria um objeto ItemMagico personalizado com base nas entradas do usuário
            ItemMagico itemPersonalizado = new ItemMagico(tipoItem, danoItem, resistenciaItem);

            // Imprime os atributos do item personalizado
            Console.WriteLine("Tipo: " + itemPersonalizado.Tipo);
            Console.WriteLine("Dano: " + itemPersonalizado.Dano);
            Console.WriteLine("Resistência: " + itemPersonalizado.Resistencia);

            // Calcula e imprime o dano causado pelo item personalizado em um combate simulado
            int danoTotal = itemPersonalizado.CalcularDano();
            Console.WriteLine("Dano em combate: " + danoTotal);
        }

        public class ItemMagico
        {
            public string Tipo { get; private set; }
            public int Dano { get; private set; }
            public int Resistencia { get; private set; }

            // Construtor para inicializar os atributos
            public ItemMagico(string tipo, int dano, int resistencia)
            {
                Tipo = tipo;
                Dano = dano;
                Resistencia = resistencia;
            }

            // Método para calcular o dano
            public int CalcularDano()
            {
                return Tipo == "arma" ? Dano * 2 : Dano;
            }
        }
    }
}
