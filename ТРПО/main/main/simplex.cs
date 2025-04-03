using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace main
{
    public partial class simplex : UserControl
    {
        public simplex()
        {
            InitializeComponent();
        }

        private void simplex_Load(object sender, EventArgs e)
        {

        }

        private void numericColumns_ValueChanged(object sender, EventArgs e)
        {
            int newColumnCount = (int)numericColumns.Value;


            while (dataGridView1.Columns.Count > newColumnCount)
            {
                dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            }


            while (dataGridView1.Columns.Count < newColumnCount)
            {
                int colIndex = dataGridView1.Columns.Count;
                dataGridView1.Columns.Add("Column" + colIndex, "Колонка " + (colIndex + 1));
            }
        }

        private void numericRows_ValueChanged(object sender, EventArgs e)
        {
            int newRowCount = (int)numericRows.Value;


            while (dataGridView1.Rows.Count > newRowCount)
            {

                if (!dataGridView1.Rows[dataGridView1.Rows.Count - 1].IsNewRow)
                {
                    dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
                }
                else
                {
                    break;
                }
            }

            while (dataGridView1.Rows.Count < newRowCount)
            {
                dataGridView1.Rows.Add();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = ">=";
            }
            else
            {
                checkBox1.Text = "<=";
            }

        }
    }
}
