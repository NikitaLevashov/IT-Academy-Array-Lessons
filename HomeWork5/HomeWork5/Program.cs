using System;
using System.Collections.Generic;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задача 1. В двумерном массиве в каждой строке все элементы, расположенные после максимального, заменить на 0.

            int _max = int.MinValue;
            
            Console.WriteLine($"Количесто строк в массиве: ");
            int.TryParse(Console.ReadLine(), out int a);

            Console.WriteLine($"Количесто столбцов в массиве: ");
            int.TryParse(Console.ReadLine(), out int b);

            Random rnd = new Random();
            int[,] array = new int[a, b];
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0, 100);
                }
            }

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }

                Console.WriteLine();
            }
          
            List<int> listMaxElements = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                _max = array[i, 0];

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > _max)
                    {
                        _max = array[i, j];
                    }
                }
               
                listMaxElements.Add(_max);

            }
           
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == listMaxElements[i] & array[i, j] != array[i, array.GetLength(1) - 1])
                    {
                        for (var k = j++; j < array.GetLength(1); j++)
                        {
                            array[i, j] = 0;
                        }

                    }
                }
            }

            Console.WriteLine();

            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }

                Console.WriteLine();
            }

            Console.ReadLine();

            //// Задачи 2. на String 

            //// Самое длинное слово в строке и количество слов в строке
            //// Вводится строка слов, разделенных пробелами.
            //// Найти самое длинное слово и вывести его на экран.
            //// Случай, когда самых длинных слов может быть несколько, не обрабатывать.


            //// Первый варинат не использовать какие либо методы из string
            //// Второй варинт решить задачу с использованием встроенных в .NET
            //// методов описанных в файле Strings.

            //// Первый вариант без Split
            
            int _maxindex = 0;
            int _maxcount = 0;
            Console.Write("Введите строку: ");
            string _str = Console.ReadLine();
            int _count = 1;
            foreach (char c in _str)
            {
                if (c == ' ')
                {
                    _count++;
                }
            }

            string[] words = new string[_count];

            int v = 0;
            for (int i = 0; i < _str.Length; i++)
            {
                if (_str[i] == ' ')
                {
                    v++;
                    words[v] += _str[i];
                }

                words[v] += _str[i];

            }

            for (int i = 0; i < _count; i++)
            {
                if (words[i].Length > _maxcount)
                {
                    _maxcount = words[i].Length;
                    _maxindex = i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Самое длинное слово без класса String:{words[_maxindex]}");
            Console.ResetColor();

            // Второй вариант со Split

            int _maxcount1 = 0;
            int _maxindex1 = 0;
            string _str1 = _str;
            string[] words1 = _str1.Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words1.Length; i++)
            {
                if (words1[i].Length > _maxcount1)
                {
                    _maxcount1 = words1[i].Length;
                    _maxindex1 = i;
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Самое длинное слово c классом String:{words1[_maxindex1]}");
            Console.ResetColor();
            Console.ReadLine();
        }

    }

}



