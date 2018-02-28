using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);               //Maze Height
        int m = Convert.ToInt32(tokens_n[1]);               //Maze Length
        int k = Convert.ToInt32(tokens_n[2]);               //Number of Bidirectional Tunnels
        float probability = 0;
        string[,] maze = new string[n,m];
        for(int a0 = 0; a0 < n; a0++){                      
            string row = Console.ReadLine();                
            
            //Generates Maze Coordinates
            for(int i = 0; i < row.Length; i++)
            {
                maze[a0,i] = row.Substring(i,1);
                // Console.Write("{0}:{1} '{2}'", a0, i, maze[a0,i]); //Testing for position and coordinates
            }
            // Console.WriteLine();                         //Test Output
        }

        //Inputs the coordinates of the tunnel entraces and exits
        for(int a0 = 0; a0 < k; a0++){
            string[] tokens_i1 = Console.ReadLine().Split(' ');
            int i1 = Convert.ToInt32(tokens_i1[0]);             //Row for tunnel 1
            int j1 = Convert.ToInt32(tokens_i1[1]);             //Column for tunnel 1
            int i2 = Convert.ToInt32(tokens_i1[2]);             //Row for tunnel 2
            int j2 = Convert.ToInt32(tokens_i1[3]);             //Column for tunnel 2
            // Write Your Code Here
        }
        Write Your Code Here

        Output: Need to reassign probability based on 
        Console.WriteLine(probability);
    }

    // //Returns the value
    // public void tile_Check(int x, int y, string[] maze)
    // {


    // }
}
