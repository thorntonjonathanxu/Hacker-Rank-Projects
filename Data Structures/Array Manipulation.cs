using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);                       //Total size of array 
        int m = Convert.ToInt32(tokens_n[1]);                       //Number of instructions
        int [] test_array = new int[n];
        int max = 0;
        for(int a0 = 0; a0 < m; a0++){                              //Set of instructions
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);                   //Start Indicies
            int b = Convert.ToInt32(tokens_a[1]);                   //End Indicies
            int k = Convert.ToInt32(tokens_a[2]);                   //Value to Sum
            for (int i = 0; i < n; i++)
            {
                if((i >= a-1) && (i <= b-1))
                {
                    test_array[i] = test_array[i] + k;
                    for(int j = 0; j < test_array.Length; j++)
                    {
                        Console.Write("{0}, ",test_array[j]);
                    }
                }
            }
            Console.WriteLine();

        }



    }

}
