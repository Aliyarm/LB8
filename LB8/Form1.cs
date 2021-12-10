using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 9; // Кол-во строк
            dataGridView1.ColumnCount = 9; // Кол-во столбцов
            dataGridView2.RowCount = dataGridView1.RowCount;
            dataGridView2.ColumnCount = dataGridView1.ColumnCount;
            int[,] a = new int[9, 9]; // Инициализируем массив
            int i, j;
            // Заполняем матрицу случайными числами и выводим её в dataGridView1
            Random rand = new();
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }
            // Поиск минимального элемента на каждой строке
            int m = int.MinValue;
            textBox1.Text = Convert.ToString(m);
            int n = 0;
            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    if (a[i, j] < m)
                    {
                        a[i, j] = n;
                        m = a[i, j];
                        dataGridView2.Rows[i].Cells[j].Value = a[i, j].ToString();
                    }
                }
            }
        }
    }
}