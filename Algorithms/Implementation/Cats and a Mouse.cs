//Completed 02/28/2018

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {


    /*
     * Complete the catAndMouse function below.
     */
    static string catAndMouse(int x, int y, int z) {
        /*
         * Write your code here.
        */
        string success_Cat = "";

        //If Cats are equidistant from the mouse then return Mouse C
        if(Math.Abs(x-z) == Math.Abs(y-z))
        {
            success_Cat = "Mouse C";
        }       
        //Cat A is closer...
        if(Math.Abs(x-z) < Math.Abs(y-z))
        {
            success_Cat = "Cat A";
        }
        
        //Cat B is closer...
        if(Math.Abs(x-z) > Math.Abs(y-z))
        {
            success_Cat = "Cat B";
        }       
        return success_Cat;
    }


    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            string[] xyz = Console.ReadLine().Split(' ');

            int x = Convert.ToInt32(xyz[0]);                //Cat A Location

            int y = Convert.ToInt32(xyz[1]);                //Cat B Location

            int z = Convert.ToInt32(xyz[2]);                //Mouse C Location

            string result = catAndMouse(x, y, z);      
            tw.WriteLine(result);
        }
        tw.Flush();
        tw.Close();
    }
}
