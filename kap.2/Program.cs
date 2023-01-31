using System;
namespace uppgift2
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur långt Elin hoppade");
            double elinhappade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hur långt Alma hoppade");
            double almahappade = Convert.ToDouble(Console.ReadLine());
            double skilland = elinhappade - almahappade;
            Console.WriteLine("Elin hoppade " + skilland + " meter mer än Alma");
        }
    }
}
      




