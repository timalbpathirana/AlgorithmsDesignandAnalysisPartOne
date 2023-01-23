using System;
using System.Collections.Generic;

namespace Algorithms__Design_and_Analysis__Part_One.Properties.Algorithms
{
    public class AlgoProcessor
    {
        private IAlgorithmsStrategy _algorithmsStrategy;

        public void SetStrategy(AlgoType algoType){
            switch (algoType)
            {
                case AlgoType.MergeSortAlgo:
                    _algorithmsStrategy = new MergeSortAlgorithm();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(algoType), algoType, null);
            }
        }

        public void Calculate(int [] arrayToSort)
        {
            _algorithmsStrategy.SortNumbers(arrayToSort);
        }
    }
}