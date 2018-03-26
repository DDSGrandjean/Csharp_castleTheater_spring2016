//Dylan Grandjean
//Assignment 2 - Castle Theater
//Program designed to calculate daily sales and taxes of a theater.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CastleTheater
{
    class Main
    {
        static void Main(string[] args)
        {
            //Unchangeable tax rate
            const double TAXRATE = 0.07;
            
            //Number of seats sold today and price of said seats
            int balconySold = 75,
                boxSold = 50,
                generalSold = 100;

            double balconyPrice = 35.0,
                   boxPrice = 50.0,
                   generalPrice = 35.0;

            //Caluculate the amount of seats sold, the revenue and the total tax owed
            int totalTicketSold = balconySold + boxSold + generalSold;
            double totalRevenue = (balconyPrice * balconySold) + (boxPrice * boxSold) + (generalPrice * generalSold),
                   totalTax = totalRevenue * TAXRATE;

            //Display the results calculated hereabove
            Console.WriteLine("Total ticket sold:\t" + totalTicketSold +
                          "\nTotal revenue:\t\t$" + totalRevenue +
                          "\nTotal tax:\t\t$" + totalTax);
            Console.Read();
        }
    }
}
