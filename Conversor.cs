namespace Conversor_Celsius___Fahrenheit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBox1, "");
            if (!double.TryParse(textBox1.Text, out double temperatura))
            {
                errorProvider1.SetError(textBox1, "Ingrese un número válido.");
                return;
            }

            // Se valida el combobox
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de conversión.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double resultado = 0;

            if (comboBox1.SelectedItem.ToString() != "Celsius a Fahrenheit")
            {
                resultado = (temperatura * 9 / 5) + 32;
            }
            else if (comboBox1.SelectedItem.ToString() == "Fahrenheit a Celsius")
            {
                resultado = (temperatura - 32) * 5 / 9;
            }

            MessageBox.Show($"Resultado: {resultado:F2}", "Conversión completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
    
