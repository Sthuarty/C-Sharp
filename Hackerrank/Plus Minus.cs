/*
https://www.hackerrank.com/challenges/plus-minus/problem
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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        int positives = 0;
        int negatives = 0;
        int zeros = 0;
        
        for (int i = 0; i < arr.Length; i++){
            if (arr[i] > 0)
                positives++;
            else if (arr[i] < 0)
                negatives++;
            else
                zeros++;
        }
        
        Console.WriteLine(
            Divider(positives, arr) + Environment.NewLine +
            Divider(negatives, arr) + Environment.NewLine +
            Divider(zeros, arr)
        );
    }
        
    private static string Divider(int value, int[] arr){
        double result = 0;
        result = (double)value / (double)arr.Length;
        return result.ToString("N6");
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
