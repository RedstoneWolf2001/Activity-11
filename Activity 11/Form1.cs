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
        public Form1()
        {
            InitializeComponent();

        }

        public static int rolls = 0;
        public static Random random = new Random();
        public static int sides = random.Next(4, 21);
        public static Dice die1 = new Dice(sides);
        public static Dice die2 = new Dice(sides);


        private void RollBTN_Click(object sender, EventArgs e)
        {
            rolls++;

            int face1 = die1.rollDie();
            int face2 = die2.rollDie();

            Num1.Text = face1.ToString();
            Num2.Text = face2.ToString();


        }
    }
}
