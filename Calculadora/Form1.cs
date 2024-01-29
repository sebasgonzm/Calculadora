using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Location = new Point(0, 30);
            this.ClientSize = new Size(265, 380);
        }

        private void estandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel1.Location = new Point(0, 30);
            this.ClientSize = new Size(265, 380);
        }

        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel2.Location = new Point(0, 30);
            this.ClientSize = new Size(518, 380);
        }

        private void programadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel3.Location = new Point(0, 30);
            this.ClientSize = new Size(518, 380);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button65.Enabled = true;
            button66.Enabled = true;
            button67.Enabled = true;
            button68.Enabled = true;
            button69.Enabled = true;
            button70.Enabled = true;
            button71.Enabled = true;
            button72.Enabled = true;
            button73.Enabled = true;
            button74.Enabled = true;
            button75.Enabled = true;
            button76.Enabled = true;
            button77.Enabled = true;
            button78.Enabled = true;
            button79.Enabled = true;
            button80.Enabled = true;
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = true;
            button87.Enabled = true;
            button88.Enabled = true;
            button89.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button56.Enabled = true;
            button61.Enabled = true;
            button57.Enabled = true;
            button37.Enabled = true;
            button33.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;
            button31.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
            button62.Enabled = true;
            button63.Enabled = true;
            button36.Enabled = true;
            button32.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button65.Enabled = true;
            button66.Enabled = true;
            button67.Enabled = true;
            button68.Enabled = true;
            button69.Enabled = true;
            button70.Enabled = true;
            button71.Enabled = true;
            button72.Enabled = true;
            button73.Enabled = true;
            button74.Enabled = true;
            button75.Enabled = true;
            button76.Enabled = true;
            button77.Enabled = true;
            button78.Enabled = true;
            button79.Enabled = true;
            button80.Enabled = true;
            button81.Enabled = true;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = true;
            button87.Enabled = true;
            button88.Enabled = true;
            button89.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button56.Enabled = false;
            button61.Enabled = false;
            button57.Enabled = false;
            button37.Enabled = false;
            button33.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = true;
            button31.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
            button62.Enabled = true;
            button63.Enabled = true;
            button36.Enabled = true;
            button32.Enabled = true;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            button65.Enabled = true;
            button66.Enabled = true;
            button67.Enabled = true;
            button68.Enabled = true;
            button69.Enabled = true;
            button70.Enabled = true;
            button71.Enabled = true;
            button72.Enabled = true;
            button73.Enabled = true;
            button74.Enabled = true;
            button75.Enabled = true;
            button76.Enabled = true;
            button77.Enabled = true;
            button78.Enabled = true;
            button79.Enabled = true;
            button80.Enabled = false;
            button81.Enabled = false;
            button82.Enabled = true;
            button83.Enabled = true;
            button84.Enabled = true;
            button85.Enabled = true;
            button86.Enabled = true;
            button87.Enabled = true;
            button88.Enabled = true;
            button89.Enabled = true;
            button90.Enabled = true;
            button91.Enabled = true;
            button92.Enabled = true;
            button56.Enabled = false;
            button61.Enabled = false;
            button57.Enabled = false;
            button37.Enabled = false;
            button33.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = true;
            button31.Enabled = true;
            button34.Enabled = true;
            button35.Enabled = true;
            button54.Enabled = true;
            button55.Enabled = true;
            button58.Enabled = true;
            button59.Enabled = true;
            button62.Enabled = true;
            button63.Enabled = true;
            button36.Enabled = true;
            button32.Enabled = true;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            button65.Enabled = false;
            button66.Enabled = false;
            button67.Enabled = true;
            button68.Enabled = false;
            button69.Enabled = false;
            button70.Enabled = false;
            button71.Enabled = false;
            button72.Enabled = true;
            button73.Enabled = false;
            button74.Enabled = false;
            button75.Enabled = false;
            button76.Enabled = false;
            button77.Enabled = false;
            button78.Enabled = false;
            button79.Enabled = false;
            button80.Enabled = false;
            button81.Enabled = false;
            button82.Enabled = false;
            button83.Enabled = false;
            button84.Enabled = false;
            button85.Enabled = false;
            button86.Enabled = false;
            button87.Enabled = false;
            button88.Enabled = false;
            button89.Enabled = false;
            button90.Enabled = false;
            button91.Enabled = false;
            button92.Enabled = false;
            button56.Enabled = false;
            button61.Enabled = false;
            button57.Enabled = false;
            button37.Enabled = false;
            button33.Enabled = false;
            button29.Enabled = false;
            button30.Enabled = false;
            button31.Enabled = false;
            button34.Enabled = false;
            button35.Enabled = false;
            button54.Enabled = false;
            button55.Enabled = false;
            button58.Enabled = false;
            button59.Enabled = false;
            button62.Enabled = false;
            button63.Enabled = false;
            button36.Enabled = false;
            button32.Enabled = false;
        }
    }
}
