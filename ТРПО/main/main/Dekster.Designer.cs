namespace main
{
    partial class Dekster
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            buttonAdd = new Button();
            dataGridViewAnswer = new DataGridView();
            button1 = new Button();
            textBoxStart = new TextBox();
            textBoxFinish = new TextBox();
            labelStart = new Label();
            labelFinish = new Label();
            labelWayanswer = new Label();
            buttonRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnswer).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(40, 28);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(450, 429);
            dataGridView.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(873, 428);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Прибавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // dataGridViewAnswer
            // 
            dataGridViewAnswer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAnswer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAnswer.Enabled = false;
            dataGridViewAnswer.Location = new Point(40, 481);
            dataGridViewAnswer.Name = "dataGridViewAnswer";
            dataGridViewAnswer.RowHeadersWidth = 51;
            dataGridViewAnswer.Size = new Size(450, 65);
            dataGridViewAnswer.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(840, 463);
            button1.Name = "button1";
            button1.Size = new Size(127, 29);
            button1.TabIndex = 3;
            button1.Text = "ВЫЕБАТЬ СТУЛ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(635, 192);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(125, 27);
            textBoxStart.TabIndex = 5;
            // 
            // textBoxFinish
            // 
            textBoxFinish.Location = new Point(635, 225);
            textBoxFinish.Name = "textBoxFinish";
            textBoxFinish.Size = new Size(125, 27);
            textBoxFinish.TabIndex = 6;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(600, 199);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(29, 20);
            labelStart.TabIndex = 7;
            labelStart.Text = "От:";
            // 
            // labelFinish
            // 
            labelFinish.AutoSize = true;
            labelFinish.Location = new Point(600, 229);
            labelFinish.Name = "labelFinish";
            labelFinish.Size = new Size(35, 20);
            labelFinish.TabIndex = 8;
            labelFinish.Text = "До: ";
            // 
            // labelWayanswer
            // 
            labelWayanswer.AutoSize = true;
            labelWayanswer.Location = new Point(541, 524);
            labelWayanswer.Name = "labelWayanswer";
            labelWayanswer.Size = new Size(0, 20);
            labelWayanswer.TabIndex = 9;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(873, 393);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(94, 29);
            buttonRemove.TabIndex = 10;
            buttonRemove.Text = "Удалить";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // Dekster
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRemove);
            Controls.Add(labelWayanswer);
            Controls.Add(labelFinish);
            Controls.Add(labelStart);
            Controls.Add(textBoxFinish);
            Controls.Add(textBoxStart);
            Controls.Add(button1);
            Controls.Add(dataGridViewAnswer);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridView);
            Name = "Dekster";
            Size = new Size(980, 568);
            Load += Dekster_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAnswer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button buttonAdd;
        private DataGridView dataGridViewAnswer;
        private Button button1;
        private TextBox textBoxStart;
        private TextBox textBoxFinish;
        private Label labelStart;
        private Label labelFinish;
        private Label labelWayanswer;
        private Button buttonRemove;
    }
}
