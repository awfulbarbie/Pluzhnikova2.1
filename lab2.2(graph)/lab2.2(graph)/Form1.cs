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

            if (a == '�' || a == '�')
            {
                textBox2.Text = ("������������ �������� ����������: 200 ��/�");
            }
            else if (a == '�' || a == '�')
            {
                textBox2.Text = ("������������ �������� ����������: 40 ��/�");
            }
            else if (a == '�' || a == '�')
            {
                textBox2.Text = ("������������ �������� ���������: 210 ��/�");
            }
            else if (a == '�' || a == '�')
            {
                textBox2.Text = ("������������ �������� ��������: 340 ��/�");
            }
            else if (a == '�' || a == '�')
            {
                textBox2.Text = ("������������ �������� ������: 200 ��/�");
            }
            else
            {
                MessageBox.Show("������� ������ ������� ������������� ��������!");
            }
        }
    }
}