using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sibenice
{


    public partial class Form1 : Form
    {
        Dictionary<int, string> Slova = new Dictionary<int, string>
        {
        {1, "int"},
        {2, "float"},
        {3, "string"},
        {4, "bool"},
        {5, "char"},
        {6, "double"},
        {7, "decimal"},
        {8, "array"},
        {9, "class"},
        {10, "object"},
        {11, "method"},
        {12, "namespace"},
        {13, "interface"},
        {14, "void"},
        {15, "public"},
        {16, "private"},
        {17, "protected"},
        {18, "static"},
        {19, "for"},
        {20, "while"}
        };

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics kp = e.Graphics;

            kp.FillRectangle(Brushes.LightGray, 0, 0, ClientSize.Width, 30);
            kp.FillRectangle(Brushes.LightSkyBlue,0,30,ClientSize.Width,ClientSize.Height-200);
            kp.FillRectangle(Brushes.LightGreen, 0, ClientSize.Height-200, ClientSize.Width, ClientSize.Height);
        }
    }
}
