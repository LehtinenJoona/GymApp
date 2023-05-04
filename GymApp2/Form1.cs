namespace GymApp2
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();
        Form6 form6 = new Form6();
        Form7 form7 = new Form7();
        Form8 form8 = new Form8();  

        public Form1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel23_Click(object sender, EventArgs e)
        {
            form2.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel24_click(object sender, EventArgs e)
        {
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            form7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            form8.Show();
        }

    }
}