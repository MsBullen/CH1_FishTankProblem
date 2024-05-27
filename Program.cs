using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH1_FishTankProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {// challenge 1: fish tank volume problem (*)
         // program to calculate the volume of a fish tank
         // Main program
            
                Console.Write("Enter Length: ");
                double Length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Depth: ");
                double Depth = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Height: ");
                double Height = Convert.ToDouble(Console.ReadLine());
                double Litres = (Length * Depth * Height) / 1000;
                Console.WriteLine("A " + Length + " x " + Depth + " x " + Height + " tank is " + Litres + " litres");
        }
    }
}
