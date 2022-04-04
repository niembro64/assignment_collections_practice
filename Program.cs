using System;

namespace assignment_collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] nums;
            nums = new int[10];
            for (int i = 0; i < 10; i++)
            {
                nums[i] = i + 1;
                Console.Write($"{i} ");
            }

            /////////////////////////////////////////////
            Console.WriteLine();

            string[] names;
            names = new string[4];
            names[0] = "Tim";
            names[1] = "Martin";
            names[2] = "Nikki";
            names[3] = "Sara";

            for (int i = 0; i < 4; i++){
                Console.Write($"{i} {names[i]} \n");
            }

            /////////////////////////////////////////////
            Console.WriteLine();

            bool[] alt;
            alt = new bool[10];
            for (int i = 0; i < 10; i++){
                alt[i] = (i % 2 == 0 ? true : false);
                Console.Write($"{i} {alt[i]} \n");
            }





        }
    }
}
