using System.Windows.Forms;

namespace main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оценкаВыборокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void LoadControl(UserControl userControl)
        {
            panelMain.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panelMain.Controls.Add(userControl); // Добавляем новый контрол
        }


        private void симплексметодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new simplex());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void транспортнаяЗадачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void тестоваяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new TestUserControl()); // аналогично с другими задачами
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void шифрыЗаменыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadControl(new Шифры_замены());
        }
    }
}
