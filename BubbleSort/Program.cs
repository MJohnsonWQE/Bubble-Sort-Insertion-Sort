using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedNums = new int[20] {55, 10, 23, 7, 18, 13, 2, 35, 0, 1, 16, 28, 14, 165, 9, 3, -1, 25, 36, 86};
            unsortedNums = BubbleSort(unsortedNums);
        }

        static int[] BubbleSort(int[] nums)
        {
            int numLength = nums.Length;
            int tempNum;
            int SwapNum = 0;
            for (int pass =  0; pass < numLength-1; pass++) //Outer loop keeps making passes until the list is sorted
            {
                if (SwapNum == numLength - pass) { break; } //Checks if the number of times no swaps were made in the inner loop is the same as the length of list minus the pass number
                SwapNum = 0;// If the two arent equal, the checker resets to 0 to check the next pass for no swaps 

                for (int i = 0; i < numLength - 1 - pass; i++) //Inner loop repeats checking and swapping until one pass is done
                {
                    if (nums[i] > nums[i + 1]) //Checks if the first number is bigger than the second number, if so the two are swapped around
                    {
                        tempNum = nums[i]; //Puts the first number into a temporary value
                        nums[i] = nums[i + 1]; //Swaps the second value to the place of the first value
                        nums[i + 1] = tempNum; //Puts the value of the temporary (First) value into the second value, completing the swap
                    }
                    else { SwapNum++; } //Console.WriteLine(SwapNum); Console.WriteLine(numLength - pass);}
                    if (SwapNum == numLength - pass) { break; } //Checks if the number of times no swaps were made in the inner loop is the same as the length of list minus the pass number
                }
                //Console.WriteLine("The order so far is: {0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19}", nums[0], nums[1], nums[2], nums[3], nums[4], nums[5], nums[6], nums[7], nums[8], nums[9], nums[10], nums[11], nums[12], nums[13], nums[14], nums[15], nums[16], nums[17], nums[18], nums[19]);
                //Console.ReadLine(); //(Testing Code)
            }
            Console.WriteLine("The sorted list is for the Bubble Sort is: [{0}]", string.Join(", ", nums));
            return nums;
        }

        static int[] InsertionSort(int[] nums)
        {
            int numLength = nums.Length;
            int tempNum = 0;
            for (int i = 1; i < numLength - 1; i++)
            {
                int n = i - 1;
            }
            return nums;
        }
    }
}
