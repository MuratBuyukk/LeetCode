using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121_BestTimeToBuyAndSellStock
{
    //You are given an array prices where prices[i] is the price of a given stock on the ith day.
    //You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
    //Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
    public class Program
    {
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            Console.WriteLine(MaxProfit(prices));
            Console.ReadLine();
        }

        public static int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
                return 0;
            int maxProfit = 0;
            int minValue = prices[0];
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < minValue)
                    minValue = prices[i];
                else
                {
                    int profit = prices[i] - minValue;
                    if (profit > maxProfit)
                    {
                        maxProfit = profit;
                    }
                }
            }
            return maxProfit;
        }
    }
}
