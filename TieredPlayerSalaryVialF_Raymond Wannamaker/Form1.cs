using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TieredPlayerSalaryVialF_Raymond_Wannamaker
{
//Author: Raymond Wannamaker 
//ID: 556586
//Date: Feb 23, 2023
//Goal Purpose of the Program: Creating a program to calculate Player rank / tier with the most hits and salary.
    public partial class Form1 : Form
    {
        private List<Player> players = new List<Player>();
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Clear any previous output
            salaryLabel.Text = "";

            //Get the input values
            string playerName = nameTextBox.Text.Trim();
            int hits;
            bool isAllStar = allStarCheckBox.Checked;
            bool isMVP = mvpCheckBox.Checked;

            if (int.TryParse(hitsTextBox.Text, out hits))
            {
                //Validate hit count
                if (hits > 0 && hits <= 300)
                {
                    double salary;
                    int tier;

                    //Determine teir and $ per hit based on hit count
                    if (hits >= 1 && hits <= 49)
                    {
                        salary = hits * 17500;
                        tier = 1;
                    }
                    else if (hits >= 50 && hits <= 99)
                    {
                        salary = hits * 20000;
                        tier = 2;
                    }
                    else if (hits >= 100 && hits <= 149)
                    {
                        salary = hits * 22500;
                        tier = 3;
                    }
                    else
                    {
                        salary = hits * 25000;
                        tier = 4;
                    }
                    //Apply bouns for All Star/MVP
                    if (isAllStar && isMVP)
                    {
                        salary *= 1.25;
                    }
                    else if (isAllStar || isMVP)
                    {
                        salary *= 1.2;
                    }
                    //Create new player object and add to list
                    Player player = new Player(playerName, hits, salary, tier);
                    players.Add(player);

                    //Output player's salary and tier
                    salaryLabel.Text = $"{playerName}'s Tier {tier} salary is: {salary.ToString("C")}";

                    //Update summary information for leading player
                    Player leadingPlayer = players.OrderByDescending(p => p.Hits).FirstOrDefault();
                    if (leadingPlayer != null)
                    {
                        leadingPlayerLabel.Text = $"Leading player: {leadingPlayer.Name}, Hits: {leadingPlayer.Hits}, Salary: {leadingPlayer.Salary.ToString("C")}, Tier: {leadingPlayer.Tier}";
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input for number of hits. Please enter a number between 1 and 300.");
                }
            }
            else
            {
                MessageBox.Show("Invalid input for number of hits. Please enter a valid integer.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear all input fields, checkboxes and output labels
            nameTextBox.Text = string.Empty;
            hitsTextBox.Text = string.Empty;
            allStarCheckBox.Checked = false;
            mvpCheckBox.Checked = false;
            salaryLabel.Text = string.Empty;
            leadingPlayerLabel.Text = string.Empty;
        }
    }

    class Player
    {
        public string Name { get; }
        public int Hits { get; }
        public double Salary { get; }
        public int Tier { get; }

        public Player(string name, int hits, double salary, int tier)
        {
            Name = name;
            Hits = hits;
            Salary = salary;
            Tier = tier;
        }
    }
}
