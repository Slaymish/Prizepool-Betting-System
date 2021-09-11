
namespace Bettingtest
{
    partial class Form1
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
            this.buttonTeamA = new System.Windows.Forms.Button();
            this.buttonTeamB = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxBetAmount = new System.Windows.Forms.TextBox();
            this.listBoxTeamA = new System.Windows.Forms.ListBox();
            this.listBoxTeamB = new System.Windows.Forms.ListBox();
            this.textBoxPrizepool = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxOdds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonAWin = new System.Windows.Forms.Button();
            this.buttonBWin = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonTeamA
            // 
            this.buttonTeamA.Location = new System.Drawing.Point(50, 185);
            this.buttonTeamA.Name = "buttonTeamA";
            this.buttonTeamA.Size = new System.Drawing.Size(117, 37);
            this.buttonTeamA.TabIndex = 3;
            this.buttonTeamA.Text = "Bet Team A";
            this.buttonTeamA.UseVisualStyleBackColor = true;
            this.buttonTeamA.Click += new System.EventHandler(this.buttonTeamA_Click);
            // 
            // buttonTeamB
            // 
            this.buttonTeamB.Location = new System.Drawing.Point(50, 242);
            this.buttonTeamB.Name = "buttonTeamB";
            this.buttonTeamB.Size = new System.Drawing.Size(117, 37);
            this.buttonTeamB.TabIndex = 4;
            this.buttonTeamB.Text = "Bet Team B";
            this.buttonTeamB.UseVisualStyleBackColor = true;
            this.buttonTeamB.Click += new System.EventHandler(this.buttonTeamB_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(72, 94);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(82, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxBetAmount
            // 
            this.textBoxBetAmount.Location = new System.Drawing.Point(72, 139);
            this.textBoxBetAmount.Name = "textBoxBetAmount";
            this.textBoxBetAmount.Size = new System.Drawing.Size(82, 20);
            this.textBoxBetAmount.TabIndex = 2;
            // 
            // listBoxTeamA
            // 
            this.listBoxTeamA.FormattingEnabled = true;
            this.listBoxTeamA.Location = new System.Drawing.Point(265, 64);
            this.listBoxTeamA.Name = "listBoxTeamA";
            this.listBoxTeamA.Size = new System.Drawing.Size(104, 95);
            this.listBoxTeamA.TabIndex = 0;
            // 
            // listBoxTeamB
            // 
            this.listBoxTeamB.FormattingEnabled = true;
            this.listBoxTeamB.Location = new System.Drawing.Point(265, 197);
            this.listBoxTeamB.Name = "listBoxTeamB";
            this.listBoxTeamB.Size = new System.Drawing.Size(104, 95);
            this.listBoxTeamB.TabIndex = 0;
            // 
            // textBoxPrizepool
            // 
            this.textBoxPrizepool.Location = new System.Drawing.Point(446, 185);
            this.textBoxPrizepool.Name = "textBoxPrizepool";
            this.textBoxPrizepool.ReadOnly = true;
            this.textBoxPrizepool.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrizepool.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bet: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prizepool Better";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Team A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Team B:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(384, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prizepool: ";
            // 
            // textBoxOdds
            // 
            this.textBoxOdds.Location = new System.Drawing.Point(446, 142);
            this.textBoxOdds.Name = "textBoxOdds";
            this.textBoxOdds.ReadOnly = true;
            this.textBoxOdds.Size = new System.Drawing.Size(100, 20);
            this.textBoxOdds.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Odds:";
            // 
            // buttonAWin
            // 
            this.buttonAWin.Location = new System.Drawing.Point(50, 345);
            this.buttonAWin.Name = "buttonAWin";
            this.buttonAWin.Size = new System.Drawing.Size(75, 23);
            this.buttonAWin.TabIndex = 5;
            this.buttonAWin.Text = "A Wins";
            this.buttonAWin.UseVisualStyleBackColor = true;
            this.buttonAWin.Click += new System.EventHandler(this.buttonAWin_Click);
            // 
            // buttonBWin
            // 
            this.buttonBWin.Location = new System.Drawing.Point(131, 345);
            this.buttonBWin.Name = "buttonBWin";
            this.buttonBWin.Size = new System.Drawing.Size(75, 23);
            this.buttonBWin.TabIndex = 6;
            this.buttonBWin.Text = "B Wins";
            this.buttonBWin.UseVisualStyleBackColor = true;
            this.buttonBWin.Click += new System.EventHandler(this.buttonBWin_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(50, 390);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 199);
            this.listBox1.TabIndex = 0;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(265, 345);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Clear All";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 619);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonBWin);
            this.Controls.Add(this.buttonAWin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxOdds);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrizepool);
            this.Controls.Add(this.listBoxTeamB);
            this.Controls.Add(this.listBoxTeamA);
            this.Controls.Add(this.textBoxBetAmount);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonTeamB);
            this.Controls.Add(this.buttonTeamA);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTeamA;
        private System.Windows.Forms.Button buttonTeamB;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxBetAmount;
        private System.Windows.Forms.ListBox listBoxTeamA;
        private System.Windows.Forms.ListBox listBoxTeamB;
        private System.Windows.Forms.TextBox textBoxPrizepool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxOdds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonAWin;
        private System.Windows.Forms.Button buttonBWin;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonClear;
    }
}

