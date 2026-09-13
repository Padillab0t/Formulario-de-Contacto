using System.Xml.Linq;

namespace Fornulario_de_contacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validamos el nombre
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Escribe tu nombre compa, porfas",
                    "Validación", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                button1.Focus();
            }
            //Obtenemos el motivo
            string motivo = "";
            if (radioButton1.Checked)
            {
                motivo = "Consulta";
            }
            else if (radioButton2.Checked)
            {
                motivo = "Queja";
            }
            else if (radioButton3.Checked)
            {
                motivo = "Sugerencia";
            }
            //Validamos que se elija la modalidad
            else if (string.IsNullOrWhiteSpace(motivo))
            {
                MessageBox.Show("Selecciona un motivo", "Validación",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            //Validamos que el check muestre respuesta
            List<string> mostrarRespuesta = new List<string>();
            if (radioButton1.Checked)
            {
                mostrarRespuesta.Add("Si");
            }
            else
            {
                mostrarRespuesta.Add("No");
            }
            string Confirmacion =

           "RESUMEN DE PREFERENCIAS\r\n" +
               "-----------------------\r\n" +
               "Nombre: " + textBox1.Text + "\r\n" +
               "Quiere recibir respuesta: " + string.Join(", ", mostrarRespuesta) + "\r\n" +
               "motivo de contacto: " + motivo;
            textBox2.Text = Confirmacion;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Letras chiquitas y mas letras chiquitas");
        }
    }
}
