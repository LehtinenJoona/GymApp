namespace GymApp2
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
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
    }
}