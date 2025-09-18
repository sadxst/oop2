namespace ООП_ЛР2_вар7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] A = textBox1.Text
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (A.Length != 20)
                {
                    MessageBox.Show("Введіть 20 чисел через пробіл.");
                    return;
                }
                int sum = 0;
                foreach (int x in A)
                {
                    if (x > 0)
                        sum += x;
                }
                suma.Text = "Сума додатніх елементів: " + sum;
            }
            catch
            {
                MessageBox.Show("Помилка!");
            }
        }
    }
}