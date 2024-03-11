using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedNums = new int[10] {55, 10, 23, 7, 18, 13, 2, 35, 0, 1};
            unsortedNums = BubbleSort(unsortedNums);
        }

        static int[] BubbleSort(int[] nums)
        {
            int numLength = nums.Length;
            int tempNum = 0;
            for (int pass =  0; pass < numLength-1; pass++)
            {
                for (int i = 0; i < numLength - 1 - pass; i++)
                {
                    if (nums[i] > nums[i + 1])
                    {
                        tempNum = nums[i];
                        nums[i] = nums[i + 1];
                        nums[i + 1] = tempNum;
                    }
                }
                //Console.WriteLine("The order so far is: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", nums[0], nums[1], nums[2], nums[3], nums[4], nums[5], nums[6], nums[7], nums[8], nums[9]);
                //Console.ReadLine(); (Testing Code)
            }
            Console.WriteLine("The sorted list is: [{0}]", string.Join(", ", nums));
            return nums;
        }
    }
}
