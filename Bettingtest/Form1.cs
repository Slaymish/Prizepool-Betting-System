using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bettingtest
{
    public partial class Form1 : Form
    {

        // Declare Variables
        decimal prizepool;
        decimal teamATotal;
        decimal teamBTotal;
        decimal teamA;
        decimal teamB;

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

            listBox1.Items.Add("Name" + "Initial".PadLeft(10) + "Payout".PadLeft(10));
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


                    listBox1.Items.Add(name + bet.ToString("c").PadLeft(10) + payout.ToString("c").PadLeft(10));
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
            textBoxOdds.Text = teamA.ToString() + " to " + teamB.ToString();

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
    }
}
