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
        int flag1 = 0;
        int flag2 = 0;
        int flag3 = 0;
        int flag4 = 0;
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
            { label6.Text = "O"; turn = 2;  flag2 = 1; }
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
            { label9.Text = "O"; turn = 2; }
            else if (turn == 2)
            { label9.Text = "X"; turn = 1; }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label10.Text = "O"; turn = 2; }
            else if (turn == 2)
            { label10.Text = "X"; turn = 1; }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label13.Text = "O"; turn = 2; }
            else if (turn == 2)
            { label13.Text = "X"; turn = 1; }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label12.Text = "O"; turn = 2; }
            else if (turn == 2)
            { label12.Text = "X"; turn = 1; }
        }

        private void label11_Click(object sender, EventArgs e)
        {
            if (turn == 1)
            { label11.Text = "O"; turn = 2; }
            else if (turn == 2)
            { label11.Text = "X"; turn = 1; }
            
        }
        int gamestate = 0;
        private void Logic()
        {
            //do
            //{
                if((flag1==1)&&(flag2==1)&&(flag3==1))
                {
                    MessageBox.Show("Player 1 Wins!");
                    gamestate = 1;
                }
            //}
            //while (gamestate != 1);
        }
    }
}
