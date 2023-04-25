using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_checker
{
    internal class Program
    {
        static int Calculate(int[] Array, int n)
        { int output = 0;
          foreach(int m in Array)
            {
                if(m == n) 
                {
                    output++;
                }
            }
          return output;
        }

        static void Main(string[] args)
        {
        }
    }
}
