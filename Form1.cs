using System;
using System.Text.RegularExpressions;
using ООП_ПР1;

namespace ООП_ПР1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            login.TextChanged += login_TextChanged;
        }
        private bool IsValidLogin(string login)
        {
            string rule = @"^[A-Za-z][A-Za-z0-9]{1,9}$";
            return Regex.IsMatch(login, rule);
        }
        private void login_TextChanged(object sender, EventArgs e)
        {
            if (IsValidLogin(login.Text))
                result.Text = "Результат: коректно";
            else
                result.Text = "Результат: некоректно";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}