//Ali Belkasri CIS 297

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string filingStatus;
            double income, taxRate, grossIncome, taxOwed, adjustedIncome;
            char contStatus = 'y';

            while(contStatus == 'y')
            {
            //Console.WriteLine("Please enter your filing status");
            //filingStatus = Console.ReadLine();

            Console.WriteLine("Please enter your annual income");
            income = Convert.ToInt32(Console.ReadLine());

            if (income > 0)
            {
                    taxRate = 0.10;
                    taxOwed = income * taxRate;
                    grossIncome = income - taxOwed;
                    Console.WriteLine("Taxes at 10%:" + taxOwed);
                    if (income > 9326)
                    {
                        taxRate = 0.15;
                        taxOwed = (income - 9325) * taxRate;
                        grossIncome = grossIncome - taxOwed;
                        Console.WriteLine("Taxes at 15%:" + taxOwed);
                        if (income > 37951)
                        {
                            taxRate = 0.25;
                            taxOwed = (income - 37950) * taxRate;
                            grossIncome = grossIncome - taxOwed;
                            Console.WriteLine("Taxes at 25%:" + taxOwed);
                            if (income > 91901)
                            {
                                taxRate = 0.28;
                                taxOwed = (income - 91900) * taxRate;
                                grossIncome = grossIncome - taxOwed;
                                Console.WriteLine("Taxes at 28%:" + taxOwed);
                                if (income > 191651)
                                {
                                    taxRate = 0.33;
                                    taxOwed = (income - 191650) * taxRate;
                                    grossIncome = grossIncome - taxOwed;
                                    Console.WriteLine("Taxes at 33%:" + taxOwed);
                                    if (income > 416701)
                                    {
                                        taxRate = 0.35;
                                        taxOwed = (income - 191650) * taxRate;
                                        grossIncome = grossIncome - taxOwed;
                                        Console.WriteLine("Taxes at 35%:" + taxOwed);
                                        if (income > 418401)
                                        {
                                            taxRate = 0.396;
                                            taxOwed = (income - 191650) * taxRate;
                                            grossIncome = grossIncome - taxOwed;
                                            Console.WriteLine("Taxes at 39.6%:" + taxOwed);
                                        }
                                    }
                                }
                            }
                        }
                    }
             }
            else
            {
                Console.WriteLine("Please enter a valid income");
                grossIncome = 0;
                taxRate = 0;
            }
            
            Console.WriteLine("Total income is: " + grossIncome);

            adjustedIncome = (grossIncome * taxRate);

            grossIncome = ((income - grossIncome) / 100);
            Console.WriteLine("Tax percentage of gross income: " + grossIncome);

            Console.WriteLine("Tax percentage of adjusted income: " + adjustedIncome);

            Console.WriteLine("Would you like to continue? y/n");
            contStatus = Console.ReadKey().KeyChar;
            
            }
        }
    }
}
