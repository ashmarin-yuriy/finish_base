/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] */

void PrintArray(string[] ar)
{
    for (int i = 0; i < ar.Length; i++)
    {
        Console.Write(ar[i] + " ");
    }
}

int CorrectValue()
{
    From:
    Console.Write("Ведите количество элементов массива: ");
    int elements = Convert.ToInt32(Console.ReadLine());
    if (elements > 0) return elements;
    Console.WriteLine("Количество элементов массива не может быть отрицательным или равным нулю");
    goto From;
}

int elementsCount = CorrectValue();

string[] array = new string[elementsCount];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    array[i] = Console.ReadLine();
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count++;
    }
}

string[] newArray = new string[count];

for (int i = 0, j = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[j] = array[i];
        j++;
    }
}

PrintArray(newArray);