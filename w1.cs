using System;

namespace Development_6A
{
  class LinearSearch
  {
    public static int LinSearch(int[] array, int element)
    {
      //  This method accepts two variables, an int[] and a int.
      //  This method uses the linear search / sequential search.
      //  It returns the int if it's found in the array, otherwise
      //  it returns a -1.

      Console.WriteLine("\n----------------------\nWeek 1 - Linear / Sequential search\n----------------------\n");
      Console.WriteLine($"Length of array: {array.Length}\n");
      Console.WriteLine($"Int you're looking for: {element}\n");

      // Loop through the array
      for (int i = 0; i < array.Length; i++)
      {
        // If the element is the same as the int we're
        // looking for, return the int and exit the for loop
        if (array[i] == element)
        {
          Console.WriteLine($"- Element is on position {i}");
          return array[i];
        }
        Console.WriteLine($"- Element is not in position {i}");
      }

      // If the element is not found, return -1
      return -1;
    }
  }

  class BinarySearch
  {
    public static int BinSearch(int[] array, int element)
    {
      //  This method accepts two variables, an int[] and a int.
      //  This method uses the binary seach.
      //  It returns the int if it's found in the array, otherwise
      //  it returns a -1.

      Console.WriteLine("\n----------------------\nWeek 1 - Bineary search\n----------------------\n");
      Console.WriteLine($"Length of array: {array.Length}\n");
      Console.WriteLine($"Int you're looking for: {element}\n");

      // These are starting variables
      int low = 0;
      int high = array.Length - 1;

      for (int i = 0; low <= high; i++)
      {
        Console.WriteLine($"+++\n- This is iteration {i}");
        // This is the middle of the array and changes
        // with every loop
        int middle = (low + high) / 2;
        Console.WriteLine($"- Low is: {low}");
        Console.WriteLine($"- Middle is: {middle}");
        Console.WriteLine($"- Middle element is: {array[middle]}");
        Console.WriteLine($"- High is: {high}");

        // Check if the element is on the left side
        if (element < array[middle])
        {
          Console.WriteLine($"- Element is on the left side: {element} < {array[middle]}\n+++");
          // Change high to the middle and continue searching
          high = middle - 1;
        }
        // Check if the element is on the right side
        else if (element > array[middle])
        {
          Console.WriteLine($"- Element is on the right side: {element} > {array[middle]}\n+++");
          // Change low to the middle and continue searching
          low = middle + 1;
        }
        // The element is not on the left or right side, so it's
        // The middle itself
        else
        {
          Console.WriteLine($"- Element has been found!\n+++");
          // Return the element
          return array[middle];
        }
      }

      // Returns -1 if the element is not found in the array
      return -1;
    }
  }
}
