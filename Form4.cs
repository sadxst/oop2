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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string st = txt.Text;
            string[] words = st.Split(' ');
            string res = "";

            for (int i = 0; i < words.Length; i++)
            {
                if ((i + 1) % 2 == 0)
                    res += words[i] + "! ";
                else
                    res += words[i] + "? ";
            }
            rs.Text = "Результат: " + res;  
        }
    }
}
