namespace lab2._1_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x, y;
            try
            {
                x = float.Parse(textBox1.Text);
                y = float.Parse(textBox2.Text);

                if ((y > 0 && y < 5) && (x > 0 && x < 10))
                {
                    textBox3.Text = ("Да");
                }
                else if ((y == 5 && (x >= 0 && x <= 10) || x == 10 && (y >= 0 && (y >= 0 && y <= 5))) || (((y <= 5) || (x <= 10)) && ((y >= 0) && (x >= 0))))
                {
                    textBox3.Text = ("На границе");
                }
                else
                {
                    textBox3.Text = ("Нет");
                }

            }
            catch
            {
                MessageBox.Show("Введен неверный символ!");
            }
        }
    }
}