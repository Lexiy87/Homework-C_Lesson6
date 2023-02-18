/*"Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

int GetNumber (string message)
{   
    int result = 0;
    System.Console.WriteLine(message);

    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else System.Console.WriteLine("Неверный ввод, повторите");
    }
    return result;
}

int [] InitArray (int result)
{
        int []array = new int [result];

        for (int i = 0; i < array.Length; i++)
        {
            array [i] = GetNumber ("Введите число с индексом "+ i);
        }

    return array;
}

void PrintArray (int []array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
}

int FindQtyOfNumbers (int []array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            count++;
        }
    }
    return count;
}

int number = GetNumber("Введите размер массива");
int [] array = InitArray (number);

int count = FindQtyOfNumbers(array);

System.Console.WriteLine("Чисел больше 0 = "+ count);
