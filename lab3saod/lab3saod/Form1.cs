using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3saod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SizeLab_Click(object sender, EventArgs e)
        {
            if (!(StrLabir.Text == "") && !(StolbLab.Text == ""))
            {
                dataGridView1.ColumnCount = int.Parse(StolbLab.Text);
                dataGridView1.RowCount = int.Parse(StrLabir.Text) + 1;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.AllowUserToAddRows = false;

            }
            else
                MessageBox.Show("Введите размеры!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        

        
        static string st;
        void MakeList(int[][] mas, int x, int y, string buf)
        {

            buf += "[" + x.ToString() + "," + y.ToString() + "] => ";
            if (x == int.Parse(EndX.Text) && y == int.Parse(EndX.Text))
            {
                st = buf;

            }


            if (x > 0) if (mas[x - 1][y] == 0) { mas[x][y] += 3; MakeList(mas, x - 1, y, buf); mas[x][y] -= 3; }
            if (x < int.Parse(StrLabir.Text)-1) if (mas[x + 1][y] == 0) { mas[x][y] += 3; MakeList(mas, x + 1, y, buf); mas[x][y] -= 3; }
            if (y > 0) if (mas[x][y - 1] == 0) { mas[x][y] += 3; MakeList(mas, x, y - 1, buf); mas[x][y] -= 3; }
            if (y < int.Parse(StolbLab.Text)-1) if (mas[x][y + 1] == 0) { mas[x][y] += 3; MakeList(mas, x, y + 1, buf); mas[x][y] -= 3; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(BeginX.Text == "") && !(BeginY.Text == "") && !(EndX.Text == "") && !(EndY.Text == ""))
            {
                int[][] mas = new int[int.Parse(StrLabir.Text)][];
                for (int i = 0; i < int.Parse(StrLabir.Text); i++)
                    mas[i] = new int[int.Parse(StolbLab.Text)];

                for (int i = 0; i < int.Parse(StrLabir.Text); i++)
                    for (int j = 0; j < int.Parse(StolbLab.Text); j++)
                        mas[i][j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[i].Value.ToString());

                MakeList(mas, int.Parse(BeginX.Text), int.Parse(BeginY.Text), "");
                Output.Text = st;

            }
            else
                MessageBox.Show("Введите размеры!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
