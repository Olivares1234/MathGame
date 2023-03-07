namespace MathGame
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblOperand1 = new System.Windows.Forms.Label();
            this.lblOperand2 = new System.Windows.Forms.Label();
            this.lblOperator = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.pblContainer = new System.Windows.Forms.Panel();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlGameOver = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.pblContainer.SuspendLayout();
            this.pnlGameOver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOperand1
            // 
            this.lblOperand1.AutoSize = true;
            this.lblOperand1.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperand1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOperand1.Location = new System.Drawing.Point(137, 115);
            this.lblOperand1.Name = "lblOperand1";
            this.lblOperand1.Size = new System.Drawing.Size(102, 75);
            this.lblOperand1.TabIndex = 0;
            this.lblOperand1.Text = "O1";
            // 
            // lblOperand2
            // 
            this.lblOperand2.AutoSize = true;
            this.lblOperand2.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperand2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOperand2.Location = new System.Drawing.Point(277, 115);
            this.lblOperand2.Name = "lblOperand2";
            this.lblOperand2.Size = new System.Drawing.Size(102, 75);
            this.lblOperand2.TabIndex = 1;
            this.lblOperand2.Text = "O2";
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperator.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblOperator.Location = new System.Drawing.Point(220, 115);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(63, 75);
            this.lblOperator.TabIndex = 2;
            this.lblOperator.Text = "+";
            this.lblOperator.Click += new System.EventHandler(this.lblOperator_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.LawnGreen;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(139, 302);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(240, 52);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit Answer";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(204, 236);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(107, 38);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyDown);
            this.txtAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnswer_KeyPress);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl1.Location = new System.Drawing.Point(403, 35);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(83, 31);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Score :";
            // 
            // pblContainer
            // 
            this.pblContainer.BackColor = System.Drawing.Color.Gainsboro;
            this.pblContainer.Controls.Add(this.pnlTime);
            this.pblContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pblContainer.Location = new System.Drawing.Point(0, 0);
            this.pblContainer.Name = "pblContainer";
            this.pblContainer.Size = new System.Drawing.Size(514, 22);
            this.pblContainer.TabIndex = 6;
            // 
            // pnlTime
            // 
            this.pnlTime.BackColor = System.Drawing.Color.LimeGreen;
            this.pnlTime.Location = new System.Drawing.Point(0, 0);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(514, 22);
            this.pnlTime.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblScore.Location = new System.Drawing.Point(476, 35);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(26, 31);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0";
            // 
            // pnlGameOver
            // 
            this.pnlGameOver.Controls.Add(this.label3);
            this.pnlGameOver.Controls.Add(this.button1);
            this.pnlGameOver.Controls.Add(this.label1);
            this.pnlGameOver.Controls.Add(this.pictureBox1);
            this.pnlGameOver.Controls.Add(this.btnPlayAgain);
            this.pnlGameOver.Location = new System.Drawing.Point(88, 81);
            this.pnlGameOver.Name = "pnlGameOver";
            this.pnlGameOver.Size = new System.Drawing.Size(368, 273);
            this.pnlGameOver.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(92, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Play Again";
            // 
            // lblHScore
            // 
            this.lblHScore.AutoSize = true;
            this.lblHScore.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHScore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHScore.Location = new System.Drawing.Point(353, 35);
            this.lblHScore.Name = "lblHScore";
            this.lblHScore.Size = new System.Drawing.Size(26, 31);
            this.lblHScore.TabIndex = 10;
            this.lblHScore.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(315, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "HI :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(232, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Back to Menu";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::MathGame.Properties.Resources.back_icon;
            this.button1.Location = new System.Drawing.Point(202, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 49);
            this.button1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.button1, "Menu");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MathGame.Properties.Resources.GameOver;
            this.pictureBox1.Location = new System.Drawing.Point(29, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.White;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Image = global::MathGame.Properties.Resources.Start_icon32px;
            this.btnPlayAgain.Location = new System.Drawing.Point(62, 187);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(114, 49);
            this.btnPlayAgain.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnPlayAgain, "Play Again");
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(514, 391);
            this.Controls.Add(this.pnlGameOver);
            this.Controls.Add(this.lblHScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pblContainer);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.lblOperand2);
            this.Controls.Add(this.lblOperand1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.pblContainer.ResumeLayout(false);
            this.pnlGameOver.ResumeLayout(false);
            this.pnlGameOver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperand1;
        private System.Windows.Forms.Label lblOperand2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pblContainer;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Panel pnlGameOver;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}