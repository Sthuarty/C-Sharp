/*
https://www.hackerrank.com/challenges/counting-valleys/problem
*/

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        char[] paths = s.ToCharArray();
        int level = 0;
        int valleysCount = 0;
        
        //Console.WriteLine("level= " + level);
        
        foreach(var i in paths) {
            //Console.WriteLine(i);
            if (level == 0 && i.ToString() == "D")
                valleysCount++;
                
            if (i.ToString() == "U")
                level++;
            if (i.ToString() == "D")
                level--;
                
            
            //Console.WriteLine("level= " + level + "   i= " + i.ToString() + "   valleysCount= " + valleysCount);
        }
        return valleysCount;
        
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
