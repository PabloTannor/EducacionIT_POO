using Clase1;

namespace Banco
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CuentaBancaria cuenta = new CuentaBancaria(textBox1.Text,textBox2.Text,textBox3.Text,double.Parse(comboBox1.Text),"peso argentino","5478-4578-4578-1245");

            MessageBox.Show(cuenta.MostrarDatos());

        }
    }
}
