/*Given the triangle of consecutive odd numbers:

             1
          3     5
       7     9    11
   13    15    17    19
21    23    25    27    29
...
Calculate the sum of the numbers in the nth row of this triangle (starting at index 1) e.g.:

rowSumOddNumbers(1); // 1
rowSumOddNumbers(2); // 3 + 5 = 8
*/

using System;
public static class Kata
{
  public static long rowSumOddNumbers(long n)
  {
    long start = 1;
    for (int i = 1; i < n; i++) 
      start += 2*(i);
    long line = start;
    for (int i = 1; i < n; i++) 
      start += line + (2*i);
    return start;
  }
}
