using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.DealGroupAICentric
{
    public class ImplementandoSistemaMensagensParaReservas
    {
        public void Executar()
        {
 
 
        // Lê a entrada como uma string no formato: Nome, Número do Quarto, Número de Diárias
        string input = Console.ReadLine();

        // Divide a string pelos separadores de vírgula
        string[] parts = input.Split(',');

        // Extrai e trata os dados de entrada
        string guestName = parts[0].Trim();            // Nome do hóspede
        int roomNumber = int.Parse(parts[1].Trim());   // Número do quarto
        int days = int.Parse(parts[2].Trim());         // Quantidade de diárias

        // Calcula o valor total da estadia (R$150 por diária)
        int totalValue = days * 150;

        // Exibe a mensagem formatada conforme solicitado
        Console.WriteLine($"{guestName} vai se hospedar no quarto {roomNumber} por R${totalValue}");
 

        }
    }
}

/*
 * 
 * Desafio
Você foi contratado para integrar uma nova funcionalidade ao sistema interno de reservas de um cliente. Esse sistema precisa registrar informações básicas sobre hospedagens e retornar um resumo simples da reserva feita.

Seu papel é implementar uma função que será utilizada por outros módulos do sistema para registrar uma nova hospedagem.

Entrada
A entrada será composta pelo nome do hóspede, número do quarto reservado e quantidade de diárias contratadas.

Saída
O programa deverá retornar uma string no seguinte formato: <nome> ficará no quarto <quarto> por R$<valor_total>

O <valor_total> deve ser calculado multiplicando o número de diárias por R$150.

Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Aline, 101, 3	Aline vai se hospedar no quarto 101 por R$450
Marina, 102, 1	Marina vai se hospedar no quarto 102 por R$150
Carlos, 203, 2	Carlos vai se hospedar no quarto 203 por R$300
Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.


 * 
 * 
 */