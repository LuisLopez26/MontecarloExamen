using MontecarloExamen.Algoritmos;
using MontecarloExamen.Modelos;


namespace MontecarloExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals("") || textBox3.Text.Equals("") ||
                textBox4.Text.Equals("") || textBox5.Text.Equals("") || textBox6.Text.Equals("") || textBox7.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser NO VACÍOS");
                return;

            }

            int a1 = Convert.ToInt32(textBox1.Text);
            int a2 = Convert.ToInt32(textBox2.Text);
            int b1 = Convert.ToInt32(textBox3.Text);
            int b2 = Convert.ToInt32(textBox4.Text);
            int tamano = Convert.ToInt32(textBox5.Text);
            int limInf = Convert.ToInt32(textBox6.Text);
            int limSup = Convert.ToInt32(textBox7.Text);

            if (a1 <= 0 || a2 <= 0 || b1 <= 0 || b2 <= 0 || tamano <= 0)
            {
                MessageBox.Show("Los números deben ser mayor que CERO");
                return;

            }

            if (limSup <= limInf)
            {
                MessageBox.Show("El limite inferior tiene que ser menor que el límite superior");
                return;
            }

            AlgoritmoGenerador algoritmo = new AlgoritmoGenerador();
            List<Experimentos> listaExperimentos = algoritmo.AlgoritmoMonteCarlo(a1, a2, b1, b2, tamano, limInf, limSup);
            double estimacion = algoritmo.EstimacionIntegral(listaExperimentos, limInf, limSup);

            textBox8.Text = estimacion.ToString();

            dataGridView1_CellContentClick(listaExperimentos);
        }

        public void dataGridView1_CellContentClick(List<Experimentos> lista)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";
            string numeroColumna3 = "3";
            string numeroColumna4 = "4";

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor Aleatorio");
            dataGridView1.Columns.Add(numeroColumna3, "Altura generada");
            dataGridView1.Columns.Add(numeroColumna4, "Área generada");

            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = lista[i].Id.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ValorGenerado.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna3) - 1].Value = lista[i].AlturaGenerada.ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna4) - 1].Value = lista[i].AreaGenerada.ToString();

            }
        }

    }
}