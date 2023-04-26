using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string putValueFirst
        {
            set
            {
                inputOne.Text = value;
            }
        }

        public string putValueSecond
        {
            set
            {
                inputTwo.Text = value;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panelTwo11.Hide();
        }

        private void panelOne_Click(object sender, EventArgs e)
        {
            panelOne11.Show();
            panelTwo11.Hide();
        }

        private void panelTwo_Click(object sender, EventArgs e)
        {
            panelOne11.Hide();
            panelTwo11.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
