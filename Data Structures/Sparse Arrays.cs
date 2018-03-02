//Completed 03/02/2018


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {
    public static int n;
    public static int q;
    // public static Dictionary<string, int> query = new Dictionary<string, int>();
    public static List<string> sample = new List<string>();
    public static List<string> query = new List<string>();


    public static void Main(String[] args) {
        n = readInInt();
        InputStringArray(sample, n);
        q = readInInt();
        InputStringArray(query, q);
        int [] count = int [q];
        for(int i = 0; i < q; i++)
        {
            for(int j = 0; j < n; j++)
            {
                if(query[i] == sample[j])
                {
                    count[i]++;
                }
            }
        }
        foreach (int i in count)
        {
            System.Console.Write("{0} ", i);
        }        
        // BuildMap(query, q);
        // RunQuery(query,sample);
        // foreach (KeyValuePair<string, int> dic in query)
        // {
        //     // Console.WriteLine("Key = {0}, Value = {1}", dic.Key, dic.Value);
        //     Console.WriteLine("{0}", dic.Value);

        // }

    }

    // public static void RunQuery (Dictionary<string,int> input, List<string> sample)
    // {
    //     for(int i = 0; i < sample.Count(); i++)
    //     {
    //         if(input.ContainsKey(sample[i]))
    //         {
    //             input[sample[i]] = input[sample[i]]+ 1;
                
    //         }
    //     }
    //     return;
    // }

    // public static void BuildMap (Dictionary<string,int> input, int size)
    // {
    //     for(int i = 0; i < size; i++)
    //     {
    //         string input_S = Console.ReadLine();
    //         if(input.ContainsKey(input_S) != true)
    //         {
    //             input.Add(input_S,0);
    //         }
    //     }
    //     return;
    // }

    public static int readInInt()
    {
        string input_S = Console.ReadLine();
        int input_I = Convert.ToInt32(input_S);
        return input_I;
    }

    public static void InputStringArray(List<string> x,int size)
    {
        for(int i = 0; i < size; i++)
        {
            string input_S = Console.ReadLine();
            x.Add(input_S);
        }
        return;

    }
}