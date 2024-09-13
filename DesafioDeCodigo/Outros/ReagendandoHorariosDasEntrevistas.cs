using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.Outros
{
    public class ReagendandoHorariosDasEntrevistas
    {
        public void Executar()
        {
            // Leitura da entrada do usuário
            List<string> entradas = new List<string>();
            string entrada;

            // Loop para ler múltiplas linhas de entrada até que uma linha vazia seja detectada
            while (!string.IsNullOrEmpty(entrada = Console.ReadLine()))
            {
                entradas.Add(entrada);
            }

            // Conversão da entrada em uma lista de tuplas (nome do candidato, horário de início, horário de fim)
            List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)> listaCandidatos = entradas.Select(entradaAtual =>
            {
                var partes = entradaAtual.Split(',');
                var nomeCandidato = partes[0];
                var intervaloHorarios = partes[1].Trim().Split('-');
                var horarioInicio = TimeSpan.Parse(intervaloHorarios[0]);
                var horarioFim = TimeSpan.Parse(intervaloHorarios[1]);
                return (nomeCandidato, horarioInicio, horarioFim);
            }).ToList();

            // Otimização dos horários das entrevistas
            var agendaAjustada = ReagendarHorarios(listaCandidatos);

            // Formatação da saída
            foreach (var candidato in agendaAjustada)
            {
                // Imprime o nome do candidato e o intervalo de horário formatado
                Console.WriteLine($"{candidato.nomeCandidato}, {candidato.horarioInicio:hh\\:mm}-{candidato.horarioFim:hh\\:mm}");
            }
        }

        // Método que ajusta os horários das entrevistas para evitar sobreposição
        static List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)> ReagendarHorarios(List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)> listaCandidatos)
        {
            // Ordena os candidatos por horário de início
            listaCandidatos = listaCandidatos.OrderBy(c => c.horarioInicio).ToList();

            List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)> agendaAjustada = new List<(string nomeCandidato, TimeSpan horarioInicio, TimeSpan horarioFim)>();
            TimeSpan horarioAtual = TimeSpan.Zero;

            foreach (var candidato in listaCandidatos)
            {
                // Se o horário de início do candidato for após o horário atual
                if (candidato.horarioInicio >= horarioAtual)
                {
                    // Adiciona o candidato à agenda ajustada
                    agendaAjustada.Add(candidato);
                    horarioAtual = candidato.horarioFim; // Atualiza o horário atual para o fim do horário do candidato
                }
                else
                {
                    // Ajusta o horário de início para o horário atual
                    var novoHorarioInicio = horarioAtual;
                    var duracaoOriginal = candidato.horarioFim - candidato.horarioInicio;
                    var novoHorarioFim = novoHorarioInicio + duracaoOriginal;

                    // Adiciona o candidato à agenda ajustada com os novos horários
                    agendaAjustada.Add((candidato.nomeCandidato, novoHorarioInicio, novoHorarioFim));
                    horarioAtual = novoHorarioFim; // Atualiza o horário atual para o novo fim do horário do candidato
                }
            }

            return agendaAjustada;
        }
    }
}


/*
 * Descrição
Você é responsável por organizar a agenda de entrevistas de candidatos para evitar conflitos de horários. Cada candidato tem um horário agendado, e você deve reorganizar as entrevistas de forma que nenhum horário se sobreponha, garantindo que todos os candidatos sejam entrevistados. A saída deve mostrar o nome do candidato junto com o horário ajustado da entrevista.

Entrada
A entrada é uma string onde cada linha representa uma lista de candidatos com seus nomes e horários agendados.

Saída
Uma lista com os horários das entrevistas organizados, de modo que não haja conflitos de horários, respeitando a ordem cronológica.
Se necessário, ajuste os horários de início das entrevistas para garantir que todos os candidatos possam ser entrevistados sem sobreposição.
Cada entrada na lista de saída deve mostrar o nome do candidato e o horário ajustado.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Tiago, 09:00-10:00
Ricardo, 09:30-10:30	Tiago, 09:00-10:00
Ricardo, 10:00-11:00
Ana, 09:00-10:00
Maria, 09:30-10:30
Pedro, 10:00-11:00	Ana, 09:00-10:00
Maria, 10:00-11:00
Pedro, 11:00-12:00
Mario, 12:30-13:30
Marcos, 13:30-14:30
Oliver, 13:00-14:00	Mario, 12:30-13:30
Oliver, 13:30-14:30
Marcos, 14:30-15:30
 * 
 */