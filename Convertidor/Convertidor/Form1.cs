namespace Convertidor
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String var1 = Moneda.GetItemText(Moneda.SelectedItem);
            String var2 = txtBox1.Text;


            Form2 form = new Form2();
            if (var2.All(Char.IsDigit))
            {
                form.Show();
                form.Local = var1;
                form.A = var2;

            }
            else
            {
                MessageBox.Show("Ingresa datos correctos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}