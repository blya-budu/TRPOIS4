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
            dataGridView1.RowTemplate.Height = 22;
            dataGridView1.AllowUserToAddRows = false;
        }

        private void numericColumns_ValueChanged(object sender, EventArgs e)
        {
            int newColumnCount = (int)numericColumns.Value+2;

            while (dataGridView1.Columns.Count > newColumnCount)
            {
                dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count -1 );
            }


            while (dataGridView1.Columns.Count < newColumnCount)
            {
                int colIndex = dataGridView1.Columns.Count -2; // 3
                dataGridView1.Columns.Add("Column" + colIndex, "X" + (colIndex + 1));
            }
            // для функции 
            while (dataGridView2.Columns.Count > newColumnCount-2)
            {
                dataGridView2.Columns.RemoveAt(dataGridView1.Columns.Count -2);
            }


            while (dataGridView2.Columns.Count < newColumnCount-2)
            {
                int colIndex = dataGridView2.Columns.Count;
                dataGridView2.Columns.Add("Column" + colIndex, "X" + (colIndex + 1));
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            int maxRows = 10;

            if (dataGridView1.Rows.Count > maxRows)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 1);
            }
        }
    }
}
