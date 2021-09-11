using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bettingtest
{
    public partial class Form1 : Form
    {

        // Declare Variables
        decimal prizepool;
        decimal teamA;
        decimal teamB;
        const string FILTER = "txt files | *.txt | All files | *.*";
        string odds;

        // Declare lists
        List<string> betterName = new List<string>();
        List<char> betterTeam = new List<char>();
        List<decimal> betterAmount = new List<decimal>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Create_Bet(char team)
        {
            // Declare Variables
            string name;
            decimal betAmount;
        

            try
            {
                // Get name and bet amount
                name = textBoxName.Text;
                betAmount = decimal.Parse(textBoxBetAmount.Text);

                if (betAmount > 0)
                {
                    // Add vars to list
                    betterName.Add(name);
                    betterTeam.Add(team);
                    betterAmount.Add(betAmount);


                    Update_Lists();
                    Odd_Prizepool();

                }
                else
                {
                    MessageBox.Show("Enter an amount higher than 0");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Decide_Winners(char team)
        {
            string name;
            decimal bet;
            decimal payout;
            decimal ratio;

            listBox1.Items.Clear();

            listBox1.Items.Add("Name".PadRight(20) + "Initial".PadLeft(20) + "Payout".PadLeft(20));
            bet = 0;
            payout = 0;
            ratio = 0;


            for (int i = 0; i < betterAmount.Count; i++)
            {
                if (betterTeam[i] == team)
                {
                    bet = betterAmount[i];
                    name = betterName[i];
                    
                    // Calculate payout
                    if (team == 'A')
                    {
                        ratio = bet / teamA;
                    }

                    if (team == 'B')
                    {
                        ratio = bet / teamB;
                    }

                    payout = prizepool * ratio;


                    listBox1.Items.Add(name.PadRight(20) + bet.ToString("c").PadLeft(20) + payout.ToString("c").PadLeft(20));
                }
                
            }
        }

        private void buttonTeamA_Click(object sender, EventArgs e)
        {
            Create_Bet('A');
        }

        private void buttonTeamB_Click(object sender, EventArgs e)
        {
            Create_Bet('B');
        }

        private void Update_Lists()
        {
            // Update listboxes
            char team;
            string name;
            decimal amount;

            listBoxTeamA.Items.Clear();
            listBoxTeamB.Items.Clear();

            for (int i = 0; i < betterAmount.Count; i++)
            {
                team = betterTeam[i];
                name = betterName[i];
                amount = betterAmount[i];

                if (team == 'A')
                {
                    listBoxTeamA.Items.Add(name + amount.ToString().PadLeft(10));
                }
                if (team == 'B')
                {
                    listBoxTeamB.Items.Add(name + amount.ToString().PadLeft(10));
                }
            }
        }

        private void Odd_Prizepool()
        {
            char team;
            prizepool = 0;


            teamA = 0;
            teamB = 0;

            // Calculate prizepool
            for (int i = 0; i < betterAmount.Count; i++)
            {
                prizepool += betterAmount[i];
                team = betterTeam[i];

                if (team == 'A')
                {
                    teamA += betterAmount[i];
                }
                if (team == 'B')
                {
                    teamB += betterAmount[i];
                }

            }

            // Calculate odds
            odds = teamA.ToString() + " to " + teamB.ToString();
            textBoxOdds.Text = odds;

            textBoxPrizepool.Text = prizepool.ToString("c");



        }

        private void buttonAWin_Click(object sender, EventArgs e)
        {
            Decide_Winners('A');
        }

        private void buttonBWin_Click(object sender, EventArgs e)
        {
            Decide_Winners('B');
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBoxBetAmount.Clear();
            textBoxName.Clear();
            listBoxTeamA.Items.Clear();
            listBoxTeamB.Items.Clear();
            textBoxOdds.Clear();
            textBoxPrizepool.Clear();

            betterAmount.Clear();
            betterName.Clear();
            betterTeam.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void saveOddsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare variables
            StreamWriter writer;

            // Set dialogs filter
            saveFileDialog1.Filter = FILTER;

            if (odds != null)
            {

                // If save file opens and ok is selected
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Create new file from user given file name
                    writer = File.CreateText(saveFileDialog1.FileName);

                    writer.WriteLine("FORMAT: NAME|BET AMOUNT");
                    writer.WriteLine(' ');
                    writer.WriteLine("Bets on Team A");
                    for (int i = 0; i < betterAmount.Count; i++)
                    {
                        if (betterTeam[i] == 'A')
                        {
                            writer.WriteLine(betterName[i] + "|" + betterAmount[i]);
                        }

                    }
                    writer.WriteLine(' ');

                    writer.WriteLine("Bets on Team B");
                    for (int i = 0; i < betterAmount.Count; i++)
                    {
                        if (betterTeam[i] == 'B')
                        {
                            writer.WriteLine(betterName[i] + "|" + betterAmount[i]);
                        }

                    }

                    writer.WriteLine(' ');
                    writer.WriteLine("Prizepool: " + prizepool.ToString("c"));
                    writer.WriteLine("Odds: " + odds + " (team A to team B)");

                    // Close text
                    writer.Close();

                }
            }
            else
            {
                MessageBox.Show("Place some bets first!");
            }
        }

        private void savePayoutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Declare variables
            StreamWriter writer;

            // Set dialogs filter
            saveFileDialog1.Filter = FILTER;

            if (odds != null)
            {
                if (listBox1.Items.Count >= 1)
                {
                    // If save file opens and ok is selected
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        // Create new file from user given file name
                        writer = File.CreateText(saveFileDialog1.FileName);

                        writer.WriteLine("FORMAT: NAME|INTIAL|PAYOUT");
                        writer.WriteLine(' ');
                        writer.WriteLine("Bets");
                        for (int i = 0; i < listBox1.Items.Count; i++)
                        {
                            writer.WriteLine(listBox1.Items[i]);

                        }

                        writer.WriteLine(' ');
                        writer.WriteLine("Ending Prizepool: " + prizepool.ToString("c"));
                        writer.WriteLine("Ending Odds: " + odds + " (team A to team B)");

                        writer.WriteLine(" ");
                        writer.WriteLine("EVERYONE NOT ON LIST, THEIR PAYOUT IS $0");

                        // Close text
                        writer.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Confirm which team won first!");
                }


            }
            else
            {
                MessageBox.Show("Place some bets first!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
