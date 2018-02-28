//In-progress


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int formingMagicSquare(int[][] s) {
        // Complete this function
        int offset = 0;
        for(int i = 0; i < 3; i++)
        {
            int sum = 0;
            for(int j = 0; j < 3; j++)
            {                  
                sum = sum + s[i][j];
            }
            offset = offset + Math.Abs(sum-15);
        }
        return offset;
    }

    static void Main(String[] args) {
        int[][] s = new int[3][];
        for(int s_i = 0; s_i < 3; s_i++){
           string[] s_temp = Console.ReadLine().Split(' ');
           s[s_i] = Array.ConvertAll(s_temp,Int32.Parse);
        }
        int result = formingMagicSquare(s);
        Console.WriteLine(result);
    }
}
