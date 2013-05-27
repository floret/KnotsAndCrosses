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
        int turn = 1;
        int player = 0;
        int flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0, flag5 = 0, flag6 = 0, flag7 = 0, flag8 = 0, flag9 = 0;
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
        int gamestate = 0;
        private void Logic()
        {//this code should maybe be put into a switch statement.
            if ((flag1 == 1) && (flag2 == 1) && (flag3 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                //gamestate = 1;
            }
            else if ((flag1 == 2) && (flag2 == 2) && (flag3 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            //second horizontal row.
            if ((flag4 == 1) && (flag5 == 1) && (flag6 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                //gamestate = 1;
            }
            else if ((flag4 == 2) && (flag5 == 2) && (flag6 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            //third horizontal row.
            if ((flag7 == 1) && (flag8 == 1) && (flag9 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                //gamestate = 1;
            }
            else if ((flag7 == 2) && (flag8 == 2) && (flag9 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            //first vertical row.
            if ((flag1 == 1) && (flag4 == 1) && (flag7 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                //gamestate = 1;
            }
            else if ((flag1 == 2) && (flag4 == 2) && (flag7 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            //second vertical row.
            if ((flag2 == 1) && (flag5 == 1) && (flag8 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                //gamestate = 1;
            }
            else if ((flag2 == 2) && (flag5 == 2) && (flag8 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            //third vertical row.
            if ((flag3 == 1) && (flag6 == 1) && (flag9 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                //gamestate = 1;
            }
            else if ((flag3 == 2) && (flag6 == 2) && (flag9 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            //first diagonal row.
            if ((flag1 == 1) && (flag5 == 1) && (flag9 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                //gamestate = 1;
            }
            else if ((flag1 == 2) && (flag5 == 2) && (flag9 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
            }
            //second diagonal row.
            if ((flag7 == 1) && (flag5 == 1) && (flag3 == 1))
            {
                MessageBox.Show("Player 1 Wins!");
                //gamestate = 1;
            }
            else if ((flag7 == 2) && (flag5 == 2) && (flag3 == 2))
            {
                MessageBox.Show("Player 2 Wins!");
            }  
        }
    }
}
//TODO: add counter to keep score.
//TODO: make the game reset afte displaying who won the round.
//TODO: ask the user best of how many they would like to play.
//TODO: let the player choose between single- and multiplayer.