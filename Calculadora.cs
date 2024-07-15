using System;
using System.Windows.Forms;

namespace Calculadora_WindowsForms_c_sharp
{
    public partial class Calculadora : Form
    {
        public double primeiroValorDigitado = 0;
        public double ultimoValorDigitado = 0;
        private string operadorAtual = "";
        public bool operadorSelecionado = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        public void adicionarNumero(string numero)
        {
            if (operadorSelecionado)
            {
                caixaTexto_Display_Calculadora_Resultado.Text = "";
                operadorSelecionado = false;
            }

            caixaTexto_Display_Calculadora_Resultado.Text += numero;
        }

        public void adicionarOperador(string operador)
        {
            if (caixaTexto_Display_Calculadora_Resultado.Text != "")
            {
                ultimoValorDigitado = double.Parse(caixaTexto_Display_Calculadora_Resultado.Text);
                if (operadorAtual != "")
                {
                    primeiroValorDigitado = calcularResultado(primeiroValorDigitado, ultimoValorDigitado, operadorAtual);
                    caixaTexto_Display_Calculadora_Resultado.Text = primeiroValorDigitado.ToString();
                }
                else
                {
                    primeiroValorDigitado = ultimoValorDigitado;
                }
                operadorAtual = operador;
                operadorSelecionado = true;
                caixaTexto_Display_Calculadora_Historico.Text = primeiroValorDigitado + " " + operador;
            }
        }

        public void calcularResultadoFinal()
        {
            if (operadorAtual != "" && caixaTexto_Display_Calculadora_Resultado.Text != "")
            {
                ultimoValorDigitado = double.Parse(caixaTexto_Display_Calculadora_Resultado.Text);
                double resultadoFinal = calcularResultado(primeiroValorDigitado, ultimoValorDigitado, operadorAtual);
                caixaTexto_Display_Calculadora_Resultado.Text = resultadoFinal.ToString();
                caixaTexto_Display_Calculadora_Historico.Text = "";
                operadorAtual = "";
                operadorSelecionado = false;
                primeiroValorDigitado = resultadoFinal;
            }
        }

        private double calcularResultado(double valor1, double valor2, string operador)
        {
            switch (operador)
            {
                case "+":
                    return valor1 + valor2;
                case "-":
                    return valor1 - valor2;
                case "*":
                    return valor1 * valor2;
                case "/":
                    return valor1 / valor2;
                default:
                    throw new InvalidOperationException("Operador desconhecido");
            }
        }

        private void botao_numero_um_Click(object sender, EventArgs e)
        {
            adicionarNumero("1");
        }

        private void botao_numero_dois_Click(object sender, EventArgs e)
        {
            adicionarNumero("2");
        }

        private void botao_numero_tres_Click(object sender, EventArgs e)
        {
            adicionarNumero("3");
        }

        private void botao_numero_quatro_Click(object sender, EventArgs e)
        {
            adicionarNumero("4");
        }

        private void botao_numero_cinco_Click(object sender, EventArgs e)
        {
            adicionarNumero("5");
        }

        private void botao_numero_seis_Click(object sender, EventArgs e)
        {
            adicionarNumero("6");
        }

        private void botao_numero_sete_Click(object sender, EventArgs e)
        {
            adicionarNumero("7");
        }

        private void botao_numero_oito_Click(object sender, EventArgs e)
        {
            adicionarNumero("8");
        }

        private void botao_numero_nove_Click(object sender, EventArgs e)
        {
            adicionarNumero("9");
        }

        private void botao_numero_zero_Click(object sender, EventArgs e)
        {
            if ((caixaTexto_Display_Calculadora_Resultado.Text.Length > 0)
                && (caixaTexto_Display_Calculadora_Resultado.Text != "0"))
            {
                adicionarNumero("0");
            }
        }

        private void botao_apagar_ultimo_Click(object sender, EventArgs e)
        {
            if (caixaTexto_Display_Calculadora_Resultado.Text.Length > 0)
            {
                caixaTexto_Display_Calculadora_Resultado.Text = caixaTexto_Display_Calculadora_Resultado.Text.Substring(0, caixaTexto_Display_Calculadora_Resultado.Text.Length - 1);
            }
        }

        private void botao_operador_adicao_Click(object sender, EventArgs e)
        {
            adicionarOperador("+");
        }

        private void botao_operador_substracao_Click(object sender, EventArgs e)
        {
            adicionarOperador("-");
        }

        private void botao_operador_multiplicacao_Click(object sender, EventArgs e)
        {
            adicionarOperador("*");
        }

        private void botao_operador_divisao_Click(object sender, EventArgs e)
        {
            adicionarOperador("/");
        }

        private void botao_execucao_igual_Click(object sender, EventArgs e)
        {
            calcularResultadoFinal();
        }

        private void button23_Click(object sender, EventArgs e)
        {

        }


        private void button24_Click(object sender, EventArgs e)
        {

        }

    }
}
