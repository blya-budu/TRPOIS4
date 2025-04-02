namespace main
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            задачиToolStripMenuItem = new ToolStripMenuItem();
            симплексметодToolStripMenuItem = new ToolStripMenuItem();
            транспортнаяЗадачаToolStripMenuItem = new ToolStripMenuItem();
            алгоритмГрафовToolStripMenuItem = new ToolStripMenuItem();
            алгоритмДейкрстрыToolStripMenuItem = new ToolStripMenuItem();
            динамическоеПрограммированиеToolStripMenuItem = new ToolStripMenuItem();
            оценкаВыборокToolStripMenuItem = new ToolStripMenuItem();
            оценкаНесколькихВыборокToolStripMenuItem = new ToolStripMenuItem();
            шифрыЗаменыToolStripMenuItem = new ToolStripMenuItem();
            шифрыПерестановокToolStripMenuItem = new ToolStripMenuItem();
            тестоваяToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            panelMain = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { задачиToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(896, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // задачиToolStripMenuItem
            // 
            задачиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { симплексметодToolStripMenuItem, транспортнаяЗадачаToolStripMenuItem, алгоритмГрафовToolStripMenuItem, алгоритмДейкрстрыToolStripMenuItem, динамическоеПрограммированиеToolStripMenuItem, оценкаВыборокToolStripMenuItem, оценкаНесколькихВыборокToolStripMenuItem, шифрыЗаменыToolStripMenuItem, шифрыПерестановокToolStripMenuItem, тестоваяToolStripMenuItem });
            задачиToolStripMenuItem.Name = "задачиToolStripMenuItem";
            задачиToolStripMenuItem.Size = new Size(72, 24);
            задачиToolStripMenuItem.Text = "Задачи";
            // 
            // симплексметодToolStripMenuItem
            // 
            симплексметодToolStripMenuItem.Name = "симплексметодToolStripMenuItem";
            симплексметодToolStripMenuItem.Size = new Size(340, 26);
            симплексметодToolStripMenuItem.Text = "Симплекс-метод";
            симплексметодToolStripMenuItem.Click += симплексметодToolStripMenuItem_Click;
            // 
            // транспортнаяЗадачаToolStripMenuItem
            // 
            транспортнаяЗадачаToolStripMenuItem.Name = "транспортнаяЗадачаToolStripMenuItem";
            транспортнаяЗадачаToolStripMenuItem.Size = new Size(340, 26);
            транспортнаяЗадачаToolStripMenuItem.Text = "Транспортная задача";
            транспортнаяЗадачаToolStripMenuItem.Click += транспортнаяЗадачаToolStripMenuItem_Click;
            // 
            // алгоритмГрафовToolStripMenuItem
            // 
            алгоритмГрафовToolStripMenuItem.Name = "алгоритмГрафовToolStripMenuItem";
            алгоритмГрафовToolStripMenuItem.Size = new Size(340, 26);
            алгоритмГрафовToolStripMenuItem.Text = "Алгоритм Графов";
            // 
            // алгоритмДейкрстрыToolStripMenuItem
            // 
            алгоритмДейкрстрыToolStripMenuItem.Name = "алгоритмДейкрстрыToolStripMenuItem";
            алгоритмДейкрстрыToolStripMenuItem.Size = new Size(340, 26);
            алгоритмДейкрстрыToolStripMenuItem.Text = "Алгоритм Дейкрстры";
            // 
            // динамическоеПрограммированиеToolStripMenuItem
            // 
            динамическоеПрограммированиеToolStripMenuItem.Name = "динамическоеПрограммированиеToolStripMenuItem";
            динамическоеПрограммированиеToolStripMenuItem.Size = new Size(340, 26);
            динамическоеПрограммированиеToolStripMenuItem.Text = "Динамическое программирование";
            // 
            // оценкаВыборокToolStripMenuItem
            // 
            оценкаВыборокToolStripMenuItem.Name = "оценкаВыборокToolStripMenuItem";
            оценкаВыборокToolStripMenuItem.Size = new Size(340, 26);
            оценкаВыборокToolStripMenuItem.Text = "Оценка двух выборок";
            оценкаВыборокToolStripMenuItem.Click += оценкаВыборокToolStripMenuItem_Click;
            // 
            // оценкаНесколькихВыборокToolStripMenuItem
            // 
            оценкаНесколькихВыборокToolStripMenuItem.Name = "оценкаНесколькихВыборокToolStripMenuItem";
            оценкаНесколькихВыборокToolStripMenuItem.Size = new Size(340, 26);
            оценкаНесколькихВыборокToolStripMenuItem.Text = "Оценка нескольких выборок";
            // 
            // шифрыЗаменыToolStripMenuItem
            // 
            шифрыЗаменыToolStripMenuItem.Name = "шифрыЗаменыToolStripMenuItem";
            шифрыЗаменыToolStripMenuItem.Size = new Size(340, 26);
            шифрыЗаменыToolStripMenuItem.Text = "Шифры замены";
            шифрыЗаменыToolStripMenuItem.Click += шифрыЗаменыToolStripMenuItem_Click;
            // 
            // шифрыПерестановокToolStripMenuItem
            // 
            шифрыПерестановокToolStripMenuItem.Name = "шифрыПерестановокToolStripMenuItem";
            шифрыПерестановокToolStripMenuItem.Size = new Size(340, 26);
            шифрыПерестановокToolStripMenuItem.Text = "Шифры перестановок";
            // 
            // тестоваяToolStripMenuItem
            // 
            тестоваяToolStripMenuItem.Name = "тестоваяToolStripMenuItem";
            тестоваяToolStripMenuItem.Size = new Size(340, 26);
            тестоваяToolStripMenuItem.Text = "Тестовая";
            тестоваяToolStripMenuItem.Click += тестоваяToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(67, 24);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 30);
            panelMain.Margin = new Padding(3, 4, 3, 4);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(896, 718);
            panelMain.TabIndex = 1;
            panelMain.Paint += panel1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 748);
            Controls.Add(panelMain);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Главное меню";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem задачиToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem симплексметодToolStripMenuItem;
        private ToolStripMenuItem транспортнаяЗадачаToolStripMenuItem;
        private ToolStripMenuItem алгоритмГрафовToolStripMenuItem;
        private ToolStripMenuItem алгоритмДейкрстрыToolStripMenuItem;
        private ToolStripMenuItem динамическоеПрограммированиеToolStripMenuItem;
        private ToolStripMenuItem оценкаВыборокToolStripMenuItem;
        private ToolStripMenuItem оценкаНесколькихВыборокToolStripMenuItem;
        private ToolStripMenuItem шифрыЗаменыToolStripMenuItem;
        private ToolStripMenuItem шифрыПерестановокToolStripMenuItem;
        private Panel panelMain;
        private ToolStripMenuItem тестоваяToolStripMenuItem;
    }
}
