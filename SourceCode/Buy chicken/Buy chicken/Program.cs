using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buy_chicken
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, Chick;
            for (a = 0; a < 20; a++)  
            {
                for (b = 0; b < 33; b++) 
                {
                    Chick = 100 - a - b;  
                    if (a * 5 + b * 3 + Chick / 3 == 100)  
                    {
                        Console.WriteLine("公鸡有:{0}只, 母鸡有:{1}, 小鸡有:{2}", a, b, Chick);
                    }
                }
            }
            Console.Read();
        }
    }
}
