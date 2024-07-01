using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                var PictureBox1 = new PictureBox();                
            }            
        }       
    }
}