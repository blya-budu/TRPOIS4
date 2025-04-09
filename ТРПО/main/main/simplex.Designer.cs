namespace main
{
    partial class simplex
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            numericColumns = new NumericUpDown();
            numericRows = new NumericUpDown();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            LastColumn = new DataGridViewCheckBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button_clear = new Button();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            radioButtonMax = new RadioButton();
            radioButtonMin = new RadioButton();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 21);
            label1.Name = "label1";
            label1.Size = new Size(145, 15);
            label1.TabIndex = 0;
            label1.Text = "Количество переменных";
            // 
            // numericColumns
            // 
            numericColumns.Location = new Point(184, 19);
            numericColumns.Margin = new Padding(3, 2, 3, 2);
            numericColumns.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
            numericColumns.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericColumns.Name = "numericColumns";
            numericColumns.Size = new Size(65, 23);
            numericColumns.TabIndex = 1;
            numericColumns.Value = new decimal(new int[] { 2, 0, 0, 0 });
            numericColumns.ValueChanged += numericColumns_ValueChanged;
            // 
            // numericRows
            // 
            numericRows.Location = new Point(184, 56);
            numericRows.Margin = new Padding(3, 2, 3, 2);
            numericRows.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
            numericRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRows.Name = "numericRows";
            numericRows.Size = new Size(65, 23);
            numericRows.TabIndex = 3;
            numericRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericRows.ValueChanged += numericRows_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 56);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 2;
            label2.Text = "Количество ограничений";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, LastColumn, Column2, Column3 });
            dataGridView1.Location = new Point(18, 151);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1083, 266);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DefaultValuesNeeded += dataGridView1_DefaultValuesNeeded;
            // 
            // Column1
            // 
            Column1.HeaderText = "Значение";
            Column1.Name = "Column1";
            // 
            // LastColumn
            // 
            LastColumn.HeaderText = "Ограничение (>=) (<=) ";
            LastColumn.Name = "LastColumn";
            // 
            // Column2
            // 
            Column2.HeaderText = "X1";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "X2";
            Column3.Name = "Column3";
            // 
            // button_clear
            // 
            button_clear.Location = new Point(167, 113);
            button_clear.Margin = new Padding(3, 2, 3, 2);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(82, 22);
            button_clear.TabIndex = 6;
            button_clear.Text = "очистить";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 92);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 7;
            label3.Text = "Ограничение <=";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 120);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 8;
            label4.Text = "Ограничение >=";
            // 
            // checkBox1
            // 
            checkBox1.AutoCheck = false;
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(124, 93);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 9;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoCheck = false;
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(124, 121);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 10;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(18, 456);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1083, 49);
            dataGridView2.TabIndex = 11;
            dataGridView2.Scroll += dataGridView2_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(1107, 470);
            label5.Name = "label5";
            label5.Size = new Size(41, 25);
            label5.TabIndex = 12;
            label5.Text = "-->";
            // 
            // radioButtonMax
            // 
            radioButtonMax.AutoSize = true;
            radioButtonMax.Checked = true;
            radioButtonMax.Location = new Point(1154, 461);
            radioButtonMax.Name = "radioButtonMax";
            radioButtonMax.Size = new Size(48, 19);
            radioButtonMax.TabIndex = 13;
            radioButtonMax.TabStop = true;
            radioButtonMax.Text = "Max";
            radioButtonMax.UseVisualStyleBackColor = true;
            // 
            // radioButtonMin
            // 
            radioButtonMin.AutoSize = true;
            radioButtonMin.Location = new Point(1154, 486);
            radioButtonMin.Name = "radioButtonMin";
            radioButtonMin.Size = new Size(46, 19);
            radioButtonMin.TabIndex = 14;
            radioButtonMin.Text = "Min";
            radioButtonMin.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(18, 511);
            button1.Name = "button1";
            button1.Size = new Size(1083, 23);
            button1.TabIndex = 15;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // simplex
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(radioButtonMin);
            Controls.Add(radioButtonMax);
            Controls.Add(label5);
            Controls.Add(dataGridView2);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_clear);
            Controls.Add(dataGridView1);
            Controls.Add(numericRows);
            Controls.Add(label2);
            Controls.Add(numericColumns);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "simplex";
            Size = new Size(1288, 610);
            Load += simplex_Load;
            ((System.ComponentModel.ISupportInitialize)numericColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericColumns;
        private NumericUpDown numericRows;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button_clear;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewCheckBoxColumn LastColumn;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label label5;
        private RadioButton radioButtonMax;
        private RadioButton radioButtonMin;
        private Button button1;
    }
}
