using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpZadachi
{
    class Program
    {
        public static void Main()
        {
            int a = 1;
            int c;
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int b=1;
            while (2 + 2 == 4)
            {
                c = a + b;
                a = b;
                b = c;
                if (c >= A && c <= B) Console.Write(c + " ");
                else if (c > B) break;
            }
        }
    }
}
