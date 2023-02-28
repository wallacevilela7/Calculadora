using System.Globalization;

namespace Banco {
    public partial class Form1 : Form {

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";
        public Form1() {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void button7_Click(object sender, EventArgs e) {
            if (txtResultado.Text != "") {

                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Subtracao";
                lblOperacao.Text = "-";
            }
            else {
                MessageBox.Show("Informe um valor");
            }
        }

        private void button5_Click(object sender, EventArgs e) {
            txtResultado.Text = "";
        }

        private void button18_Click(object sender, EventArgs e) {
            txtResultado.Text += ".";
        }

        private void button20_Click(object sender, EventArgs e) {
            txtResultado.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e) {
            if (txtResultado.Text != "") {

                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Soma";
                lblOperacao.Text = "+";
            }
            else {
                MessageBox.Show("Informe um valor");
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            txtResultado.Text += "7";
        }

        private void button2_Click(object sender, EventArgs e) {
            txtResultado.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e) {
            txtResultado.Text += "1";
        }

        private void button14_Click(object sender, EventArgs e) {
            txtResultado.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e) {
            txtResultado.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e) {
            txtResultado.Text += "4";
        }

        private void button9_Click(object sender, EventArgs e) {
            txtResultado.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e) {
            txtResultado.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e) {
            lblOperacao.Text = "";
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "Soma") {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "Subtracao") {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "Multiplicacao") {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }


        }

        private void button12_Click(object sender, EventArgs e) {
            if (txtResultado.Text != "") {

                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Multiplicacao";
                lblOperacao.Text = "X";
            }
            else {
                MessageBox.Show("Informe um valor");
            }
        }

        private void button17_Click(object sender, EventArgs e) {
            if (txtResultado.Text != "") {

                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "Divisao";
                lblOperacao.Text = "/";
            }
            else {
                MessageBox.Show("Informe um valor");
            }
        }

        private void button6_Click(object sender, EventArgs e) {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button3_Click(object sender, EventArgs e) {
            txtResultado.Text += "9";
        }
    }
}