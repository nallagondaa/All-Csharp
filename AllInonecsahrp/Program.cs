// Use using to declare namespaces and functions we wish to use
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalNS;

/*
Multiline Comment
*/

// Delegates are used to pass methods as arguments to other methods
// A delegate can represent a method with a similar return type and attribute list
delegate double GetSum(double num1, double num2);

// ---------- ENUMS ----------
// Enums are unique types with symbolic names and associated values

public enum Temperature
{
    Freeze,
    Low,
    Warm,
    Boil
}

// ---------- STRUCT ----------
// A struct is a custom type that holds data made up from different data types
struct Customers
{
    private string name;
    private double balance;
    private int id;

    public void createCust(string n, double b, int i)
    {
        name = n;
        balance = b;
        id = i;
    }

    public void showCust()
    {
        Console.WriteLine("struct called and Name : " + name);
        Console.WriteLine(" struct called and Balance : " + balance);
        Console.WriteLine("struct called and ID : " + id);
    }
}
// Give our code a custom namespace
namespace AllInonecsharp
{
    class Program
    {
        // Code in the main function is executed
        static void Main(string[] args)
        {

            // Prints string out to the console with a line break (Write = No Line Break)
            Console.WriteLine("What is your name : ");

            // Accept input from the user
            string name = Console.ReadLine();

            // You can combine Strings with +
            Console.WriteLine("Hello " + name);

            // ---------- DATA TYPES ----------

            // Booleans are true or false
            bool canVote = true;

            // Characters are single 16 bit unicode characters
            char grade = 'A';

            // Integer with a max number of 2,147,483,647
            int maxInt = int.MaxValue;

            // Long with a max number of 9,223,372,036,854,775,807
            long maxLong = long.MaxValue;

            // Decimal has a maximum value of 79,228,162,514,264,337,593,543,950,335
            // If you need something bigger look up BigInteger
            decimal maxDec = decimal.MaxValue;

            // A float is a 32 bit number with a maxValue of 3.402823E+38 with 7 decimals of precision
            float maxFloat = float.MaxValue;

            // A float is a 32 bit number with a maxValue of 1.797693134E+308 with 15 decimals of precision
            double maxDouble = double.MaxValue;

            // You can combine strings with other values with +
            Console.WriteLine("Max Int : " + maxInt);
            Console.WriteLine("canVote boolean value is : " + maxInt);
            Console.WriteLine("Max Long    : " + maxLong);
            Console.WriteLine("Max Dec : " + maxDec);
            Console.WriteLine("Max Float : " + maxFloat);


            // The dynamic data type is defined at run time 
            dynamic otherName = "Paul";
            Console.WriteLine("Hello " + otherName);
            otherName = 1;
            Console.WriteLine("Hello " + otherName);
            // The var data type is defined when compiled and then can't change
            var anotherName = "Tom";
            // ERROR : anotherName = 2;
            Console.WriteLine("Hello " + anotherName);

            // How to get the type and how to format strings
            Console.WriteLine("anotherName is a {0}", anotherName.GetTypeCode());

            // ---------- MATH ----------

            Console.WriteLine("5 + 3 = " + (5 + 3));
            Console.WriteLine("5 - 3 = " + (5 - 3));
            Console.WriteLine("5 * 3 = " + (5 * 3));
            Console.WriteLine("5 / 3 = " + (5 / 3));
            Console.WriteLine("5.2 % 3 = " + (5.2 % 3));

            int i = 0;

            Console.WriteLine("i++ = " + (i++));
            Console.WriteLine("++i = " + (++i));
            Console.WriteLine("i-- = " + (i--));
            Console.WriteLine("--i = " + (--i));

            Console.WriteLine("i += 3 " + (i += 3));
            Console.WriteLine("i -= 2 " + (i -= 2));
            Console.WriteLine("i *= 2 " + (i *= 2));
            Console.WriteLine("i /= 2 " + (i /= 2));
            Console.WriteLine("i %= 2 " + (i %= 2));

            // Casting : If no magnitude is lost casting happens automatically, but otherwise it must be done
            // like this

            double pi = 3.14;
            int intPi = (int)pi; // put the data type to convert to between braces

            // Math Functions
            // Acos, Asin, Atan, Atan2, Cos, Cosh, Exp, Log, Sin, Sinh, Tan, Tanh
            double number1 = 10.5;
            double number2 = 15;

            Console.WriteLine("Math.Abs(10.5) " + (Math.Abs(number1)));
            Console.WriteLine("Math.Ceiling(10.5) " + (Math.Ceiling(number1)));
            Console.WriteLine("Math.Floor(10.5) " + (Math.Floor(number1)));
            Console.WriteLine("Math.Max(10.5, 15) " + (Math.Max(number1, number2)));
            Console.WriteLine("Math.Min(10.5, 15) " + (Math.Min(number1, number2)));
            Console.WriteLine("Math.Pow(10.5, 2) " + (Math.Pow(number1, 2)));
            Console.WriteLine("Math.Round(10.549) " + (Math.Round(10.549)));
            Console.WriteLine("Math.Sqrt(10.5) " + (Math.Sqrt(number1)));

            // Random Numbers
            Random rand = new Random();
            Console.WriteLine("Random Number Between 1 and 10 " + (rand.Next(1, 11)));

            // ---------- CONDITIONALS ----------

            // Relational Operators : > < >= <= == !=
            // Logical Operators : && || ^ !

            // If Statement
            int age = 17;

            if ((age >= 5) && (age <= 7))
            {
                Console.WriteLine("Go to elementary school");
            }
            else if ((age > 7) && (age < 13))
            {
                Console.WriteLine("Go to middle school");
            }
            else
            {
                Console.WriteLine("Go to high school");
            }

            if ((age < 14) || (age > 67))
            {
                Console.WriteLine("You shouldn't work");
            }

            Console.WriteLine("! true = " + (!true));

            // Ternary Operator

            bool canDrive = age >= 16 ? true : false;

            // Switch is used when you have limited options
            // Fall through isn't allowed with C# unless there are no statements between cases
            // You can't check multiple values at once

            switch (age)
            {
                case 0:
                    Console.WriteLine("Infant case 0 in switch");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Toddler case1 ");

                    // Goto can be used to jump to a label elsewhere in the code
                    goto Cute;
                default:
                    Console.WriteLine("Child is default case ");
                    break;
            }

            // Lable we can jump to with Goto
            Cute:
            Console.WriteLine("Toddlers are cute");

            // ---------- LOOPING ----------

            int N = 0;

            while (N < 10)
            {
                // If i = 7 then skip the rest of the code and start with i = 8
                if (N == 7)
                {
                    N++;
                    continue;
                }

                // Jump completely out of the loop if i = 9
                if (N == 9)
                {
                    break;
                }

                // You can't convert an int into a bool : Print out only odds
                if ((N % 2) > 0)
                {
                    Console.WriteLine("the odds are {0}",N);
                }
                N++;
            }

            // The do while loop will go through the loop at least once
            string guess;
            do
            {
                Console.WriteLine("Guess a Number until you enter 15 do while repeats");
                guess = Console.ReadLine();
            } while (!guess.Equals("15")); // How to check String equality

            // Puts all changes to the iterator in one place
            for (int j = 0; j < 10; j++)
            {
                if ((j % 2) > 0)
                {
                    Console.WriteLine("the for loop intro and odd number logic"+j);
                }
            }

            // foreach cycles through every item in an array or collection
            string randStr = "Here are some random characters";
            Console.WriteLine("print each charecter in  string using for each");
            foreach (char c in randStr)
            {
                Console.WriteLine(c);
            }

            // ---------- STRINGS ----------

            // Escape Sequences : \' \" \\ \b \n \t

            string sampString = "A bunch of random charecters";

            // Check if empty
            Console.WriteLine("using method String.IsNullOrEmpty(sampString) Is string Empty ??" + String.IsNullOrEmpty(sampString));
            Console.WriteLine("using String.IsNullOrWhiteSpace(sampString) Is empty or containing only spaces??" + String.IsNullOrWhiteSpace(sampString));// only true whenstring contains only spaces(no charectrers ex: "    ") or null
            Console.WriteLine("String Length " + sampString.Length);

            // Find a string index (Starts with 0) if it can not find returns -1
            Console.WriteLine("Index of bunch " + sampString.IndexOf("bunch"));//answer 2 

            // Get a substring
            Console.WriteLine("2nd Word " + sampString.Substring(2, 6));

            string sampString2 = "More random words";

            // Are strings equal
            Console.WriteLine("Strings equal" + sampString.Equals(sampString2));

            // Compare strings
            Console.WriteLine("Starts with A bunch " + sampString.StartsWith("A bunch"));
            Console.WriteLine("Ends with words " + sampString.EndsWith("words"));

            // Trim white space at beginning and end or (TrimEnd / TrimStart)
            sampString = sampString.Trim();

            // Replace words or characters
            sampString = sampString.Replace("charecters", "words");// exactly same charecters not even a space is allowed if you give space it will not replace chareters with words
            Console.WriteLine("after replace the new string is "+sampString);

            // Remove starting at a defined index up to the second index
            sampString = sampString.Remove(0, 2);
            Console.WriteLine("after removal of first two charerters   is "+sampString);

            // Join values in array and save to string in the below example we join using dot + 3/4 spaces 
            string[] names = new string[3] { "Matt", "Joe", "Paul" };
            Console.WriteLine(@"Name List  separated by . using String.Join("".    "", names)   " + String.Join(".     ", names));

            // Formatting : Currency, Decimal Places, Before Decimals, Thousands Separator
            string fmtStr = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 15.561, .56, 10000000);//c means currency defualt cvalue is $, 00.00 means 2 precisions after numbers round up value also, #.00 means nothing before precison, separeated by comma

            Console.WriteLine(fmtStr.ToString());

            // ---------- STRINGBUILDER ----------
            // Each time you create a string you actually create another string in memory
            // StringBuilders are used when you want to be able to edit a string without creating new ones
            //stringbuilder is mutable

            StringBuilder sb = new StringBuilder();

            // Append a string to the StringBuilder (AppendLine also adds a newline at the end)
            sb.Append("This is the first sentence.");
            Console.WriteLine(@"string builder is after sb.Append("""") " + sb);
            // Append a formatted string
            sb.AppendFormat("My name is {0} and I live in {1}", "Derek", "Pennsylvania");//hover over format to check the syntax
            Console.WriteLine("string builder is " + sb);
        
            // Replaces every instance of the first with the second
            sb.Replace("a", "e");
            Console.WriteLine(@"string builder is after sb.replace(""a"",""e"") " + sb.ToString());

            // Remove characters starting at the index and then up to the defined index
            sb.Remove(5, 7);

            // Out put everything
            Console.WriteLine("string builder is after sb.remove(5,7) "+sb.ToString());

            // Clear the StringBuilder
            sb.Clear();
            Console.WriteLine("string builder after  sb.clear()  " + sb);
            // ---------- ARRAYS ----------
            // Declare an array
            int[] randNumArray;

            // Declare the number of items an array can contain
            int[] randArray = new int[5];

            // Declare and initialize an array
            int[] randArray2 = { 1, 2, 3, 4, 5 };

            // Get array length
            Console.WriteLine("Array Length " + randArray2.Length);

            // Get item at index
            Console.WriteLine("Item 0 is " + randArray2[0]);

            // Cycle through array
            Console.WriteLine("print array using for loop index : value");
             for (int J = 0; J < randArray2.Length; J++)
            {
                Console.WriteLine("{0} : {1}", J, randArray2[J]);
            }

            // Cycle with foreach
            Console.WriteLine("using for each loop ");
            foreach (int num in randArray2)
            {
                Console.WriteLine(num);
            }

            // Get the index of an item or -1
            Console.WriteLine("Where is 1 in the array" + Array.IndexOf(randArray2, 1));

            string[] names2 = { "Tom", "Paul", "Sally" };

            // Join an array into a string
            string nameStr = string.Join("#", names2);
            Console.WriteLine("string of array joined into other string"+nameStr);

            // Split a string into an array
            string[] nameArray = nameStr.Split('#');
            Console.WriteLine("after the stringarrayname.Split('#')  " + nameArray[0]);

            // Create a multidimensional array
            int[,] multArray = new int[5, 3];

            // Create and initialize a multidimensional array
            int[,] multArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            // Cycle through multidimensional array
            foreach (int num in multArray2)
            {
                Console.WriteLine(num);
            }
                Console.WriteLine("dimension length {0} {1}" + multArray2.GetLength(0) +"  "+  multArray2.GetLength(1));
            
            // Cycle and have access to indexes
            for (int x = 0; x < multArray2.GetLength(0); x += 1)// Getlength(0) means the 0'th dimension
            {
                for (int y = 0; y < multArray2.GetLength(1); y += 1)// Getlength(1) means the 1'th dimension if you have one more dimesion use one more for loop and getlength(3)
                {
                    Console.WriteLine("{0} | {1} : {2}", x, y, multArray2[x, y]);
                }
            }

            // ---------- LISTS ----------
            // A list unlike an array automatically resizes

            // Create a list and add values
            List<int> numList = new List<int>();
            numList.Add(5);
            numList.Add(15);
            numList.Add(25);
            foreach (var item in numList)
            {
                Console.WriteLine("list example" + item);
            }
          
            // Add an array to a list
            int[] randArray3 = { 1, 2, 3, 4, 5 };
            numList.AddRange(randArray3);
            Console.Write("After AddRange(intarray)" );
            foreach (var item in numList)
            {
                Console.WriteLine(item);
            }

            // Insert in a specific index
            numList.Insert(1, 10);

            // Remove a specific value
            numList.Remove(5);

            // Remove at an index
            numList.RemoveAt(2);
            Console.WriteLine("after insert @1 with 10 and remove  5 and remiveat 2");
            foreach (var item in numList)
            {
                Console.Write( item);
            }

            // Clear a list
            numList.Clear();
            Console.WriteLine( "after clearing a list");
            // Copy an array into a List
            List<int> numList2 = new List<int>(randArray3);

            // Create a List with array
            List<int> numList3 = new List<int>(new int[] { 1, 2, 3, 4 });

            // Cycle through a List with foreach or
            for (int ar = 0; ar < numList.Count; ar++)
            {
                Console.WriteLine(numList[ar]);
            }

            // Return the index for a value or -1
            Console.WriteLine("4 is in index " + numList3.IndexOf(4));

            // Does the List contain a value
            Console.WriteLine("5 in list " + numList3.Contains(5));

            // Search for a value in a string List
            List<string> strList = new List<string>(new string[] { "Tom", "Paul" });
            Console.WriteLine("Tom in list " + strList.Contains("tom", StringComparer.OrdinalIgnoreCase));

            // Sort the List
            strList.Sort();

            // ---------- EXCEPTION HANDLING ----------
            // All the exceptions 
            // msdn.microsoft.com/en-us/library/system.systemexception.aspx#inheritanceContinued

            try
            {
                Console.Write("Divide 10 by ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10 / {0} =  {1}", num, (10 / num));

            }

            // Specifically catches the divide by zero exception
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by zero");

                // Get additonal info on the exception
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);

                // Throw the exception to the next inline
                // throw ex;

                // Throw a specific exception
                throw new InvalidOperationException("Operation Failed", ex);
            }

            // Catches any other exception
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            // ---------- CLASSES & OBJECTS ----------

            Animal bulldog = new Animal(13, 50, "Spot", "Woof");

            Console.WriteLine("{0} says {1}", bulldog.name, bulldog.sound);

            // Console.WriteLine("No. of Animals " + Animal.getNumOfAnimals());

            // ---------- ENUMS ----------

            Temperature micTemp = Temperature.Low;
            Console.Write("What Temp : ");

            Console.ReadLine();

            switch (micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Temp on Freezing");
                    break;

                case Temperature.Low:
                    Console.WriteLine("Temp on Low");
                    break;

                case Temperature.Warm:
                    Console.WriteLine("Temp on Warm");
                    break;

                case Temperature.Boil:
                    Console.WriteLine("Temp on Boil");
                    break;
            }

            // ---------- STRUCTS ----------
            Customers bob = new Customers();

            bob.createCust("Bob", 15.50, 12345);

            bob.showCust();

            // ---------- ANONYMOUS METHODS ----------
            // An anonymous method has no name and its return type is defined by the return used in the method

            GetSum sum = delegate (double num1, double num2) {
                return num1 + num2;
            };

            Console.WriteLine("5 + 10 = " + sum(5, 10));

            // ---------- LAMBDA EXPRESSIONS ----------
            // A lambda expression is used to act as an anonymous function or expression tree

            // You can assign the lambda expression to a function instance
            Func<int, int, int> getSum = (x, y) => x + y;
            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));

            // Get odd numbers from a list
            List<int> numList1 = new List<int> { 5, 10, 15, 20, 25 };

            // With an Expression Lambda the input goes in the left (n) and the statements go on the right
            List<int> oddNums = numList1.Where(n => n % 2 == 1).ToList();

            foreach (int num in oddNums)
            {
                Console.Write(num + ", ");
            }

            // ---------- FILE I/O ----------
            // The StreamReader and StreamWriter allows you to create text files while reading and 
            // writing to them

            string[] custs = new string[] { "Tom", "Paul", "Greg" };

            using (StreamWriter sw = new StreamWriter("custs.txt"))
            {
                foreach (string cust in custs)
                {
                    sw.WriteLine(cust);
                }
            }

            string custName = "";
            using (StreamReader sr = new StreamReader("custs.txt"))
            {
                while ((custName = sr.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }
            string[] fruits = { "apple", "orange", "banana" };
            for (int f = 0; f < fruits.Length; f++)   // in case of for loop f value does not incement until it reaches end of for loop in case of post-increment operator 
            {
                Console.WriteLine(f);
                Console.WriteLine(fruits[f++]);// f value increments rightaway after cw statement so its the scope block afterr which post-incrment will do addition(+1)     
                Console.WriteLine(f);
            }// for loop incrments f after this curly brace, so its the scope block afterr which post-incrment will do addition(+1)
            Console.Write("Hit Enter to Exit");
            string exitApp = Console.ReadLine();

        
        }
    }
}



