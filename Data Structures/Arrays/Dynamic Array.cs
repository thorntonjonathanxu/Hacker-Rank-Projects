//In progress 03/01/2018
//List outputs break with long formatting.


using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] arr_input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_input,Int32.Parse);
        int n = arr[0];
        int q = arr[1];
        int lastAnswer = 0;
        List <int> seq0 = new List<int>();
        List <int> seq1 = new List<int>();

        for(int arr_i = 0; arr_i < q; arr_i++)
        {
            arr_input = Console.ReadLine().Split(' ');
            arr = Array.ConvertAll(arr_input,Int32.Parse);
            if(arr[0]==1)
            {
                if((arr[1] ^ lastAnswer) % n == 0)
                {
                    seq0.Add(arr[2]);
                }
                else
                {
                    seq1.Add(arr[2]);
                }
            }
            if(arr[0]== 2)
            {
                if((arr[1] ^ lastAnswer) % n == 0)
                {                    
                    lastAnswer = seq0[(arr[2] % seq0.Count)];                  
                    Console.WriteLine(seq0[lastAnswer]);
                }
                else
                {
                    lastAnswer = seq1[(arr[2] % seq1.Count)];
                    Console.WriteLine(seq1[lastAnswer]);
                }
            }
        }
    }
}