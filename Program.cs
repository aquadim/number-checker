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
            Console.Write("Введите размерность массива: "); //Выводим текст для пользователя
            int n = int.Parse(Console.ReadLine()); //Вводим переменную
            var mas = new int[n]; //Добавляем массив
            for (int i = 0; i < n; i++) //Цикл 
            {
                Console.Write($"Введите число для: {i} "); //Выводим текст для пользователя
                mas[i] = int.Parse(Console.ReadLine()); //Ввод числа для массива

            }
            Console.Write("Введите число: "); //Выводим текст для пользователя
            int num = int.Parse(Console.ReadLine()); //Вводим переменную числа
			
            int output= Calculate( mas, num); // переменная обьявлена
            Console.WriteLine($"В массиве {output} раз встречается число"); // вывод числа

        }
    }
}
