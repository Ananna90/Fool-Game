using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fool_Game_1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random R = new Random();
            i++;
            Point pt = new Point(
            int.Parse(R.Next(600).ToString()),
            int.Parse(R.Next(300).ToString())
            );
            button2.Location = pt;
        }

        int i = 0;
        
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                Form3 form3 = new Form3();
                this.Hide();
                form3.Show();

            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();           
            form2.Show();
            form2.Tag = this;
            Hide();
        }

       
    }
}
