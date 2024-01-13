namespace DesafioDeCodigo.DecolaTech2024
{
    public class RegistroDeUsuario
    {
        public void Ecexutar()
        {

            // TODO: Declare as variáveis para guardar as informações de nome, email e senha:
            string registroNome = "";
            string registroEmail = "";
            string registroSenha = "";

            // Obtém o email e nome do usuário a partir da entrada do console
            Console.WriteLine($"Digite o nome!");
            registroNome = Console.ReadLine();
            Console.WriteLine($"Digite o nome do e-mail!");
            registroEmail = Console.ReadLine();



            // TODO: Imprima a mensagem formatada com o nome do usuário e o email de registro:
            Console.WriteLine($"{registroNome}, verifique o email: {registroEmail} para ativar.");
        }
    }


    /*
     * 
     * Descrição
Neste desafio, aplicaremos conceitos essenciais de programação, seu objetivo é desenvolver uma solução simulando o registro de usuário em uma aplicação. Assegure que o código tenha uma sintaxe clara e organizada, com nomenclaturas significativas para variáveis como email, nomeUsuario, senha que será o local de armazenamento das informações de registro. Escolha tipos de dados apropriados, como o String para representar o email, nomeUsuario e senha. Certifique-se de tratar senha como strings para operações específicas.

Entrada
Como entrada receberemos três informações referente ao emailCadastro(String), nomeUsuario(String) e senha(String).

Saída
Construa uma mensagem de saída formatada corretamente, como nessa estrutura: ' registroNome + ", verifique o email: " + registroEmail + " para ativar." '

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
anavaz@email.com
Ana
2323	Ana, verifique o email: anavaz@email.com para ativar.
joaocarlos@email.com
Joao
3232	Joao, verifique o email: joaocarlos@email.com para ativar.
shaula@email.com
Shaula
8989	Shaula, verifique o email: shaula@email.com para ativar.
     * 
     */
}
