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



class Solution
{
    public static void Main(string[] args)
    {
        string str, reversestring = "";

        int len;

        str = Console.ReadLine();

        len = str.Length - 1;

        while (len >= 0)

        {
            reversestring +=str[len];

            len--;

        }

        Console.WriteLine("{0}", reversestring);

        Console.ReadLine();
    }



}
