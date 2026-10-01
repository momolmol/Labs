class Tasks
{
    public int sumLastNums(int x)
    {
        int digit = x % 10;
        int sec_digit = (x / 10) % 10;
        return digit + sec_digit;
    }

    public bool isPositive(int x)
    {
        if (x > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool isUpperCase(char x)
    {
        return x >= 'A' && x <= 'Z';
    }

    public bool isDivisor(int a, int b)
    {
        if (a % b == 0 || b % a == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public int lastNumSum(int a, int b)
    {
        return a % 10 + b % 10;
    }

    public double safeDiv(int x, int y)
    {
        if (y != 0)
        {
            return (double)x / y;
        }
        else
        {
            return 0;
        }
    }

    public string makeDecision(int x, int y)
    {
        string op = "";
        if (x > y)
        {
            op = ">";
        }
        else if (x < y)
        {
            op = "<";
        }
        else
        {
            op = "==";
        }

        return x + op + y;
    }

    public bool sum3(int x, int y, int z)
    {
        if (x + y == z || x + z == y || y + z == x)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string age(int x)
    {
        string word;

        if (x % 100 >= 11 && x % 100 <= 19)
        {
            word = " лет";
        }
        else if (x % 10 == 1)
        {
            word = " год";
        }
        else if (x % 10 >= 2 && x % 10 <= 4)
        {
            word = " года";
        }
        else
        {
            word = " лет";
        }

        return x.ToString() + word;
    }

    public void printDays(string x)
    {
        switch (x)
        {
            case "понедельник":
                Console.WriteLine("Понедельник");
                goto case "вторник";
            case "вторник":
                Console.WriteLine("Вторник");
                goto case "среда";
            case "среда":
                Console.WriteLine("Среда");
                goto case "четверг";
            case "четверг":
                Console.WriteLine("Четверг");
                goto case "пятница";
            case "пятница":
                Console.WriteLine("Пятница");
                goto case "суббота";
            case "суббота":
                Console.WriteLine("Суббота");
                goto case "воскресенье";
            case "воскресенье":
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("Это не день недели");
                break;
        }
    }

    public string reverseListNums(int x)
    {
        string res = "";
        while (x >= 0)
        {
            res += x + " ";
            x--;
        }
        return res;
    }

    public int pow(int x, int y)
    {
        int i = 0;
        int res = 1;
        while (i < y)
        {
            res *= x;
            i++;
        }
        return res;
    }

    public bool equalNum(int x)
    {
        int i = x % 10;
        x /= 10;
        while (x != 0)
        {
            if (x % 10 != i)
            {
                return false;
            }
            else
            {
                x /= 10;
            }
        }
        return true;
    }

    public void leftTriangle(int x)
    {
        string res = "";
        for (int i = 0; i < x; i++)
        {
            res += "*";
            Console.WriteLine(res);
        }
    }

    public void guessGame()
    {
        Random random = new Random();
        int num = random.Next(10);
        int count = 0;
        int x;

        do
        {
            if (count == 0)
            {
                Console.Write("Задание 3_10. Игра Угадайка. Введите число от 0 до 9: ");
            }
            else
            {
                Console.Write("Вы не угадали, введите число от 0 до 9: ");
            }

            string input = Console.ReadLine();
            if (!int.TryParse(input, out x))
            {
                Console.WriteLine("Введено не число. Попробуйте ещё раз.");
                continue;
            }

            count++;

        } while (x != num);

        string attempt = "";

        if (count % 100 >= 11 && count % 100 <= 19)
        {
            attempt = "попыток";
        }
        else if (count % 10 == 1)
        {
            attempt = "попытку";
        }
        else if (count % 10 >= 2 && count % 10 <= 4)
        {
            attempt = "попытки";
        }
        else
        {
            attempt = "попыток";
        }

        Console.WriteLine("Вы угадали!");
        Console.WriteLine($"Вы отгадали число за {count} {attempt}");
    }

    public int findLast(int[] arr, int x)
    {
        int result = -1;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result = i;
            }
        }
        return result;
    }

    public int[] add(int[] arr, int x, int pos)
    {
        int[] arr2 = new int[arr.Length + 1];
        for (int i = 0; i < arr2.Length; i++)
        {
            if (i < pos)
            {
                arr2[i] = arr[i];
            }
            else if (i == pos)
            {
                arr2[i] = x;
            }
            else
            {
                arr2[i] = arr[i - 1];
            }
        }
        return arr2;
    }

    public void reverse(int[] arr)
    {
        int i = 0;
        int j = arr.Length - 1;

        while (i < j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            i++;
            j--;
        }
    }

    public int[] concat(int[] arr1, int[] arr2)
    {
        int[] arr3 = new int[arr1.Length + arr2.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            arr3[i] = arr1[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            arr3[arr1.Length + i] = arr2[i];
        }
        return arr3;
    }

    public int[] deleteNegative(int[] arr)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                count++;
            }
        }
        int[] arr2 = new int[count];
        int j = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] >= 0)
            {
                arr2[j] = arr[i];
                j++;
            }
        }
        return arr2;
    }
}

class Program
{
    static void Main()
    {
        Tasks t = new Tasks();
        Program p = new Program();

        Console.Write("Введите часть (1-4): ");
        int part = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите номер задания (2, 4, 6, 8, 10): ");
        int task = Convert.ToInt32(Console.ReadLine());

        int taskNumber = (part - 1) * 10 + task;

        switch (taskNumber)
        {
            case 2:  p.RunTask1_2(t);  break;
            case 4:  p.RunTask1_4(t);  break;
            case 6:  p.RunTask1_6(t);  break;
            case 8:  p.RunTask1_8(t);  break;
            case 10: p.RunTask1_10(t); break;
            case 12: p.RunTask2_2(t);  break;
            case 14: p.RunTask2_4(t);  break;
            case 16: p.RunTask2_6(t);  break;
            case 18: p.RunTask2_8(t);  break;
            case 20: p.RunTask2_10(t); break;
            case 22: p.RunTask3_2(t);  break;
            case 24: p.RunTask3_4(t);  break;
            case 26: p.RunTask3_6(t);  break;
            case 28: p.RunTask3_8(t);  break;
            case 30: p.RunTask3_10(t); break;
            case 32: p.RunTask4_2(t);  break;
            case 34: p.RunTask4_4(t);  break;
            case 36: p.RunTask4_6(t);  break;
            case 38: p.RunTask4_8(t);  break;
            case 40: p.RunTask4_10(t); break;
            default:
                Console.WriteLine("Такой задачи нет.");
                break;
        }
    }

    private bool TryReadInt(string prompt, out int value)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        return int.TryParse(input, out value);
    }

    private bool TryReadChar(string prompt, out char value)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        return char.TryParse(input, out value);
    }

    private bool TryReadIntArray(string prompt, out int[] arr)
    {
        arr = null;
        Console.Write(prompt);
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');
        int[] result = new int[parts.Length];

        for (int i = 0; i < parts.Length; i++)
        {
            if (!int.TryParse(parts[i], out result[i]))
            {
                return false;
            }
        }

        arr = result;
        return true;
    }

    private void PrintIntArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    private void RunTask1_2(Tasks t)
    {
        if (!TryReadInt("Задание 1_2. Введите число: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Сумма: {t.sumLastNums(x)}");
    }

    private void RunTask1_4(Tasks t)
    {
        if (!TryReadInt("Задание 1_4. Введите число: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Число положительное? {t.isPositive(x)}");
    }

    private void RunTask1_6(Tasks t)
    {
        if (!TryReadChar("Задание 1_6. Введите символ: ", out char x))
        {
            Console.WriteLine("Введён не один символ");
            return;
        }
        Console.WriteLine($"Большая буква? {t.isUpperCase(x)}");
    }

    private void RunTask1_8(Tasks t)
    {
        if (!TryReadInt("Задание 1_8. Введите a: ", out int a))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите b: ", out int b))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Делит нацело? {t.isDivisor(a, b)}");
    }

    private void RunTask1_10(Tasks t)
    {
        if (!TryReadInt("Задание 1_10. Введите a: ", out int a))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите b: ", out int b))
        {
            Console.WriteLine("Введено не число");
            return;
        }

        int result = t.lastNumSum(a, b);
        result = t.lastNumSum(result, 123);
        result = t.lastNumSum(result, 14);
        result = t.lastNumSum(result, 1);
        Console.WriteLine($"Итого: {result}");
    }

    private void RunTask2_2(Tasks t)
    {
        if (!TryReadInt("Задание 2_2. Введите x: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите y: ", out int y))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Результат: {t.safeDiv(x, y)}");
    }

    private void RunTask2_4(Tasks t)
    {
        if (!TryReadInt("Задание 2_4. Введите x: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите y: ", out int y))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Результат: {t.makeDecision(x, y)}");
    }

    private void RunTask2_6(Tasks t)
    {
        if (!TryReadInt("Задание 2_6. Введите x: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите y: ", out int y))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите z: ", out int z))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Результат: {t.sum3(x, y, z)}");
    }

    private void RunTask2_8(Tasks t)
    {
        if (!TryReadInt("Задание 2_8. Введите возраст: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Результат: {t.age(x)}");
    }

    private void RunTask2_10(Tasks t)
    {
        Console.Write("Задание 2_10. Введите день недели: ");
        string x = Console.ReadLine();
        Console.WriteLine("Результат:");
        t.printDays(x);
    }

    private void RunTask3_2(Tasks t)
    {
        if (!TryReadInt("Задание 3_2. Введите x: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Результат: {t.reverseListNums(x)}");
    }

    private void RunTask3_4(Tasks t)
    {
        if (!TryReadInt("Задание 3_4. Введите x: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите y: ", out int y))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Результат: {t.pow(x, y)}");
    }

    private void RunTask3_6(Tasks t)
    {
        if (!TryReadInt("Задание 3_6. Введите x: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine($"Результат: {t.equalNum(x)}");
    }

    private void RunTask3_8(Tasks t)
    {
        if (!TryReadInt("Задание 3_8. Введите x: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        Console.WriteLine("Результат: ");
        t.leftTriangle(x);
    }

    private void RunTask3_10(Tasks t)
    {
        t.guessGame();
    }

    private void RunTask4_2(Tasks t)
    {
        if (!TryReadIntArray("Задание 4_2. Введите массив через пробел: ", out int[] arr))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите число для поиска x: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }

        int index = t.findLast(arr, x);
        Console.WriteLine($"Индекс последнего вхождения: {index}");
    }

    private void RunTask4_4(Tasks t)
    {
        if (!TryReadIntArray("Задание 4_4. Введите массив через пробел: ", out int[] arr))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите число для вставки x: ", out int x))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadInt("Введите позицию pos: ", out int pos))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (pos < 0 || pos > arr.Length)
        {
            Console.WriteLine("Позиция вне диапазона массива");
            return;
        }

        int[] result = t.add(arr, x, pos);

        Console.Write("Результат: ");
        PrintIntArray(result);
    }

    private void RunTask4_6(Tasks t)
    {
        if (!TryReadIntArray("Задание 4_6. Введите массив через пробел: ", out int[] arr))
        {
            Console.WriteLine("Введено не число");
            return;
        }

        t.reverse(arr);

        Console.Write("Результат: ");
        PrintIntArray(arr);
    }

    private void RunTask4_8(Tasks t)
    {
        if (!TryReadIntArray("Введите первый массив через пробел: ", out int[] arr1))
        {
            Console.WriteLine("Введено не число");
            return;
        }
        if (!TryReadIntArray("Введите второй массив через пробел: ", out int[] arr2))
        {
            Console.WriteLine("Введено не число");
            return;
        }

        int[] result = t.concat(arr1, arr2);

        Console.Write("Результат: ");
        PrintIntArray(result);
    }

    private void RunTask4_10(Tasks t)
    {
        if (!TryReadIntArray("Задание 4_10. Введите массив через пробел: ", out int[] arr))
        {
            Console.WriteLine("Введено не число");
            return;
        }

        int[] result = t.deleteNegative(arr);

        Console.Write("Результат: ");
        PrintIntArray(result);
    }
}
