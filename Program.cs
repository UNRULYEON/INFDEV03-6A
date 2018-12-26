using System;

namespace Development_6A
{
  class Program
  {
    static void Main(string[] args)
    {

			// Week 1 - Linear / Sequential search
			int[] linearSearchArr = new int[] {1, 4, 85, 4, 13, 2, 52, 3, 8};
			Console.WriteLine($"Returned: {LinearSearch.LinSearch(linearSearchArr, 8)}");

			// Week 1 - Bineary search
			int[] binarySearchArr = new int[] {3, 5, 8, 11, 23, 33, 57, 87, 122, 134, 267, 455};
			Console.WriteLine($"Returned: {BinarySearch.BinSearch(binarySearchArr, 23)}");
    }
  }
}
