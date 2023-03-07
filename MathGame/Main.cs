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
    public partial class Main : Form
    {
        int operand1 = 0, operand2 = 0;
        int score = 0, highScore = 0;
        int width = 0;
        int max = 0;
        string _operator;
        int answer = 0;
        int temp = 0;
        int _diff = 0;
        
        Random objRandom = new Random();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        public Main(int diff, string @operator)
        {
            InitializeComponent();
            timer1.Start();
            this.ActiveControl = txtAnswer;
            txtAnswer.Focus();
            _diff = diff;
            switch (diff)
            {
                case 0:
                    max = 5;
                    break;
                case 1:
                    max = 30;
                    break;
                case 2:
                    max = 80;
                    break;
            }
            _operator = @operator;
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            pnlTime.Width--;
            if (pnlTime.Width <= 0)
            {
                timer1.Stop();
                player.SoundLocation = "gameover.wav";
                player.Play();
                pnlGameOver.Show();
                score = 0;
                btnSubmit.Enabled = false;
                txtAnswer.Clear();
                btnPlayAgain.Focus();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            pnlGameOver.Hide();

            lblScore.Text = score.ToString();
            width = pnlTime.Width;
            operand1 = objRandom.Next(1,max);
            operand2 = objRandom.Next(1,max);
            if (operand2 > operand1)
            {
                temp = operand1;
                operand1 = operand2;
                operand2 = temp;
                
            }
            lblOperand1.Text = operand1.ToString();
            lblOperand2.Text = operand2.ToString();

            if (_operator == "Addition")
            {
                lblOperator.Text = "+";
            }
            else if (_operator == "Subtraction")
            {
                lblOperator.Text = "-";
            }
            else if (_operator == "Division")
            {
                lblOperator.Text = "÷";
            }
            else if (_operator == "Multiplication")
            {

                lblOperator.Text = "X";
            }

            

        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSubmit.PerformClick();
 
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_operator == "Addition")
            {
                answer = operand1 + operand2;
            }
            else if (_operator == "Subtraction")
            {
                answer = operand1 - operand2;             
            }
            else if (_operator == "Division")
            {
                answer = operand1 / operand2;
            }
            else if (_operator == "Multiplication")
            {
                answer = operand1 * operand2;
            }
            
            if (txtAnswer.Text == answer.ToString())
            {
                score++;
                lblScore.Text = score.ToString();
                txtAnswer.Clear();                
                player.SoundLocation = "correct.wav";
                player.Play();
                pnlTime.Width = width;
                max += 2;
                operand1 = objRandom.Next(1, max);
                operand2 = objRandom.Next(1, max);
                if (operand2 > operand1)
                {
                    temp = operand1;
                    operand1 = operand2;
                    operand2 = temp;
                    lblOperand1.Text = operand1.ToString();
                    lblOperand2.Text = operand2.ToString();
                }
                else
                {
                    lblOperand1.Text = operand1.ToString();
                    lblOperand2.Text = operand2.ToString();
 
                }
                

                if (score >= highScore)
                {
                    highScore = score;
                    lblHScore.Text = highScore.ToString();
                }
            }
            else
            {
                player.SoundLocation = "incorrect.wav";
                player.Play();
                pnlTime.Width -= 50;
 
            }
        }

        private void txtAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar == 8)
            {
                return;
            }
            if (e.KeyChar == '-')
            {
                return;
            }
            if(e.KeyChar < '0' || e.KeyChar>'9')
            {
                e.Handled = true;
            }
        }

        private void lblOperator_Click(object sender, EventArgs e)
        {

        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            pnlGameOver.Hide();
            lblScore.Text = score.ToString();
            pnlTime.Width = width;
            timer1.Start();
            btnSubmit.Enabled = true;
            txtAnswer.Focus();

            player.Stop();
            switch (_diff)
            {
                case 0:
                    max = 5;
                    break;
                case 1:
                    max = 30;
                    break;
                case 2:
                    max = 80;
                    break;
            }
            operand1 = objRandom.Next(1, max);
            operand2 = objRandom.Next(1, max);
            lblOperand1.Text = operand1.ToString();
            lblOperand2.Text = operand2.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 objForm1 = new Form1();
            objForm1.Show();
            player.Stop();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Are you sure?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
                timer1.Start();
            }
            
        }



    }
}
