// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше, либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// 
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []



void NewArray(string[] array, string[] newarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[count] = array[i];
            count++;
        }
    }
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


string[] array = new string[4] {"hello", "2", "world", ":-)"};
string[] newarray = new string[array.Length];

NewArray(array, newarray);
Console.WriteLine($"Задан следующий массив из строк: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Программа сформировала массив из строк, длина которых меньше, либо равна 3 символам: ");
PrintArray(newarray);