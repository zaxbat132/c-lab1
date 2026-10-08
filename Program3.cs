// using System;
// public class Assignment3
// {
//     // 1. Числа подряд.
//     public string ListNums(int x)
//     {
//         string result = "";
//         for (int i = 0; i <= x; i++)
//         {
//             result = result + i + " ";
//         }
//
//         return result.Trim();
//     }
//
//     // 3. Чётные числа.
//     public string Chet(int x)
//     {
//         string result = "";
//         for (int i = 0; i <= x; i = i + 2)
//         {
//             result = result + i + " ";
//         }
//
//         return result.Trim();
//     }
//
//     // 5. Длина числа.
//     public int NumLen(long x)
//     {
//         int count = 0;
//         do
//         {
//             x = x / 10;
//             count++;
//         }
//         while (x != 0);
//
//         return count;
//     }
//
//     // 7. Квадрат.
//     public void Square(int x)
//     {
//         for (int i = 0; i < x; i++)
//         {
//             for (int j = 0; j < x; j++)
//             {
//                 Console.Write("*");
//             }
//
//             Console.WriteLine();
//         }
//     }
//
//     // 9. Правый треугольник.
//     public void RightTriangle(int x)
//     {
//         for (int i = 1; i <= x; i++)
//         {
//             for (int j = 0; j < x - i; j++)
//             {
//                 Console.Write(" ");
//             }
//
//             for (int j = 0; j < i; j++)
//             {
//                 Console.Write("*");
//             }
//
//             Console.WriteLine();
//         }
//     }
//
//     public static void Main()
//     {
//         Console.OutputEncoding = System.Text.Encoding.UTF8;
//         Assignment3 task = new Assignment3();
//
//         // Ограничиваем размер вывода, чтобы не печатать слишком много строк и чисел.
//         Console.WriteLine("1. Числа подряд");
//         int x = ReadInt("x", 0, 1000);
//         Console.WriteLine(task.ListNums(x));
//         Console.WriteLine();
//
//         Console.WriteLine("3. Чётные числа");
//         x = ReadInt("x", 0, 1000);
//         Console.WriteLine(task.Chet(x));
//         Console.WriteLine();
//
//         Console.WriteLine("5. Длина числа");
//         long number = ReadLong();
//         Console.WriteLine("Результат: " + task.NumLen(number));
//         Console.WriteLine();
//
//         Console.WriteLine("7. Квадрат");
//         x = ReadInt("x", 1, 100);
//         task.Square(x);
//         Console.WriteLine();
//
//         Console.WriteLine("9. Правый треугольник");
//         x = ReadInt("x", 1, 100);
//         task.RightTriangle(x);
//     }
//     private static int ReadInt(string name, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(name + " (от " + min + " до " + max + "): ");
//             int number;
//
//             if (!int.TryParse(Console.ReadLine(), out number))
//             {
//                 Console.WriteLine("Введите целое число.");
//             }
//             else if (number >= min && number <= max)
//             {
//                 return number;
//             }
//             else
//             {
//                 Console.WriteLine("Число вне допустимого диапазона.");
//             }
//         }
//     }
//     private static long ReadLong()
//     {
//         while (true)
//         {
//             Console.Write("x (от " + long.MinValue + " до " + long.MaxValue + "): ");
//             long number;
//
//             if (long.TryParse(Console.ReadLine(), out number))
//             {
//                 return number;
//             }
//             Console.WriteLine("Введите целое число из диапазона long.");
//         }
//     }
// }