﻿using System;


    public class Program
    {
        static void Main(string[] args)
        {
            // exception = errors that occur during execution

            //          try    = try some code that is considered "dangerous"
            //          catch  = catches and handles exceptions when they occur
            //          finally = always executes regardless if exception is caught or not

            double x;
            double y;
            double result;
            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToDouble(Console.ReadLine());

                result = x / y;

                Console.WriteLine($"result: {result}");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a valid number");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something Went Wrong");
            }
            finally
        {
            Console.WriteLine("Thank you for using Divider");
        }
              
           

            Console.ReadKey();
        }
    }
