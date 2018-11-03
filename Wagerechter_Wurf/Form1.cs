using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wagerechter_Wurf
{
    public partial class Form1 : Form
    {
        int positionX;
        int positionY;
        int g = 10;
       int s0;
        int t = 0;
        int v = 30;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
            positionX = berechneX();
            positionY = berechneY();
            
            xErgebniss.Text = Convert.ToString(positionX);
            yErgebniss.Text = Convert.ToString(positionY);
            Ball.Location = new Point(positionX, positionY);
            Label newBall = new Label();
            newBall.Size = new Size(5, 5);
            newBall.BackColor = Color.Yellow;
           // newBall.Image = 
            newBall.Enabled = true;
            newBall.Location = new Point(positionX, positionY);

            newBall.Show();
           


            field.Controls.Add(newBall);
            if(newBall.Location.Y >= field.Height)
            {
                timer.Stop();
                t = 0;
            }
            t = t + 1;
        }

        private int berechneX()
        {
           int x = v * t;
            return x;
        }

        private int berechneY()
        {
            
          
            double yKomma = s0 + 0.5 * g * (t * t);
         
            int y = Convert.ToInt32(yKomma);
            return y;
        }

        private void Start_Click(object sender, EventArgs e)
        {
            
            if(wurf.Value > 0)
            {
                v = Convert.ToInt32(wurf.Value);
                timer.Start();
            }
            else
            {
                wurf.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s0 = Ball.Location.Y;
        }
    }
}
