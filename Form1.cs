using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class Form1 : Form
    {
        private int speed = 5;
        private int direction = 1;
        private int direction_2 = -1;
        private int player_position = 0; 


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            enemy_1.Left += speed * direction;
            enemy_2.Left += speed * direction;
            enemy_3.Left += speed * direction_2;

            if (enemy_1.Left <= 0 || enemy_1.Right >= this.ClientSize.Width)
                direction *= -1;
            if (enemy_2.Left <= 0 || enemy_2.Right >= this.ClientSize.Width)
                direction *= -1;
            if (enemy_3.Left <= 0 || enemy_3.Right >= this.ClientSize.Width)
                direction_2 *= -1;
            

            if (player_position == 1)
                player.Top -= speed;
            if (player_position == 2)
                player.Top += speed;
            if (player_position == 3)
                player.Left -= speed;
            if (player_position == 4)
                player.Left += speed;

           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Cross;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                player_position = 1;
            }
            if (e.KeyCode == Keys.S)
            {
                player_position = 2;
            }
            if (e.KeyCode == Keys.A)
            {
                player_position = 3;
            }
            if (e.KeyCode == Keys.D)
            {
                player_position = 4;
            }
        }
    }
}
