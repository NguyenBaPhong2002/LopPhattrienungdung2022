using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LopPhattrienungdung2022
{
    public partial class laptrinhcoban : Form
    {
        int i, n, T;
        public laptrinhcoban()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n = Convert.ToInt16(txtN.Text);
            T = 0;
            for (i=1;i<=n;i++)
            {
                if (i%2 == 0)
                {
                    T += i;
                }    
            }
            lblT.Text = "Ket qua tinh theo for la: " + Convert.ToString(T);
        }

    }
}
