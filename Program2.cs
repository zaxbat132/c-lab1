// using System;
// public class Assignment2
// {
//     // 1. Модуль числа.
//     public int Abs(int x)
//     {
//         if (x < 0)
//         {
//             return -x;
//         }
//
//         return x;
//     }
//
//     // 3. 35
//     public bool Is35(int x)
//     {
//         if (x % 3 == 0 && x % 5 != 0)
//         {
//             return true;
//         }
//
//         if (x % 5 == 0 && x % 3 != 0)
//         {
//             return true;
//         }
//
//         return false;
//     }
//
//     // 5. Тройной максимум.
//     public int Max3(int x, int y, int z)
//     {
//         int max = x;
//         if (y > max)
//         {
//             max = y;
//         }
//
//         if (z > max)
//         {
//             max = z;
//         }
//
//         return max;
//     }
//
//     // 7. Двойная сумма.
//     public int Sum2(int x, int y)
//     {
//         int sum = x + y;
//         if (sum >= 10 && sum <= 19)
//         {
//             return 20;
//         }
//
//         return sum;
//     }
//
//     // 9. День недели.
//     public string Day(int x)
//     {
//         switch (x)
//         {
//             case 1:
//                 return "понедельник";
//             case 2:
//                 return "вторник";
//             case 3:
//                 return "среда";
//             case 4:
//                 return "четверг";
//             case 5:
//                 return "пятница";
//             case 6:
//                 return "суббота";
//             case 7:
//                 return "воскресенье";
//             default:
//                 return "это не день недели";
//         }
//     }
//
//     public static void Main()
//     {
//         Console.OutputEncoding = System.Text.Encoding.UTF8;
//         Assignment2 task = new Assignment2();
//
//         Console.WriteLine("1. Модуль числа");
//         int x = ReadInt("x", -int.MaxValue, int.MaxValue);
//         Console.WriteLine("Результат: " + task.Abs(x));
//         Console.WriteLine();
//
//         Console.WriteLine("3. Тридцать пять");
//         x = ReadInt("x", int.MinValue, int.MaxValue);
//         Console.WriteLine("Результат: " + task.Is35(x));
//         Console.WriteLine();
//
//         Console.WriteLine("5. Тройной максимум");
//         x = ReadInt("x", int.MinValue, int.MaxValue);
//         int y = ReadInt("y", int.MinValue, int.MaxValue);
//         int z = ReadInt("z", int.MinValue, int.MaxValue);
//         Console.WriteLine("Результат: " + task.Max3(x, y, z));
//         Console.WriteLine();
//
//         Console.WriteLine("7. Двойная сумма");
//         x = ReadInt("x", -1000000000, 1000000000);
//         y = ReadInt("y", -1000000000, 1000000000);
//         Console.WriteLine("Результат: " + task.Sum2(x, y));
//         Console.WriteLine();
//
//         Console.WriteLine("9. День недели");
//         x = ReadInt("x", int.MinValue, int.MaxValue);
//         Console.WriteLine("Результат: " + task.Day(x));
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
// }