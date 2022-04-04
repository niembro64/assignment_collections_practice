using System;

namespace assignment_collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums;
            nums = new int[10];
            for (var i = 0; i < 10; i++)
            {
                nums[i] = i + 1;
                Console.Write($"{i} ");
            }
            

        }
    }
}
