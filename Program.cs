//if you're reading this for the comments, start in the Converter.cs file! It has context for this file.

using System;

namespace UnitConversion
{
    class Program
    {
        static void Main(string[] args) //like C++, C# also has a main function, but it takes the type void, not main
        {
            object LengthObject(0.3048; "meters"; "feet";);

            //declare variables, this looks awfully familiar, huh?
            int lengthDirection, whichDimension, volumeDirection, pressureDirection;
            string whichDimensionAsString = string.Empty; //declaring strings as empty strings is considered best practice in C#
            string loopControl = string.Empty;
            loopControl = "1";
            string lengthDirectionAsString = string.Empty;
            string volumeDirectionAsString = string.Empty;
            string pressureDirectionAsString = string.Empty;

            //while loop
            while (loopControl != "0") //these work just the same as C++
                //even a for loop still uses i++ to auto-increment!
            {
                Console.WriteLine("Select from menu: "); //a Console.WriteLine works like a cout << something << "\n"; in C++
                Console.WriteLine("\t1) Length conversion"); //\t, \r, and \n work just the same in C#
                Console.WriteLine("\t2) Volume conversion");
                Console.WriteLine("\t3) Pressure conversion");
                Console.Write("Select: ");
                try
                {
                    whichDimensionAsString = Console.ReadLine(); //this is equivalent to a cin in C++
                    whichDimension = Convert.ToInt16(whichDimensionAsString); //when converting to an int, you have your choice of length
                    //Depending on the size of your int, a small int should be stored in an Int16, while a big int should be stored in Int32
                    //for memory deallocation, just assign the now-useless string to be null
                    whichDimensionAsString = null;

                    if (whichDimension == 1) { //a length conversion
                        Console.WriteLine("Select from menu: ");
                        Console.WriteLine("\t1) US to SI");
                        Console.WriteLine("\t2) SI to US");
                        Console.Write("Select: ");
                        try
                        {
                            lengthDirectionAsString = Console.ReadLine();
                            lengthDirection = Convert.ToInt16(lengthDirectionAsString);
                            lengthDirectionAsString = null;

                            if (lengthDirection == 1)
                            {
                                LengthObject.ChooseConversion(true); //tells ChooseConversions in Converter.cs the direction of the Conversion

                            }
                            else if (lengthDirection == 2)
                            {
                                LengthObject.ChooseConversion(false);
                            }
                        }
                        catch (FormatException f)
                        {
                            Console.WriteLine(f.Message);
                        }
                    }
                    else if (whichDimension == 2) //a volume conversion
                    {
                        Console.WriteLine("Select from menu: ");
                        Console.WriteLine("\t1) US to SI");
                        Console.WriteLine("\t2) SI to US");
                        Console.Write("Select: ");
                        try
                        {
                            volumeDirectionAsString = Console.ReadLine();
                            volumeDirection = Convert.ToInt16(volumeDirectionAsString);
                            volumeDirectionAsString = null;

                            if (volumeDirection == 1)
                            {
                                VolumeObject.ChooseConversion(true); //tells ChooseConversions in Converter.cs the direction of the Conversion

                            }
                            else if (volumeDirection == 2)
                            {
                                VolumeObject.ChooseConversion(false);
                            }
                        }
                        catch (FormatException f)
                        {
                            Console.WriteLine(f.Message);
                        }
                    }
                    else if (whichDimension == 3) {
                        Console.WriteLine("Select from menu: ");
                        Console.WriteLine("\t1) US to SI");
                        Console.WriteLine("\t2) SI to US");
                        Console.Write("Select: ");
                        try
                        {
                            pressureDirectionAsString = Console.ReadLine();
                            pressureDirection = Convert.ToInt16(pressureDirectionAsString);
                            pressureDirectionAsString = null;

                            if (pressureDirection == 1)
                            {
                                PressureObject.ChooseConversion(true); //tells ChooseConversions in Converter.cs the direction of the Conversion

                            }
                            else if (pressureDirection == 2)
                            {
                                PressureObject.ChooseConversion(false);
                            }
                        }
                        catch (FormatException f)
                        {
                            Console.WriteLine(f.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option.");
                    }
                }
                catch (FormatException f)
                {
                    Console.WriteLine(f.Message);
                }
            }
            Console.WriteLine("Enter 1 to continue or any other character to quit: ");
            loopControl = Console.ReadLine();
        }
    }
}
