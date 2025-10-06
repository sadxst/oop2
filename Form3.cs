using System;
using System.Windows.Forms;
namespace ООП_ПР3
{
    public partial class Form3 : Form
    {
        private TextBox inputTextBox;
        private TextBox resultTextBox;
        private Button upperButton;
        private Button lowerButton;
        private Button starButton;
        private TextContext context;

        public Form3()
        {
            InitializeComponent();
            SetupForm();
            context = new TextContext();
        }

        private void SetupForm()
        {
            this.Width = 360;
            this.Height = 290;
            inputTextBox = new TextBox();
            inputTextBox.Location = new System.Drawing.Point(20, 20);
            inputTextBox.Width = 300;

            this.Controls.Add(inputTextBox);
            resultTextBox = new TextBox();
            resultTextBox.Location = new System.Drawing.Point(20, 60);
            resultTextBox.Width = 300;
            resultTextBox.ReadOnly = true;

            this.Controls.Add(resultTextBox);
            upperButton = new Button();
            upperButton.Text = "Змінити літери на великі";
            upperButton.Width = 300;
            upperButton.Height = 35;
            upperButton.Location = new System.Drawing.Point(20, 100);
            upperButton.Click += UpperButton_Click;

            this.Controls.Add(upperButton);
            lowerButton = new Button();
            lowerButton.Width = 300;
            lowerButton.Height = 35;
            lowerButton.Text = "Змінити літери на маленькі";
            lowerButton.Location = new System.Drawing.Point(20, 145);
            lowerButton.Click += LowerButton_Click;

            this.Controls.Add(lowerButton);
            starButton = new Button();
            starButton.Width = 300;
            starButton.Height = 35;
            starButton.Text = "Зірочки поміж літерами";
            starButton.Location = new System.Drawing.Point(20, 190);
            starButton.Click += StarButton_Click;
            this.Controls.Add(starButton);
        }
        private void UpperButton_Click(object sender, EventArgs e)
        {
            context.SetStrategy(new UpperCaseStrategy());
            resultTextBox.Text = context.ExecuteStrategy(inputTextBox.Text);
        }
        private void LowerButton_Click(object sender, EventArgs e)
        {
            context.SetStrategy(new LowerCaseStrategy());
            resultTextBox.Text = context.ExecuteStrategy(inputTextBox.Text);
        }
        private void StarButton_Click(object sender, EventArgs e)
        {
            context.SetStrategy(new StarStrategy());
            resultTextBox.Text = context.ExecuteStrategy(inputTextBox.Text);
        }
    }
}