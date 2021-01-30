using System;
using System.Linq;

namespace LongestSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            //string sequence = string.Empty;
            int bestCount = 0;
            int bestIndex = 0;

            for (int i = 0; i < numbers.Length; i++)  // 2 1 1 2 3 3 2 2 2 1
            {
                int currElement = numbers[i];
                int currCount = 1;

                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (currElement == numbers[j])
                    {
                        currCount++;
                       // sequence += numbers[i];
                    }
                    else
                    {
                        break;
                    } 
                }

                if (currCount > bestCount)
                {
                    bestCount = currCount;
                    bestIndex = i;
                }
            }
            string result = string.Empty;
            for (int i = 0; i < bestCount; i++)
            {
                result += numbers[bestIndex]+ " ";
            }
            Console.WriteLine(result.Trim());

        }
    }
}
