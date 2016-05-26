using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserPart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Location = new Point(190, 63);
            panel2.Location = new Point(190, 63);
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            panel2.Visible = true;
            panel1.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        

       
    }
}
