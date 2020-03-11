﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UnitConversion
{
    class Converter
    {
        private double conversionFactor; //like C++, C# supports protected variables, but you must declare these on a case-by-case instance
        private string SI = string.Empty; //for some reason, it's considered best practice to declare your string and initialize them as empty before using them...
        private string US = string.Empty;

        public Converter(double factor, string siUnit, string usUnit) //this moves our variables from private to public
        {
            conversionFactor = factor;
            SI = siUnit;
            US = usUnit;
        }

        public void ChooseConversion(bool whichConversion) {
            if(whichConversion == true) //a open/close parentheses in C# is also true => whichConversion()
            {
                masterFunction(true); //like C++
            } else if (whichConversion == false)
            {
                masterFunction(false);
            }
            //if this function returned anything (bool, string, int, double, etc.), you MUST provide a return path for everything!
            //that is, if there were returning anything, it must return something that catches everything else
        }
        public void masterFunction(bool UStoISorViceVersa)
        {
            string inputValueAsString = string.Empty; //C# cannot take in doubles in a Console.ReadLine, only a string
            //why? This enforces that the value being put into inputValue is actually a double, and prohibits mistyping and improper type casting
            double inputValue, finalConversion;
            double finalConversionTruncated; //for explicit value truncation
            if (conversionFactor == 0.3048 && UStoISorViceVersa == true) //feet to meters
                //as you can see, the comparison operators are the same as C++
            {
                Console.Write("Enter length in feet: ");
                //if there's one thing that C# loves, it's try/catch blocks...
                //and for good reason; they do a lot to make sure that your program doesn't throw errors during runtime
                try //to readline and convert string to double
                {
                    inputValueAsString = Console.ReadLine(); //this is equivalent to a cin in C++
                    inputValue = Convert.ToDouble(inputValueAsString); //ToDouble is a standard function in the System library
                    //see the using statements at the top of this class
                    finalConversion = inputValue * conversionFactor; //calculate the conversion
                    finalConversionTruncated = Math.Round(finalConversion, 2); //truncate the final value to two decimal places
                    //Math.Round is a standard function of C# System library
                    Console.Write("Conversion to meters: ");
                    Console.Write(finalConversionTruncated);
                }
                catch (FormatException f) //the inputted value was not a double!
                {
                    //FormatException is an exception thrown by the runtime framework that is autogenerated.
                    //FormatException contains multiple fields, so we need to specify that we want the message.
                    Console.WriteLine(f.Message); //
                }
            }
            else if (conversionFactor == 0.3048 && UStoISorViceVersa == false) //meters to feet
            {
                Console.Write("Enter length in meters: ");
                try
                {
                    inputValueAsString = Console.ReadLine();
                    inputValue = Convert.ToDouble(inputValueAsString);
                    finalConversion = inputValue / conversionFactor;
                    finalConversionTruncated = Math.Round(finalConversion, 2);
                    Console.Write("Conversion to feet: ");
                    Console.Write(finalConversionTruncated);
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
            else if (conversionFactor == 3.785411784 && UStoISorViceVersa == true) //gallons to liters
            { 
                Console.Write("Enter volume in gallons: ");
                try
                {
                    inputValueAsString = Console.ReadLine();
                    inputValue = Convert.ToDouble(inputValueAsString);
                    finalConversion = inputValue * conversionFactor;
                    finalConversionTruncated = Math.Round(finalConversion, 2);
                    //let's try to concatenate the strings and print just the one string
                    string finalOutput = string.Empty;
                    finalOutput = string.Concat("Conversion to liters: ", finalConversionTruncated);
                    Console.WriteLine(finalOutput);
                    //Console.WriteLine automatically puts a newline at the end of the line, so you don't have to type \n
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
            else if (conversionFactor == 3.785411784 && UStoISorViceVersa == false) //liters to gallons
            {
                try
                {
                    inputValueAsString = Console.ReadLine();
                    inputValue = Convert.ToDouble(inputValueAsString);
                    finalConversion = inputValue / conversionFactor;
                    finalConversionTruncated = Math.Round(finalConversion, 2);
                    Console.Write("Conversion to gallons: ");
                    Console.Write(finalConversionTruncated);
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
            else if (conversionFactor == 0.000145038 && UStoISorViceVersa == true) //PSI to pascals
            {
                try
                {
                    inputValueAsString = Console.ReadLine();
                    inputValue = Convert.ToDouble(inputValueAsString);
                    finalConversion = inputValue * conversionFactor;
                    finalConversionTruncated = Math.Round(finalConversion, 2);
                    Console.Write("Conversion to gallons: ");
                    Console.Write(finalConversionTruncated);
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
            else if (conversionFactor == 0.000145038 && UStoISorViceVersa == true) //pascals to PSI
            {
                try
                {
                    inputValueAsString = Console.ReadLine();
                    inputValue = Convert.ToDouble(inputValueAsString);
                    finalConversion = inputValue / conversionFactor;
                    finalConversionTruncated = Math.Round(finalConversion, 2);
                    Console.Write("Conversion to gallons: ");
                    Console.Write(finalConversionTruncated);
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
        }
    }
}
