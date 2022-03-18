namespace rameez_shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label1_Click.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            circle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         Rectangle rectangle = new Rectangle();
         rectangle.Show();

        }

        private void exit_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}