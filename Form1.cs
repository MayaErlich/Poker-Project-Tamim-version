using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //InitializeComponent();
            TabControl tabcontrol1 = new TabControl();
            tabcontrol1.Dock = DockStyle.Top;
            TabPage tab1 = new TabPage("Form1 Name");
            Form1 frm1 = new Form1();
            frm1.TopLevel = false;
            frm1.Parent = tab1;
            frm1.Visible = true;
            tabcontrol1.TabPages.Add(tab1);

            Form2 frm2 = new Form2();
            TabPage tab2 = new TabPage("Form2 Name");
            frm2.TopLevel = false;
            frm2.Parent = tab2;
            frm2.Visible = true;
            tabcontrol1.TabPages.Add(tab2);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
