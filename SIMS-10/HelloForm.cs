using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_10
{
    public partial class HelloForm : Form
    {
        public HelloForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameController.RollsCount = Convert.ToInt32(rollCountTB.Text);            
            GameController.isHard = checkBox1.Checked;
            Console.WriteLine(GameController.isHard);
            Console.WriteLine(GameController.RollsCount);
            Form1 form = new Form1();
            form.Show();
            button1.Enabled = false;
            form.FormClosed += Form_FormClosed;
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            button1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rollCountTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
