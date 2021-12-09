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
            int[,] a = new int[9, 9]; // Инициализируем массив
            int i, j;
            // Заполняем матрицу случайными числами
            Random rand = new Random();
            for (i = 0; i < 9; i++)
                for (j = 0; j < 9; j++)
                    a[i, j] = rand.Next(-100, 100);
            // Выводим матрицу в dataGridView1
            for (i = 0; i < 9; i++)
                for (j = 0; j < 9; j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
            // Поиск максимального элемента
            // на дополнительной диагонали
            int m = int.MaxValue;
            for (i = 0; i < 9; i++)
            {
                if (a[i, 8 - i] > m) m = a[i, 8 - i];
            }
            // выводим результат
            textBox1.Text = Convert.ToString(m);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
