using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int age , toy ;
            float machine;
            int USD = 0, sum_of_toyP = 0 , increment = 10;
            int oddCount = 0;
            float total = 0, remaining;

            Console.Write("Enter Lily's Age : ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter price of each toy : ");
            toy = int.Parse(Console.ReadLine());
            Console.Write("Enter Washihng Machine's price : ");
            machine = float.Parse(Console.ReadLine());

            for(int i=1;i<=age;i++)
            {
                if(i %2 != 0)
                {
                    oddCount++;
                    sum_of_toyP = sum_of_toyP + toy;
                    
                }
                else
                {
                    USD = USD + increment;
                    increment = increment + 10;
                }
            }

            total = sum_of_toyP + USD - oddCount;
            /*Console.WriteLine(sum_of_toyP);
            Console.WriteLine(USD);
            Console.WriteLine(oddCount);*/
            remaining = total - machine;

            if(remaining >= 0)
            {
                Console.Write("YES! " + remaining);
            }
            else
            {
                remaining = (-1)*(remaining);
                Console.Write("NO! " + remaining);
            }
            Console.Read();
        }
    }
}
