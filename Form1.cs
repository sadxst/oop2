using System;
using System.Windows.Forms;

namespace ООП_ПР3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeButtons();
            Form Form2 = new Form2();
            Form2.Show();
            Form Form3 = new Form3();
            Form3.Show();
        }
        private void InitializeButtons()
        {
            IButtonFactory redFactory = new RedButtonFactory();
            IButtonFactory greenFactory = new GreenButtonFactory();
            IButtonFactory blueFactory = new BlueButtonFactory();
            IButton redButton = redFactory.CreateButton();
            redButton.Render(this, 20, 20);
            IButton greenButton = greenFactory.CreateButton();
            greenButton.Render(this, 120, 20);
            IButton blueButton = blueFactory.CreateButton();
            blueButton.Render(this, 220, 20);
        }
    }
}