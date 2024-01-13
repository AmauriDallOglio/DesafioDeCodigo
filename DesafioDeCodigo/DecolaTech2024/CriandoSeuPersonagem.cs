namespace DesafioDeCodigo.DecolaTech2024
{
    public class CriandoSeuPersonagem
    {
        public void Eexcutar()
        {
            string nome = string.Empty;
            string raca = string.Empty;
            string classe  = string.Empty;

            Console.WriteLine($"Digite o nome!");
            nome = Console.ReadLine();
            Console.WriteLine($"Digite a raça!");
            raca = Console.ReadLine();
            Console.WriteLine($"Digite a classe");
            classe = Console.ReadLine();

            Personagem p1 = new Personagem(nome, raca, classe);
            Console.WriteLine("Status:");
            p1.ExibirStatus();
        }

        class Personagem
        {
            public string Nome { get; set; } = String.Empty;
            public string Raca { get; set; } = String.Empty;
            public string Classe { get; set; } = String.Empty;
            public int Nivel { get; set; } = 1;
            public int Vida { get; set; } = 10;

            public Personagem(string nome, string raca, string classe)
            {
                Nome = nome;
                Raca = raca;
                Classe = classe;
            }

            public void ExibirStatus()
            {
                Console.WriteLine("Nome:" + Nome);
                Console.WriteLine("Raça:" + Raca);
                Console.WriteLine("Classe:" + Classe);
                Console.WriteLine("Nível:" + Nivel);
                Console.WriteLine("Vida:" + Vida);
            }
        }

    }
}
