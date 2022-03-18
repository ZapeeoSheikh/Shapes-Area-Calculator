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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private void Linput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Winput_TextChanged(object sender, EventArgs e)
        {

        }

        private void area_button_Click(object sender, EventArgs e)
        {
            if (Linput.Text != "" && Winput.Text != "")
            {
                double width = Convert.ToDouble(Winput.Text);
                double legnth = Convert.ToDouble(Linput.Text);
                double area = legnth * width;
                result.Text = area.ToString();

            }
            else
            {
              
                    MessageBox.Show("Empty Field !!");
                
            }
        }

        private void parameter_button_Click(object sender, EventArgs e)
        {
            if (Linput.Text != "" && Winput.Text != "")
            {
                double width = Convert.ToDouble(Winput.Text);
                double legnth = Convert.ToDouble(Linput.Text);
                double parameter = 2 * (legnth + width);
                result.Text = parameter.ToString();

            }
            else
            {
               
                    MessageBox.Show(" Empty Field !! ");
      
            }

        }

        private void result_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void move_circle_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            this.Close();
            circle.Show();
        }
    }
}
