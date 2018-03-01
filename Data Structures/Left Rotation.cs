//Completed on 03/01/2018


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] leftRotation(int[] a, int d) {
        // Complete this function
        var left_elements = a.Skip(0).Take(d).ToArray();                //Builds an array of all elements that need to be rotated
        var right_elements = a.Skip(d).Take(a.Length-d).ToArray();      //Takes the remainder of the list.
        
        var rotated_result = new int [a.Length];
        right_elements.CopyTo(rotated_result,0);                        //Copies elements from the right then left into a new list.
        left_elements.CopyTo(rotated_result,a.Length-d);
        return rotated_result;
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);                   //size of the array
        int d = Convert.ToInt32(tokens_n[1]);                   //number of rotations
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int[] result = leftRotation(a, d);
        Console.WriteLine(String.Join(" ", result));


    }
}
