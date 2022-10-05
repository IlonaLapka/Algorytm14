using System;
using System.Collections.Generic;

namespace Algorytm14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int> { 2, 6, 1, 10, 3, 4, 7, 9, 8, 5 };
            Console.WriteLine("Przykładowe drezwo binarne ma postać:");
            BinaryTree tree = new BinaryTree(values);
            tree.PrintInDepth(tree, 0);
            int x, indexX, a, y, result;
            do
            {
                Console.WriteLine("Podaj wierzchołek, którego kuzynów chcesz znaleźć: ");
                x = Int32.Parse(Console.ReadLine());
                indexX = values.IndexOf(x);
                if (indexX == 0)
                {
                    Console.WriteLine("Podany wierzchołek nie ma kuzynów.");
                }
                else if(indexX == -1)
                {
                    Console.WriteLine("Podanego wierzchołka nie ma w drzewie.");
                }
                else
                {
                    a = 0;
                    y = 1;
                    do
                    {
                        a++;
                        result = Convert.ToInt32(Math.Pow(2, a));
                        y += result;
                    } while (y < indexX + 1);
                    Console.Write("Jego kuzyni to: ");
                    for (int i = y - result; i < y && i < values.Count; i++)
                    {
                        if (i == indexX) continue;
                        Console.Write(values[i] + " ");
                    }
                    Console.WriteLine("\n");
                }

            } while (true);
        }
    }
}
