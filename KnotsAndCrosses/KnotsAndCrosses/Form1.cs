using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KnotsAndCrosses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int turn = 1;//used to deremine who's turn it is, 1 is O since O always starts first.
        int flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0, flag5 = 0, flag6 = 0, flag7 = 0, flag8 = 0, flag9 = 0;//used to determine when a player wins
        int score1 = 0, score2 = 0;//used to keep score

        private void label5_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label5.Text = "O"; turn = 2; flag1 = 1; }
            else if (turn == 2)
            { label5.Text = "X"; turn = 1; flag1 = 2; }
            Logic();
        }

        private void label6_Click(object sender, EventArgs e)
        {

            if (turn == 1)
            { label6.Text = "O"; turn = 2; flag2 = 1; }
            else if (turn == 2)
            { label6.Text = "X"; turn = 1; flag2 = 2; }
            Logic();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            if (turn == 1)
            { label7.Text = "O"; turn = 2; flag3 = 1; }
            else if (turn == 2)
            { label7.Text = "X"; turn = 1; flag3 = 2; }
            Logic();
        }

        private void label8_Click(object sender, EventArgs e)
        {

            if (turn == 1)
            { label8.Text = "O"; turn = 2; flag4 = 1; }
            else if (turn == 2)
            { label8.Text = "X"; turn = 1; flag4 = 2; }
            Logic();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label9.Text = "O"; turn = 2; flag5 = 1; }
            else if (turn == 2)
            { label9.Text = "X"; turn = 1; flag5 = 2; }
            Logic();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label10.Text = "O"; turn = 2; flag6 = 1; }
            else if (turn == 2)
            { label10.Text = "X"; turn = 1; flag6 = 2; }
            Logic();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label13.Text = "O"; turn = 2; flag7 = 1; }
            else if (turn == 2)
            { label13.Text = "X"; turn = 1; flag7 = 2; }
            Logic();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label12.Text = "O"; turn = 2; flag8 = 1; }
            else if (turn == 2)
            { label12.Text = "X"; turn = 1; flag8 = 2; }
            Logic();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label11.Text = "O"; turn = 2; flag9 = 1; }
            else if (turn == 2)
            { label11.Text = "X"; turn = 1; flag9 = 2; }
            Logic();
        }
        /// <summary>
        /// Resets the game board so that another round can be played.
        /// </summary>
        private void Reset()
        {
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            turn = 1;
            flag1 = 0;
            flag2 = 0;
            flag3 = 0;
            flag4 = 0;
            flag5 = 0;
            flag6 = 0;
            flag7 = 0;
            flag8 = 0;
            flag9 = 0;
            //lblScore.Text = "Score: Player 1: " + "0" + " Player 2: " + "0"; 
        }
        /// <summary>
        /// Determines when someone wins.
        /// </summary>
        private void Logic()
        {//this code should maybe be put into a switch statement. 
            //!the reset isn't working correctly, it needs to break somewhere.
            //first horizontal row.
            if ((flag1 == 1) && (flag2 == 1) && (flag3 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                score1++;                
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2;                
            }
            else if ((flag1 == 2) && (flag2 == 2) && (flag3 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
                score2++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2;
            }

            //second horizontal row.
            if ((flag4 == 1) && (flag5 == 1) && (flag6 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                score1++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }
            else if ((flag4 == 2) && (flag5 == 2) && (flag6 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
                score2++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }

            //third horizontal row.
            if ((flag7 == 1) && (flag8 == 1) && (flag9 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                score1++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }
            else if ((flag7 == 2) && (flag8 == 2) && (flag9 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
                score2++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }

            //first vertical row.
            if ((flag1 == 1) && (flag4 == 1) && (flag7 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                score1++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }
            else if ((flag1 == 2) && (flag4 == 2) && (flag7 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
                score2++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }

            //second vertical row.
            if ((flag2 == 1) && (flag5 == 1) && (flag8 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                score1++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }
            else if ((flag2 == 2) && (flag5 == 2) && (flag8 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
                score2++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }

            //third vertical row.
            if ((flag3 == 1) && (flag6 == 1) && (flag9 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                score1++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }
            else if ((flag3 == 2) && (flag6 == 2) && (flag9 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
                score2++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }

            //first diagonal row.
            if ((flag1 == 1) && (flag5 == 1) && (flag9 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                score1++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }
            else if ((flag1 == 2) && (flag5 == 2) && (flag9 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
                score2++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }

            //second diagonal row.
            if ((flag7 == 1) && (flag5 == 1) && (flag3 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                score1++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }
            else if ((flag7 == 2) && (flag5 == 2) && (flag3 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
                score2++;
                Reset();
                lblScore.Text = "Score: Player 1: " + score1 + " Player 2: " + score2; 
            }            
        }
    }
}
//TODO: Fix the reset so that it works.
//TODO: ask the user best of how many they would like to play.
//TODO: let the player choose between single- and multiplayer.