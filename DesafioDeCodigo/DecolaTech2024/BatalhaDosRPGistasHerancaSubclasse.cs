using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.DecolaTech2024
{
    public class BatalhaDosRPGistasHerancaSubclasse
    {
        public void Executar()
        {
            string nome = string.Empty;
            int mana = 0;
            int danoBase = 0;

            Console.WriteLine($"Digite seu nome!");
            nome = (Console.ReadLine());
            Console.WriteLine($"Digite a quantidade de mana do personagem!");
            mana = int.Parse(Console.ReadLine());
            Console.WriteLine($"Digite referente ao dano base da subclasse!");
            danoBase = int.Parse(Console.ReadLine());

            Subclasse ps1 = new Subclasse(nome, mana, danoBase);
            ps1.CalcularDano();
        }

        class Personagem
        {
            public string Nome { get; set; } = String.Empty;
            public int Mana { get; set; } = 0;

            public Personagem(string nome, int mana)
            {
                Nome = nome;
                Mana = mana;
            }
        }

        class Subclasse : Personagem
        {
            public int DanoBase { get; set; } = 0;

            public Subclasse(string nome, int mana, int danoBase) : base(nome, mana)
            {
                DanoBase = danoBase;
            }

            public void CalcularDano()
            {
                Console.WriteLine(Nome + " atacou e causou " + DanoBase * Mana + " de dano!");
            }
        }

    }
}
