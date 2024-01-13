namespace DesafioDeCodigo.DecolaTech2024
{
    public class GerenciamentoDeTarefas
    {
        public void Executar()
        {
            // TODO: Crie as variáveis titulo, descricao e dataVencimento para guardar as informações das tarefas:
            string titulo = "";
            string descricao = "";
            var dataVencimento = "";

            // Obtém o titulo e a descricao a partir da entrada do console  
            Console.WriteLine($"Digite o titulo!");
            titulo = Console.ReadLine();
            Console.WriteLine($"Digite a descrição da tarefa!");
            descricao = Console.ReadLine();

            // TODO: Crie uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres.
            if (descricao.Length < 50)
            {
                // Caso a descricao esteja dentro do limite é solicitado a entrada pelo console:
                dataVencimento = Console.ReadLine();
                // TODO: Imprima a descricao e a data de vencimento como nos exemplos da tabela:  
                Console.WriteLine(descricao + " ate " + dataVencimento);
            }
            else
            {
                Console.WriteLine("Descricao ultrapassa limite de caracteres.");
            }
        }
    }

    /*
     * 
     * Descrição
Agora, focaremos em outro conceito fundamental de programação para desenvolver um algoritmo que possua como objetivo a simulação de um Sistema de Gerenciamento de Tarefas. Dessa forma, crie variáveis como, titulo, descricao e dataVencimento para guardar as informações das tarefas, após isso, implemente uma estrutura condicional 'if/else' para verificar se a descrição da tarefa excede 50 caracteres. Caso a descrição exceda 50 carateres, trataremos essa condição exibindo uma mensagem adequada. Lembrando que as estruturas condicionais são fundamentais para o controle de fluxo dos programas pois realizam verificações precisas com base em condições específicas predefinidas, neste caso, é o limite de 50 caracteres.

Entrada
A entrada será as Strings com o titulo da tarefa, a descrição e a data de vencimento.

Saída
Será exibido a tarefa que foi adicionada com o título, descrição e data de vencimento. Mas caso a descrição tenha mais de 50 caracteres deverá ser informado: 'O Valor da descrica excede a quantidade de caracteres permitido'.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Backup Noturno
Executar backup automatico de servidores as 2h da madrugada	Descricao ultrapassa limite de caracteres.
Monitoramento de Rede
Configurar alertas para trafego em tempo real
18/12	Configurar alertas para trafego em tempo real ate 18/12
Atualizacao de Software
Aplicar patches
22/12	Aplicar patches ate 22/12
     * 
     */
}
