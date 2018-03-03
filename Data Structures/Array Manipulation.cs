using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        string[] tokens_n = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(tokens_n[0]);                       //Total size of array 
        int m = Convert.ToInt32(tokens_n[1]);                       //Number of instructions
        long [] test_array = new long[n+1];
        for(int a0 = 0; a0 < m; a0++){                              //Set of instructions
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);                   //Start Indicies
            int b = Convert.ToInt32(tokens_a[1]);                   //End Indicies
            long k = long.Parse(tokens_a[2]);                   //Value to Sum
            test_array[a] += k;
            if((b+1) <= n)
            {
                test_array[b+1] -= k;
            }
        //     for (long i = 0; i < n; i++)
        //     {
        //         if((i >= a-1) && (i <= b-1))
        //         {
        //             test_array[i] = test_array[i] + k;
        //         }
        //         if(max < test_array[i])
        //         {
        //             max = test_array[i];
        //         }
        //     }
            }
            long max = 0;
            long x =0;
            for(int i=0; i<n; i++)
            {
                x=x+test_array[i];
                if(max < x)
                {
                    max = x;
                }
            }
            Console.WriteLine(max);
    }
}
