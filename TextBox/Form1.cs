    using System.Security.Cryptography.X509Certificates;
    using System.Windows.Forms;

    namespace TextBox
    {
        public partial class Formularz : Form
        {
            public Formularz()
            {
                InitializeComponent();

            

            }

        
        
            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void richTextBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void label3_Click(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
            Application.Exit();
            }

            private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {

            }

            private void textBox1_TextChanged_1(object sender, EventArgs e)
            {
                

            }

            private void button1_Click(object sender, EventArgs e)
            {
                DateTime dt = dateTimePicker1.Value;

         

          
                if (textBox1.Text.Length == 0    || textBox2.Text.Length == 0)
                {

                    MessageBox.Show ("Nie wpisano wszystkich danych");
                }
            
                else
                {
                MessageBox.Show("Podano imiê:" + textBox1.ToString() + "nazwisko: " + textBox2.ToString() + ("rok urodzenia") + dt.ToString());


            }
            }
        }
    }