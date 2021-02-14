using System;
using System.Collections.Generic;
using System.Linq;

namespace Youtube_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
           var min = MinCostClimbingStairs(new[] { 10, 15, 20, 25 });
        }

        public static int MinCostClimbingStairs(int[] cost)
        {
            int n = cost.Length;
            

            int twoStep = cost[0];
            int oneStep = cost[1];

            for (int i = 2; i < n; i++)
            {
                int currentStep = Math.Min(twoStep, oneStep) + cost[i];
                twoStep = oneStep;
                oneStep = currentStep;
            }

            return Math.Min(twoStep, oneStep);
        }
    }
}
