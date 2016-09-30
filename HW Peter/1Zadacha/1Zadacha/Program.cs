using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Ot1DoNPrez3
    {
        static void Main()
        {
            int num = 1;
            int N = int.Parse(Console.ReadLine());
            for (int i=1;i<=N-1;i++)
            {
                Console.WriteLine(num);
                num = (num * 2) + 1;
            }
           
        }
    }
}