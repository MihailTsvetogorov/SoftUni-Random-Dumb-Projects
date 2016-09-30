using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main()
        {
            int BD = int.Parse(Console.ReadLine());
            int PatiBrat = 0;//Kolko pati si e vzel brat i!
            int Money = 0;
            int Toys = 0;
            double PriceToy = double.Parse(Console.ReadLine());
            double PriceMachine = double.Parse(Console.ReadLine());
            for(int i=1;i<=BD;i++)
            {
                if (i % 2 == 1) Toys++;
                if (i % 2 == 0)
                {
                    Money += 10;
                    PatiBrat++;
                } 
            }
            double SabraniPari = (Money - PatiBrat) + (PriceToy * Toys);
            if (SabraniPari>PriceMachine)
            {
                double Ostavashti = SabraniPari - PriceMachine;
                Console.WriteLine("Yes! " + Ostavashti);
            }
            else
            {
                double Nujni = PriceMachine - SabraniPari;
                Console.WriteLine("No! " + Nujni);
            }
        }
    }
}
