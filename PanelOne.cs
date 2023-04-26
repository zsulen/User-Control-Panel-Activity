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
    public partial class panelOne1 : UserControl
    {
        public panelOne1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var parent = this.Parent as Form1;
            parent.putValueFirst = textBox1.Text;
            parent.putValueSecond = textBox2.Text;
        }
    }
}
