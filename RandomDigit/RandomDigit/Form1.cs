using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomDigit
{
    public partial class Form1 : Form
    {
        public int xrandom = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int xrandom = rnd.Next(1, 100000);
            this.textBox1.Text = xrandom.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
