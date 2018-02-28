using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int countingValleys(int n, string s) {
        // Complete this function
        int valleys = 0;
        int location = 0;
        
        //If U then +1, If D then -1
        for(int i = 0; i < s.Length; i++)
        {
            //Find all instances of when values are a step up.
            if(s.Substring(i,1) =='U'.ToString())
            {
                //If one step below sealevel, then this must be a valley
                if(location == -1)  valleys++;
                location++;
            }
            //It's a step down then decrement by one
            else  location--;
        }
        return valleys;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine()); //Total number of steps
        string s = Console.ReadLine();               //Step type, U = Step Up; D = Step Down
        int result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}
