using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ООП_ПР1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private string filter(string input)
        {
            string z2 = @"\bгро(ші|шей|шима|шенята)?\b";
            return Regex.Replace(input, z2, "***", RegexOptions.IgnoreCase);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            before.Text = "Початковий: " + textBox1.Text;
            after.Text = "Кінцевий: " + filter(textBox1.Text);
        }
    }
}
