using System;

public class Tasks
{
    // Раздел 1
    // 1. Дробная часть. 
    public double Fraction(double x)
    {
        return x - (int)x;
    }

    // 3. Букву в число.
    public int CharToNum(char x)
    {
        return x - '0';
    }

    // 5. Двузначное.
    public bool Is2Digits(int x)
    {
        return (x >= 10 && x <= 99) || (x >= -99 && x <= -10);
    }

    // 7. Диапазон. 
    public bool IsInRange(int a, int b, int num)
    {
        return num >= Math.Min(a, b) && num <= Math.Max(a, b);
    }

    // 9. Равенство.
    public bool IsEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    // Раздел 2
    // 1. Модуль числа.
    public int Abs(int x)
    {
        if (x < 0)
        {
            return -x;
        }

        return x;
    }

    // 3. 35
    public bool Is35(int x)
    {
        if (x % 3 == 0 && x % 5 != 0)
        {
            return true;
        }

        if (x % 5 == 0 && x % 3 != 0)
        {
            return true;
        }

        return false;
    }

    // 5. Тройной максимум.
    public int Max3(int x, int y, int z)
    {
        int max = x;
        if (y > max)
        {
            max = y;
        }

        if (z > max)
        {
            max = z;
        }

        return max;
    }

    // 7. Двойная сумма.
    public int Sum2(int x, int y)
    {
        int sum = x + y;
        if (sum >= 10 && sum <= 19)
        {
            return 20;
        }

        return sum;
    }

    // 9. День недели.
    public string Day(int x)
    {
        switch (x)
        {
            case 1:
                return "понедельник";
            case 2:
                return "вторник";
            case 3:
                return "среда";
            case 4:
                return "четверг";
            case 5:
                return "пятница";
            case 6:
                return "суббота";
            case 7:
                return "воскресенье";
            default:
                return "это не день недели";
        }
    }

    // Раздел 3
    // 1. Числа подряд.
    public string ListNums(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i++)
        {
            result = result + i + " ";
        }

        return result.Trim();
    }

    // 3. Чётные числа.
    public string Chet(int x)
    {
        string result = "";
        for (int i = 0; i <= x; i = i + 2)
        {
            result = result + i + " ";
        }

        return result.Trim();
    }

    // 5. Длина числа.
    public int NumLen(long x)
    {
        int count = 0;
        do
        {
            x = x / 10;
            count++;
        }
        while (x != 0);

        return count;
    }

    // 7. Квадрат.
    public void Square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    // 9. Правый треугольник.
    public void RightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            for (int j = 0; j < x - i; j++)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }

    // Раздел 4
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
}