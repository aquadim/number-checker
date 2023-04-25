using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_checker
{
    internal class Program
    {
        // Функция вычисления ответа
        static int Calculate(int[] Array, int n)
        { int output = 0; // Сколько раз n встречается в Array
          foreach(int m in Array) // Сверяем все элементы с n
            {
                if(m == n) 
                {
                    // Элемент равен n
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
