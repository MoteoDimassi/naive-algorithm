using System;
using System.Collections.Generic;

namespace Наивный_Алгоритм
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "vaaaaa";
            string find = "aaa";
            List<int> index = simpleSearch(str, find);
            if (index.Count >0)
            {
                Console.WriteLine("Подстрока содержится в строке " + index.Count+" раз");
                foreach(var item in index)
                {
                    Console.WriteLine("На " + (item + 1) + " месте");
                }
            }
            else
            {
                Console.WriteLine("Такой подстроки нет! :(");
            }

        }
        public static List<int> simpleSearch(string where, string what)
        {
            List<int> enter = new List<int>();
            int n = where.Length;
            int m = what.Length;
            bool flag = false;
            int count = 0;

            for (int i = 0; i < n - m; i++) 
            {
                for (int j = 0; j < m; j++)
                {
                    count++;
                    if (where[i + j] == what[j])
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;

                        break;
                    }
                }
                if (flag)
                {
                    enter.Add(i);
                }
                
            }
            Console.WriteLine(count + " - количество вхождений в циклы");
            return enter;
        }
    }
 }

