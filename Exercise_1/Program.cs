using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
              int baht_1000, baht_500, baht_100, baht_50, baht_20, baht_10, baht_5, baht_1;
              int sum_1000, sum_500, sum_100, sum_50, sum_20, sum_10, sum_5, sum_1;
              int demo_1000, demo_500, demo_100, demo_50, demo_20, demo_10, demo_5, demo_1;
              bool status = true;
              int total, total_demo, change_input, change;
              Console.WriteLine("Please enter the number of banknotes.");
              Console.Write("1000 baht banknote : ");
              int.TryParse(Console.ReadLine(), out baht_1000);
              Console.Write("500 baht banknote : ");
              int.TryParse(Console.ReadLine(), out baht_500);
              Console.Write("100 baht banknote : ");
              int.TryParse(Console.ReadLine(), out baht_100);
              Console.Write("50 baht banknote : ");
              int.TryParse(Console.ReadLine(), out baht_50);
              Console.Write("20 baht banknote : ");
              int.TryParse(Console.ReadLine(), out baht_20);
              Console.Write("10 baht coin : ");
              int.TryParse(Console.ReadLine(), out baht_10);
              Console.Write("5 baht coin : ");
              int.TryParse(Console.ReadLine(), out baht_5);
              Console.Write("1 baht coin : ");
              int.TryParse(Console.ReadLine(), out baht_1);
              sum_1000 = baht_1000 * 1000;
              sum_500 = baht_500 * 500;
              sum_100 = baht_100 * 100;
              sum_50 = baht_50 * 50;
              sum_20 = baht_10 * 20;
              sum_10 = baht_10 * 10;
              sum_5 = baht_5 * 5;
              sum_1 = baht_1;
              total = sum_1000 + sum_500 + sum_100 + sum_50 + sum_20 + sum_10 + sum_5 + sum_1;
              Console.Write ("\n");
            
   
            while (total >= 0) {
                Console.Write("How much change do you need? : ");
                int.TryParse(Console.ReadLine(), out change_input);
                if (change_input > total)
                {
                    Console.WriteLine("Unable to change money due to not enough money");
                    Console.Write("\n");
                }
                else {
                    Console.Write("\n");
                    change = change_input;
                    demo_1000 = 0;
                    demo_500 = 0;
                    demo_100 = 0;
                    demo_50 = 0;
                    demo_20 = 0;
                    demo_10 = 0;
                    demo_5 = 0;
                    demo_1 = 0;
                    if (baht_1000 > 0)
                    {
                        for (int a = 1; a <= baht_1000; a++) {
                            if (change >= 1000) { 
                                change = change - 1000;
                                demo_1000++;
                            }
                        }
                    }
                    if (baht_500 > 0)
                    {
                        for (int b = 1; b <= baht_500; b++)
                        {
                            if (change >= 500)
                            {
                                change = change - 500;
                                demo_500++;
                            }
                        }
                    }
                    if (baht_100 > 0)
                    {
                        for (int c = 1; c <= baht_100; c++)
                        {
                            if (change >= 100)
                            {
                                change = change - 100;
                                demo_100++;
                            }
                        }
                    }
                    if (baht_50 > 0)
                    {
                        for (int d = 1; d <= baht_50; d++)
                        {
                            if (change >= 50)
                            {
                                change = change - 50;
                                demo_50++;
                            }
                        }
                    }
                    if (baht_20 > 0)
                    {
                        for (int e = 1; e <= baht_20; e++)
                        {
                            if (change >= 20)
                            {
                                change = change - 20;
                                demo_20++;
                            }
                        }
                    }
                    if (baht_10 > 0)
                    {
                        for (int f = 1; f <= baht_10; f++)
                        {
                            if (change >= 10)
                            {
                                change = change - 10;
                                demo_10++;
                            }
                        }
                    }
                    if (baht_5 > 0)
                    {
                        for (int g = 1; g <= baht_1000; g++)
                        {
                            if (change >= 5)
                            {
                                change = change - 5;
                                demo_5++;
                            }
                        }
                    }
                    if (baht_1 > 0)
                    {
                        for (int h = 1; h <= baht_1; h++)
                        {
                            if (change >= 1)
                            {
                                change = change - 1;
                                demo_1++;
                            }
                        }
                    }

                    if (change > 0)
                    {
                        Console.WriteLine("Unable to change money because there are no scraps.");
                        Console.Write("\n");
                    }
                    else {
                        baht_1000 = baht_1000 - demo_1000;
                        baht_500 = baht_500 - demo_500;
                        baht_100 = baht_100 - demo_100;
                        baht_50 = baht_50 - demo_50;
                        baht_20 = baht_20 - demo_20;
                        baht_10 = baht_10 - demo_10;
                        baht_5 = baht_5 - demo_50;
                        baht_1 = baht_1 - demo_1;
                        total = total - change_input;
                        Console.WriteLine("Want to change {0} baht.", change_input);
                        Console.WriteLine("Use a 1000 baht banknote : {0} balance {1}", demo_1000, baht_1000);
                        Console.WriteLine("Use a 500 baht banknote : {0} balance {1}", demo_500, baht_500);
                        Console.WriteLine("Use a 100 baht banknote : {0} balance {1}", demo_100, baht_100);
                        Console.WriteLine("Use a 50 baht banknote : {0} balance {1}", demo_50, baht_50);
                        Console.WriteLine("Use a 20 baht banknote : {0} balance {1}", demo_20, baht_20);
                        Console.WriteLine("Use a 10 baht coin : {0} balance {1}", demo_10, baht_10);
                        Console.WriteLine("Use a 5 baht coin : {0} balance {1}", demo_5, baht_5);
                        Console.WriteLine("Use a 1 baht coin : {0} balance {1}", demo_1, baht_1);
                        Console.Write("\n");

                    }
                    
                }
               
            }

            Console.ReadKey();
            


        }
    }
}
