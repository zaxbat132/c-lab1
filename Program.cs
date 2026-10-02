// Задание 1, задача 1.
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();

        double x = ReadDouble("Введите x: ", -1000000, 1000000);
        Console.WriteLine("Результат: " + program.Fraction(x));
    }

    public double Fraction(double x)
    {
        return x - (int)x;
    }

    private static double ReadDouble(string prompt, double min, double max)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            double value;
            if (double.TryParse(input, out value) && value >= min && value <= max)
            {
                return value;
            }

            Console.WriteLine("Введите число от " + min + " до " + max + ".");
            Console.WriteLine("Если дробное число не принимается, попробуйте другой разделитель: точку или запятую.");
        }
    }
}

// // Задание 1, задача 3.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         char x = ReadDigit();
//         Console.WriteLine("Результат: " + program.CharToNum(x));
//     }
//
//     public int CharToNum(char x)
//     {
//         return x - '0';
//     }
//
//     private static char ReadDigit()
//     {
//         while (true)
//         {
//             Console.Write("Введите один символ от 0 до 9: ");
//             string input = Console.ReadLine();
//             if (input != null && input.Length == 1 && input[0] >= '0' && input[0] <= '9')
//             {
//                 return input[0];
//             }
//
//             Console.WriteLine("Нужно ввести ровно одну цифру.");
//         }
//     }
// }

// // Задание 1, задача 5.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int x = ReadInt("Введите x: ", -1000000, 1000000);
//         Console.WriteLine("Результат: " + program.Is2Digits(x));
//     }
//
//     public bool Is2Digits(int x)
//     {
//         if (x >= 10 && x <= 99)
//         {
//             return true;
//         }
//
//         if (x >= -99 && x <= -10)
//         {
//             return true;
//         }
//
//         return false;
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 1, задача 7.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int a = ReadInt("Введите a: ", -1000000, 1000000);
//         int b = ReadInt("Введите b: ", -1000000, 1000000);
//         int num = ReadInt("Введите проверяемое число: ", -1000000, 1000000);
//         Console.WriteLine("Результат: " + program.IsInRange(a, b, num));
//     }
//
//     public bool IsInRange(int a, int b, int num)
//     {
//         int min = a;
//         int max = b;
//         if (a > b)
//         {
//             min = b;
//             max = a;
//         }
//
//         if (num >= min && num <= max)
//         {
//             return true;
//         }
//
//         return false;
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 1, задача 9.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int a = ReadInt("Введите a: ", -1000000, 1000000);
//         int b = ReadInt("Введите b: ", -1000000, 1000000);
//         int c = ReadInt("Введите c: ", -1000000, 1000000);
//         Console.WriteLine("Результат: " + program.IsEqual(a, b, c));
//     }
//
//     public bool IsEqual(int a, int b, int c)
//     {
//         if (a == b && b == c)
//         {
//             return true;
//         }
//
//         return false;
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 2, задача 1.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int x = ReadInt("Введите x: ", -1000000, 1000000);
//         Console.WriteLine("Результат: " + program.Abs(x));
//     }
//
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
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 2, задача 3.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int x = ReadInt("Введите x: ", -1000000, 1000000);
//         Console.WriteLine("Результат: " + program.Is35(x));
//     }
//
//     public bool Is35(int x)
//     {
//         if (x % 3 == 0 && x % 5 == 0)
//         {
//             return false;
//         }
//
//         if (x % 3 == 0 || x % 5 == 0)
//         {
//             return true;
//         }
//
//         return false;
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 2, задача 5.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int x = ReadInt("Введите x: ", -1000000, 1000000);
//         int y = ReadInt("Введите y: ", -1000000, 1000000);
//         int z = ReadInt("Введите z: ", -1000000, 1000000);
//         Console.WriteLine("Результат: " + program.Max3(x, y, z));
//     }
//
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
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 2, задача 7.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int x = ReadInt("Введите x: ", -1000000, 1000000);
//         int y = ReadInt("Введите y: ", -1000000, 1000000);
//         Console.WriteLine("Результат: " + program.Sum2(x, y));
//     }
//
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
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 2, задача 9.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         // Любое число int разрешено: вне 1–7 метод должен вернуть сообщение.
//         int x = ReadInt("Введите номер дня: ", int.MinValue, int.MaxValue);
//         Console.WriteLine("Результат: " + program.Day(x));
//     }
//
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
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 3, задача 1.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int x = ReadInt("Введите x: ", 0, 1000);
//         Console.WriteLine("Результат: " + program.ListNums(x));
//     }
//
//     public string ListNums(int x)
//     {
//         string result = "";
//         for (int i = 0; i <= x; i++)
//         {
//             result += i + " ";
//         }
//
//         return result.TrimEnd();
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 3, задача 3.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int x = ReadInt("Введите x: ", 0, 1000);
//         Console.WriteLine("Результат: " + program.Chet(x));
//     }
//
//     public string Chet(int x)
//     {
//         string result = "";
//         for (int i = 0; i <= x; i += 2)
//         {
//             result += i + " ";
//         }
//
//         return result.TrimEnd();
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 3, задача 5.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         long x = ReadLong("Введите x: ");
//         Console.WriteLine("Результат: " + program.NumLen(x));
//     }
//
//     public int NumLen(long x)
//     {
//         if (x == 0)
//         {
//             return 1;
//         }
//
//         int count = 0;
//         while (x != 0)
//         {
//             count++;
//             x = x / 10;
//         }
//
//         return count;
//     }
//
//     private static long ReadLong(string prompt)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             long value;
//             if (long.TryParse(input, out value))
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + long.MinValue + " до " + long.MaxValue + ".");
//         }
//     }
// }
//
// // Задание 3, задача 7.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int x = ReadInt("Введите размер квадрата: ", 1, 30);
//         Console.WriteLine("Результат:");
//         program.Square(x);
//     }
//
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
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 3, задача 9.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int x = ReadInt("Введите высоту треугольника: ", 1, 30);
//         Console.WriteLine("Результат:");
//         program.RightTriangle(x);
//     }
//
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
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 4, задача 1.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int[] arr = ReadArray("Исходный массив", 0);
//         int x = ReadInt("Введите искомое число: ", -1000000, 1000000);
//         Console.WriteLine("Результат: " + program.FindFirst(arr, x));
//     }
//
//     public int FindFirst(int[] arr, int x)
//     {
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] == x)
//             {
//                 return i;
//             }
//         }
//
//         return -1;
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
//
//     private static int[] ReadArray(string title, int minLength)
//     {
//         Console.WriteLine(title);
//         int length = ReadInt("Количество элементов: ", minLength, 100);
//         int[] arr = new int[length];
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = ReadInt("Элемент [" + i + "]: ", -1000000, 1000000);
//         }
//
//         return arr;
//     }
// }
//
// // Задание 4, задача 3.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int[] arr = ReadArray("Исходный массив", 1);
//         Console.WriteLine("Результат: " + program.MaxAbs(arr));
//     }
//
//     public int MaxAbs(int[] arr)
//     {
//         int result = arr[0];
//         for (int i = 1; i < arr.Length; i++)
//         {
//             if (Math.Abs(arr[i]) > Math.Abs(result))
//             {
//                 result = arr[i];
//             }
//         }
//
//         return result;
//     }
//
//     private static int[] ReadArray(string title, int minLength)
//     {
//         Console.WriteLine(title);
//         int length = ReadInt("Количество элементов: ", minLength, 100);
//         int[] arr = new int[length];
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = ReadInt("Элемент [" + i + "]: ", -1000000, 1000000);
//         }
//
//         return arr;
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
// }
//
// // Задание 4, задача 5.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int[] arr = ReadArray("Исходный массив", 0);
//         int[] ins = ReadArray("Вставляемый массив", 0);
//         int pos = ReadInt("Введите позицию вставки (индекс от 0): ", 0, arr.Length);
//         int[] result = program.Add(arr, ins, pos);
//         Console.Write("Результат: ");
//         PrintArray(result);
//     }
//
//     public int[] Add(int[] arr, int[] ins, int pos)
//     {
//         int[] result = new int[arr.Length + ins.Length];
//         for (int i = 0; i < pos; i++)
//         {
//             result[i] = arr[i];
//         }
//
//         for (int i = 0; i < ins.Length; i++)
//         {
//             result[pos + i] = ins[i];
//         }
//
//         for (int i = pos; i < arr.Length; i++)
//         {
//             result[ins.Length + i] = arr[i];
//         }
//
//         return result;
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
//
//     private static int[] ReadArray(string title, int minLength)
//     {
//         Console.WriteLine(title);
//         int length = ReadInt("Количество элементов: ", minLength, 100);
//         int[] arr = new int[length];
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = ReadInt("Элемент [" + i + "]: ", -1000000, 1000000);
//         }
//
//         return arr;
//     }
//
//     private static void PrintArray(int[] arr)
//     {
//         Console.Write("[");
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (i > 0)
//             {
//                 Console.Write(", ");
//             }
//
//             Console.Write(arr[i]);
//         }
//
//         Console.WriteLine("]");
//     }
// }
//
// // Задание 4, задача 7.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int[] arr = ReadArray("Исходный массив", 0);
//         int[] result = program.ReverseBack(arr);
//         Console.Write("Результат: ");
//         PrintArray(result);
//     }
//
//     public int[] ReverseBack(int[] arr)
//     {
//         int[] result = new int[arr.Length];
//         for (int i = 0; i < arr.Length; i++)
//         {
//             result[i] = arr[arr.Length - 1 - i];
//         }
//
//         return result;
//     }
//
//     private static int[] ReadArray(string title, int minLength)
//     {
//         Console.WriteLine(title);
//         int length = ReadInt("Количество элементов: ", minLength, 100);
//         int[] arr = new int[length];
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = ReadInt("Элемент [" + i + "]: ", -1000000, 1000000);
//         }
//
//         return arr;
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
//
//     private static void PrintArray(int[] arr)
//     {
//         Console.Write("[");
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (i > 0)
//             {
//                 Console.Write(", ");
//             }
//
//             Console.Write(arr[i]);
//         }
//
//         Console.WriteLine("]");
//     }
// }
//
// // Задание 4, задача 9.
// using System;
//
// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//
//         int[] arr = ReadArray("Исходный массив", 0);
//         int x = ReadInt("Введите искомое число: ", -1000000, 1000000);
//         int[] result = program.FindAll(arr, x);
//         Console.Write("Индексы (начиная с 0): ");
//         PrintArray(result);
//     }
//
//     public int[] FindAll(int[] arr, int x)
//     {
//         int count = 0;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] == x)
//             {
//                 count++;
//             }
//         }
//
//         int[] result = new int[count];
//         int index = 0;
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (arr[i] == x)
//             {
//                 result[index] = i;
//                 index++;
//             }
//         }
//
//         return result;
//     }
//
//     private static int ReadInt(string prompt, int min, int max)
//     {
//         while (true)
//         {
//             Console.Write(prompt);
//             string input = Console.ReadLine();
//             int value;
//             if (int.TryParse(input, out value) && value >= min && value <= max)
//             {
//                 return value;
//             }
//
//             Console.WriteLine("Введите целое число от " + min + " до " + max + ".");
//         }
//     }
//
//     private static int[] ReadArray(string title, int minLength)
//     {
//         Console.WriteLine(title);
//         int length = ReadInt("Количество элементов: ", minLength, 100);
//         int[] arr = new int[length];
//         for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] = ReadInt("Элемент [" + i + "]: ", -1000000, 1000000);
//         }
//
//         return arr;
//     }
//
//     private static void PrintArray(int[] arr)
//     {
//         Console.Write("[");
//         for (int i = 0; i < arr.Length; i++)
//         {
//             if (i > 0)
//             {
//                 Console.Write(", ");
//             }
//
//             Console.Write(arr[i]);
//         }
//
//         Console.WriteLine("]");
//     }
// }