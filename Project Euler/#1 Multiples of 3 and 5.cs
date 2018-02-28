//Completed 02/28/2018


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine()); //Input: Number of Test Cases

        //To handle large numbers for given inputs, utilized long as data type.
        long sum = 0;
        long three = 0;
        long five = 0;
        long fifteen = 0;

        for(int a0 = 0; a0 < t; a0++){
            long n = long.Parse(Console.ReadLine()); //Integer to test the multiples of 3 and 5 that fit into that number
            
            //Find the total number of multiples in N for each given variable. 
            three = (n-1)/3;
            five = (n-1)/5;
            fifteen = (n-1)/15;     //Need to find all multiples of the product of 3 and 5 = 15 and exlcude from the final sum.


            //AP Method to solve for Multiples. O(1)
            //Sum all products of 3 and 5 and exlcude all multiples of 15.
            //For each multiple, take the product of the Multiple * (Total Possible Multiples) * (Total Possible Mutliples)/2
            sum = 3*(three*(three+1)/2)+5*(five*(five+1)/2)-15*(fifteen*(fifteen+1)/2);
            Console.WriteLine(sum);

            // Brute Force with Modulo. Timeout for extremely large numbers since O(n^2)
            // sum = 0;
            // for(int i = 0; i < n; i++)  
            // {
            //     if((i % 3 == 0) || (i % 5 == 0))
            //     {
            //         sum = sum + i;
            //     }       
            // }
            // Console.WriteLine(sum); 
        }
    }
}