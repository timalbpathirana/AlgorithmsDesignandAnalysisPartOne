using System;
using Algorithms__Design_and_Analysis__Part_One.Properties.Algorithms;

namespace Algorithms__Design_and_Analysis__Part_One
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            var algoProcessor = new AlgoProcessor();
            var tempArray = new int[]{3,67,2,4,12,6,8,4,2,56,8,3,57,4,89,79,56,4,46};

            algoProcessor.SetStrategy(AlgoType.MergeSortAlgo);
            algoProcessor.Calculate(tempArray);
            
            
            
        }
    }
}