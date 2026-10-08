using System;

// Каждый файл запускается отдельно. Решены задачи 1, 3, 5, 7, 9.
public class Assignment4
{
    // 1. Поиск первого значения.
    public int FindFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                return i;
            }
        }

        return -1;
    }

    // 3. Поиск максимального
    public int MaxAbs(int[] arr)
    {
        int max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            // Преобразование в long позволяет найти модуль даже у int.MinValue.
            if (Math.Abs((long)arr[i]) > Math.Abs((long)max))
            {
                max = arr[i];
            }
        }

        return max;
    }

    // 5. Добавление массива в массив.
    public int[] Add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];

        for (int i = 0; i < pos; i++)
        {
            result[i] = arr[i];
        }

        for (int i = 0; i < ins.Length; i++)
        {
            result[pos + i] = ins[i];
        }

        for (int i = pos; i < arr.Length; i++)
        {
            result[i + ins.Length] = arr[i];
        }

        return result;
    }

    // 7. Возвратный реверс
    public int[] ReverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }

        return result;
    }

    // 9. все вхождения
    public int[] FindAll(int[] arr, int x)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                count++;
            }
        }

        int[] result = new int[count];
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[k] = i;
                k++;
            }
        }

        return result;
    }

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Assignment4 task = new Assignment4();

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
