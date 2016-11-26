using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmitester
{
    class Program
    {
        public string Gender { get; private set; }
     

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            Console.WriteLine("BMI Calculator");
            Console.WriteLine("===========");
            Console.WriteLine();

            Console.Write("Weight in kg: ");
            int kg;

            kg = Convert.ToInt32(Console.ReadLine());

            if (kg > 999)
            {
                Console.WriteLine("Error! Did you input the right format?");
            }

            if (kg < 20)
            {
                Console.WriteLine("Error! Did you input the right format?");
            }

            Console.Write("Height in cm: ");
            int cm;
            cm = Convert.ToInt32(Console.ReadLine());

            if (cm < 40)
            {
                Console.WriteLine("Error! Did you input the right format?");
            }

            if (cm > 300)
            {
                Console.WriteLine("Error! Did you input the right format?");
            }

            Console.Write("Gender (m/f):");


            string Gender = Console.ReadLine();
            double BMI = kg / ((cm / 100.0) * (cm / 100.0));


            //female
            if (BMI < 19 & Gender == "f")

                { Console.WriteLine("-> Underweight"); }

            if (BMI >= 19 & BMI <= 26 & Gender == "f")

                { Console.WriteLine("-> Normal"); }

            if (BMI >= 27 & Gender == "f")

                { Console.WriteLine("-> Overweight"); }



            //male
            if (BMI < 20 & Gender == "m")

                { Console.WriteLine("-> Underweight"); }

            if (BMI >= 20 & BMI <= 28 & Gender == "m")

                { Console.WriteLine("-> Normal"); }

            if (BMI >= 29 & Gender == "m")

                { Console.WriteLine("-> Overweight"); }

            Console.ReadKey();
        }
    }
}


















    //class Program
    //{
    //    string bmiHeight = "";
    //    string bmiWeight = "";

    //    static void Main(string[] args)
    //    {

    //        Program myProgram = new Program();
    //        myProgram.Run();
    //    }

    //    private void Run()
    //    {
    //        bmiHeight = ReadLine("Height");
    //        Console.Clear();
    //        bmiWeight = ReadLine("Weight");
    //        Console.Clear();

    //    }

    //    public string ReadLine(string parameter)
    //    {
    //        string openingSentence = "Enter the " + parameter;
    //        string message = "Wrong format! Please try again:";
    //        Console.WriteLine(openingSentence);
    //        string input = Console.ReadLine();
    //        switch (parameter)
    //        {
    //            case "Height":
    //                if (CheckForNumbersHeight(input) == false)
    //                {
    //                    Console.WriteLine(message);
    //                    Console.ReadKey();
    //                    Console.Clear();
    //                    bmiHeight = ReadLine(parameter);
    //                }
    //                break;
    //            case "Weight":
    //                if (CheckForNumbersWeight(input) == false)
    //                {
    //                    Console.WriteLine(message);
    //                    Console.ReadKey();
    //                    Console.Clear();
    //                    bmiWeight = ReadLine(parameter);
    //                }
    //                break;
    //         }
    //        return input;
                
    //    }

    //        public bool CheckForNumbersWeight(string weight)
    //    {
    //        List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    //        bool IsOnlyInts = false;
    //        foreach (char digit in weight)
    //        {
    //            if (bmiWeight.Contains(digit))
    //            {
    //                IsOnlyInts = true;
    //            }
    //            else
    //            {
    //                IsOnlyInts = false;
    //            }
    //        }
    //        return IsOnlyInts;
    //    }

    //    public bool CheckForNumbersHeight(string height)
    //    {
    //        List<char> numbers = new List<char> { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    //        bool IsOnlyInts = false;
    //        foreach (char digit in height)
    //        {
    //            if (bmiHeight.Contains(digit))
    //            {
    //                IsOnlyInts = true;
    //            }
    //            else
    //            {
    //                IsOnlyInts = false;
    //            }
    //        }
    //        return IsOnlyInts;
    //    }

     
    //}


  
