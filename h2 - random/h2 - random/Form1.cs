using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace h2___random
{
    public partial class Form1 : Form
    {
        double sum = 0;
        int count = 0;
        List<double> list = new List<double>(); 
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (timer1.Enabled == true)
            {
                Generate.Text = "Generate"; // change the text on the button
                timer1.Enabled = false; 
            }
            else
            {
                Generate.Text = "Stop";
                timer1.Enabled = true; 
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Random random = new Random();
            double num = 0;
            

            num = random.NextDouble();
            list.Add(num);  
            

            this.richTextBox1.AppendText(num.ToString() +  " ----> AVG: " + list.Average() + "\n"); 

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            sum = 0;
            count = 0;
            list.RemoveAll(x => true);
        }
    }
}
