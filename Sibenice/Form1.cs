using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sibenice
{


    public partial class Form1 : Form
    {

        List<string> WordsList = new List<string>
        {
        {"int"},
        {"float"},
        {"string"},
        {"bool"},
        {"char"},
        {"double"},
        {"decimal"},
        {"array"},
        {"class"},
        {"object"},
        {"method"},
        {"namespace"},
        {"interface"},
        {"void"},
        {"public"},
        {"private"},
        {"protected"},
        {"static"},
        {"for"},
        {"while"}
        };
        List<char> word = new List<char>();

        Random rnd = new Random();

        Pen thickPen = new Pen(Color.Black, 5);
        Pen thickPenBrown = new Pen(Color.Brown, 16);

        char[] WordArray;

        public int random;
        int FailedCount = 0;
        int count   = 0;
        int maxAllowedFailedAttempts = 7;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(ClientSize.Width / 2 - label1.Width / 2, 10);
            random = rnd.Next(0, 20);
            for (int i = 0; i < WordsList[random].Length; i++)
            {
                word.Add(WordsList[random][i]);
            }

            WordArray = new char[word.Count]; 

            for (int i = 0; i < word.Count; i++)
            {
                WordArray[i] = '?';
            }

            foreach (char ch in WordArray)
            {
                label1.Text += ch;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            kp.FillRectangle(Brushes.LightGray, 0, 0, ClientSize.Width, 30);
            kp.FillRectangle(Brushes.LightSkyBlue, 0, 30, ClientSize.Width, ClientSize.Height - 200);
            kp.FillRectangle(Brushes.LightGreen, 0, ClientSize.Height - 200, ClientSize.Width, ClientSize.Height);

            if (FailedCount>=1)
            {
                kp.FillRectangle(Brushes.Brown, 200, 50, 20, ClientSize.Height - 200);
            }

            if (FailedCount >= 2)
            {
                kp.FillRectangle(Brushes.Brown, 200, 50, 200, 20);
            }

            if (FailedCount >= 3)
            {
                kp.DrawLine(thickPenBrown, 210 , 130, 285, 55);
                
            }

            if (FailedCount >= 4)
            {
                kp.FillRectangle(Brushes.Brown, 380, 60, 10, 50);
            }


            if (FailedCount >= 5)
            {
                kp.FillEllipse(Brushes.Yellow, 360, 110, 50,50);
                kp.DrawEllipse(thickPen, 360, 110, 50, 50);
            }

            if (FailedCount >= 6)
            {
                kp.DrawLine(thickPen, 385, 160, 385, 260);
            }

            if (FailedCount >= 7)
            {
                kp.DrawLine(thickPen, 385, 250, 385+50, 250+50);
                kp.DrawLine(thickPen, 385, 250, 385 - 50, 250 + 50);
                kp.DrawLine(thickPen, 385, 200, 385 + 50, 200 + 50);
                kp.DrawLine(thickPen, 385, 200, 385 - 50, 200 + 50);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                char currentLetter = char.ToLower((char)e.KeyValue);
                if (word.Contains(currentLetter))
                {
                    count = 0;
                    foreach (char x in word)
                    {
                        if (x == currentLetter)
                        {
                            label1.Text = null;
                            WordArray[count] = x;
                        }
                        count++;
                    }
                }
                else
                {
                    label1.Text = null;
                    FailedCount++;
                    Refresh();
                }
                foreach (char ch in WordArray)
                {
                    label1.Text += ch;
                }

            if (GameWon())
            {
                Refresh();
                MessageBox.Show("Congratulations! You've won!");
                Close();
            }
            else if (GameLost())
            {
                Refresh();
                MessageBox.Show("GAME OVER." + "\nFailed:" + FailedCount);
                Close();
            }
        }
        

        private bool GameWon()
        {
            return !WordArray.Contains('?');
        }

        private bool GameLost()
        {
            return FailedCount >= maxAllowedFailedAttempts;
        }


        // USELESS SO FAR
        //---------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!---------------------
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }
        //---------------!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!---------------------
    }
}