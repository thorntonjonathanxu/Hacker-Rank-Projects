using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int[][] arr = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++){
           string[] arr_temp = Console.ReadLine().Split(' ');
           arr[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }
        int largestsum = -63;           //Total of seven elements in an hourglass, max size of 9 for any given element
        int compare = -63;              //therefore -9*7 = -63 as the lowest possible value. 

        //Build an array for each hourglass. 
        int[] arr_hourglass = new int[7];

        for(int i = 0; i < 4; i++) //Vertical axis
        {
            for(int j = 0; j < 4; j++) //Horizontal Axis
            {
                arr_hourglass[0] = arr[i][j];
                arr_hourglass[1] = arr[i][j+1];
                arr_hourglass[2] = arr[i][j+2];
                arr_hourglass[3] = arr[i+1][j+1];
                arr_hourglass[4] = arr[i+2][j];
                arr_hourglass[5] = arr[i+2][j+1];
                arr_hourglass[6] = arr[i+2][j+2];

                compare = arr_hourglass.Sum();

                if(compare > largestsum)         //Finds the largest sum from each hourglass.
                {
                    largestsum = compare;
                }
                // Console.Write("Array {0}: {1} \n",i, compare); //Used to test sum for each given hourglass                
            }
        }
        // Console.WriteLine();                 //Lists output for test cases
        Console.WriteLine(largestsum);

    }
}
