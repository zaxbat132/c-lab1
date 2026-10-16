using System;

internal class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Tasks task = new Tasks();

        // Раздел 1
        {
            Console.WriteLine("=== Раздел 1 ===");
            Console.WriteLine("1. Дробная часть");
            double number = ReadDouble();
            Console.WriteLine("Результат: " + task.Fraction(number));
            Console.WriteLine();

            Console.WriteLine("3. Букву в число");
            char digit = ReadDigit();
            Console.WriteLine("Результат: " + task.CharToNum(digit));
            Console.WriteLine();

            Console.WriteLine("5. Двузначное");
            int x = ReadInt("x", int.MinValue, int.MaxValue);
            Console.WriteLine("Результат: " + task.Is2Digits(x));
            Console.WriteLine();

            Console.WriteLine("7. Диапазон");
            int a = ReadInt("a", int.MinValue, int.MaxValue);
            int b = ReadInt("b", int.MinValue, int.MaxValue);
            int num = ReadInt("num", int.MinValue, int.MaxValue);
            Console.WriteLine("Результат: " + task.IsInRange(a, b, num));
            Console.WriteLine();

            Console.WriteLine("9. Равенство");
            a = ReadInt("a", int.MinValue, int.MaxValue);
            b = ReadInt("b", int.MinValue, int.MaxValue);
            int c = ReadInt("c", int.MinValue, int.MaxValue);
            Console.WriteLine("Результат: " + task.IsEqual(a, b, c));
        }

        // Раздел 2
        {
            Console.WriteLine("=== Раздел 2 ===");
            Console.WriteLine("1. Модуль числа");
            int x = ReadInt("x", -int.MaxValue, int.MaxValue);
            Console.WriteLine("Результат: " + task.Abs(x));
            Console.WriteLine();

            Console.WriteLine("3. Тридцать пять");
            x = ReadInt("x", int.MinValue, int.MaxValue);
            Console.WriteLine("Результат: " + task.Is35(x));
            Console.WriteLine();

            Console.WriteLine("5. Тройной максимум");
            x = ReadInt("x", int.MinValue, int.MaxValue);
            int y = ReadInt("y", int.MinValue, int.MaxValue);
            int z = ReadInt("z", int.MinValue, int.MaxValue);
            Console.WriteLine("Результат: " + task.Max3(x, y, z));
            Console.WriteLine();

            Console.WriteLine("7. Двойная сумма");
            x = ReadInt("x", -1000000000, 1000000000);
            y = ReadInt("y", -1000000000, 1000000000);
            Console.WriteLine("Результат: " + task.Sum2(x, y));
            Console.WriteLine();

            Console.WriteLine("9. День недели");
            x = ReadInt("x", int.MinValue, int.MaxValue);
            Console.WriteLine("Результат: " + task.Day(x));
        }

        // Раздел 3
        {
            Console.WriteLine("=== Раздел 3 ===");
            // Ограничиваем размер вывода, чтобы не печатать слишком много строк и чисел.
            Console.WriteLine("1. Числа подряд");
            int x = ReadInt("x", 0, 1000);
            Console.WriteLine(task.ListNums(x));
            Console.WriteLine();

            Console.WriteLine("3. Чётные числа");
            x = ReadInt("x", 0, 1000);
            Console.WriteLine(task.Chet(x));
            Console.WriteLine();

            Console.WriteLine("5. Длина числа");
            long number = ReadLong();
            Console.WriteLine("Результат: " + task.NumLen(number));
            Console.WriteLine();

            Console.WriteLine("7. Квадрат");
            x = ReadInt("x", 1, 100);
            task.Square(x);
            Console.WriteLine();

            Console.WriteLine("9. Правый треугольник");
            x = ReadInt("x", 1, 100);
            task.RightTriangle(x);
        }

        // Раздел 4
        {
            Console.WriteLine("=== Раздел 4 ===");
            Console.WriteLine("1. Поиск первого значения");
            int[] arr = ReadArray("arr", 0);
            int x = ReadInt("x", int.MinValue, int.MaxValue);
            Console.WriteLine("Результат: " + task.FindFirst(arr, x));
            Console.WriteLine();

            Console.WriteLine("3. Поиск максимального по модулю");
            arr = ReadArray("arr", 1);
            Console.WriteLine("Результат: " + task.MaxAbs(arr));
            Console.WriteLine();

            Console.WriteLine("5. Добавление массива в массив");
            arr = ReadArray("arr", 0);
            int[] ins = ReadArray("ins", 0);
            int pos = ReadInt("Позиция вставки", 0, arr.Length);
            int[] result = task.Add(arr, ins, pos);
            PrintArray(result);
            Console.WriteLine();

            Console.WriteLine("7. Возвратный реверс");
            arr = ReadArray("arr", 0);
            result = task.ReverseBack(arr);
            Console.WriteLine("Новый массив:");
            PrintArray(result);
            Console.WriteLine("Исходный массив:");
            PrintArray(arr);
            Console.WriteLine();

            Console.WriteLine("9. Все вхождения");
            arr = ReadArray("arr", 0);
            x = ReadInt("x", int.MinValue, int.MaxValue);
            result = task.FindAll(arr, x);
            PrintArray(result);
        }
    }

    private static int ReadInt(string name, int min, int max)
    {
        while (true)
        {
            Console.Write(name + " (от " + min + " до " + max + "): ");
            int number;

            if (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введите целое число.");
            }
            else if (number >= min && number <= max)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Число вне допустимого диапазона.");
            }
        }
    }

    private static double ReadDouble()
    {
        while (true)
        {
            Console.Write("x (от -1000000000 до 1000000000): ");
            double number;

            if (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Введите число, используя дробный разделитель вашей системы.");
            }
            else if (number >= -1000000000 && number <= 1000000000)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Число вне допустимого диапазона.");
            }
        }
    }

    private static char ReadDigit()
    {
        while (true)
        {
            Console.Write("Введите одну цифру от 0 до 9: ");
            char digit;

            if (!char.TryParse(Console.ReadLine(), out digit))
            {
                Console.WriteLine("Введите только один символ.");
            }
            else if (digit >= '0' && digit <= '9')
            {
                return digit;
            }
            else
            {
                Console.WriteLine("Нужна цифра от 0 до 9.");
            }
        }
    }

    private static long ReadLong()
    {
        while (true)
        {
            Console.Write("x (от " + long.MinValue + " до " + long.MaxValue + "): ");
            long number;

            if (long.TryParse(Console.ReadLine(), out number))
            {
                return number;
            }
            Console.WriteLine("Введите целое число из диапазона long.");
        }
    }

    private static int[] ReadArray(string name, int minLength)
    {
        int length = ReadInt("Размер " + name, minLength, 100);
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = ReadInt(name + "[" + i + "]", int.MinValue, int.MaxValue);
        }

        return arr;
    }

    private static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (i > 0)
            {
                Console.Write(", ");
            }

            Console.Write(arr[i]);
        }

        Console.WriteLine("]");
    }
}
