using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_11
{
    public partial class Form1 : Form
    {
        
        public static int rolls = 0;
        public static Random random = new Random();
        public static int sides = random.Next(4, 21);
        public static Dice die1 = new Dice(sides);
        public static Dice die2 = new Dice(sides);
        
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine(sides);

        }

        private void RollBTN_Click(object sender, EventArgs e)
        {
            rolls++;
            int num1 = die1.rollDie();
            int num2 = die2.rollDie();
            
            Num1.Text = num1.ToString();
            Num2.Text = num2.ToString();

            Console.WriteLine("Die 1: " + num1 + "\tDie 2: " + num2 + "\t Rolls :" + rolls);

            if (num1 == 1 && num2 == 1)
            {
                System.Windows.Forms.MessageBox.Show("It took " + rolls + " rolls to get snake eyes!");
                Close();
            }

        }

        private void AutoRoll_Click(object sender, EventArgs e)
        {
            bool run = true;
            while (run) 
            {
                rolls++;
                int num1 = die1.rollDie();
                int num2 = die2.rollDie();

                Num1.Text = num1.ToString();
                Num2.Text = num2.ToString();
                
                Console.WriteLine("Die 1: " + num1 + "\tDie 2: " + num2 + "\t Rolls :" + rolls);
                
                if (num1 == 1 && num2 == 1)
                {
                    run = false;
                    System.Windows.Forms.MessageBox.Show("It took " + rolls + " to get snake eyes!");
                    Close();
                }

            }

        }
    }
}
