using System.Runtime.CompilerServices;

namespace kvadr_rovnice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // načti rovnici 
            //GetCoef(int a, int b, int c)
        }

        //public void GetCoef(int a, int b, int c)
        //{
        //    this.a = a;
        //    this.b = b;
        //    this.c = c;
        //}

        public double D(int a, int b, int c)
        { 
            double disc = Math.Pow(b, 2) - (4 * a * c);

            Console.WriteLine(disc);
            return disc;
        }

        public int SolutionCount(int d)
        {
            if (d < 0)
            {
                return 0;
            }
            else if(d == 0)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}