using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GraphicsMonteCarloPI
{
    public partial class Form : System.Windows.Forms.Form
    {
        Random rnd = new Random();
        List<KeyValuePair<float, float>> list = new List<KeyValuePair<float, float>>();

        public Form()
        {
            InitializeComponent();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {       
       
            this.DoubleBuffered = true;

            Paint += new PaintEventHandler(Form1_Paint);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen ellipsePen = new Pen(Color.Red, 2); //pen

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, 200, 200));
            e.Graphics.DrawEllipse(ellipsePen, new Rectangle(0, 0, 200, 200));

            double piApproximation = 0;
            int total = 0;
            int numInCircle = 0;
            float x, y; // Coordinates of the random point.
            float xG, yG; // Graphics scale
            int iterations = 0;
            int i = 0;

            // Generate random points until our approximation within
            // the desired tolerance.
            //while (Math.Abs(Math.PI - piApproximation) > tolerance)
            Console.WriteLine("How many iterations?");

            iterations = Convert.ToInt32(Console.ReadLine());

            while (i < iterations)
            {
                x = rnd.Next(-100, 100);
                y = rnd.Next(-100, 100);

                xG = x + 100;
                yG = y + 100;

                //    e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)xG, (int)yG, 1, 1));
                /*
                    list.Add(new KeyValuePair<float, float>(xG, yG));

                    foreach(KeyValuePair<float, float> element in list)
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)element.Value, (int)element.Key, 1, 1));
                */
                //e.Graphics.DrawRectangle(Pens.Black, new Rectangle((int)xG, (int)yG, 1, 1));

                e.Graphics.FillRectangle(Brushes.Black, xG, yG, 1, 1); //drawing pixel          

                x = x / 100;
                y = y / 100;

                if (x * x + y * y <= 1.0) // Is the point in the circle?
                {
                    ++numInCircle;
                }
                ++total;

                i++;
            
            }

            piApproximation = 4.0 * ((double)numInCircle / (double)total);

            Console.WriteLine();

            Console.WriteLine("Pi calculated with {0} random points.", total);
            Console.WriteLine("Approximated Pi = {0}", piApproximation);
         
        }

        private void tnrAppTimer_Tick(object sender, EventArgs e)
        {
           //this.Refresh();
        }
    }
}
