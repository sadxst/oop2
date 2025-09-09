using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_ЛР1_вар3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string rech = r.Text;
            string sl = w.Text;
            string[] words = rech.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string result = "";
            foreach (string part in words)
            {
                if (part != sl)
                    result += part + " ";
            }
            result1.Text = "Результат: " + result.Trim();
        }
    }
}
