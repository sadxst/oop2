using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ООП_ЛР3_вар7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txtm.Text = "";
            txtn.Text = "";
            result.Text = "";
            dgvMass.Columns.Clear();
            dgvMass.Rows.Clear();
        }

        private void start_Click(object sender, EventArgs e)
        {
            int n, m, nn = 0;
            float summ = 0, sr = 0;
            n = Int32.Parse(txtn.Text);
            m = Int32.Parse(txtm.Text);
            int[,] A = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i <= n - 1; i++)
                for (int j = 0; j <= m - 1; j++)
                    A[i, j] = rand.Next(-50, 50);
            dgvMass.ColumnCount = m;
            dgvMass.RowCount = n;
            for (int i = 0; i <= n - 1; i++)
                for (int j = 0; j <= m - 1; j++)
                    dgvMass.Rows[i].Cells[j].Value = A[i, j].ToString();
            for (int j = 0; j <= m - 1; j++)
                dgvMass.Columns[j].Width = 50;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                    if (A[i, j] > 0)
                    {
                        summ += A[i, j];
                        nn++;
                    }
            }
        sr = summ / nn;
            result.Text = "Середнє арифметичне додатних елементів: " + Math.Round(sr,5).ToString() + 
                          "\nК-ть додатних елементів: " + nn.ToString();
        }
    }
}