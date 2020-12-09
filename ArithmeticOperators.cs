using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class ArithmeticOperators
    {
        /*  
         *  Arithmetic Operators:
            +	Addition	    Adds together two values	            x + y	
            -	Subtraction	    Subtracts one value from another	    x - y	
            *	Multiplication	Multiplies two values	                x * y	
            /	Division	    Divides one value by another	        x / y	
            %	Modulus	        Returns the division remainder	        x % y	
            ++	Increment	    Increases the value of a variable by 1	x++	
            --	Decrement       Decreases the value of a variable by 1  x--
        */

        static void Main(string[] args)
        {
            int x = 10;
            int y = 5;
            Console.WriteLine(x+y); // returns 15
            Console.WriteLine(x-y); // returns 5
            Console.WriteLine(x*y); // returns 50
            Console.WriteLine(x/y); // returns 2
            Console.WriteLine(x%y); // returns 0
            Console.WriteLine(x++); // returns 10
            Console.WriteLine(x); // returns 11
            Console.WriteLine(y--); //returns 5
            Console.WriteLine(y); // returns 4
        }

    }
}
