﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.AvanadeBackendNETIA
{
    public class SistemaAgendamentoConsultores
    {
        public void Executar()
        {
              
        }
    }
}


/*
 * 
 * 
 * Descrição
Uma consultoria de tecnologia precisa organizar os agendamentos realizados por seus consultores. Cada agendamento inclui o nome do cliente, a data e a descrição do serviço. Sua tarefa é desenvolver uma aplicação simples que modele essas informações de forma estruturada.

O foco deste desafio é aplicar os conceitos de Programação Orientada a Objetos (POO), utilizando classes, propriedades e métodos para representar o problema de maneira modular e organizada.

Entrada
A entrada deve conter os seguintes dados:

Nome do consultor
Para cada agendamento:
Nome do cliente
Data do agendamento (formato: dd/MM/yyyy)
Descrição do serviço
Saída
O programa deve exibir os dados organizados:

Nome do consultor
Lista de agendamentos em ordem cronológica (data crescente)
Se não houver agendamentos, exibir mensagem apropriada
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Consultor: Ana
Agendamentos:
Joao, 05/09/2025, Revisao de sistema	
Ana:
05/09/2025 - Joao: Revisao de sistema

Consultor: Fernando
Agendamentos:
Paulo, 02/09/2025, Treinamento	
Fernando:
02/09/2025 - Paulo: Treinamento

Consultor: Carlos
Agendamentos:	Carlos:
Nenhum agendamento cadastrado
Consultor: Brena
Agendamentos:
Joana, 01/09/2025, Mentoria	
Brena:
01/09/2025 - Joana: Mentoria

Atenção: É extremamente importante que as entradas e saídas sejam exatamente iguais às descritas na descrição do desafio de código.
 * 
 * 
 * 
 */