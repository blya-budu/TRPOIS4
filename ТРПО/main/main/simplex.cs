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
            int newColumnCount = (int)numericColumns.Value + 2;

            while (dataGridView1.Columns.Count > newColumnCount)
            {
                dataGridView1.Columns.RemoveAt(dataGridView1.Columns.Count - 1);
            }


            while (dataGridView1.Columns.Count < newColumnCount)
            {
                int colIndex = dataGridView1.Columns.Count - 2; // 3
                dataGridView1.Columns.Add("Column" + colIndex, "X" + (colIndex + 1));
            }
            // для функции 
            while (dataGridView2.Columns.Count > newColumnCount - 2)
            {
                dataGridView2.Columns.RemoveAt(dataGridView1.Columns.Count - 2);
            }


            while (dataGridView2.Columns.Count < newColumnCount - 2)
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

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            //проверка данных
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                for (i = 2; i < row.Cells.Count; i++)
                {
                    DataGridViewCell cell = row.Cells[i];

                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        MessageBox.Show($"Есть пустые ячейки в столбце {i + 1}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!int.TryParse(cell.Value.ToString(), out _))
                    {
                        MessageBox.Show($"Найдены нечисловые значения в столбце {i + 1}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            //столбец с полем "Значение"
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewCell cell = row.Cells[0];

                if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    MessageBox.Show("Есть пустые ячейки в первом столбце!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(cell.Value.ToString(), out _))
                {
                    MessageBox.Show("Найдены нечисловые значения в первом столбце!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            // и таблицу F(x)
            DataGridViewRow firstRow = dataGridView2.Rows[0];

            foreach (DataGridViewCell cell in firstRow.Cells)
            {
                if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                {
                    MessageBox.Show($"Есть пустые ячейки в столбце !", "Ошибка");
                    return;
                }

                if (!int.TryParse(cell.Value.ToString(), out _))
                {
                    MessageBox.Show($"Найдены нечисловые значения в столбце !", "Ошибка");
                    return;
                }
            }

            // берем данные из столбца value
            int rowCountValue = dataGridView1.Rows.Count;
            int[] columnValues = new int[rowCountValue]; // одномерный массив 1-ого столбца
            i = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                columnValues[i] = Convert.ToInt32(row.Cells["Column1"].Value);
                i++;
            }

            // берем данные с x1, x2 ....
            int rowCount = dataGridView1.RowCount;
            int columnCount = dataGridView1.Columns.Count -2 ;
            int[,] matrix = new int[rowCount, columnCount];

            for (i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++) // начало с 3 столюца
                {
                    matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j+2].Value);
                }
            }

            // берем данные из f(x)
            int rowIndex = 0;  
            int columnCountF = dataGridView2.Columns.Count;
            int[] rowValues = new int[columnCountF];
            for (i = 0; i < columnCountF; i++)
            {
                rowValues[i] = Convert.ToInt32(dataGridView2.Rows[rowIndex].Cells[i].Value);
            }

            
            // для случая когда <=
            if (CheckAllCheckBoxesFalse())
            {
                // объеденим все массивы в одну матрицу
                int n = matrix.GetLength(1);  
                int m = matrix.GetLength(0);    

                double[,] tableau = new double[m + 1, n + m + 1]; 

                
                for (i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        tableau[i, j] = matrix[i, j]; 
                    }

                    tableau[i, n + i] = 1; 
                    tableau[i, n + m] = columnValues[i]; 
                }

               
                for (int j = 0; j < n; j++)
                {
                    tableau[m, j] = -rowValues[j]; 
                }
                PerformSimplex(tableau);


                double resFunc = tableau[m, n+m];
                string resVar = "";
                int newRowCount = (int)numericRows.Value;

                for (i = 0; i < tableau.GetLength(0) - newRowCount + 1; ++i) 
                {
                    resVar += tableau[i, tableau.GetLength(1) -1].ToString() + ", ";
                }
                string resultTable = GetTableString(tableau);

                MessageBox.Show($"Переменные: {resVar} Значение функции: {resFunc} \n{resultTable}");
            }
        }
        //функция для проверки <= >= во 2 столбце
        private bool CheckAllCheckBoxesFalse()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value != null && (bool)row.Cells[1].Value == true)
                {
                    return false; 
                }
            }
            return true; 
        }

        private void dataGridView2_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            {
                e.NewValue = e.OldValue; 
            }
        }

        // для решения задачи с <= (max)
        void PerformSimplex(double[,] tableau)
        {
            int rows = tableau.GetLength(0);
            int cols = tableau.GetLength(1);

            while (true)
            {
                // 1. Поиск ведущего столбца
                int pivotCol = -1; // это ведующий столбец
                double minValue = 0;

                for (int j = 0; j < cols - 1; j++)
                {
                    if (tableau[rows - 1, j] < minValue)
                    {
                        minValue = tableau[rows - 1, j];
                        pivotCol = j;
                    }
                }

                if (pivotCol == -1) break; // Оптимум найден

                // 2. Поиск ведущей строки
                double minRatio = double.PositiveInfinity; 
                int pivotRow = -1; // ведующая строка

                for (int i = 0; i < rows - 1; i++)
                {
                    if (tableau[i, pivotCol] > 0)
                    {
                        double ratio = tableau[i, cols - 1] / tableau[i, pivotCol];
                        if (ratio < minRatio)
                        {
                            minRatio = ratio;
                            pivotRow = i;
                        }
                    }
                }

                if (pivotRow == -1)
                {
                    MessageBox.Show("Решение не ограничено!", "Ошибка");
                    return;
                }

                // 3. Преобразование таблицы
                double pivot = tableau[pivotRow, pivotCol]; // ведующая ячейка 

                for (int j = 0; j < cols; j++)
                    tableau[pivotRow, j] /= pivot; 

                for (int i = 0; i < rows; i++)
                {
                    if (i == pivotRow) continue;

                    double factor = tableau[i, pivotCol];
                    for (int j = 0; j < cols; j++)
                    {
                        tableau[i, j] -= factor * tableau[pivotRow, j];
                    }
                }
            }
        }


        string GetTableString(double[,] tableau)
        {
            int rows = tableau.GetLength(0);
            int cols = tableau.GetLength(1);
            var sb = new StringBuilder();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(tableau[i, j].ToString("0.##").PadLeft(8)); 
                }
                sb.AppendLine(); 
            }

            return sb.ToString();
        }

    }
}
