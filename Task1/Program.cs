// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
//  Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
class Program
{
    static void Main()
    {
        int count = 0;
        string[] strArray = { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
        for (int i = 0; i < strArray.Length; i++)
        {
            if (strArray[i].Length <= 3)
            {
                count++;
            }
        }
        string[] arrayResult = new string[count];
        int index = 0;
        for (int i = 0; i < strArray.Length; i++)
        {
            if (strArray[i].Length <= 3)
            {
                arrayResult[index] = strArray[i];
                index++;
            }
        }
        Console.Write("Вывод нового массива на экран: ");
        for (int i = 0; i < arrayResult.Length; i++)
        {
            Console.Write(arrayResult[i] + " ");
        }
    }
}