using System;

namespace ForPractice {
  internal class Program {
    //REGIONS ARE SECTIONED OFF BY SEPARATE EXERCISES, TO CHECK FUNCTIONALITY UNCOMMENT 1 SECTION AT A TIME

    private static void Main(string[] args) {
      //number to binary conversion

      #region

      //var number = 0;

      //Console.WriteLine("What number would you like to convert to binary?");

      //var number = Console.ReadLine();

      //var result = Convert.ToInt64(number, 2);

      //Console.WriteLine(result);
      //Console.ReadKey(true);

      #endregion

      //find the highest number of 3 values

      #region

      //int x, y, z;
      //Console.WriteLine("Please enter your first value to store...");
      //x = Convert.ToInt32(Console.ReadLine());

      //Console.WriteLine("Please enter your second value to store...");
      //y = Convert.ToInt32(Console.ReadLine());

      //Console.WriteLine("Please enter your third and final value to store...");
      //z = Convert.ToInt32(Console.ReadLine());

      //if (x > y)
      //{
      //    if (x > z)
      //    {
      //        Console.WriteLine("your highest number is..." + x);
      //    }
      //}

      //else if (y > x)
      //{
      //    if (y > z)
      //    {
      //        Console.WriteLine("your highest number is..." + y);
      //    }

      //    else
      //    {
      //        Console.WriteLine("your highest number is..." + z);

      //    }
      //}

      #endregion

      //convert letter to its uppercase equivalent

      #region

      //Console.WriteLine("Enter a letter in lower case form, ");
      //Console.WriteLine("and i will show you its upper case form...");
      //Console.WriteLine();
      //string x = (Console.ReadLine());
      //string upper = x.ToUpper();
      //Console.WriteLine();
      //Console.WriteLine("The upper case form up your entry is..." + upper);

      #endregion

      //repeat number entered (0-9) back to user with try catch if other key is entered

      #region

      //try
      //{
      //    Console.WriteLine("Please press a number between 0-9...");
      //    int key = int.Parse(Console.ReadLine());

      //    switch (key)
      //    {
      //        case 0: Console.WriteLine("you pressed 0");
      //            break;

      //        case 1: Console.WriteLine("you pressed 1");
      //            break;

      //        case 2: Console.WriteLine("you pressed 2");
      //            break;

      //        case 3: Console.WriteLine("you pressed 3");
      //            break;

      //        case 4: Console.WriteLine("you pressed 4");
      //            break;

      //        case 5: Console.WriteLine("you pressed 5");
      //            break;

      //        case 6: Console.WriteLine("you pressed 6");
      //            break;

      //        case 7: Console.WriteLine("you pressed 7");
      //            break;

      //        case 8: Console.WriteLine("you pressed 8");
      //            break;

      //        case 9: Console.WriteLine("you pressed 9");
      //            break;

      //        default: Console.WriteLine("Not Allowed!");
      //            break;
      //    }

      //}catch (Exception e)
      //{
      //    Console.WriteLine("you gotta choose a number between 0-9, duh!!", e);
      //}

      #endregion

      //convert string "ABCDEFG" to key of 'C major'

      #region

      //string notes = "ABCDEFG";
      //string keyOfC1 = "";
      //string keyOfC2 = "";
      //string keyOfCFinal = "";

      //keyOfC1 = notes.Substring(2, 5);
      //keyOfC2 = notes.Substring(0, 2);

      //keyOfCFinal = keyOfC1 + keyOfC2;

      //if (keyOfCFinal == "CDEFGAB")
      //{
      //    Console.WriteLine("CDEFGAB is the 'C' major scale...");
      //}
      //else
      //{
      //    Console.WriteLine("Something went wrong");
      //}

      #endregion

      //show numbers with their corresponding ASCII characters starting with '10'

      #region

      //char ASCII;
      //int i = 10;

      //do
      //{
      //    Console.Write(i);
      //    Console.Write(" ");
      //    ASCII = (char)i;
      //    Console.WriteLine(ASCII);
      //    i++;
      //} while (i <= 255);
      //Console.ReadKey();

      #endregion

      //check to see if the user has entered an even or odd number

      #region

      //Console.WriteLine("Please enter a number...");
      //int oddOrEven = int.Parse(Console.ReadLine());

      //if (oddOrEven % 2 == 0)
      //{
      //    Console.WriteLine("this is an even number...");
      //}
      //else
      //{
      //    Console.WriteLine("this is an odd number...");
      //}

      #endregion

      //swap two numbers that user has entered

      #region

      //int num1, num2, temp;
      //WriteLine("Enter your first number...");
      //num1 = int.Parse(Console.ReadLine());
      //WriteLine("Enter your second number...");
      //num2 = int.Parse(Console.ReadLine());

      //temp = num1;
      //num1 = num2;
      //num2 = temp;

      //Console.WriteLine("After number swap");
      //Console.WriteLine("First number is now : "+num1);
      //Console.WriteLine("Second number is now : "+num2);

      #endregion

      //figures out the sum of all the digits entered by user

      #region

      //int num, sum = 0, rem;
      //Console.WriteLine("please enter a number...");
      //num = int.Parse(Console.ReadLine());

      //while (num != 0)
      //{
      //    rem = num % 10;
      //    num = num / 10;
      //    sum = sum + rem;
      //}
      //Console.WriteLine("The sum of the digits entered is : " + sum);

      #endregion

      //figures out the reverse of the entered number

      #region

      //int num, rev = 0;
      //Console.WriteLine("Please enter a number...");
      //num = int.Parse(Console.ReadLine());

      //while (num != 0)
      //{
      //    rev = rev * 10;
      //    rev = rev + num % 10;
      //    num = num / 10;
      //}

      //Console.WriteLine("Revers of Entered Number is : " + rev);

      #endregion

      //reverse an array of 10 numbers

      #region

      //    Console.WriteLine("Input 10 numbers and seperate each with a comma: ");

      //    string[] arrayInput = ReverseMyArray();

      //    Console.WriteLine($"{string.Join(" ", arrayInput)}");
      //}

      //public static string[] ReverseMyArray()
      //{
      //    var arrayInput = new String[9];
      //    arrayInput = Console.ReadLine().Split(',');
      //    Array.Reverse(arrayInput);
      //    return arrayInput;

      #endregion

      //My way:  adds the number of digits equal to 1

      #region

      //int enteredNumber, modEnteredNumber, currentCount = 0;
      //Console.WriteLine("Please enter a number...");
      //enteredNumber = int.Parse(Console.ReadLine());
      //while (enteredNumber != 0)
      //{
      //    modEnteredNumber = enteredNumber % 10;
      //    enteredNumber = enteredNumber / 10;
      //    if (modEnteredNumber == 1)
      //    {
      //        currentCount += 1;
      //    }
      //}
      //Console.WriteLine("The number digits equal to 1 are : " + currentCount);

      #endregion

      //Their way:  adds the number of digits equal to 1

      #region

      //int m, count = 0;
      //Console.WriteLine("Enter the Limit : ");
      //m = int.Parse(Console.ReadLine());
      //int[] a = new int[m];
      //Console.WriteLine("Enter the Numbers :");
      //for (int i = 0; i < m; i++)
      //{
      //    a[i] = Convert.ToInt32(Console.ReadLine());
      //}
      //foreach (int o in a)
      //{
      //    if (o == 1)
      //    {
      //        count++;
      //    }
      //}
      //Console.WriteLine("Number of 1's in the Entered Number : ");
      //Console.WriteLine(count);
      //Console.ReadLine();

      #endregion

      //generates 4 random numbers

      #region

      //Random rnd = new Random();
      //for (int i = 0; i < 4; i++)
      //{
      //    int randomNumber = rnd.Next();
      //    Console.WriteLine(randomNumber);
      //    Console.ReadKey(true);
      //}

      #endregion

      //checks to see if the year entered is a leap year

      #region

      //var leapYearCheck = -1;
      //try
      //{
      //    while (leapYearCheck != 0)
      //    {
      //        Console.WriteLine("please enter year to see if it is a leap year...");
      //        leapYearCheck = int.Parse(Console.ReadLine());

      //        if (leapYearCheck % 4 == 0 && leapYearCheck % 100 != 0 || leapYearCheck % 400 == 0)
      //        {
      //            Console.WriteLine("{0} is a leap year...", leapYearCheck);
      //        }
      //        else if ((leapYearCheck % 4 == 0) && (leapYearCheck % 100 == 0))
      //        {
      //            Console.WriteLine("{0} is not a leap year...", leapYearCheck);
      //        }
      //        else
      //        {
      //            Console.WriteLine("{0} is not a leap year...", leapYearCheck);
      //        }
      //    }
      //}
      //catch (Exception) { }

      #endregion

      //swaps two integers using Bitwise XOR operation

      #region

      //int i, k;
      //Console.WriteLine("Enter two integers \n");
      //i = int.Parse(Console.ReadLine());
      //k = int.Parse(Console.ReadLine());
      //Console.WriteLine("\n Before swapping i = {0} and k = {1}", i, k);
      //i = i ^ k;
      //k = i ^ k;
      //i = i ^ k;
      //Console.WriteLine("\n After swapping i = {0} and k = {1}", i, k);
      //Console.ReadLine();

      #endregion

      //shows different datetime formats

      #region

      //DateTime date = new DateTime(2014, 12, 25);

      //Console.WriteLine(date.ToString("yyyy-MM-dd"));
      //Console.WriteLine(date.ToString("yyyy-dd-MM"));
      //Console.WriteLine(date.ToString("MM-dd-yyyy"));
      //Console.WriteLine(date.ToString("MM-yyyy-dd"));
      //Console.WriteLine(date.ToString("dd-yyyy-MM"));
      //Console.WriteLine(date.ToString("dd-MM-yyyy"));

      //DateTime date = DateTime.Now;
      //Console.WriteLine(date.ToString("dd-MM-yyyy"));
      //StringBuilder sb = new StringBuilder();
      //Console.WriteLine(sb.Append(date.ToString("dd-MM-yyyy")));

      #endregion

      //Binary triangle

      #region

      //int p, lastInt = 0, input;
      //Console.WriteLine("Enter the Number of Rows : ");
      //input = int.Parse(Console.ReadLine());
      //for (int i = 1; i <= input; i++)
      //{
      //    for (p = 1; p <= i; p++)
      //    {
      //        if (lastInt == 1)
      //        {
      //            Console.Write("0");
      //            lastInt = 0;
      //        }
      //        else if (lastInt == 0)
      //        {
      //            Console.Write("1");
      //            lastInt = 1;
      //        }
      //    } Console.Write("\n");
      //}
      //Console.ReadLine();

      #endregion

      //compares two different dates

      #region

      //DateTime date = new DateTime();
      //date = DateTime.Now;
      //DateTime dateToCompare = date.AddDays(10);

      //if (date < dateToCompare)
      //{
      //    Console.WriteLine("you have done this problem correctly");
      //    Console.WriteLine("the two dates you wanted to compare are...\n");
      //    Console.WriteLine("1 - {0}", date);
      //    Console.WriteLine("2 - {0}", dateToCompare);
      //    Console.WriteLine("{0} will occur before {1}", date, dateToCompare);
      //}
      //else
      //{
      //    Console.WriteLine("this problem was done incorrectly...");
      //    Console.WriteLine("please refactor..");
      //}

      #endregion

      //generates 1000 random numbers

      #region

      //Random r = new Random();
      //for (int i = 0; i < 1000; i++)
      //{
      //    int nextRandom = r.Next();
      //    Console.WriteLine(nextRandom);
      //}

      #endregion

      //loan calculator (INCOMPLETE)

      #region

      //int loanAmount;
      //double annualPercentageRate, loanTerm, monthlyPayment,
      //    aprDecimalMove, loanTotalWithAPR;

      //Console.WriteLine("Enter the Loan amount");
      //loanAmount = int.Parse(Console.ReadLine());
      //Console.WriteLine("Enter the APR");
      //annualPercentageRate = double.Parse(Console.ReadLine());
      //Console.WriteLine("Enter the Loan term in months");
      //loanTerm = double.Parse(Console.ReadLine());

      //aprDecimalMove = annualPercentageRate /= 100;
      //loanTotalWithAPR = aprDecimalMove * loanAmount;
      //loanTotalWithAPR = loanAmount + aprDecimalMove;
      //monthlyPayment = loanTotalWithAPR / loanTerm;

      //Console.WriteLine(monthlyPayment);

      #endregion

      //show  pattern with '*******' starting on first row, subtracting on character for each new row

      #region

      // int i, j;
      // for (i = 0; i <= 6; i++)
      // {
      //     for (j = 1; j <= 7 - i; j++)
      //         Console.Write("*");
      //     Console.Write("\n");
      //}

      // Console.ReadLine();

      #endregion

      //exercise from mark.

      #region

      //StringBuilder result = new StringBuilder();
      //const string testString = @"The quick brown fox jumps over the lazy dog";
      //var wordCount = testString.Length;
      //foreach (var word in testString.Split(' '))
      //{
      //    result.Append($"{word}").Append(--wordCount > 0 ? " " : "");

      //    Console.Write($"{word}");
      //    wordCount = wordCount - 1;
      //    if (wordCount > 0)
      //    {
      //        Console.Write(" ");
      //    }


      //    Console.Write($"{word}");
      //    Console.Write("{0}", --wordCount > 0 ? " " : "");

      //}

      #endregion

      //allows a user to guess a number between 1 and 6 that will be randomly generated by the computer

      #region

      //Console.WriteLine("Pick a number between 1 and 6");
      //int userGuess = int.Parse(Console.ReadLine());
      //Random ranGuess = new Random();
      //int ranSwitch = ranGuess.Next(0,6);

      //Console.WriteLine("The random number is....." + ranSwitch);

      //if (ranSwitch == userGuess)
      //{
      //    Console.WriteLine("You Win!!");
      //}

      #endregion

      //create a triangle based on user input. 

      #region

      Console.WriteLine("enter a size for the base of the triangle...");
      int subOne, baseOfTriangleCount = int.Parse(Console.ReadLine());
      for (int i = 0; i <= baseOfTriangleCount; i++) {

      }
      Console.ReadKey();
      #endregion
    }
  }
}