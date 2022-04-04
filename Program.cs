using System;
using System.Collections.Generic;

namespace assignment_collections_practice
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine();

      int[] nums;
      nums = new int[10];
      for (int i = 0; i < 10; i++)
      {
        nums[i] = i + 1;
        Console.Write($"{i} ");
      }
      Console.WriteLine();

      /////////////////////////////////////////////
      Console.WriteLine();

      string[] names;
      names = new string[4];
      names[0] = "Tim";
      names[1] = "Martin";
      names[2] = "Nikki";
      names[3] = "Sara";

      for (int i = 0; i < 4; i++)
      {
        Console.Write($"{i} {names[i]} \n");
      }

      /////////////////////////////////////////////
      Console.WriteLine();

      bool[] alt;
      alt = new bool[10];
      for (int i = 0; i < 10; i++)
      {
        alt[i] = (i % 2 == 0 ? true : false);
        Console.Write($"{i} {alt[i]} \n");
      }


      /////////////////////////////////////////////
      Console.WriteLine();
      List<string> flavors = new List<string>();

      flavors.Add("Chocolate");
      flavors.Add("Vanilla");
      flavors.Add("Frag");
      flavors.Add("Pist");
      flavors.Add("Vermicello");


      for (int i = 0; i < flavors.Count; i++)
      {
        Console.Write($"{i} {flavors[i]} \n");

      }
      Console.Write($"There are : {flavors.Count} Flavors \n");
      Console.Write($"Third Flavor : {flavors[2]} \n");
      flavors.RemoveAt(2);
      Console.Write($"There are : {flavors.Count} Flavors \n");
      Console.Write($"Third Flavor : {flavors[2]} \n");

      /////////////////////////////////////////////
      Console.WriteLine();

      // each key is a name from your names array
      // each value is a randomly elected flavor from your flavors list.




    }
  }
}
