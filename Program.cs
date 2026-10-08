// using System;
// public class Assignment1
// {
//     // 1. Дробная часть. При отрицательном x результат тоже отрицательный.
//     public double Fraction(double x)
//     {
//         return x - (int)x;
//     }
//
//     // 3. Букву в число.
//     public int CharToNum(char x)
//     {
//         return x - '0';
//     }
//
//     // 5. Двузначное. Знак минус не считается цифрой.
//     public bool Is2Digits(int x)
//     {
//         return (x >= 10 && x <= 99) || (x >= -99 && x <= -10);
//     }
//
//     // 7. Диапазон. Границы можно передать в любом порядке.
//     public bool IsInRange(int a, int b, int num)
//     {
//         return num >= Math.Min(a, b) && num <= Math.Max(a, b);
//     }
//
//     // 9. Равенство.
//     public bool IsEqual(int a, int b, int c)
//     {
//         return a == b && b == c;
//     }
//
//     public static void Main()
//     {
//         Console.OutputEncoding = System.Text.Encoding.UTF8;
//         Assignment1 task = new Assignment1();
//
//         Console.WriteLine("1. Дробная часть");
//         double number = ReadDouble();
//         Console.WriteLine("Результат: " + task.Fraction(number));
//         Console.WriteLine();
//
//         Console.WriteLine("3. Букву в число");
//         char digit = ReadDigit();
//         Console.WriteLine("Результат: " + task.CharToNum(digit));
//         Console.WriteLine();
//
//         Console.WriteLine("5. Двузначное");
//         int x = ReadInt("x", int.MinValue, int.MaxValue);
//         Console.WriteLine("Результат: " + task.Is2Digits(x));
//         Console.WriteLine();
//
//         Console.WriteLine("7. Диапазон");
//         int a = ReadInt("a", int.MinValue, int.MaxValue);
//         int b = ReadInt("b", int.MinValue, int.MaxValue);
//         int num = ReadInt("num", int.MinValue, int.MaxValue);
//         Console.WriteLine("Результат: " + task.IsInRange(a, b, num));
//         Console.WriteLine();
//
//         Console.WriteLine("9. Равенство");
//         a = ReadInt("a", int.MinValue, int.MaxValue);
//         b = ReadInt("b", int.MinValue, int.MaxValue);
//         int c = ReadInt("c", int.MinValue, int.MaxValue);
//         Console.WriteLine("Результат: " + task.IsEqual(a, b, c));
//     }
//
//     // Сначала проверяем, что введено число, затем проверяем его диапазон.
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
//
//     private static double ReadDouble()
//     {
//         while (true)
//         {
//             Console.Write("x (от -1000000000 до 1000000000): ");
//             double number;
//
//             if (!double.TryParse(Console.ReadLine(), out number))
//             {
//                 Console.WriteLine("Введите число, используя дробный разделитель вашей системы.");
//             }
//             else if (number >= -1000000000 && number <= 1000000000)
//             {
//                 return number;
//             }
//             else
//             {
//                 Console.WriteLine("Число вне допустимого диапазона.");
//             }
//         }
//     }
//
//     private static char ReadDigit()
//     {
//         while (true)
//         {
//             Console.Write("Введите одну цифру от 0 до 9: ");
//             char digit;
//
//             if (!char.TryParse(Console.ReadLine(), out digit))
//             {
//                 Console.WriteLine("Введите только один символ.");
//             }
//             else if (digit >= '0' && digit <= '9')
//             {
//                 return digit;
//             }
//             else
//             {
//                 Console.WriteLine("Нужна цифра от 0 до 9.");
//             }
//         }
//     }
// }