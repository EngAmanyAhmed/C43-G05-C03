using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region String Formating
            // String Formating
            // Equation ; X +Y =12

            //int X = 3, Y = 4;

            // 1. string Cocatnation

            //String Message = "Equaion : " + X + "+" + Y + "=" + (X + Y);

            //Console.WriteLine(Message);
            // string : Immutable -> Can't Change its Value After Creation

            // 2. String Format

            //string Message = string.Format(format: "Euation : {0} + {1} = {2}", X, Y, X + Y);
            //Console.WriteLine(Message);

            // 3. String Interpolution
            // $ :

            //string Message = $"Equation ; {X} +{Y} ={X + Y}";
            //Console.WriteLine(Message); 
            #endregion

            #region Control Statements

            // Control Statements
            // Control Statements : 1. Conditional Controle Statments (If Statment, Switch Case)
            // Control Statements : 2. Loop Control Statements (For, While, do-While)

            //Console.WriteLine(value:"Hello, World!");
            //Console.WriteLine(value: "Hello, World!");
            //Console.WriteLine(value: "Hello, World!");
            //Console.WriteLine(value: "Hello, World!");




            #endregion

            #region Control Statements : 1. Conditional Controle Statments (If Statment, Switch Case)


            //Console.WriteLine(value: "Enter Number of Month in 1st Quarter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            // 1 --> Jan
            // 2 --> Feb
            // 3 --> Mar

            //Console.WriteLine(value: "Jan");
            //Console.WriteLine(value: "Feb");
            //Console.WriteLine(value: "Mar");

            //if(/*Expression*/)
            //{
            //    // code
            //    // This Code will be executed when the condition is true
            //}

            //if (MonthNumber == 1) 
            //{
            //    // code
            //    Console.WriteLine(value: "Jan");
            //}

            #endregion

            #region Ex01

            //Console.WriteLine(value: "Enter Number of Month in 1st Quarter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //if (MonthNumber == 2)
            //{
            //    // code
            //    Console.WriteLine(value: "Feb");
            //}

            //if (MonthNumber == 3)
            //{
            //    // code
            //    Console.WriteLine(value: "Mar");
            //}

            //if(MonthNumber == 1)
            //{
            //    Console.WriteLine(value: "Jan");
            //}else if(MonthNumber == 2)
            //{
            //    Console.WriteLine(value: "Feb");
            //}else if(MonthNumber == 3)
            //{
            //    Console.WriteLine(value: "Mar");
            //}else
            //{
            //    Console.WriteLine(value: "Invalid Month Number");
            //}

            // 2. using Switch 

            //switch(/*Expression*/)
            //{

            //}

            //Console.WriteLine(value: "Enter Number of Month in 1st Quarter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());


            //// Jump Table
            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine(value: "Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine(value: "Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine(value: "Mar");
            //        break;
            //    default:
            //        Console.WriteLine(value: "Invalid Month Number");
            //        break;
            //}
            #endregion

            #region Ex02

            //Console.WriteLine(value: "Enter Your Name: ");
            //string Name = Console.Readline();

            // Hi Ahmed

            //if(Name == "Ahmed" || Name == "ahmed")
            //{
            //    Console.WriteLine(value: "Hi Ahmed");
            //}else if(Name == "Omar" || Name == "omar")
            //{
            //    Console.WriteLine(value: "Hi Omar");
            //}else if(Name == "Ali" || Name == "ali")
            //{
            //    Console.WriteLine(value: "Hi Ali");
            //}
            //else if (Name == "Mariam" || Name == "mariam")
            //{
            //    Console.WriteLine(value: "Hi Mariam");
            //}



            //Console.WriteLine(value: "Enter Your Name: ");
            //string Name = Console.ReadLine();

            //// Jump Table
            //switch (Name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine(value: "Hi Ahmed");
            //        break;
            //    case "Omar":
            //    case "omar":
            //        Console.WriteLine(value: "Hi Omar");
            //        break;
            //    case "Ali":
            //    case "ali":
            //        Console.WriteLine(value: "Hi Ali");
            //        break;
            //    case "Mariam":
            //    case "mariam":
            //        Console.WriteLine(value: "Hi Mariam");
            //        break;
            //    default:
            //        Console.WriteLine(value: "Invalid Name");
            //        break;
            //}

            #endregion

            #region Ex03

            Console.WriteLine(value: "Enter Your Age : ");
            int Age = int.Parse(Console.ReadLine());

            // 1. Using If

            //if (Age > 18)
            //{
            //    Console.WriteLine(value: "Welcom :)");
            //}
            //else if (Age < 18)
            //{
            //    Console.WriteLine(value: "Bye Bye :(");
            //}
            //else
            //{
            //    Console.WriteLine(value: "Equal !!");
            //}

            //switch (Age)
            //{
            //    case > 18:
            //        Console.WriteLine(value: "Welcom :)");
            //        break;
            //    case < 18:
            //        Console.WriteLine(value: "Bye Bye :(");
            //        break;
            //    default:
            //        Console.WriteLine(value: "Equal !!");
            //        break;
            //}
            #endregion

            #region C# 7.0
            //object object = new object();

            //object = "Ahmed";
            //object = 1;

            //switch (object)
            //{
            //    case int X when X > -12:
            //        Console.WriteLine(value: "Int object");
            //        break;
            //    case string X when X.Length > 5:
            //        Console.WriteLine(value: "string object");
            //        break;
            //    case string X when X.Length <= 5:
            //        Console.WriteLine(value: "string object <= 5");
            //        break;

            #endregion

            #region c# 8.0

            //string Input = Console.ReadLine();
            // 1
            // 2
            // 3

            //Console.WriteLine(Input switch
            //{
            //    "1" => "option 1",
            //    "2" => "option 2",
            //    "3" => "option 3",
            //    _ => "Unsupport Option ! !"
            //});

            #endregion

            #region  Control Statements : 2. Loop Control Statements (For, foreach)

            // 1. for loop

            //for(/*Statment*/;/* Expression*/;/*Statment*/  )
            //{
            //    // code
            //    // That Code Will Be Repeated
            //}

            //for(iConsole.WriteLine(value: "Hello 1"); Console.WriteLine(value: "Hello 2"))
            //{
            //    Console.WriteLine(value:"Hello Worled");
            //    i++;
            //}


            //for(intX = 1; X <= 10; X++)
            //{
            //     Console.WritLine(X);
            //}


            //2. foreach

            //int[] Numbers  = { 1, 2, 3, 4, 5, 6, 7}

            //for(int i=0; i < Numbers.Length; i++)
            //{

            //    Console.WriteLine(Numbers[i]);
            //}

            //foreach(int N in Numbers)
            //{
            //Console.WriteLine(N);
            //}

            #endregion

            #region Control Statements : 2. Loop Control Statements (While, do-While)

            // while (true)
            //{
            // Console.WriteLine("Hallo Worled");
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(value:"Hello Worled");
            //    i++;
            //}

            //Console.WriteLine(i);

            // do - while

            //do
            //{
            //    //code
            //    // This Code Will Be Executed First
            //} while (/* Expression*/);


            //int i = 11;

            //do
            //{
            //    Console.WriteLine(value: "Hello Worled");
            //} while (i <= 10);

            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine(value: "Even Number :");
            //} while (!int.TryParse(Console.ReadLine(), out Number) == false || Number % 2 != 0);

            //Console.WriteLine(Number);

            #endregion

            #region string
            //// string : Reference Type : HEAP (Class)
            //// Immutable Type : Can't Change its Value After Creation
            //string S01;
            ////Declare For Reference (Pointer) From Type 'String'
            //// S01 : Can Refer To Object From 'String'
            //// S01 : Refer To Null

            //// 8 Byte Will Be Allocated At Stack For Refernce 'S01'
            //// 0 Byte Will Be Allocated At HEAP


            //// S01 = new string(value: "Ahmed");
            //S01 = "Ahmed";  // Syntax Sugar
            //                // new
            //                // 1. Allocate The Number Of Required Bytes for The Object At HEAP
            //                // 2. Initialized The Allocated Bytes With The Default Value
            //                // 3. Call User-Defined Constructor is Exists
            //                // 4. Assign The Object To The Reference
            //Console.WriteLine(S01.GetHashCode()); //Id : Indicate Address


            //S01 = "Ali";
            //// 1. Allocate The Number Of Required Bytes for The Object At HEAP
            //// 2. Initialized The Allocated Bytes With The Default Value
            //// 3. Call User-Defined Constructor is Exists
            //// 4. Assign The Object To The Reference
            //Console.WriteLine(S01.GetHashCode()); //Id : Indicate Address


            //S01 = "Yassmin";
            //// new
            //// 1. Allocate The Number Of Required Bytes for The Object At HEAP
            //// 2. Initialized The Allocated Bytes With The Default Value
            //// 3. Call User-Defined Constructor is Exists
            //// 4. Assign The Object To The Reference
            //Console.WriteLine(S01.GetHashCode()); //Id : Indicate Address

            //string Message = "Hello";

            //Console.WriteLine("Message :" + Message);
            //Console.WriteLine("HashCode :" + Message.GetHashCode());
            //Console.WriteLine();

            //Message += "Ahmed";

            //Console.WriteLine("Message :" + Message);
            //Console.WriteLine("HashCode :" + Message.GetHashCode());
            //Console.WriteLine(); 
            #endregion

            #region String Builder
            // StringBuilder: Class (Reference Type) : HEAP
            // Mutable Datatype : Can Change its Value After Creation


            //StringBuilder S01;
            //////Declare For Reference (Pointer) From Type 'StringBuilder'
            ////// S01 : Can Refer To Object From 'StringBuilder'
            ////// S01 : Refer To Null

            //S01 = new string(value: "Ahmed");
            ///// new
            //// 1. Allocate The Number Of Required Bytes for The Object At HEAP
            //// 2. Initialized The Allocated Bytes With The Default Value
            //// 3. Call User-Defined Constructor is Exists
            //// 4. Assign The Object To The Reference
            //Console.WriteLine(S01.GetHashCode()); //Id : Indicate Address

            //Console.WriteLine("S01 :" + S01);
            //Console.WriteLine("S01HashCode :" + S01.GetHashCode());
            //Console.WriteLine();

            //// S01 = new StringBuilder(value: "Ahmed");

            //S01.Append(value: "Ahmed");

            //Console.WriteLine("S01 :" + S01);
            //Console.WriteLine("S01HashCode :" + S01.GetHashCode());
            //Console.WriteLine();

            #endregion

            #region String Methods

            #endregion



        }








    }
        
}
