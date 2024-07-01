using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace In_class_test_proj
{
    public struct Profile
    {
        public string name;

        public Profile(string Name)

        {
            name = Name;
        }
    }
    public partial class Form1 : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = textBox1.Text;
        }
        public Form1()
        {
            InitializeComponent();
        }
        DateTime dt = new DateTime();
        TimeSpan tspan = new TimeSpan(7, 0, 0, 0);
        TimeSpan instanceName = new TimeSpan();

        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime selected = DateTimePicker1.Value;
            dateLabel.Text = selected.ToString("F");
        }

         private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox1.Image = imageList1.Images[0];                
            }   
            if (comboBox1.SelectedIndex == 1)
            {
                pictureBox1.Image = imageList1.Images[1];
            }
            if (comboBox1.SelectedIndex == 2)
            {
                pictureBox1.Image = imageList1.Images[2];
            }
            if (comboBox1.SelectedIndex == 3)
            {
                pictureBox1.Image = imageList1.Images[3];   
            }
            if (comboBox1.SelectedIndex == 4)
            {
                pictureBox1.Image = imageList1.Images[4];
            }
            if (comboBox1.SelectedIndex == 5)
            {
                pictureBox1.Image = imageList1.Images[5];
            }
            if (comboBox1.SelectedIndex == 6)
            {
                pictureBox1.Image = imageList1.Images[6];
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(inputTextBox.Text);
                if (number > +1 && number < +10)
                {
                    MessageBox.Show("That number is accepted.");
                }
                else
                {
                    MessageBox.Show("That number is NOT accepted.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
                
        
    }
}