// string color,pluralNoun,celebrity;

// Console.Write("Enter a color: ");
// color = Console.ReadLine();
// Console.Write("Enter a plural noun: ");
// pluralNoun = Console.ReadLine();
// Console.Write("Enter a Celebrity Name: ");
// celebrity = Console.ReadLine();


// Console.WriteLine("Roses are " + color);
// Console.WriteLine(pluralNoun + " are blue");
// Console.WriteLine("I love " + celebrity);

// Arrays

// Methods

// static void SayHi(string name)
// {
//   Console.WriteLine("Hello " + name);
// }

// SayHi("Mike");

// Return Statement

// static int Cube(int num) 
// {
//   int result = num * num * num;
//   return result;
// }

// Console.WriteLine(Cube(5));

// If Statements

// bool isMale = false;
// bool isTall = true;
// if (isMale || isTall)
// {
//   Console.WriteLine("You are nigga");
// } else
// {
//   Console.WriteLine("HI gal");
// }

// static int GetMax(int num1, int num2, int num3) 
// {
//   int result;

//   if (num1 > num2 && num1 > num3)
//   {
//     result = num1;
//   } else if (num1 !> num2 && num2 > num3)
//   {
//     result = num2;
//   } else
//   {
//     result = num3;
//   }

//   return result;
// }

// Console.WriteLine(GetMax(30, 10, 4));

// Building a calculator
// Console.Write("Enter a number: ");

// double num1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Mathematical sign: ");

// string op = Console.ReadLine();

// Console.Write("Enter a Second number: ");

// double num2 = Convert.ToDouble(Console.ReadLine());

// if (op == "+")
// {
//   Console.WriteLine(num1 + num2);
// } else if (op == "-")
// {
//   Console.WriteLine(num1 - num2);
// } else if (op == "*")
// {
//   Console.WriteLin(num1 * num2);
// } else if (op == "/")
// {
//   Console.WriteLine(num1 / num2);
// } else 
// {
//   Console.WriteLine("Error! Invalid operator");
// }


// Switch Statements

//   static string GetDay(int dayNum) 
//   {
//     string dayName;

//     switch (dayNum)
//     {
//       case 0:
//       dayName = "Sunday";
//       break;
//       case 1:
//       dayName = "Monday";
//       break;
//       case 2:
//       dayName = "Tuesday";
//       break;
//       case 3:
//       dayName = "Wednesday";
//       break;
//       case 4:
//       dayName = "Thursday";
//       break;
//       case 5:
//       dayName = "Friday";
//       break;
//       case 6:
//       dayName = "Saturday";
//       break;
//       default:
//       dayName = "Invalid Day";
//       break;
//     }

//     return dayName;
//   }

// Console.WriteLine(GetDay(7));

// While Loop

// int index = 1;
// while (index <= 5)
// {
//   Console.WriteLine(index);
//   index++;
// }

// How To Build a Guessing Game

// string secretWord = "giraffe";
// string guess = "";
// int guessCount = 0;
// int guessLimit = 3;
// bool outOfGuesses = false;

// while (guess != secretWord && !outOfGuesses)
// {
//   if (guessCount < guessLimit)
//   {
//    Console.Write("Guess the Secret Animal: ");
//     guess = Console.ReadLine().ToLower();
//     guessCount++; 
//   } else 
//   {
//     outOfGuesses = true;
//   }
// }
// if(outOfGuesses)
// {
//   Console.WriteLine("You Loose!");
// } else
// {
//  Console.WriteLine("Successful!"); 
// }

// For Loop

// int[] luckyNumbers = { 10, 3, 5, 35, 16, 42 };
// for (int i = 0; i < luckyNumbers.Length; i++)
// {
//   Console.WriteLine(luckyNumbers[i]);
// }

// Exponents

// static int GetPower(int baseNum, int powNum)
// {
//   int result = 1;

//   for (int i = 0; i < powNum; i++)
//   {
//     result = result * baseNum;
//   }

//   return result;
// }

// Console.WriteLine(GetPower(3,2));

// 2D Arrays

// int[,] numbergrid = {
//   {1, 2, 5, 6},
//   {45, 3, 65, 9}
// };

// Console.WriteLine(numbergrid[0,2]);

// Exception Handling

// try
// {
//   Console.Write("Enter a Number: ");
//   int num1 = Convert.ToInt32(Console.ReadLine());
//   Console.Write("Enter a Number: ");
//   int num2 = Convert.ToInt32(Console.ReadLine());

//   Console.WriteLine(num1 / num2);
// }
// catch (Exception e)
// {
//   Console.WriteLine(e.Message + " So an Error Occurred");
// }
// finally
// {

// }

// Classes and Objects

Book book1 = new Book();
book1.title = "Harry Potter";
book1.author = "Jk Rowling";
book1.pages = 400;

Console.WriteLine(book1.title);
