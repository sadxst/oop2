using System;
using System.Windows.Forms;

namespace ООП_ПР3
{
    public partial class Form2 : Form
    {
        private TextBox textBox1;
        private Button button1;
        public Form2()
        {
            InitializeComponent();
            SetupForm();
        }
        private void SetupForm()
        {
            this.Width = 600;
            this.Height = 330;
            textBox1 = new TextBox();
            textBox1.Multiline = true;
            textBox1.Width = 550;
            textBox1.Height = 200;
            textBox1.Location = new System.Drawing.Point(20, 20);
            this.Controls.Add(textBox1);

            button1 = new Button();
            button1.Text = "Друк";
            button1.Width = 100;
            button1.Height = 40;
            button1.Location = new System.Drawing.Point(230, 230);
            button1.Click += Button1_Click;
            this.Controls.Add(button1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LegacyPrinter legacyPrinter = new LegacyPrinter();
            IPrinter printer = new PrinterAdapter(legacyPrinter);
            printer.PrintToForm("Привіт з групи ІПЗ24-1!", textBox1);
        }
    }
}