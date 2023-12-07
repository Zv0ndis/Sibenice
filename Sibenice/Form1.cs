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
        List<string> Slova = new List<string>
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

        List<char> slovo = new List<char>();
        Random rnd = new Random();
        public int random;
        char Key;
        int FailedCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(ClientSize.Width / 2 - label1.Width / 2, 10);
            random = rnd.Next(1, 21);
            for (int i = 0; i < Slova[random].Length; i++)
            {
                slovo.Add(Slova[random][i]);
            }

            slovo = slovo.Select(x => char.ToUpper(x)).ToList();
                
            for (int i = 0; i < slovo.Count; i++)
            {
                label1.Text += "?";
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            kp.FillRectangle(Brushes.LightGray, 0, 0, ClientSize.Width, 30);
            kp.FillRectangle(Brushes.LightSkyBlue, 0, 30, ClientSize.Width, ClientSize.Height - 200);
            kp.FillRectangle(Brushes.LightGreen, 0, ClientSize.Height - 200, ClientSize.Width, ClientSize.Height);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            char currentLetter = 'a';
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