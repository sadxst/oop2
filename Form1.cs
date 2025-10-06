namespace ООП_ЛР3_вар7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Form Form2 = new Form2();
            Form2.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] parts = txtArray.Text.Split(new[] { ' ', '\n', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length != 25)
            {
                MessageBox.Show("Невірно введена кількість чисел, спробуйте знову!");
                return;
            }
            int[,] A = new int[5, 5];
            int index = 0;
            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 5; j++)
                    A[i, j] = int.Parse(parts[index++]);
            int num = int.Parse(txtNum.Text);
            int count = Diagonal(A, num);
            result.Text = ""+count;
        }
        private int Diagonal(int[,] array, int num)
        {
            int count = 0;
            int n = array.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (array[i, j] > num)
                        count++;
                }
            }
            return count;
        }
    }
}