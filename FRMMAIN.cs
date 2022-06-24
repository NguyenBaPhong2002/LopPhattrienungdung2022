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
    public partial class FRMMAIN : Form
    {
        public FRMMAIN()
        {
            InitializeComponent();
        }

        private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();

        }

        private void tínhTổngSốChẵnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laptrinhcoban A = new laptrinhcoban();
            A.Show();
        }

        private void FRMMAIN_Load(object sender, EventArgs e)
        {

        }

        private void đăngNhậpLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.Show();
        }

        private void kếtThúcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form1 B = new Form1();
            B.Show();
        }
    }
}
