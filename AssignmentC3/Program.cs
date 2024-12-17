using System;

namespace AssignmentC3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Problem 01
            //1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Enter a number: ");
            //int num1 = int.Parse(Console.ReadLine());
            //if (num1 % 3 == 0 && num1 % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            #endregion


            #region Problem 02

            //2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.Write("Enter an integer: ");
            //int num2 = int.Parse(Console.ReadLine());

            //switch (num2)
            //{
            //    case > 0:
            //        Console.WriteLine("Positive");
            //        break;
            //    case < 0:
            //        Console.WriteLine("Negative");
            //        break;
            //    default:
            //        Console.WriteLine(value: "Equal !!");
            //        break;
            //}
            #endregion


            #region Problem 03

            //3- Write a program that takes 3 integers from the user then prints the max element and the min element.

            //Console.WriteLine("Enter three integers:");
            //int num3 = int.Parse(Console.ReadLine());
            //int num4 = int.Parse(Console.ReadLine());
            //int num5 = int.Parse(Console.ReadLine());

            //int max = Math.Max(Math.Max(num3, num4), num5);
            //int min = Math.Min(Math.Min(num3, num4), num5);

            //Console.WriteLine("Max element = " + max);
            //Console.WriteLine("Min element = " + min);

            #endregion


            #region Problem 04

            //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            #endregion


            #region Problem 05

            //5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).

            //Console.Write("Enter a character: ");
            //char ch = char.Parse(Console.ReadLine());

            //if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else
            //{
            //    Console.WriteLine("Consonant");
            //}

            #endregion


            #region Problem 06

            //6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.Write("Enter a positive integer: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion


            #region Problem 07

            //7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{number} x {i} = {number * i}");
            //}

            #endregion


            #region Problem 08

            //8- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.Write("Enter a positive integer: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 2; i <= n; i += 2)
            //{
            //    Console.Write(i + " ");
            //}

            #endregion


            #region Problem 09

            //9- Write a program that takes two integers then prints the power.

            //Console.Write("Enter the base: ");
            //int baseNum = int.Parse(Console.ReadLine());

            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());

            //int result = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //    result *= baseNum;
            //}

            //Console.WriteLine($"{baseNum}^{exponent} = {result}");

            #endregion


            #region Problem 10

            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //int[] marks = new int[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter marks of subject {0}: ", i + 1);
            //    marks[i] = int.Parse(Console.ReadLine());
            //}

            //int total = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    total += marks[i];
            //}

            //double average = (double)total / 5;
            //double percentage = (double)total / 500 * 100;

            //Console.WriteLine("Total marks = " + total);
            //Console.WriteLine("Average Marks = " + average);
            //Console.WriteLine("Percentage = " + percentage);

            #endregion


            #region Problem 11

            //11- Write a program to input the month number and print the number of days in that month.

            //Console.Write("Enter month number: ");
            //int month = int.Parse(Console.ReadLine());

            //int days;

            //switch (month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        days = 31;
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        days = 30;
            //        break;
            //    case 2:
            //        days = 28;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid month number");
            //        return;
            //}

            //Console.WriteLine("Days in Month: " + days);

            #endregion


            #region Problem 12

            //12- Write a program to create a Simple Calculator.

            //Console.Write("Enter first number: ");
            //double num1 = double.Parse(Console.ReadLine());

            //Console.Write("Enter second number: ");
            //double num2 = double.Parse(Console.ReadLine());

            //Console.Write("Enter operator (+, -, *, /): ");
            //char op = char.Parse(Console.ReadLine());

            //double result;

            //switch (op)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 == 0)
            //        {
            //            Console.WriteLine("Error: Division by zero");
            //            return;
            //        }
            //        result = num1 / num2;
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator");
            //        return;
            //}

            //Console.WriteLine("Result: " + result);

            #endregion


            #region Problem 13

            //13- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.Write("Enter a string: ");
            //string str = Console.ReadLine();

            //string reversedStr = "";
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    reversedStr += str[i];
            //}

            //Console.WriteLine("Reversed string: " + reversedStr);

            #endregion


            #region Problem 14

            //14- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());

            //int reversedNumber = 0;
            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversedNumber = reversedNumber * 10 + digit;
            //    number /= 10;
            //}

            //Console.WriteLine("Reversed number: " + reversedNumber);

            #endregion


            #region Problem 15

            //15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.Write("Enter starting number of range: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Enter ending number of range: ");
            //int end = int.Parse(Console.ReadLine());

            //Console.WriteLine("Prime numbers between {0} and {1}:", start, end);
            //for (int num = start; num <= end; num++)
            //{
            //    bool isPrime = true;
            //    for (int i = 2; i <= Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    if (isPrime && num > 1)
            //    {
            //        Console.Write(num + " ");
            //    }
            //}


            #endregion


            #region Problem 16

            //16- Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.Write("Enter a number to convert: ");
            //int number = int.Parse(Console.ReadLine());

            //string binary = "";
            //while (number > 0)
            //{
            //    binary = number % 2 + binary;
            //    number /= 2;
            //}

            //Console.WriteLine("The Binary of {0} is {1}", number, binary);

            #endregion


            #region Problem 17

            //17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("Enter coordinates of three points (x1, y1), (x2, y2), (x3, y3):");

            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());

            //double area = Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);

            //Console.WriteLine("Area of the triangle: " + area);

            #endregion


            #region Problem 18

            //18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
            /* -If the worker completes the job within 2 to 3 hours, they are considered highly efficient.
            - If the worker takes 3 to 4 hours, they are instructed to increase their speed.
            - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed.
            - If the worker takes more than 5 hours, they are required to leave the company.
              To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.*/

            //Console.Write("Enter the time taken to complete the task (in hours): ");
            //double timeTaken = double.Parse(Console.ReadLine());

            //if (timeTaken >= 2 && timeTaken < 3)
            //{
            //    Console.WriteLine("Highly Efficient Worker!");
            //}
            //else if (timeTaken >= 3 && timeTaken < 4)
            //{
            //    Console.WriteLine("Please increase your speed.");
            //}
            //else if (timeTaken >= 4 && timeTaken < 5)
            //{
            //    Console.WriteLine("Training is required to enhance your speed.");
            //}
            //else
            //{
            //    Console.WriteLine("You are required to leave the company.");
            //}

            #endregion





        }
    }
}
