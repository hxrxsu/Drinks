namespace Drinks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ананьчев Михаил", "Автор");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 dc = new Form2();
            dc.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 dc = new Form3();
            dc.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Дорабатывается...", "ОШИБКА");
        }
    }
}