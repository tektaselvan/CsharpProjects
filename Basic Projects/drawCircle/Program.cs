using System;

namespace drawCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daire çizmek için yarıçapı girin: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());

            Dairecizici dairecizici = new Dairecizici();
            dairecizici.DaireCiz(yaricap);
            Console.ReadLine();
        }
    }
}
