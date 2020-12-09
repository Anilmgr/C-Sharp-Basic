using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class TypeCasting
    {
        /*
         Implicit Casting (automatically) - converting a smaller type to a larger type size
         char -> int -> long -> float -> double

        Explicit Casting (manually) - converting a larger type to a smaller size type
        double -> float -> long -> int -> char

        Builtin Type Conversion Method - Convert.ToBoolean, Convert.ToDouble, Convert.ToString,
        Convert.ToInt32 (int) and Convert.ToInt64 (long):
        */
        static void Main(String[] args)
        {
            int integerNumber = 10;
            double doubleNumber = integerNumber; //implicit Casting

            Console.WriteLine(integerNumber);    // Outputs 10
            Console.WriteLine(doubleNumber);    // Outputs 10

            double myDouble = 9.78;
            int myInt = (int)myDouble;    // Explicit casting: double to int

            Console.WriteLine(myDouble);   // Outputs 9.78
            Console.WriteLine(myInt);   // Outputs 9

            int myIntNum = 10;
            double myDoubleNum = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(myIntNum));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myIntNum));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDoubleNum));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

        }
    }
}
