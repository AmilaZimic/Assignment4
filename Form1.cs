using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHubProjectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numbers = richTextBox1.Text;
            string[] array = numbers.Split(',');
            int[] inputs = Array.ConvertAll(array, int.Parse);

            double average;
            int sum = 0;

            for (int i = 0; i <= (inputs.Length - 1); i++)
            {
                sum += inputs[i];
            }

            average = (double)sum / inputs.Length;
            label1.Text = "The average of inputed numbers is: " + average.ToString("0.###");
        }
    }
}
