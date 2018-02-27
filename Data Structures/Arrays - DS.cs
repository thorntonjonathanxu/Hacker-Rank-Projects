using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        // while(n != -1)                                   //Inital Method Brute force by stepping backwards through list
        // {
        //     Console.Write(arr[n-1] + " ");
        //     n--;
        // }
        // Console.WriteLine();

        Array.Reverse(arr);                                 
        Console.WriteLine("{0}", string.Join(" ", arr));
        
    }
}
