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

        int[][] arr_queries = new int[6][];
        for(int arr_i = 0; arr_i < 6; arr_i++)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            arr_queries[arr_i] = Array.ConvertAll(arr_temp,Int32.Parse);
        }

        int lastAnswer = 0;




        Console.WriteLine("N: {0} Q: {1}", n, q);
    }
    
    public void query_One(int n, int x, int lastAnswer)
    {
        
    }
}