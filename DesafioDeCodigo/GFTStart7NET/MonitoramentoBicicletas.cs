using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.GFTStart7NET
{
    public class MonitoramentoBicicletas
    {
        // Define a cultura para garantir consistência na formatação (boa prática)
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        // Leitura do modelo
        string modelo = Console.ReadLine();

        // Leitura do nível de bateria
        string nivelStr = Console.ReadLine();
        int nivelBateria = int.Parse(nivelStr);

        // Criação do objeto BicicletaInterna
        // O construtor é chamado aqui, inicializando o objeto.
        BicicletaInterna bicicleta = new BicicletaInterna(modelo, nivelBateria);

        // Exibição da mensagem
        Console.WriteLine(bicicleta.ObterMensagem());
    }

    // Classe interna para representar a bicicleta
    class BicicletaInterna
    {
        private string modelo;
        private int nivelBateria;

        // TODO: Crie o construtor da classe BicicletaInterna que inicializa os atributos com os valores recebidos.
        public BicicletaInterna(string modelo, int nivelBateria)
        {
            this.modelo = modelo;
            this.nivelBateria = nivelBateria;
        }

        // TODO: Implemente o método que calcula a distância estimada com base no nível da bateria.
        public double CalcularDistancia()
        {
            // Regra de negócio: Cada 1% de bateria permite percorrer 0,5 km.
            const double KM_POR_PERCENTUAL = 0.5;

            // Distância = Nível da Bateria (em %) * Quilômetros por percentual
            double distanciaEstimada = nivelBateria * KM_POR_PERCENTUAL;

            return distanciaEstimada;
        }

        public string ObterMensagem()
        {
            // Utiliza o formatador "F1" para garantir uma casa decimal.
            return $"{modelo}: Distancia estimada = {CalcularDistancia():F1} km";
        }
    }
}


/*
 * 
 * 
 * Descrição
Um sistema de monitoramento de bicicletas compartilhadas precisa calcular a distância máxima que cada bicicleta pode percorrer, com base no nível atual de bateria. Cada 1% de bateria permite percorrer 0,5 km. Neste desafio, você deve utilizar os conceitos de Programação Orientada a Objetos (POO) para modelar a bicicleta. Crie uma classe que contenha os atributos necessários e um método para calcular a distância estimada.

Entrada
A entrada deve conter:

O nome do modelo da bicicleta (String).
O nível de bateria (int).
Saída
Deverá retornar uma mensagem com o modelo da bicicleta e a distância máxima estimada, formatada com uma casa decimal.

Retorno em formato de mensagem.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
BikeX
80	BikeX: Distancia estimada = 40.0 km
UrbanRide
50	UrbanRide: Distancia estimada = 25.0 km
EcoBike
30	EcoBike: Distancia estimada = 15.0 km
 * 
 * 
 * 
 */