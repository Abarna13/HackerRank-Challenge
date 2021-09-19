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

public class Exercise3

{
    public static void Main()

    {
        int[] a= new int[100];

        int i,n, sum=0;

        n = Convert.ToInt32(Console.ReadLine());

        for(i=0; i<n; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());

        }

        for(i=0; i<n; i++)

        {
            sum+= a[i];

        }
        Console.Write("Sum of all elements stored in the array is : {0}", sum);
    }

}

