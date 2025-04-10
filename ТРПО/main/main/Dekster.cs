using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class Dekster : UserControl
    {
        public Dekster()
        {
            InitializeComponent();
        }
        string[] alphabet = {
        "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
        "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
        "U", "V", "W", "X", "Y", "Z"
        };
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dataGridView.Rows.Count;
            dataGridView.Columns.Add(alphabet[lastRowIndex % 26], alphabet[lastRowIndex % 26]);
            dataGridViewAnswer.Columns.Add(alphabet[lastRowIndex % 26], alphabet[lastRowIndex % 26]);
            dataGridView.Rows.Add();

            dataGridView.Rows[lastRowIndex].HeaderCell.Value = alphabet[lastRowIndex % 26];
        }

        private void Dekster_Load(object sender, EventArgs e)
        {
            dataGridView.AllowUserToAddRows = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] array = new int[dataGridView.Rows.Count, dataGridView.Rows.Count];


            for (int i = 0; i < dataGridViewAnswer.Columns.Count; i++)
            {
                dataGridViewAnswer.Rows[0].Cells[i].Value = 0;
            }



            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Rows.Count; j++)
                {
                    array[i, j] = Int32.Parse(dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "0");
                }
            }




            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 1; j < dataGridView.Rows.Count; j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value.ToString() != "0")
                    {
                        int temp = Int32.Parse(dataGridViewAnswer.Rows[0].Cells[i].Value?.ToString() ?? "0") + Int32.Parse(dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "0");
                        if (temp < Int32.Parse(dataGridViewAnswer.Rows[0].Cells[j].Value?.ToString() ?? "0") || dataGridViewAnswer.Rows[0].Cells[j].Value.ToString() == "0")
                        {
                            dataGridViewAnswer.Rows[0].Cells[j].Value = temp;
                        }
                    }
                }
            }

            string Start = textBoxStart.Text;
            string Finish = textBoxFinish.Text;
            int count = (char)(Finish[0]) - 65;
            labelWayanswer.Text = Finish;
            while (count != (char)(Start[0]) - 65)
            {
                for (int j = 0; j < dataGridView.Rows.Count; j++)
                {

                    if (dataGridView.Rows[count].Cells[j].Value.ToString() != "0")
                    {
                        int temp = Int32.Parse(dataGridViewAnswer.Rows[0].Cells[count].Value?.ToString() ?? "0") - Int32.Parse(dataGridView.Rows[count].Cells[j].Value?.ToString() ?? "0");
                        if (temp == Int32.Parse(dataGridViewAnswer.Rows[0].Cells[j].Value?.ToString() ?? "0"))
                        {

                            labelWayanswer.Text = (char)(j + 65) + "->" + labelWayanswer.Text;
                            count = j;
                            break;
                        }
                    }
                }
            }













        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dataGridView.Rows.Count - 1;
            if (lastRowIndex >= 0)
            {
                dataGridView.Rows.RemoveAt(lastRowIndex);
                dataGridView.Columns.RemoveAt(lastRowIndex);
                dataGridViewAnswer.Columns.RemoveAt(lastRowIndex);
                
            }
        }
    }
}
