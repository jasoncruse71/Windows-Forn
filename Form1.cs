using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Phase1 phase = new Phase1();
            phase.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Phase2 phase = new Phase2();
            phase.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Phase3 phase = new Phase3();
            phase.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Phase4 phase = new Phase4();
            phase.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Phase5 phase = new Phase5();
            phase.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
