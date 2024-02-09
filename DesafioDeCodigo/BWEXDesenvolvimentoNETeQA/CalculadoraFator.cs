using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDeCodigo.BWEXDesenvolvimentoNETeQA
{
    public class CalculadoraFator
    {
        private Queue<string> _historico;

        public CalculadoraFator()
        {
            _historico = null;
        }

        private void atualizarHistorico(string mensagem)
        {
            if (_historico.Count > 3)
            {
                _historico.Dequeue();
            }

            _historico.Enqueue(mensagem);
        }

        public int somar(int num1, int num2)
        {
            int resultado = num1 + num2;

            atualizarHistorico($"Resultado: ${num1} + {num2} = {resultado}");
            return resultado;
        }

        public int subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;

            atualizarHistorico($"Resultado: ${num1} - {num2} = {resultado}");
            return resultado;
        }

        public int multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;

            atualizarHistorico($"Resultado: ${num1} * {num2} = {resultado}");
            return resultado;
        }

        public float dividir(int num1, int num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException();
            }

            float resultado = (float)num1 / num2;

            atualizarHistorico($"Resultado: ${num1} / {num2} = {resultado}");

            return resultado;
        }

        public Queue<string> historico()
        {
            return _historico;
        }
    }
}