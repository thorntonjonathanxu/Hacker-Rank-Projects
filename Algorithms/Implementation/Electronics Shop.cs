//Completed 02/28/2018


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int getMoneySpent(int[] keyboards, int[] drives, int s){
        //Initialize moneySpent to -1 if a purchase for both devices can't be made.
        int moneySpent = -1;
        int sum = 0;
        
        //Checks the sum between each variable from both lists. Runs at O(m*n)
        for(int i = 0; i < keyboards.Length; i++)
        {
            for(int j = 0; j < drives.Length; j++)
            {
                sum = keyboards[i]+drives[j];
                //If the value is below the maximum amount of money and is larger than the previous sum then modify current moneySpent.
                if((sum <= s) && (moneySpent <= sum))   
                {
                    moneySpent = sum;
                }
            }
        }
        return moneySpent;
    }

    static void Main(String[] args) {
        string[] tokens_s = Console.ReadLine().Split(' ');
        int s = Convert.ToInt32(tokens_s[0]);   //Amount of money Monica has
        int n = Convert.ToInt32(tokens_s[1]);   //Number of Keyboards  
        int m = Convert.ToInt32(tokens_s[2]);   //Number of USB Drives
        string[] keyboards_temp = Console.ReadLine().Split(' ');
        int[] keyboards = Array.ConvertAll(keyboards_temp,Int32.Parse);     //Price of Keyboards
        string[] drives_temp = Console.ReadLine().Split(' ');
        int[] drives = Array.ConvertAll(drives_temp,Int32.Parse);           //Price of USB Drives
        //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
        int moneySpent = getMoneySpent(keyboards, drives, s);
        Console.WriteLine(moneySpent);
    }
}
