using System;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen1 = new Pen();

            try
            {
                Pen pen2 = new Pen("z-grip", "black", 30, 15, false);
                pen1.Write();
                pen2.Write(1000);
                Console.WriteLine(pen2.InkLevel);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(pen1.InkLevel);
        }       
    }
}
