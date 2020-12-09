using System;

namespace CSharpBasics
{
    class StringOp
    {
        static void Main()
        {
            string str1 = "Hello";
            string str2 = "Namaste";

            Console.WriteLine(str1[0]); //returns H ->character of index 0
            Console.WriteLine(str1.IndexOf("e")); //returns 1 ->index of character "e" 

            Console.WriteLine("Length of string str1: " + str1.Length); //returns Length of string str1: 5

            Console.WriteLine(str1.ToUpper()); //returns HELLO
            Console.WriteLine(str1.ToLower()); //returns hello

            string concat = str1 + str2; //Concatenation 
            string altconcat = string.Concat(str1, str2); //also Concatenation 
            Console.WriteLine(concat); //returns HelloNamaste
            Console.WriteLine(altconcat); //returns HelloNamaste

            //String Interpolation
            string fname = "Leonal";
            string lname = "Messi";
            string football = $"Barcelona 10 = {fname} {lname}";
            Console.WriteLine(football); //returns Barcelona 10 = Leonal Messi

            string str = "ForEver";
            Console.WriteLine(str.Substring(3)); //returns Ever

        }
    }
}
