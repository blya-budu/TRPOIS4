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
            button_clear = new Button();
            checkBox1 = new CheckBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericRows).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 28);
            label1.Name = "label1";
            label1.Size = new Size(183, 20);
            label1.TabIndex = 0;
            label1.Text = "Количество переменных";
            // 
            // numericColumns
            // 
            numericColumns.Location = new Point(210, 25);
            numericColumns.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
            numericColumns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericColumns.Name = "numericColumns";
            numericColumns.Size = new Size(74, 27);
            numericColumns.TabIndex = 1;
            numericColumns.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericColumns.ValueChanged += numericColumns_ValueChanged;
            // 
            // numericRows
            // 
            numericRows.Location = new Point(210, 75);
            numericRows.Maximum = new decimal(new int[] { 11, 0, 0, 0 });
            numericRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericRows.Name = "numericRows";
            numericRows.Size = new Size(74, 27);
            numericRows.TabIndex = 3;
            numericRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericRows.ValueChanged += numericRows_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 75);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 2;
            label2.Text = "Количество ограничений";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dataGridView1.Location = new Point(21, 127);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(854, 361);
            dataGridView1.TabIndex = 5;
            // 
            // button_clear
            // 
            button_clear.Location = new Point(526, 75);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(94, 29);
            button_clear.TabIndex = 6;
            button_clear.Text = "очистить";
            button_clear.UseVisualStyleBackColor = true;
            button_clear.Click += button_clear_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Popup;
            checkBox1.Location = new Point(881, 127);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(48, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "<=";
            checkBox1.TextAlign = ContentAlignment.TopCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Column2";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.FlatStyle = FlatStyle.Popup;
            checkBox2.Location = new Point(881, 157);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(48, 24);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "<=";
            checkBox2.TextAlign = ContentAlignment.TopCenter;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.FlatStyle = FlatStyle.Popup;
            checkBox3.Location = new Point(881, 217);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(48, 24);
            checkBox3.TabIndex = 10;
            checkBox3.Text = "<=";
            checkBox3.TextAlign = ContentAlignment.TopCenter;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.FlatStyle = FlatStyle.Popup;
            checkBox4.Location = new Point(881, 187);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(48, 24);
            checkBox4.TabIndex = 9;
            checkBox4.Text = "<=";
            checkBox4.TextAlign = ContentAlignment.TopCenter;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // simplex
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(checkBox3);
            Controls.Add(checkBox4);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button_clear);
            Controls.Add(dataGridView1);
            Controls.Add(numericRows);
            Controls.Add(label2);
            Controls.Add(numericColumns);
            Controls.Add(label1);
            Name = "simplex";
            Size = new Size(1179, 680);
            Load += simplex_Load;
            ((System.ComponentModel.ISupportInitialize)numericColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericRows).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private CheckBox checkBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
    }
}
