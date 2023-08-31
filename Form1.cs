namespace Calculadora2
{
    public enum operacion
    {
        nodefinida = 0,
        suma = 1,
        resta = 2,
        division = 3,
        multiplicacion = 4,
        modulo = 5
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        operacion operador = operacion.nodefinida;
        public Form1()
        {
            InitializeComponent();
        }
        private void LeerNumero(string numero)
        {
            if (cajaResultado.Text == "0" && cajaResultado.Text != null)
            {
                cajaResultado.Text = numero;
            }
            else
            {
                cajaResultado.Text += numero;
            }
        }
        private double EjecutarOperacion()
        {
            double resultado = 0;
            switch (operador)
            {
                case operacion.suma:
                    resultado = valor1 + valor2;
                    break;
                case operacion.resta:
                    resultado = valor1 - valor2;
                    break;
                case operacion.division:
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede dividir entre 0");
                        resultado = 0;
                    }
                    else
                    {
                        resultado = valor1 / valor2;
                    }
                    break;
                case operacion.multiplicacion:
                    resultado = valor1 * valor2;
                    break;
                case operacion.modulo:
                    resultado = valor1 % valor2;
                    break;
            }
            return resultado;
        }
        private void btncero_Click(object sender, EventArgs e)
        {
            if (cajaResultado.Text == "0")
            {
                return;
            }
            else
            {
                cajaResultado.Text += "0";
            }

        }

        private void btnuno_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void btndos_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btntres_Click(object sender, EventArgs e)
        {
            LeerNumero("3");

        }

        private void btncuatro_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btncinco_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnseis_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnsiete_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnocho_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnnueve_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }
        private void obtenervalor(string operador)
        {
            valor1 = Convert.ToDouble(cajaResultado.Text);
            lblHistorial.Text = cajaResultado + operador;
            cajaResultado.Text = "0";
        }
        private void btnsuma_Click(object sender, EventArgs e)
        {
            operador = operacion.suma;
            obtenervalor("+");
        }

        private void btnresultado_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(cajaResultado.Text);
                lblHistorial.Text += valor2 + "=";
                double resultado = EjecutarOperacion();
                valor1 = 0;
                valor2 = 0;
                cajaResultado.Text = Convert.ToString(resultado);
            }
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            operador = operacion.resta;
            obtenervalor("-");
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            operador = operacion.multiplicacion;
            obtenervalor("x");
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = operacion.division;
            obtenervalor("/");
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            operador = operacion.modulo;
            obtenervalor("%");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cajaResultado.Text = "0";
            lblHistorial.Text = "";
        }

        private void cajaResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}