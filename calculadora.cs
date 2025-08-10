namespace Calculadora_4_operaciones
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out double num1, out double num2))
            {
                labeltotal.Text = $"Resultado: {num1 + num2}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        private bool ValidarEntrada(out double num1, out double num2)
        {
            num2 = 0;
            if (!double.TryParse(textBox1.Text, out num1) || !double.TryParse(textBox2.Text, out num2))
            {
                MessageBox.Show("Por favor, ingresa solo números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        // PERMITIR SOLO NÚMEROS
        private void txt_num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out double num1, out double num2))
            {
                if (num2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                labeltotal.Text = $"Resultado: {num1 / num2}";
            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out double num1, out double num2))
            {
                labeltotal.Text = $"Resultado: {num1 - num2}";
            }
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            if (ValidarEntrada(out double num1, out double num2))
            {
                labeltotal.Text = $"Resultado: {num1 * num2}";
            }
        }
    }
}
     