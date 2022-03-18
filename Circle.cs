using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rameez_shapes
{
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private void Circle_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void parameter_button_Click(object sender, EventArgs e)
        {
            if (input.Text != "")

            {
                double radius = Convert.ToDouble(input.Text);
                double parameter = 2 * Math.PI * radius;
                result.Text = parameter.ToString();

            }
            else
            {
                MessageBox.Show("Please enter Radius !!");
            }

        }

        private void area_button_Click(object sender, EventArgs e)
        {
            if (input.Text != "")

            {
               double radius = Convert.ToDouble(input.Text);
                double area = Math.PI * radius * radius;
                result.Text = area.ToString();

            }
            else
            {
               MessageBox.Show("Please enter Radius !!");
            }
        }

        private void calculate_label_Click(object sender, EventArgs e)
        {

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void input_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void move_rectangle_Click(object sender, EventArgs e)
        {
            Rectangle rectangle = new Rectangle();
            this.Close();
            rectangle.Show();

        }
    }
}
