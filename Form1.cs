namespace ООП_ЛР1_вар3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form2 f2 = new Form2();
            Form3 f3 = new Form3();
            Form4 f4 = new Form4();

            f2.Show();
            f3.Show();
            f4.Show();
        }

        private void s_TextChanged(object sender, EventArgs e)
        {
            int count = 0;
            foreach (char c in s.Text)
            {
                if (char.IsDigit(c)) count++;
            }
            label1.Text = "Кількість цифр: " + count;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
