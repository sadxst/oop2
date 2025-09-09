using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ООП_ЛР1_вар3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string S1 = s1.Text;
            string S2 = s2.Text;
            int pos = S1.IndexOf(S2);
            if (pos != -1)
            {
                S1 = S1.Remove(pos, S2.Length);
            }
            result.Text = "Результат: " + S1;
        }
    }
}
