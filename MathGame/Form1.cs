using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathGame
{
    public partial class Form1 : Form
    {
        string diff;
        string @operator;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            switch (cboxOperator.SelectedIndex)
            {
                case 0:
                    @operator = "Addition";
                    break;
                case 1:
                    @operator = "Subtraction";
                    break;
                case 2:
                    @operator = "Division";
                    break;
                case 3:
                    @operator = "Multiplication";
                    break;
                case 4:
                    @operator = "Random";
                    break;
            }
            this.Hide();
            Main objMain = new Main(cboxDiff.SelectedIndex,@operator);         
            objMain.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboxOperator.SelectedIndex = 0;
            cboxDiff.SelectedIndex = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }


    }
}
