namespace lab2._2_graph_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char a;

            a = Convert.ToChar(textBox1.Text);

            if (a == 'а' || a == 'А')
            {
                textBox2.Text = ("Максимальная скорость автомобиля: 200 км/ч");
            }
            else if (a == 'в' || a == 'В')
            {
                textBox2.Text = ("Максимальная скорость велосипеда: 40 км/ч");
            }
            else if (a == 'м' || a == 'М')
            {
                textBox2.Text = ("Максимальная скорость мотоцикла: 210 км/ч");
            }
            else if (a == 'с' || a == 'С')
            {
                textBox2.Text = ("Максимальная скорость самолета: 340 км/ч");
            }
            else if (a == 'п' || a == 'П')
            {
                textBox2.Text = ("Максимальная скорость поезда: 200 км/ч");
            }
            else
            {
                MessageBox.Show("Неверно введен признак транспортного средства!");
            }
        }
    }
}