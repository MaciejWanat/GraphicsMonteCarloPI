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

        private void Form_Load(object sender, EventArgs e)
        {       
       
            this.DoubleBuffered = true;
            Paint += new PaintEventHandler(Form_Paint);

        }

        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Pen ellipsePen = new Pen(Color.Red, 5); //pen for ellipse            
            Pen rectanglePen = new Pen(Color.Black, 3); //pen for rectangle

            double piApproximation = 0;
            int total = 0;
            int numInCircle = 0;
            float x, y; // Coordinates of the random point.
            Int32 iterations = 0;
            int i = 0, side = 10;
            bool pass = false;

            while (pass == false)
            {
                try
                {
                    Console.WriteLine("How many iterations? (>0)");
                    iterations = Convert.ToInt32(Console.ReadLine());

                    if (iterations > 0) //check if iteration value is bigger than 0
                    {
                        Console.WriteLine("How long should be the rectangle side in the visualisation? (between 100-800, integer)");
                        side = Convert.ToInt32(Console.ReadLine());

                        if (side >= 100 && side <= 800) //check if the side size is legit
                            pass = true;
                    }

                }
                catch (Exception error)
                {
                    //the actuall message is written below if somethings gone wrong
                }

                if (pass == false)
                    Console.WriteLine("Please enter correct values!\n");
            }

            e.Graphics.DrawRectangle(rectanglePen, new Rectangle(0, 0, side, side));
            e.Graphics.DrawEllipse(ellipsePen, new Rectangle(0, 0, side, side));

            while (i < iterations)
            {                
                x = rnd.Next(0, side); // points in rectangle
                y = rnd.Next(0, side);

                e.Graphics.FillRectangle(Brushes.Black, x, y, 2, 2); //drawing point       
              
                if (x * x + y * y <= side * side) // Is the point in the circle?
                {
                    ++numInCircle;
                }
                ++total;

                i++;
            }

            piApproximation = 4.0 * ((double)numInCircle / (double)total);

            Console.WriteLine();

            Console.WriteLine("Pi calculated with {0} random points and {1} rectangle side size.", total, side);
            Console.WriteLine("Approximated Pi = {0}", piApproximation);
            Console.WriteLine("--------------------------------\n"); // separating calls
         
        }

        private void tnrAppTimer_Tick(object sender, EventArgs e)
        {
           this.Refresh();
        }
    }
}
