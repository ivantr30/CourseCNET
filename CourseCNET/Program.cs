using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Threading;

namespace CourseCNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CourseCNET";
            /*
            char ch = (char)Console.Read();
            string? input = Console.ReadLine();
            Console.WriteLine("Hello " + input);
            */

            //string num = "5";
            //int a = Convert.ToInt32(num);

            //string str = "brrrr";
            //using (FileStream fl = new FileStream("text.txt", FileMode.OpenOrCreate))
            //{
            //    byte[] arr = System.Text.Encoding.Default.GetBytes(str);
            //    fl.Write(arr, 0, arr.Length);
            //}
            //using (FileStream flr = File.OpenRead("text.txt"))
            //{
            //    byte[] arr = new byte[flr.Length];
            //    flr.Read(arr,0,arr.Length);
            //    string txt = System.Text.Encoding.Default.GetString(arr);
            //}

            //string str = "1.9";
            //NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            //{
            //    NumberDecimalSeparator = ".",
            //};
            //double d = Convert.ToDouble(str);
            //Console.WriteLine(d);

            //string str = "5.7";
            //double a;
            //bool result = double.TryParse(str,out a);
            //Console.WriteLine(a);

            //int firstNumber;
            //bool firstNumberResult = int.TryParse(Console.ReadLine(), out firstNumber);
            //if (!firstNumberResult)
            //{
            //    Console.WriteLine("Error: wrong input format");
            //}
            //int secondNumber;
            //bool secondNumberResult = int.TryParse(Console.ReadLine(), out secondNumber);
            //if (!secondNumberResult)
            //{
            //    Console.WriteLine("Error: wrong input format");
            //}
            //double result = (double) (firstNumber + secondNumber)/2;
            //Console.WriteLine(result);

            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //int secondNumber = Convert.ToInt32(Console.ReadLine());
            //int thirdNumber = Convert.ToInt32(Console.ReadLine());
            //int sum = firstNumber + secondNumber + thirdNumber;
            //int multiply = firstNumber * secondNumber * thirdNumber;
            //Console.WriteLine(sum);
            //Console.WriteLine(multiply);

            //Console.WriteLine("Choose currency - Rub(r) or Dol(d)");
            //char chooseCurrency = Console.ReadLine()[0];
            //double res = 0;
            //if(chooseCurrency == 'r' || chooseCurrency == 'R')
            //{
            //    double rubles = Convert.ToInt32(Console.ReadLine());
            //    res = rubles / 100;
            //}
            //if (chooseCurrency == 'd' || chooseCurrency == 'D')
            //{
            //    double dollars = Convert.ToInt32(Console.ReadLine());
            //    res = dollars * 100;
            //}
            //Console.WriteLine(res);

            //int test1 = 2 + 2 * 2;
            //// same result
            //int test2 = 2 + (2 * 2);
            //Console.WriteLine(test1 + " " + test2);

            //double firstValue, secondValue;
            //Console.WriteLine("Enter firstValue");
            //bool firstInputRes = double.TryParse(Console.ReadLine(), out firstValue);
            //Console.WriteLine("Enter secondValue");
            //bool sceondInputRes = double.TryParse(Console.ReadLine(), out secondValue);
            //if (firstInputRes && sceondInputRes)
            //{
            //    double res = (firstValue + secondValue) / 2;
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("Error: invalid input format");
            //}

            //double firstValue, secondValue, thirdValue;
            //Console.WriteLine("Enter firstValue");
            //bool firstInputRes = double.TryParse(Console.ReadLine(), out firstValue);
            //Console.WriteLine("Enter secondValue");
            //bool secondInputRes = double.TryParse(Console.ReadLine(), out secondValue);
            //Console.WriteLine("Enter thirdValue");
            //bool thirdInputRes = double.TryParse(Console.ReadLine(), out thirdValue);
            //if (firstInputRes && secondInputRes && thirdInputRes)
            //{
            //    double sumResult = firstValue + secondValue + thirdValue;
            //    double multiplyRes = firstValue * secondValue * thirdValue;
            //    Console.WriteLine(sumResult + "\n" + multiplyRes);
            //}
            //else
            //{
            //    Console.WriteLine("Error: invalid input format");
            //}

            //double usdToRub = 105.96;
            //double inputCurrency;
            //Console.WriteLine("Enter currency, Rub(r), Usd(d)");
            //char currencyType = Console.ReadLine()[0];
            //Console.WriteLine("Enter currency count");
            //bool inputRes = double.TryParse(Console.ReadLine(), out inputCurrency);
            //if (inputRes)
            //{
            //    double result = 0;
            //    if (currencyType == 'r')
            //    {
            //        result = inputCurrency / usdToRub;
            //    }
            //    else if (currencyType == 'd')
            //    {
            //        result = inputCurrency * usdToRub;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: invalid currency type");
            //    }
            //    Console.WriteLine("The result is " + result);
            //}
            //else
            //{
            //    Console.WriteLine("Error: invalid input format");
            //}

            //int a = 0;
            //// a--;
            //// a++
            //Console.WriteLine(a++);
            //Console.WriteLine(++a);

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine()); faster

            //int number;
            //Console.WriteLine("Enter a number: ");
            //bool numberInputResult = int.TryParse(Console.ReadLine(), out number);
            //if (numberInputResult)
            //{
            //    Console.WriteLine(number % 2 == 0 ? "The number is even" : "The number is odd");
            //}
            //else
            //{
            //    Console.WriteLine("Error: invalid format input");
            //}

            //bool input = Convert.ToBoolean(Console.ReadLine());
            //bool input2 = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine(input | input2);
            //Console.WriteLine(input & input2);
            //Console.WriteLine(input || input2);
            //Console.WriteLine(input && input2); effitency
            //Console.WriteLine(input != input2);

            /*switch (consoleKey)
            {
                case ConsoleKey.None:
                    break;
                case ConsoleKey.Backspace:
                    break;
                case ConsoleKey.Tab:
                    break;
                case ConsoleKey.Clear:
                    break;
                case ConsoleKey.Enter:
                    break;
                case ConsoleKey.Pause:
                    break;
                case ConsoleKey.Escape:
                    break;
                case ConsoleKey.Spacebar:
                    break;
                case ConsoleKey.PageUp:
                    break;
                case ConsoleKey.PageDown:
                    break;
                case ConsoleKey.End:
                    break;
                case ConsoleKey.Home:
                    break;
                case ConsoleKey.LeftArrow:
                    break;
                case ConsoleKey.UpArrow:
                    break;
                case ConsoleKey.RightArrow:
                    break;
                case ConsoleKey.DownArrow:
                    break;
                case ConsoleKey.Select:
                    break;
                case ConsoleKey.Print:
                    break;
                case ConsoleKey.Execute:
                    break;
                case ConsoleKey.PrintScreen:
                    break;
                case ConsoleKey.Insert:
                    break;
                case ConsoleKey.Delete:
                    break;
                case ConsoleKey.Help:
                    break;
                case ConsoleKey.D0:
                    break;
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.D4:
                    break;
                case ConsoleKey.D5:
                    break;
                case ConsoleKey.D6:
                    break;
                case ConsoleKey.D7:
                    break;
                case ConsoleKey.D8:
                    break;
                case ConsoleKey.D9:
                    break;
                case ConsoleKey.A:
                    break;
                case ConsoleKey.B:
                    break;
                case ConsoleKey.C:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.E:
                    break;
                case ConsoleKey.F:
                    break;
                case ConsoleKey.G:
                    break;
                case ConsoleKey.H:
                    break;
                case ConsoleKey.I:
                    break;
                case ConsoleKey.J:
                    break;
                case ConsoleKey.K:
                    break;
                case ConsoleKey.L:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.N:
                    break;
                case ConsoleKey.O:
                    break;
                case ConsoleKey.P:
                    break;
                case ConsoleKey.Q:
                    break;
                case ConsoleKey.R:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.T:
                    break;
                case ConsoleKey.U:
                    break;
                case ConsoleKey.V:
                    break;
                case ConsoleKey.W:
                    break;
                case ConsoleKey.X:
                    break;
                case ConsoleKey.Y:
                    break;
                case ConsoleKey.Z:
                    break;
                case ConsoleKey.LeftWindows:
                    break;
                case ConsoleKey.RightWindows:
                    break;
                case ConsoleKey.Applications:
                    break;
                case ConsoleKey.Sleep:
                    break;
                case ConsoleKey.NumPad0:
                    break;
                case ConsoleKey.NumPad1:
                    break;
                case ConsoleKey.NumPad2:
                    break;
                case ConsoleKey.NumPad3:
                    break;
                case ConsoleKey.NumPad4:
                    break;
                case ConsoleKey.NumPad5:
                    break;
                case ConsoleKey.NumPad6:
                    break;
                case ConsoleKey.NumPad7:
                    break;
                case ConsoleKey.NumPad8:
                    break;
                case ConsoleKey.NumPad9:
                    break;
                case ConsoleKey.Multiply:
                    break;
                case ConsoleKey.Add:
                    break;
                case ConsoleKey.Separator:
                    break;
                case ConsoleKey.Subtract:
                    break;
                case ConsoleKey.Decimal:
                    break;
                case ConsoleKey.Divide:
                    break;
                case ConsoleKey.F1:
                    break;
                case ConsoleKey.F2:
                    break;
                case ConsoleKey.F3:
                    break;
                case ConsoleKey.F4:
                    break;
                case ConsoleKey.F5:
                    break;
                case ConsoleKey.F6:
                    break;
                case ConsoleKey.F7:
                    break;
                case ConsoleKey.F8:
                    break;
                case ConsoleKey.F9:
                    break;
                case ConsoleKey.F10:
                    break;
                case ConsoleKey.F11:
                    break;
                case ConsoleKey.F12:
                    break;
                case ConsoleKey.F13:
                    break;
                case ConsoleKey.F14:
                    break;
                case ConsoleKey.F15:
                    break;
                case ConsoleKey.F16:
                    break;
                case ConsoleKey.F17:
                    break;
                case ConsoleKey.F18:
                    break;
                case ConsoleKey.F19:
                    break;
                case ConsoleKey.F20:
                    break;
                case ConsoleKey.F21:
                    break;
                case ConsoleKey.F22:
                    break;
                case ConsoleKey.F23:
                    break;
                case ConsoleKey.F24:
                    break;
                case ConsoleKey.BrowserBack:
                    break;
                case ConsoleKey.BrowserForward:
                    break;
                case ConsoleKey.BrowserRefresh:
                    break;
                case ConsoleKey.BrowserStop:
                    break;
                case ConsoleKey.BrowserSearch:
                    break;
                case ConsoleKey.BrowserFavorites:
                    break;
                case ConsoleKey.BrowserHome:
                    break;
                case ConsoleKey.VolumeMute:
                    break;
                case ConsoleKey.VolumeDown:
                    break;
                case ConsoleKey.VolumeUp:
                    break;
                case ConsoleKey.MediaNext:
                    break;
                case ConsoleKey.MediaPrevious:
                    break;
                case ConsoleKey.MediaStop:
                    break;
                case ConsoleKey.MediaPlay:
                    break;
                case ConsoleKey.LaunchMail:
                    break;
                case ConsoleKey.LaunchMediaSelect:
                    break;
                case ConsoleKey.LaunchApp1:
                    break;
                case ConsoleKey.LaunchApp2:
                    break;
                case ConsoleKey.Oem1:
                    break;
                case ConsoleKey.OemPlus:
                    break;
                case ConsoleKey.OemComma:
                    break;
                case ConsoleKey.OemMinus:
                    break;
                case ConsoleKey.OemPeriod:
                    break;
                case ConsoleKey.Oem2:
                    break;
                case ConsoleKey.Oem3:
                    break;
                case ConsoleKey.Oem4:
                    break;
                case ConsoleKey.Oem5:
                    break;
                case ConsoleKey.Oem6:
                    break;
                case ConsoleKey.Oem7:
                    break;
                case ConsoleKey.Oem8:
                    break;
                case ConsoleKey.Oem102:
                    break;
                case ConsoleKey.Process:
                    break;
                case ConsoleKey.Packet:
                    break;
                case ConsoleKey.Attention:
                    break;
                case ConsoleKey.CrSel:
                    break;
                case ConsoleKey.ExSel:
                    break;
                case ConsoleKey.EraseEndOfFile:
                    break;
                case ConsoleKey.Play:
                    break;
                case ConsoleKey.Zoom:
                    break;
                case ConsoleKey.NoName:
                    break;
                case ConsoleKey.Pa1:
                    break;
                case ConsoleKey.OemClear:
                    break;
                default:
                    break;
            }
            */
            // тут обработка всех клавишей
            // / ConsoleKey.Oem2
            // * ConsoleKey.D8
            // + ConsoleKey.OemPlus
            // - ConsoleKey.OemMinus
            //double firstValue, secondValue;
            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Enter firstValue");
            //    bool firstInputResult = double.TryParse(Console.ReadLine(), out firstValue);
            //    Console.WriteLine("Enter secondValue");
            //    bool secondInputResult = double.TryParse(Console.ReadLine(), out secondValue);
            //    if (firstInputResult && secondInputResult)
            //    {
            //        Console.WriteLine("Enter operation '+' '-' '/' '*'");
            //        //ConsoleKey consoleKey = Console.ReadKey().Key;
            //        char action = Console.ReadLine()[0];
            //        Console.WriteLine();
            //        switch (action)
            //        {
            //            case '/':
            //                if (firstValue != 0 & secondValue != 0)
            //                {
            //                    Console.WriteLine($"The division of {firstValue} and {secondValue} is " + firstValue / secondValue);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Error: division by zero");
            //                    Console.WriteLine($"The division of {firstValue} and {secondValue} is " + 0);
            //                }
            //                break;
            //            case '*':
            //                Console.WriteLine($"The multiplying of {firstValue} and {secondValue} is " + firstValue * secondValue);
            //                break;
            //            case '+':
            //                Console.WriteLine($"The sum of {firstValue} and {secondValue} is " + (firstValue + secondValue));
            //                break;
            //            case '-':
            //                Console.WriteLine($"The substraction of {firstValue} and {secondValue} is " + (firstValue - secondValue));
            //                break;
            //            default:
            //                Console.WriteLine("Error: invalid operation");
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: invalid input format");
            //    }
            //    //Console.WriteLine("Continue? Y or N");
            //    //char continueOrStop = Console.ReadLine().ToLower()[0];
            //    //if (continueOrStop != 'y')
            //    //{
            //    //    break;
            //    //}
            //    Console.ReadKey();
            //}

            //int endOfRange, startOfRange;
            //uint countOfEven = 0, countOfOdd = 0;
            //int sumOfEven = 0, sumOfOdd = 0;
            //Console.WriteLine("Enter start point of the range");
            //bool startValueInputResult = int.TryParse(Console.ReadLine(), out startOfRange);
            //Console.WriteLine("Enter end point of the range");
            //bool rangeInputResult = int.TryParse(Console.ReadLine(), out endOfRange);
            //if (rangeInputResult & startValueInputResult & (startOfRange < endOfRange))
            //{
            //    for(int currentValue = startOfRange; currentValue <= endOfRange; currentValue++)
            //    {
            //        if(currentValue % 2 == 0)
            //        {
            //            countOfEven++;
            //            sumOfEven += currentValue;
            //        }
            //        else
            //        {
            //            countOfOdd++;
            //            sumOfOdd += currentValue;
            //        }
            //    }
            //    Console.WriteLine($"The count of even is {countOfEven} and of the odd is {countOfOdd}");
            //    Console.WriteLine($"The sum of even is {sumOfEven} and of the odd is {sumOfOdd}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: invalid input format");
            //}

            //Thread.Sleep(3000);

            ////int j = 5; тоже можно
            //for (int i = 0, j = 9; i < 5 & j < 12; i++,j++)
            //{
            //    Console.WriteLine("i: " + i);
            //    Console.WriteLine("j: " + j);
            //}

            //var sw = new Stopwatch();
            //int height = 0, countOfPairs = 0;
            //bool heightInputResult, countOfPairsInputResult;
            //string fillingSymbol;
            //Console.WriteLine("Enter height of the triangles");
            //heightInputResult = int.TryParse(Console.ReadLine(), out height);
            //Console.WriteLine("Enter count of triangle pairs");
            //countOfPairsInputResult = int.TryParse(Console.ReadLine(), out countOfPairs);
            //Console.WriteLine("Enter filling symbol(or even a string)");
            //fillingSymbol = Console.ReadLine();
            //sw.Start();
            //if (!(heightInputResult & countOfPairsInputResult))
            //{
            //    Console.WriteLine("Error: invalid input format");
            //}
            //if (height > 0 && countOfPairs > 0)
            //{
            //    for (int k = 1; k <= countOfPairs; k++)
            //    {
            //        for (int i = 1; i <= 2; i++)
            //        {
            //            for (int j = 0; j <= height; j++)
            //            {
            //                string output = "";
            //                if (i == 2)
            //                {
            //                    output = string.Concat(Enumerable.Repeat(fillingSymbol, height - j)) + string.Concat(Enumerable.Repeat(" ", j));
            //                }
            //                else
            //                {
            //                    output = string.Concat(Enumerable.Repeat(fillingSymbol, j)) + string.Concat(Enumerable.Repeat(" ", height - j));
            //                }
            //                if (k % 2 == 0)
            //                {
            //                    char[] charArray = output.ToCharArray();
            //                    Array.Reverse(charArray);
            //                    output = new string(charArray);
            //                }
            //                if (output.Trim() == "")
            //                {
            //                    continue;
            //                }
            //                Console.WriteLine(output);
            //            }
            //            Console.WriteLine();
            //        }
            //    }
            //}
            //sw.Stop();
            //Console.WriteLine(sw.ElapsedMilliseconds);

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 10; j > i; j--)
            //    {
            //       Console.Write(" ");
            //    }
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //int height = int.Parse(Console.ReadLine());
            //for (int i = 0; i < height; i++)
            //{
            //    Console.SetCursorPosition(10 - i, i + 1);
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //int[] myarr = { 1, 2, 3};
            //int[] myarr = Enumerable.Repeat(5,10).ToArray();
            //int[] myarr = Enumerable.Range(4,5).ToArray();
            //Console.WriteLine(string.Join(" ", myarr));

            //int arrayLength = int.Parse(Console.ReadLine());
            //int[] array = new int[arrayLength];
            //int sumOfEven = 0, minValue = int.MaxValue;
            //for(int i = 0; i < arrayLength;i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //    if (array[i] % 2 == 0)
            //    {
            //        sumOfEven += array[i];
            //    }
            //    if (array[i] < minValue)
            //    {
            //        minValue = array[i];
            //    }
            //}
            //Array.Reverse(array);
            //Console.WriteLine(string.Join(" ", array));
            //Console.WriteLine(minValue);
            //Console.WriteLine(sumOfEven);

            //int[] arr = { 18, 53, 37, 37, 793, 51, 51, 53, -5, 74 };
            //string str = "Hello world";
            //Index index = ^2;
            //Index index = new Index(3,false);
            //Range range = ^4..^1;
            //int[] arr2 = arr[range];
            //int[] arr2 = arr[1..4];
            //int[] arr2 = arr[..4];
            //int[] arr2 = arr[5..];
            //int result = arr.Where(i => i % 2 == 0).Sum();
            //int[] result = arr.Distinct().ToArray();
            //int[] result = arr.OrderBy(i => i).ToArray();
            //int[] result = arr.OrderByDescending(i => i).ToArray();
            //Array.Sort(arr);
            //int[] result = new int[arr.Length];
            //arr.CopyTo(result, 0);
            //int[] result = Array.FindAll(arr, i => i < 50);
            //int result = Array.Find(arr, i => i < 50);
            //int result = Array.FindLast(arr, i => i < 50);
            //int result = Array.FindIndex(arr, i => i == 74); // если нет то выдадет -1
            //int result = Array.FindLastIndex(arr, i => i == 74);
            //int[] result = arr.Where(i => i < 70).ToArray();// вместо ToArray() (int[]) можно First() or Last() (int)
            //int result = arr.Where(i => i < -7).FirstOrDefault(); вернёт 0
            //Console.WriteLine(string.Join(" ", arr[^1]));
            //Console.WriteLine(string.Join(" ", arr2));
            //Console.WriteLine(string.Join(" ", arr[index]));
            //Console.WriteLine($"value of {index.Value} is from end {index.IsFromEnd}");
            //Console.WriteLine(str[^1]);
            //Console.WriteLine(str[^2..]);
            //Console.WriteLine(str[0..6]);
            //foreach (var item in str[0..6])
            //{
            //    Console.WriteLine(item);
            //}

            //int[,] arr = new int[5,5];
            //int[,] arr = {
            //    {3, 5, 4, 5, 2},
            //    {9, 8, 8, 6, 2},
            //    {46, 943, 54, 721, 15},
            //    {-4, -71, -14, -5, 0}
            //};
            //arr[0, 2] = 52;
            //Console.WriteLine(arr[0,2]);
            //foreach(int i in arr){
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(arr.Rank);
            //Console.WriteLine(arr.Length);
            //int height = arr.GetLength(0);
            //int width = arr.GetLength(1);
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        Console.Write(arr[y, x] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int height = 0, width = 0;
            //Console.WriteLine("Enter height of the array");
            //bool heightInputRes = int.TryParse(Console.ReadLine(), out height);
            //Console.WriteLine("Enter width of the array");
            //bool widthInputRes = int.TryParse(Console.ReadLine(),out width);
            //int[,] array = new int[height, width];
            //for (int y = 0; y < height; y++)
            //{
            //    for (int x = 0; x < width; x++)
            //    {
            //        Console.WriteLine($"Enter element under the index of {y} y and {x} x");
            //        bool elementInput = int.TryParse(Console.ReadLine(), out array[y, x]);
            //        if (!elementInput)
            //        {
            //            Console.WriteLine($"Error: wrong input format at {y} y {x} x");
            //        }
            //    }
            //}
            //for (int i = 0; i < height; i++)
            //{
            //    for (int j = 0; j < width; j++)
            //    {
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int[,] ints = new int[10, 6];
            //Random random = new Random();
            //for (int y = 0; y < ints.GetLength(0); y++)
            //{
            //    for (int x = 0; x < ints.GetLength(1); x++)
            //    {
            //        ints[y, x] = random.Next();
            //    }
            //}
            //for (int i = 0; i < ints.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ints.GetLength(1); j++)
            //    {
            //        Console.Write(ints[i, j] + "\t");
            //    }
            //    Console.WriteLine("\n");
            //}

            //int[][] arr = new int[3][];
            //arr[0] = new int[3];
            //arr[1] = new int[2];
            //arr[2] = new int[7];
            //Random random = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        arr[i][j] = random.Next(-100,100);
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = 0; j < arr[i].Length; j++)
            //    {
            //        Console.Write(arr[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //int[] ints = arr[0];
            //Console.WriteLine(arr[0][2]);
            //int[,] arr2 = new int[3, 3];
            //Console.WriteLine(arr.Length);
            //Console.WriteLine(arr2.Length);
            //Console.WriteLine(arr.Rank);
            //Console.WriteLine(arr2.Rank);

            // понятие массива в виде: полка - тетрадь - страница - строчка - столбец
            //                                               z         y         x
            //int[,,] ints =
            //{
            //    {
            //        {2,5,7 },
            //        {9,44,82 }
            //    },
            //    {
            //        {-2,-5,-7 },
            //        {-9,-44,-82 }
            //    },
            //    {
            //        {744,21345,1345 },
            //        {5487,3715,12672 }
            //    }
            //};
            //Random random = new Random();
            //int[,,] ints = new int[3, 2, 5];
            //for (int z = 0; z < ints.GetLength(0); z++)
            //{
            //    Console.WriteLine("страница, номер "+ (z + 1));
            //    for (int y = 0; y < ints.GetLength(1); y++)
            //    {
            //        Console.WriteLine("\tстолбец, номер " + (y + 1));
            //        for (int x = 0; x < ints.GetLength(2); x++)
            //        {
            //            ints[z, y, x] = random.Next(-100, 100);
            //            Console.WriteLine("\t\tстрочка, номер " + (x + 1));
            //            Console.WriteLine("\t\t\t"+ints[z, y, x]);
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //Random random = new Random();
            //int[][][] ints = new int[random.Next(1, 5)][][];
            //for (int z = 0; z < ints.Length; z++)
            //{
            //    ints[z] = new int[random.Next(1, 6)][];
            //    for (int y = 0; y < ints[z].Length; y++)
            //    {
            //        ints[z][y] = new int[random.Next(1, 6)];
            //        for (int x = 0; x < ints[z][y].Length; x++)
            //        {
            //            ints[z][y][x] = random.Next(-100, 100);
            //        }
            //    }
            //}
            //for (int z = 0; z < ints.Length; z++)
            //{
            //    Console.WriteLine("страница, номер " + (z + 1));
            //    for (int y = 0; y < ints[z].Length; y++)
            //    {
            //        Console.WriteLine("\tстрочка, номер " + (y + 1));
            //        Console.Write("\t\t");
            //        for (int x = 0; x < ints[z][y].Length; x++)
            //        {
            //            Console.Write(ints[z][y][x] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //Console.WriteLine(getIndex(new int[] {2, 6, 3, 7, 2, 3, 47, 3276, -3, 562, -46, 0}, 0));
            //int[] ints = { 2, 6, 3, 7, 2, 3, 47, 3276, -3, 562, -46, 0 };
            //Console.WriteLine(Array.IndexOf(ints, 0));
            //Console.WriteLine(Array.FindIndex(ints, i => i == 0));

            //char symbol;
            //uint symbolsCount;
            //bool symbolsCountInputResult;
            //Console.WriteLine("Enter symbol to be written");
            //symbol = Console.ReadKey().KeyChar;
            //Console.WriteLine("\nEnter how many times symbol to be written");
            //uint.TryParse(Console.ReadLine(), out symbolsCount);
            //printString(symbol, symbolsCount);

            //Console.WriteLine(string.Join(" ",getRandomArray(5,-2,5)));

            // struct остаются только в пределах своих областей видимости(меньше, быстрее), имеет дефолтное значение
            // class остаютсяя до уборки сборщиком мусора(больше, медленее), null - дефолтное значение
            //string str = null;
            ////string result = str ?? "No data";
            //string result = str ?? string.Empty; 
            //Console.WriteLine("Lenght of line's symbols is " + result.Length);
            //string str = null;
            //str ??= "No data";
            //Console.WriteLine(str);
            //int[] arr = null;
            //arr ??= new int[0];
            // проект можно перенести со старой версии си шарп на новую
            //int[] arr = null;
            //Console.WriteLine((arr?.Sum() ?? 0));    
            // Person?.Contacts?.PhoneNumber ?? "No data"\

            //int a = 6;
            //Foo(ref a);
            //Console.WriteLine(a);
            //Mystruct mystruct = new Mystruct(); сохраняет значние из метода только при использовани ref
            //Foo(ref mystruct);
            //Myclass myclass = new Myclass(); сохраняет значение из метода всегда
            //Foo(myclass);
            //int[] arr = { 3, 5, 7 };
            //Bar(arr);
            //Console.WriteLine(string.Join(", ", arr));

            //int[] ints = { 8, 23, 5, 14 };
            //ref int b = ref ints[0]; // де факто теперь b контроллирует первый элемент массива ints
            //ref int b = ref Foo(ints); // в методе передали ссылку и создаём переменную, контроллирующую значение по той ссылке
            //b = -5;

            // test 1 correct array correct length - succed
            // test 2 correct array wrong length - succed
            // test 3 wrong array correct length - succed
            // test 4 wrong array wrong length - succed

            //int[] array = null; // test case
            //Console.WriteLine(string.Join(", ", Resize(array, 3)));

            //int[] arrayToBeResized;
            //uint arrayLength, newArrayLength;
            //bool lengthInputResult, newLengthInputResult;

            //Console.WriteLine("Hello, enter your array length");

            //lengthInputResult = uint.TryParse(Console.ReadLine(), out arrayLength);
            //arrayToBeResized = new int[arrayLength];

            //if (lengthInputResult)
            //{
            //    for (int i = 0; i < arrayToBeResized.Length; i++)
            //    {
            //        Console.WriteLine($"Enter the element under the index of {i}");

            //        bool elementInputResult = int.TryParse(Console.ReadLine(), out arrayToBeResized[i]);

            //        if (!elementInputResult)
            //        {
            //            Console.WriteLine($"Error: invalid input format unde the index of {i}");
            //        }
            //    }
            //    Console.WriteLine("Enter the new length of the array");

            //    newLengthInputResult = uint.TryParse(Console.ReadLine(), out newArrayLength);

            //    if (!newLengthInputResult)
            //    {
            //        Console.WriteLine("Error: wrong new length format");
            //    }
            //    else
            //    {
            //        Resize(ref arrayToBeResized, newArrayLength);
            //        Console.WriteLine(string.Join(", ", arrayToBeResized));
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Wrong length format");
            //}

            //int[] arr = null;
            //deleteAt(ref arr,2);
            //Console.WriteLine(string.Join(", ", arr ?? new int[] {}));

            // ref - не обязует присваивать значения
            // out - обязует присваивать значения, а также можно создавать переменную при вызове метода
            /* in - запрещает действия с переменной в методе
             * если не требуются изменения, то это эффективней и быстрее, чем просто к примеру int value
            */

            //Stopwatch sw = Stopwatch.StartNew(); // создаём таймер и сразу активируем
            // sw.Restart(); начинает таймер занаво

            //Console.WriteLine(Sum("res",6,3,6,2,6,2,67));

            //object o = 5; // упаковка, при извлечении будет распоковка

            //string str = "Message {0},{1}";
            //Console.WriteLine(str, 1, 3);

            //Sum(1, 2, true);
            //Sum(1, 2);
            //Sum(b: 2, a: 1); // именнованые параметры
            //Sum(firstValue : 1,secondValue : 2, enableLogging: true);
            //именованные параметры упрощают восприятие кода, без открытия самого метода

            //FooRecursia(0);

            //printArray(new int[] {2,5,6,4,7,3});
            //sumArray(new int[] { 2, 5, 6, 4, 7, 3 },0);
            //sumNumber(561);
            //int result = sumArray(new int[] { 2, 5, 6, 4, 7, 3 }, 0);
            //Console.WriteLine(result);
            //int result = sumNumber(561);
            //Console.WriteLine(result);
            //int value = 561;
            //int result = 0;
            //while (value > 0){
            //    result += value % 10;
            //    value /= 10;
            //}
            //Console.WriteLine(result);

            // Where используется для фильтрации и обрезки массива под условие
            /* 
             * Select перебор(как foreach), пользволяет получать индекс
             * Select((x,i) => x = i * 2), где x - текущее значение во время перебора(обозначение каждой ячейки во время перебора), и i - её индекс
            */
            // AsParallel() - делить задачу на потоки, оптимизирует, но нагружает все потоки
            //int[] ints = { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //ints = ints.AsParallel().Select((x,i) => x = i * 2).ToArray();
            //ints = ints.Select(x => x * 2).ToArray();
            //Console.WriteLine(string.Join(", ",ints));

            /*
             * Func<int, int[]> - тип возвращающий лямбда хуямбда функцию где int - тип, который будет во внутренней функции, а int[] - возвращаемое значение
             * public static Func<int, int[]> MultiplyAll(int[] ints)
             *   {
             *       return (int multiplier) => ints.Select(x => x * multiplier).ToArray();
             *   }
             *   Assert.That(Kata.(new int[] {1, 2, 3})(2), Is.EqualTo(new int[] {2, 4, 6})); - где (2) - int, а int{1,2,3} - получаемое возвращаемое значение
             *   
            */

            // неявное преобразование(автоматическое) называется implicit (float -> int) расширяющее
            // явное преобразование называется explicit ((float)doubleVariable -> float) сущающающее
            // float > int, что означает что float включит в себя int
            // double > float, что означает что float не включит в себя double
            //int a = 5;
            //float b = a;
            //double c = a;
            //float d = (float)c;
            //int a = 259;
            //byte b = (byte)a; если a > b, то b = 259 - 256 (3)
            //int a = 5;
            //float b = 2.5f;
            //float result = a + b;
            //Console.WriteLine(result);
            // переполнение через верхнюю границу к примеру (byte)(259 - 256) = 3 -> это значение будет при плюсовано к минимальному значению типа переменной, которой оно присвоено = 3
            // переполнение через нижнюю границу к примеру (byte)(0 - 1) = -1 -> это значение будет вычтено из максимального значения типа переменной, которой оно присвоено = 255
            // в настройках можно сделать выдачу ошибки при таком переполнении, но эта опция замедляет программу
            // checked проверяет строчки или блоки кода на арифметическое переполнение. Также выдаёт ошибку
            // unchecked наоборот выключает проверку арифметического переполнения для строчки или блока кода.
            //byte agression = 1;
            //byte democracyModifier = 2;
            //checked
            //{
            //    agression = (byte)(agression - democracyModifier);
            //}
            //agression = checked((byte)(agression - democracyModifier));
            //try
            //{
            //    agression = checked((byte)(agression - democracyModifier));
            //    Console.WriteLine(agression);
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Error overflow");
            //}
            //// это всё относится только к float, double
            //// проверка на бесконечность, ибо любое число, делённое на ноль будет равно бесконечности и isInfinity проверяет это
            //double a = 1.0 / 0.0;
            //Console.WriteLine(double.IsInfinity(a));
            //// 0 / 0 - не число и isNan проверяет число ли это
            //double b = 0.0 / 0.0;
            //Console.WriteLine(double.IsNaN(a));
            //// также если тип double переполнен, то он также выдаёт бесконечность
            //double c = double.MaxValue + double.MaxValue;
            //Console.WriteLine(double.IsInfinity(c));
            //decimal a = decimal.MaxValue;
            //decimal b = decimal.MaxValue;
            //// выдаст ошибку всегда, даже с unchecked
            //decimal c = a + b;

            // массив char можно вывести в консоль без запар
            // Console.WriteLine(new char[] { ',', ',', ',', ',', });

            //int? inty = null;
            //bool booly = inty.HasValue;
            //int res = inty.GetValueOrDefault();
            //res = inty.GetValueOrDefault(3);
            //res = inty ?? 55;
            // 3 + null = null

            //var t = 5;
            //var t = new float[10];
            //var k = new Dictionary<int, int>();
            //var l = new { Name = "Gay", age = 25 };
            //Console.WriteLine(t.GetType());
            //int[] ints = { 52, 5, 267, 2456, -245, 15 };
            //var result = from i in ints where i > 52 orderby i select i;
            //foreach(var j in result)
            //{
            //    Console.WriteLine(j);
            //}
            // применение var ограничевается локальным контекстом

            //ConsoleKey key = Console.ReadKey().Key;
            //int keyInt = (int)key;
            //Console.WriteLine(keyInt);
            //if(key == ConsoleKey.Enter)
            //{
            //    Console.WriteLine("Enter");
            //}
            //Console.WriteLine(Enum.GetUnderlyingType(typeof(DayOfWeek)));
            //DayOfWeek dayOfWeek = DayOfWeek.Tuesday;
            //Console.WriteLine(dayOfWeek);
            //Console.WriteLine((int)dayOfWeek);
            //Console.WriteLine((DayOfWeek)3);
            //dayOfWeek++;
            //int value = 55;
            //if(Enum.IsDefined(typeof(DayOfWeek), value))
            //{
            //    dayOfWeek = (DayOfWeek)value;
            //    Console.WriteLine("Enum value is valid");
            //}
            //var value = Enum.GetValues(typeof(DayOfWeek));
            //foreach(var v in value)
            //{
            //    Console.WriteLine(v);
            //}
            //string str = Console.ReadLine();
            //DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), str, ignoreCase : true);
            //Console.WriteLine(dayOfWeek);
            //switch (dayOfWeek)
            //{
            //    case DayOfWeek.Monday:
            //        break;
            //    case DayOfWeek.Tuesday:
            //        break;
            //    case DayOfWeek.Wednesday:
            //        break;
            //    case DayOfWeek.Friday:
            //        break;
            //    case DayOfWeek.Saturday:
            //        break;
            //    case DayOfWeek.Sunday:
            //        break;
            //    default:
            //        break;
            //}
            // дефолтное значение enum - int, но можно сделать любое значение с помощью : тип
            // если enum числовой, то можно рабоать с ним как с int
            // в enum каждый следующий элемент int будет иметь значение на 1 больше предыдущего

            //Point point = new Point(4, 7, Color.Red);
            //point.color = Color.Orange;
            // Guid используется для создания уникальных id
            // Guid.NewGuid()
            // функция которая является членом класса это метод
            // в c# функция без класса быть не может
            // итого метод = функция в c#

            //var typeOf = typeof(Point).GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            //foreach (var item in typeOf)
            //{
            //    Console.WriteLine($"{item.Name}\t IsPrivate: {item.IsPrivate} \t isPublic: {item.IsPublic}");
            //}

            // если поток один то он ждёт пока не получит ответ на к примеру вызов данных из базы данных, если несколько то тоже самое, ток эффективней
            // но чтобы потоки ничё не делали пока ждали ответ можно использовать асинхронность

            // интерфейсы нужны для обьединения разных типов одного обьекта под нужные параметры
            // обьекты обьединнёные интерфейсами могут иметь разные характеристики, методы и подобную хуйню,
            // но они всегда будут иметь основные свойства интерфейса, за счёт чего удобно будет реализовывать общие действия с ними
            //Rocket rocket = new Rocket();
            //rocket.Engine = new Engine();
            //Rocket rocket2 = new Rocket();
            //rocket2.Engine = new HyinaEngine();
            //rocket.Engine.Run();
            //rocket2.Engine.Run();

            //int[] arr = new int[] { 36, 6, 1, 82345, 19, -143, 5, -1, 37, 49, 51, 0, 134 };
            //MergeSorting(arr, 0, arr.Length - 1); - самый быстрый
            //Console.WriteLine(string.Join(", ", arr));
            //arr = new int[] { 36, 6, 1, 82345, 19, -143, 5, -1, 37, 49, 51, 0, 134 };
            //Console.WriteLine(string.Join(", ", MergeSorting2(arr))); чуток медленней
            //arr = new int[] { 36, 6, 1, 82345, 19, -143, 5, -1, 37, 49, 51, 0, 134 };
            //Console.WriteLine(string.Join(", ", MergeSorting3(arr))); самый медленный но и самый удобный

            // Array.Copy() копирует один массив в другой, есть разные вариации кода

            // в висуал студио есть снипет ctor создающий конструктор
            // стоит учитывать встроенные или созданные классы в конструкторах, к примеру DateTime

            // ##################
            // обьекты классов - это ссылки и присваивая одной ссылочной переменной другую мы получим просто привязку их обоих к одним и тем же данным
            // ##################
            // при изменении логики в классе может сломаться один из конструкторов, дабы это предотварить можно использовать цепочки конструкторов
            /*
             * public constructor(4 параметра к примеру) : this(2 параметра к примеру)
             * {
             *      действия с двумя параметрами
             * }
             */
            // this обеспечивает доступ к текущему экземпляру класса и неприменим к static методам
            // ОЧЕНЬ ВАЖНО ИСПОЛЬЗОВАТЬ ИМЕНОВАННЫЕ ПАРАМЕТРЫ
            // снипет propfull создаёт обьект с геттером и сеттером
            // гетсеттер можно использовать как переменную, а можно для работы с переменной. Пример в RocketHeader
            // get и set - аксессоры
            // снипет prop - сокращённая и нормальная реализация гетсеттера, пример в RocketHeader

            // если у нас есть класс, от которого нужно наследовать много разных классов и в некоторых логика некоторых методов отсутствует
            // то надо выносить такие методы в интерфейсы - это правило LSP

            // KeyValuePair - тип данных, позволяющий итерировать Dictionary с помощью foreach 
            // избегать вложений к примеру if-ов с помощью инверсии и в случае к примеру авторизации и аунтефикации объединять их или вынести вынести их логику 
            // в один метод по типу isValidUser
            // да и в целом стараться всё методизировать
            // избегать дубликации кода в методе также с помощью методов
            // в переменных в которых есть некая привязанность к единицам измерения чего то одного к примеру времени, стоит добавлять в чём оно измеряется
            // к примеру delaySeconds
            // при абстракции лучше уточнять именно названия дочерних классов

            // ФАЙЛЫ
            //string path = "C:\\Users\\Ivan\\Desktop\\урок28";
            //string fileName = "\\чучелобаля.txt";
            //using (File.Create(path + fileName)) создание файла
            //{

            //}
            //if (File.Exists(path + fileName)) проверка на сущестование
            //{
            //    if(!File.Exists("C:\\Users\\Ivan\\Desktop\\Сайт" + fileName))
            //    {
            //        File.Copy(path + fileName, "C:\\Users\\Ivan\\Desktop\\Сайт" + fileName); копирование файла из одной директории в другую
            //        Console.WriteLine("copy");
            //    }
            //    File.Delete(path + fileName); удаление файла
            //    Console.WriteLine("delete");
            //}
            //else
            //{
            //    File.Create(path + fileName);
            //    Console.WriteLine("create");
            //}
            //File.Delete(path + fileName);
            //File.Move(path + fileName, "C:\\Users\\Ivan\\Desktop\\Сайт" + fileName); перемещение файла
            //if (!File.Exists(path + fileName))
            //{
            //    File.Create(path + fileName).Close();
            //}
            //File.WriteAllText(path + fileName, File.ReadAllText(path + fileName) + "GOYDA\nGOYDA\n"); написать весь текст

            //string[] lines = File.ReadAllLines(path + fileName); массив всех строк

            //FileInfo fi1 = new FileInfo(path + fileName);
            //Console.WriteLine(fi1.FullName); полный путь
            //Console.WriteLine(fi1.Name); название и расширение
            //Console.WriteLine(fi1.Attributes); тип файла
            //Console.WriteLine(fi1.CreationTime); время создания
            //Console.WriteLine(fi1.Directory); //получаем директорию файла для дальнейшей работы с ней
            //Console.WriteLine(fi1.DirectoryName); //получаем полнои имя директори
            //Console.WriteLine(fi1.Extension); расширение
            //Console.WriteLine(fi1.Length); размер в байтах
            //Console.WriteLine(fi1.LastWriteTime); последнее время изменения

            //string lines = File.ReadAllText(path + fileName); // считать весь текст в одну переменную
            //lines = lines.Replace("чертила", "гойда");
            //File.WriteAllText(path + fileName, lines);
            //File.AppendAllText(path + fileName, "Za наших"); // добавление текста в конец файла

            //string fullPath = "C:\\Users\\Ivan\\Desktop\\урок28\\Урок29.txt";
            //StreamWriter swo = new StreamWriter(fullPath); // поток записывающий чтолибо в файлы
            //for (int i = 0; i < 10; i++)
            //{
            //    swo.WriteLine("ПЕНИС ЧЛЕН ЖОПА ТРАХАТЬСЯ");// запись только заменой
            //}
            //swo.Close();// надо закрывать
            //StreamReader sr = new StreamReader(fullPath); // поток считывающий содержание файлов
            //string text = sr.ReadToEnd();// прочесть до конца
            //Console.WriteLine(text);
            //string listText = sr.ReadLine(); // прочесть строку
            //Console.WriteLine(listText);

            //string text = sr.ReadToEnd();
            //string[] strings = text.Split("\n");
            //foreach (string s in strings)
            //{
            //    Console.WriteLine(s);
            //}

            // диски

            //DriveInfo[] drives = DriveInfo.GetDrives(); // список жёстких дисков компа
            //foreach (var drive in drives)
            //{
            //    Console.WriteLine(drive.Name); // жёсткий диск компа изображенный к примеру в виде C:\ 
            //    Console.WriteLine(drive.DriveType); // тип диска fixed или подобное
            //    Console.WriteLine(drive.TotalSize); // весь размер в байтах
            //    Console.WriteLine(drive.TotalFreeSpace); // свободное пространство в байтах
            //}

            // поиск файлов

            //string directoryPath = "C:\\Users\\Ivan\\Desktop\\Unity";
            //string[] files = Directory.GetFiles(directoryPath); // получаем файлы или точнее пути их хранения
            //// есть ещё getDirectories
            //foreach (var file in files)
            //{
            //    //Console.WriteLine(file);
            //    FileInfo fileInfo = new FileInfo(file); // получаем информацию из файла по пути его хранения
            //    Console.WriteLine(fileInfo.Name);
            //    Console.WriteLine(fileInfo.Length);
            //}

            // работа с каталогами (папками)

            //string dir = "C:\\";
            //string[] directories = Directory.GetDirectories(dir); // получаем все директории-папки
            //foreach (string d in directories)
            //{
            //    DirectoryInfo dInfo = new DirectoryInfo(d); // получаем информацию из папки по пути его хранения
            //    Console.WriteLine(dInfo.Name);
            //}

            //string pattern = Console.ReadLine();
            //string[] directories2 = Directory.GetDirectories(dir, $"*{pattern}*"); // паттерн определяет наличие строки в названии директории
            //string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories); // ищет во всех подпапках и благодаря "*" ищет все файлы
            //// паттерне также используются ? и *
            //foreach (string d2 in directories2)
            //{
            //    Console.WriteLine(d2);
            //}

            //string csFilePath = "C:\\Users\\Ivan\\source\\repos\\Lesson29\\Lesson29\\Program.cs";
            //string resultFile = "C:\\Users\\Ivan\\Desktop\\урок30\\result.cs";
            //string[] fileText = File.ReadAllLines(csFilePath);
            //for (int i = 0; i < fileText.Length; i++)
            //{
            //    fileText[i] = fileText[i].Replace("public", "private", StringComparison.OrdinalIgnoreCase);
            //}
            //if (File.Exists(resultFile))
            //{
            //    File.WriteAllLines(resultFile, fileText.Reverse());
            //}
            //else
            //{
            //    File.Create(resultFile);
            //    File.WriteAllLines(resultFile, fileText.Reverse());
            //}
            //string csFilePath = "C:\\Users\\Ivan\\source\\repos\\Lesson29\\Lesson29\\Program.cs";
            //string resultFile = "C:\\Users\\Ivan\\Desktop\\урок30\\result.cs";
            //string[] fileText = File.ReadAllLines(csFilePath);
            //for (int i = 0; i < fileText.Length; i++)
            //{
            //    char[] chars = fileText[i].ToCharArray();
            //    fileText[i] = string.Join("",chars.Reverse());

            //}
            //File.WriteAllLines(resultFile, fileText);

            /*
             * Написать программу, которая находит все файлы с заданным расширением в указанной директории и выводит их имена.
             */

            //Console.WriteLine("Enter extension");
            //string extension = Console.ReadLine();
            //if (!extension.StartsWith("."))
            //{
            //    extension = "." + extension;
            //}
            //string directoryPath = "C:\\Users\\Ivan\\Desktop\\Unity";
            //string[] files = Directory.GetFiles(directoryPath);
            //foreach (string file in files)
            //{
            //    FileInfo fileInfo = new FileInfo(file);
            //    if (fileInfo.Extension == extension)
            //    {
            //        Console.WriteLine(fileInfo.Name);
            //    }
            //}

            /*
             * Пользователь вводит путь к папке и искомое слово.
             * Программа ищет это слово в файлах данной папки.
             * После работы программы формируется отчет с информацией о том, где было слово найдено, количество совпадений.
             */
            //Console.WriteLine("Введите путь до папки");
            //string path = Console.ReadLine(); // получаем путь с консоли
            //Console.WriteLine("Введите искомое слово");
            //string word = Console.ReadLine(); // получаем искомое слово с консоли
            //string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories); // ищет во всех подпапках и благодаря "*" ищет все файлы
            //int countOfFiles = 0; // количество файлов, в которых мы найдём нужное слово
            //int countOfWords = 0;
            //foreach (string file in files) // перебираем все найденные файлы
            //{
            //    FileInfo fileInfo = new FileInfo(file); // сохраняем сюда характеристики файла
            //    if (fileInfo.Extension != ".txt") continue; // проверяем текстовый ли файл, если нет то скипаем эту итерацию
            //    if (!File.ReadAllText(file).Contains(word)) continue; // проверяем хранит ли слово в себе файл, если нет то также скип
            //    Console.WriteLine(file); // выводим путь файла
            //    string[] lines = File.ReadAllLines(file);
            //    for (int i = 0; i < lines.Length; i++)
            //    {
            //        string[] line = lines[i].Split(' ');
            //        for (int j = 0; j < line.Length; j++)
            //        {
            //            if (line[j].Contains(word))
            //            {
            //                countOfWords++;
            //            }
            //        }
            //    }
            //    countOfFiles++; // тк мы нашли совпадение то увеличиваем на 1
            //}
            //Console.WriteLine("Количество файлов: " + countOfFiles);
            //Console.WriteLine("Количество совпадений: " + countOfWords);

            // ДЕЛЕГАТЫ
            // делегат -> метод вызывающий другой метод
            /* к примеру с помощью делегата можно пометить объект и с помощью кнопки
             * взаимодействовать с ним. К примеру мы подошли к камню и активировали триггер 
             * триггер сохранил действие движения в делегат, и делает кнопку видимой
             * и только по нажатию кнопки можно сделать активацию метода
             * с помощью этого можно придумать логику как в mini ninjas чтоб можно было
             * при подходе к воротам включалась кнопка и появлялась возможность их открыть
             */
            // делегат Func возвращает значение полученное с метода, Action - нет
            // также можно создавать свои делегаты и переменной делегата можно присвоить
            // сразу несколько ссылок и при вызове исполнять сразу ряд действий
            // создание делегата с ключевым словом event запрещает обнуление его подписок
            // и вызова ИЗ ВНЕ
            // также в юнити можно взаимодействовать так не только с тригеррами, но и с тегами
            // к примеру прошли мы сквозь какой-то блок или взяли обьект и при взаимодействии -
            // в делегат записался какой-то метод, к примеру выпить, при нажатии на кнопку 
            // мы задействуем метод и к примеру удалим предмет из рук
            // OnClick в свойствах кнопки в юнити - это тоже делегат
            // Взаимодействие с кнопкой в юнити из другого скрипта -
            // имя_делегата.GetComponent()<Button>.OnClick().AddListener(delegate {экземпляр_делегата();});
            // скобках addlistener может быть просто делегат
            // либо () => действие
            // в юнити есть метод Find который находит и получает значение имеющегося в проекте обьекта -
            // по его названию

            // список.ForEach(делегат, вызываемый для каждого обьекта)
            // List group2 = group.FindAll(BornInSummer) - ищет всех, кто родился летом
            /*
             *private bool BornInSummer(Student student){
             * return student.BirthMonth >= 6 && student.BirthMonth <= 8
             *}
             */
            // методы compare(obj obj1, obj obj2) и obj1.compareTo(obj2) выдают int значения
            // сравнение по алфавиту, если в сравнении двух обьектов, к примеру строк второе больше,-
            // то compare выдаёт 1 -
            // если меньше, то -1, а если одинаково то 0
            /* 
             * Comparer<int>.Default.Compare(a, b);
             * 
             * string.Compare("apple", "banana");
             * 
             * Console.WriteLine(Comparer<int>.Default.Compare(5, 10)); // -1
             * 
             * Comparison<int> comp = (x, y) => x.CompareTo(y);
             * list.Sort(comp);
             * 
             * List<int> numbers = new List<int> { 5, 2, 9 };
             * numbers.Sort((x, y) => y.CompareTo(x)); // Сортировка по убыванию
             * 
             * | Что        | Где удобно использовать                  |
               |------------|-------------------------------------------|
               | `CompareTo` | Когда объект умеет сравнивать сам себя (например, `int`, `string`) |
               | `Compare`   | Когда не хочешь реализовывать интерфейсы |
               | `Comparison<T>` | Когда нужна гибкая сортировка (например, по нескольким параметрам) |
            public class Person : IComparable<Person>
            {
                public string Name { get; set; }
                public int Age { get; set; }

                public int CompareTo(Person other)
                {
                    if (other == null) return 1;
                    return this.Age.CompareTo(other.Age);
                }

                public override string ToString() => $"{Name}, {Age}";
            }
            Comparison<Person> compareByNameLength = (x, y) => x.Name.Length.CompareTo(y.Name.Length);

            people.Sort(compareByNameLength);

            Console.WriteLine("\nСортировка по длине имени:");
            foreach (var person in people)
            Console.WriteLine(person);


            //Определяем делегат для условия сортировки
            public delegate int SortDelegate(string str1, string str2);

            //Метод для сортировки массива строк
            public static void SortStrings(string[] strings, SortDelegate sortMethod)
            {
                Array.Sort(strings, new Comparison<string>(sortMethod));
            }

            //Метод для сортировки по длине строки (СРАВНЕНИЕ СЛОВ ПО ДЛИНЕ)
            public static int CompareByLength(string str1, string str2)
            {
                Console.WriteLine("Слово 2: " + str1 + " Слово 1: " + str2 + " Отношение: " + str1.Length.CompareTo(str2.Length));
                //Console.WriteLine(str1.Length.CompareTo(str2.Length));
                return str1.Length.CompareTo(str2.Length);
            }

            //Метод для сортировки по алфавиту (СРАВНЕНИЕ СЛОВ ПО АЛФАВИТУ)
            public static int CompareByAlphabet(string str1, string str2)
            {
                Console.WriteLine("Слово 1: " + str1 + " Слово 2: " + str2 + " Отношение: " + string.Compare(str1, str2));
                return string.Compare(str1, str2);
            }
             */
            // можно сортировать с помощью делегата, ток нужно создать нужный
            // если завернуть следующее выражение в метод, то можно фильтровать список по нужному формату
            // т.е. по методу выдающему bool
            // вместо метода делегату можно выдать лямбда выражние к примеру -
            // FilterDelegate xxx = x => x % 2 == 0
            // public delegate bool FilterDelegate(int number) - фильтрует интовые значения
            /* public bool IsEven(int number){
             * return x % 2 == 0;
             * }
             * filter = new FilterDelegate(IsEven)
             * foreach(item in items){
             * if(filter(item)){
             * list.Add(item)
             * }
             * }
             */
            // СОБЫТИЯ
            // клиент заплатил за услугу - работник заплатил за услугу -
            // тут надо использовать события
            // подписка на событие - подписка на метод, который при вызове вызывает все подписанные на него -
            // методы. К примеру есть группа студентов и препод, у препода есть метод проверки экзамена -
            // с помощью цикла подписываем каждого к методу проверки экзамена
            /* List<Student> students = group.FindAll(CanPassExam) - создаём новый список, фильтрованный -
             * делегатом
             * Teacher Michael = new Teacher()
             * foreach(Student student in students){
             * Michael.checkExam += student.TakeExam
             * }
             * После, у учителя вызываем метод
            */
            // АСИНХРОННОСТЬ
            // асинхронность позволяет программе не зацикливаться на одном действие и продолжать работать -
            // даже после вызова какого то асинхронного метода
            // await применим только к async методам

            //Button button = new Button();
            //button.OnClick += () => Console.WriteLine("Пшел нахуй");
            //button.Click();

            //Score score = new Score();
            //score.OnSubscribe += ShowScore;
            //score.OnSubscribe += ShowScore;
            //score.OnSubscribe += ShowScore;
            //score.OnSubscribe += ShowScore;
            //score.Number = 60;
            //score.Number = 30;
            //score.Number = 20;
            //score.Number = 10;

            // СТРОКИ
            // char.IsLetter, char.IsDigit - проверки: является ли символ буквой или числом
            // также есть другие такие функции
            // char.ToUpper, char.ToLower - меняем регистр
            // string a3 = new String(new char[] { 'a', 'd', 'j', 'i', 'g', 'i', 'r', 'e', 'i'}, 2, 3); -
            // составляем строку из массива символов путём выставления стартового и конечного индекса
            // a.LastIndexOf('и') - выдаёт последний номер элемента строки, -
            // соответствующего указанному символу
            // a.Insert(4, a3); //вставляет в строку другую строку в указанную позицию
            // string jjj = string.Join("_", sss); - делаем из массива строк одну с внедрением одного символа
            // Replace - меняем определённые фрагменты строки на другие
            // t = t.Trim(new char[] { 'и', ')', 'М' , '=', 'у', ' '}); создаём новую строку, -
            // где из массива убираем все пробелы
            // r = r.Remove(0, r.Length - 1); //убирает последнюю букву
            // r = r.Remove(3, 4); //удаляет 4 символа начиная с 3го

            // UNITY
            /*Составляющие Slider:
            Background - незакрашенный фон
            Fill area - закрашенный фон
            Handle Slide area -бегунок
            Параметры:
            направление(слева направо, сверху вниз)
            минимальное и максимальное значения
            whole numbers -только интовые значения в диапазоне
            базовое значение в виде так же slider
            также каждый элемент слайдера можно по-своему маштабировать 
            */
            // ===звуки===
            /*
             * AudioSource - компонент, воспроизводящий звук
             * AudioClip - параметр или элемент AudioSource, т.е. сам звук
             * Манипуляция с ними через код проста
             * public AudioClip AudioClip;
             * otherSounds.clip = AudioClip;
             * otherSounds.Play();
             * здесь мы добавили определённый звук(mp3, wav и тп) в AudioClip, применили и воспроизвели
             * 
             * public AudioSource bgMusic;
             * public Slider slider;
             * bgMusic.volume = slider.value;
             * сделали так, что громкость музыки эквивалента значению слайдера
             * а также подобная тема должна быть занесена в метод, который будет изменяться при каждой -
             * смене значения(в slider в самом юнити)
             
               AudioResource или AudioClip - сам звуковой файл
               Mute - выключить
               Play on Awake - воспроизводить по загрузке компонента
               Loop - зацикленность
               Priority - приоритет в плане громкости по отношению к другим звукам
               Volume - громкость от 0 до 1
               Pitch - звуковое искажение в движении
               Reverb zone mix -эхо
               Spatial blend -переход от 2d до 3d и наоборот
               Stereo Pan -в какой наушник будет звучать
               3d sound settings -из главного: кривая воспроизведения
            */

            // ===работа с объектами и компонентами===
            /*
             * GameObject.Find("MenuManager").GetComponent<AudioManager>().OnEscapeClickSound();
             * нашли объект - Find и обратились к его компоненту, после вызвали метод компонента(в наше-
             * м случае это AudioManager - самописный скрипт
             */
            // ===положение объектов===
            /*
             * transform.position = new Vector3(Random.Range(),Random.Range()) рандомно располагаем -
             * объект
             */
            //===Scroll View===
            /*
             * В Content добавлять сами объекты, а также компоненты -
             * (grid, horizontal, vertical - layout groups)
             * grid: расставляет объекты в сетку, пример - инвентарь
             * horizontal: расставляет объекты в ширь - 
             * пример: хотбар в майне вне инветаря или в аналог террарии
             * vertical: расставляет объекты в высоту -
             * пример: тот же хотбар, но сбоку, выглядящий достаточно солидно
             * В этих компонентах есть Spacing - разделение объектов, а также возможность -
             * сделать фиксированное количество рядов или столбцов, центровку объектов.
             * В компоненте Scroll Rect можно отключать движение по вертикали и горизонтали, -
             * а также Movement Type: то, как будет себя вести сама область -
                 * Clamped: не двигается дальше видимой части
                 * Elastic: возвращает к области после отжатия, но даёт доступ двигаться куда угодно
                 * Unrestricked: неограниченная, невозвращающаяся область
             * Сами ScrollBar можно кастомизировать, менять направление, диапазон значений и подобие -
             * WholeNumbers в виде Number of Steps
             * также у ScrollBar и самого ScrollView есть событие OnValueChanged
             * Также сами объекты - скролы можно удалить, при этом стоит предварительно отключить -
             * ту возможно в ScrollRect
             * Pivot в Content определяет центр и, следовательно, расположение объектов или поставить -
             * якоря в левом верхнем углу настройки компонента Rect Transform, а конкретней, Child -
             * Aligment будет вообще работать, только при постановлении центровки на center -
             * Pivot тоже обязательно настроить тк благодаря нему центровка будет человечной
             * Чтобы перемещать обьекты внутри Content надо ткнуть по самому Content
             * В Content Constraint отвечает за то, будет ли ограничение по рядам и будет ли оно
             * В Content Child Aligment отвечает за то, как будут распологаться объекты внутри ScrollView
             * В Image ScrollView можно убрать прозрачность и бэкграунда не будет
             * Сам Content можно менять в плане его размера
             * !!!!ВАЖНО!!!!: ЧТОБЫ SCROLLVIEW РАБОТАЛ НОРМАЛЬНО НУЖНО В CONTENT ДОБАВИТЬ 2 КОМПОНЕНТА -
             * FIT CONTENT, GRID ИЛИ ДРУГОЙ LAYOUT GROUP И ПОСТАВИТЬ ПАРАМЕТР CLAMPED -
             * и pivot поставить на 0 1
             */
            //===Material===
            /* Чтобы получить нормальный доступ к шейдрам нужно запускать HDRP проект
             * Шейдер - набор настроек и правил для рендера объекта
             * 
             * Skybox
             * 
             * Skybox 6 sided - просто настройки поворота и экспозиции + 6 пикч, из которых -
             * составлено небо
             * Skybox - то же самое, ток без некоторых настроек
             * Skybox Cubemap - просто карта и те же настройки
             * Panoramic - примерно тоже самое
             * Procedural - процедурное небо, настройки размеров солнца, его ореола, жирности атмосферы, -
             * экспозиция, наложение цвета на небо, наложения цвета на землю
             * Physically based - настройки космоса, поворота планеты и тп
             * 
             * Lit - шейдер для обычных обьектов
             * Можно поменять Opaque на Transparent и можно будет регулировать прозрачность
             * Base map - обычный цвет
             * Metallic - металличность
             * Smothness - отражаемость и сглаженность
             * 
             * Standard - обычный шейдер
             * У меня ничего не работает но настройки примерно те же, ток упрощённые
             * offset - смещение текстуры и с помощью него можно сделать анимацию через код -
             * (прокручивание)
             * Tiling - наложение
             * Normal map позволяет добавить карту нормалей и тем самым сделать иллюзию обьёма
             * Настройки normal map относится к освещению и созданию этой иллюзии
             * Base map - текстура или цвет
             * Mask map - отражения как после дождя
             * Use emissive ... - свечение
             * Intensivity регулирует силу свечения
             * Weigth де факто тоже самое, но для свечения надо выкручивать
             * 
             * Как использовать пикчи в unity? ===Sprite===
             * при добавлении пикчи её надо сделать спрайтом, т.е. поменять ей texture type
             * Wrap mode - будет ли пикча повторяться и чото ещё
             * Поменяв WrapMode на repeat можно будет нормально реализовать Tiling в материале
             * Sprite mode - будет ли текстура единичной, полигоном или множественной
             * Read/Write - возможность менять текстуру в коде
             * Если поменять Resize Algorithm можно убрать рябь при растяжении текстуры
             * Sprite можно накинуть на Material и редактировать его, к примеру с помощью того же -
             * transparent и opaque. Если png пикчу просто накинуть на обьект, то пустые пространства -
             * будут заполнены белым цветом
             * Generate mipmap + Aniso level делает реализм размывания 
             */
            //===Физика===
            /* Для физики объекту нужна коллизия и rigidbody
             * RigidBody - компонент, добавляющий физику объекту
             * Mass - масса объекта в кг
             * в constraint можно заблокировать поворот или движение по одной из осей к примеру чтобы - 
             * другие обьекты не толкали некоторый, но его можно двигать через код
             * Linear damping - сопротивление воздуха и в целом тормозит движение объектов в любой -
             * плоскости т.е. направлении
             * Angular damping - угловое сопротивление воздуха, тормозит поворот объектов при движении -
             * и, тем самым, само движение
             * Automatic center mass - автоматически определяет центр массы
             * при отключении этого прикола можно менять физический центр массы обьекта по всем осям.
             * Is kinematic - отключает физику и замораживает обьект
             * Use Gravity - без коментов
             * Automatic tensor - расчитывает вращение, при не автоматическом можно определить те -
             * части, относительно которых оно просчитывается. Помогает не заваливаться обьекту -
             * по некоторым осям.
             * Interpolate - интерполяция, т.е. сглаживает и просчитывает движение обьекта и -
             * делает плавный переход меж положениями обьекта.
             * - interpolate - плавный переход в плане отрисовки
             * - exterpolate - просчитывает будущее положение обьекта, нежелателен тк может менять -
             * движение.
             * Сolision detection - вид обнаружения коллизии
             * - continious - подгоняет кадры, выдаваемые компом так, чтобы избежать пролёта обьектов -
             * друг через друга.
             * Layer overrides - можно менять слои физики у обьектов, т.е. менять взаимодействие меж -
             * обьектами, а также эти взаимодействия можно менять в настройках проекта. К примеру можно
             * сделать так, чтобы один обьект игнорил другой, который тож имеет rigidbody
             * Масса почти не влияет на скорость падения, поэтому для ускорения падения нужно использ -
             * овать linear damping.
             * Объекты с большей массой менее движимы при столкновении и имеют большую силу для столкно- 
             * вения
             * При прохождении одного обьекта сквозь другой, надо поменять в настройках проекта - 
             * в разделе time уменьшить time stamp
             * обьект, имеющий родительский класс, связан с ним и дополняет его физику, даже если не -
             * имеет своей и меняет его центр массы.
             * Поменяв центр массы можно к примеру сделать неваляшку
             */
            
        }
        static void ShowScore(int newScore)
        {
            Console.WriteLine("Новое значение: " + newScore);
        }
        class Score
        {
            public event Action<int> OnSubscribe;
            private int number;
            public int Number {
                get
                {
                    return number;
                }
                set
                {
                    number = value;
                    OnSubscribe?.Invoke(number);
                }
            }
        }
        class Button
        {
            public event Action OnClick;

            public void Click()
            {
                OnClick?.Invoke();
            }
        }
        private static void SortPeople(List<string> names, Comparison<string> comparison)
        {
            string[] res = names.ToArray();
            Array.Sort(res, comparison);
            names = res.ToList();
        }
        private static List<int> Filter(List<int> numbers, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (int number in numbers)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }
            }

            return result;
        }
        private static int[] TransformArray(int[] numbers, Func<int, int> operation)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = operation(numbers[i]);
            }
            return numbers;
        }
        private static void LogMessages(List<string> messages, Action<string> logAction)
        {
            foreach (var message in messages)
            {
                logAction(message);
            }
        }
        public static string[] TransformStrings(string[] input, Func<string, string> transformer)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = transformer(input[i]);
            }
            return input;
        }
        public static int Apply(int x, int y, Func<int, int, int> operation)
        {
            return operation(x, y);
        }
        public delegate void SizeDelegate();

        public void Visota()
        {
            //gameObject.transform.localScale += Vector3(0,1,0);
        }
        public void Zhir()
        {
            //gameObject.transform.localScale += Vector3(1,0,0);
        }
        static int[,] MultiplyMatrices(int[,] A, int[,] B)
        {
            int rowsA = A.GetLength(0);
            int colsA = A.GetLength(1);
            int colsB = B.GetLength(1);

            int[,] C = new int[rowsA, colsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    for (int k = 0; k < colsA; k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                    }
                }
            }

            return C;
        }
        public static int[] MergeSorting3(int[] ints)
        {
            if (ints.Length <= 1)
            {
                return ints;
            }
            int middle = (ints.Length) / 2;

            int[] leftArray = MergeSorting3(ints[..middle]);
            int[] rightArray = MergeSorting3(ints[middle..]);

            return Merging3(leftArray, rightArray);

        }
        public static int[] Merging3(int[] leftArray, int[] rightArray)
        {
            List<int> result = new List<int>();

            int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    result.Add(leftArray[leftIndex]);
                    leftIndex++;
                }
                else
                {
                    result.Add(rightArray[rightIndex]);
                    rightIndex++;
                }
                mergedIndex++;
            }

            // копируем оставшиеся данных из подмассивов в результат
            result.AddRange(leftArray[leftIndex..]);
            result.AddRange(rightArray[rightIndex..]);
            return result.ToArray();
        }
        public static int[] MergeSorting2(int[] ints)
        {
            if (ints.Length <= 1)
            {
                return ints;
            }
            int middle = (ints.Length) / 2;

            int[] leftArray = MergeSorting2(ints[..middle]);
            int[] rightArray = MergeSorting2(ints[middle..]);

            return Merging2(leftArray, rightArray);
            
        }
        public static int[] Merging2(int[] leftArray, int[] rightArray)
        {
            int[] result = new int[leftArray.Length + rightArray.Length];

            int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

            while (leftIndex < leftArray.Length && rightIndex < rightArray.Length)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    result[mergedIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    result[mergedIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            // копируем оставшиеся данных из подмассивов в результат
            Array.Copy(leftArray[leftIndex..], 0, result, mergedIndex, leftArray[leftIndex..].Length); 
            Array.Copy(rightArray[rightIndex..], 0, result, mergedIndex, rightArray[rightIndex..].Length);
            return result;
        }
        public static void MergeSorting(int[] ints, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSorting(ints, left, middle);
                MergeSorting(ints, middle + 1, right);

                Merging(ints, left, middle, right);
            }
        }
        public static void Merging(int[] ints, int left, int middle, int right)
        {
            int leftSize = middle - left + 1;
            int rightSize = right - middle;

            int[] leftArray = new int[leftSize];
            int[] rightArray = new int[rightSize];

            for (int i = 0; i < leftSize; i++)
                leftArray[i] = ints[left + i];

            for (int j = 0; j < rightSize; j++)
                rightArray[j] = ints[middle + 1 + j];

            int leftIndex = 0, rightIndex = 0, mergedIndex = left;

            while (leftIndex < leftSize && rightIndex < rightSize)
            {
                if (leftArray[leftIndex] <= rightArray[rightIndex])
                {
                    ints[mergedIndex] = leftArray[leftIndex];
                    leftIndex++;
                }
                else
                {
                    ints[mergedIndex] = rightArray[rightIndex];
                    rightIndex++;
                }
                mergedIndex++;
            }

            while (leftIndex < leftSize)
            {
                ints[mergedIndex] = leftArray[leftIndex];
                leftIndex++;
                mergedIndex++;
            }

            while (rightIndex < rightSize)
            {
                ints[mergedIndex] = rightArray[rightIndex];
                rightIndex++;
                mergedIndex++;
            }
        }
        public class Rocket
        {
            public RocketHeader Header { get; set; }
            public IEngine Engine {  get; set; }

        }
        public class RocketHeader
        {
            public RocketHeader()
            {
                
            }
            private int fuel;

            public int Fuel
            {
                get
                {
                    return fuel;
                }
                set
                {
                    fuel = value;
                }
            }
            public int MyProperty { get; set; }

        }
        public class Engine : IEngine
        {
            public int Weight { get; }
            public int Power { get; }

            public void Run()
            {
                Console.WriteLine("Гойда");
            }

            public void Stop()
            {
                Console.WriteLine("Не Гойда");
            }
        }
        public class HyinaEngine : IEngine
        {
            public int Weight { get; }
            public int Power { get; }

            public void RunSlowly()
            {
                Console.WriteLine("Гойда медленная");
            }

            public void Run()
            {
                Console.WriteLine("Потужно");
            }

            public void Stop()
            {
                Console.WriteLine("Не Потужно");
            }
        }
        public interface IEngine
        {
            public void Run();
            public void Stop();
            public int Weight { get; }
            public int Power { get; }
        }
        public enum Color { 
            Red,
            Green,
            Blue,
            Yellow,
            White,
            Black,
            Orange
        }
        class Point
        {
            public Guid id;
            private int x;
            private int y;
            public Color color;

            public Point(int x, int y, Color color)
            {
                this.x = x;
                this.y = y;
                this.color = color;
            }
        }
        enum DayOfWeek : byte
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Friday,
            Saturday,
            Sunday,
        }
        public static int sumNumber(int value)
        {
            if(value < 10)
            {
                return value;
            }
            return value % 10 + sumNumber(value / 10);
        } 
        public static void sumNumber(int number, int result = 0, int i = 0)
        {
            if (i >= number.ToString().Length || i < 0)
            {
                Console.WriteLine(result);
                return;
            }
            sumNumber(number, result += int.Parse(number.ToString()[i].ToString()), i+1);
        }
        public static void sumArray(int[] ints, int result = 0, int i = 0)
        {
            if (i >= ints.Length || i < 0)
            {
                Console.WriteLine(result);
                return;
            }
            sumArray(ints, result += ints[i], i+1);
        }
        public static int sumArray(int[] ints, int i = 0)
        {
            if (i >= ints.Length || i < 0)
                return 0;
            return sumArray(ints, i + 1) + ints[i];
        }
        public static void printArray(int[] ints, int i = 0)
        {
            if (i >= ints.Length || i < 0)
                return;
            Console.WriteLine(ints[i]);
            printArray(ints, i+1);
        }
        // рекурсия занимает место в стеке до освобождения и увеличивается с каждым вызовом. Также занимаемая память зависит от данных, используемых в методе
        /*
         * можно в классе создавать поле, которое может быть того же типа, что и класс, благодаря чему можно создавать цепочки объектов
         * (к примеру маршрут) на примере игры, сделанной мною на занятиях по java
         * перебирать это можно методом и циклом, к примеру
         * for(Item i = item; i != null; i = i.Child){
         * Console.WriteLine(i.Value);
         * }
        */
        //public static void FooRecursia(int i)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //    FooRecursia(i);
        //}
        /*
         * необязательный параметр может быть любого типа, но с дефолтным(указанным в методе) значении.
         * после необязательного параметра нельзя ставить обязательные
         * enableLogging, c, params ints - необязательные параметры
         * params может быть пустым
        */
        public static int Sum(int firstValue, int secondValue, bool enableLogging = false, int c = 0, params int[] ints)
        {
            if (enableLogging)
            {
                Console.WriteLine(firstValue + secondValue);
                return firstValue + secondValue;
            }
            return firstValue + secondValue;
        }
        /* 
         * нельзя добавлять через запятую другие параметры ПОСЛЕ params
         * params в методе только 1
         * можно передать массив типа object[] для разнообразия принимаемых параметров(ибо все наследованны от object)
        */
        public static int Sum(string strs,params int[] ints) 
        {
            int result = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                result += ints[i];
            }
            return result;
        }
        public static void Bar(out int variable)
        {
            variable = 5; // обязательно любое присваение
        }
        public static void FooRef(ref int variable)
        {
            variable = 5; // необязательное действие
        }
        public static void FooIn(in int variable)
        {
        //    variable = 5; // запрещённое действие
        }
        public static void addFirst<T>(ref T[] inputArray, T element)
        {
            addAt(ref inputArray, element,0); 
        }
        public static void addLast<T>(ref T[] inputArray, T element)
        {
            addAt(ref inputArray, element, inputArray.Length);
        }

        public static void addAt<T>(ref T[] inputArray, T element, int index)
        {
            int inputArrayLength = inputArray?.Length ?? -1;
            if (index > inputArrayLength || index < 0)
            {
                return;
            }
            T[] newArray = new T[inputArrayLength + 1];
            newArray[index] = element;
            for (int i = 0; i < index; i++)
            {
                newArray[i] = inputArray[i];
            }
            for(int i = index; i < inputArrayLength; i++)
            {
                newArray[i+1] = inputArray[i];
            }
            inputArray = newArray;
        }
        public static void deleteFirst<T>(ref T[] inputArray)
        {
            deleteAt(ref inputArray, 0);
        }
        public static void deleteLast<T>(ref T[] inputArray)
        {
            deleteAt(ref inputArray, inputArray.Length-1);
        }

        public static void deleteAt<T>(ref T[] inputArray, int index)
        {
            int inputArrayLength = inputArray?.Length ?? -1;
            if (index > inputArrayLength || index < 0)
            {
                return;
            }
            T[] newArray = new T[inputArrayLength-1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = inputArray[i];
            }
            for (int i = index+1; i < inputArrayLength; i++)
            {
                newArray[i-1] = inputArray[i];
            }
            inputArray = newArray;
        }
        public static void Resize<T>(ref T[] inputArray, uint outputLenght)
        {
            T[] outputArray = new T[outputLenght];
            for (int currentIndex = 0; currentIndex < inputArray.Length; currentIndex++)
            {
                outputArray[currentIndex] = inputArray[currentIndex];
            }
            inputArray = outputArray;
        }
        /// <summary>
        /// Looks for the searched index
        /// </summary>
        /// <param name="array"></param>
        /// <param name="searchedElement"></param>
        /// <returns> searched index in the array or -1 if unfound</returns>
        public static int GetIndex(int[] array, int searchedElement)
        {
            for(int element = 0; element < array.Length;element++)
            {
                if(searchedElement == array[element])
                {
                    return element;
                }
            }
            return -1;
        }

        public static int[] GetRandomArray(uint length, int minValue, int MaxValue)
        {
            int[] outputArray = new int[length];
            Random random = new Random();
            for(uint i = 0; i < length; i++)
            {
                outputArray[i] = random.Next(minValue, MaxValue);
            }
            return outputArray;
        }

        public static void PrintString(char symbol, uint symbolsCount)
        {
            string result = "";
            //Console.Write(string.Concat(Enumerable.Repeat(symbol, (int)symbolsCount),Enumerable.Repeat(symbol, (int)symbolsCount)));
            for (uint currentIteration = 0; currentIteration < symbolsCount; currentIteration++)
            {
                result += symbol;
            }
            Console.WriteLine(result);
        }

        static void Foo(ref int a)
        {
            a = -2;
        }
        static void Foo(ref Mystruct mystruct)
        {
            mystruct.a = -2;
            mystruct.b = 3.14f;
            mystruct.c = 3.14526;

        }
        static void Foo(Myclass myclass)
        {
            myclass.a = -2;
            myclass.b = 3.14f;
            myclass.c = 3.14526;

        }
        static ref int Foo(int[] array)
        {
            return ref array[0];
        }
        // массив ссылается на данные, чтобы поменять данные в методе, надо передать целый массив через ref
        // (проще говоря меняем по одной ссылке,а не по разным)
        // но менять отдельные данные по разным ссылкам можно, ибо null просто разрывает связь
        static void Bar(int[] arr) // если добавить ref, то при присваивании null массиву он обнулится
        {
            arr[0] = 228;
            //arr = null;
            arr = new int[10];// только через ref будет работать, ибо тут другая переменная, под которую выделяем память
        }
    }

    struct Mystruct
    {
        public int a;
        public float b;
        public double c;
    }
    class Myclass
    {
        public int a;
        public float b;
        public double c;
    }
}
