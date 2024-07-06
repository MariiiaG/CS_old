// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


string[] SelectByLength(string[] array, int elLength)
{
    string[] myArray = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= elLength)
        {
            myArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref myArray, j);
    return myArray;
}


string[] GetStrArrayInput()
{
    Console.WriteLine("Let'smake an array");
    int arraySize = 0;
    do
    {
        Console.Write("Provide array length :");
        bool parseInput = int.TryParse(Console.ReadLine(), out int i);
        if (parseInput != true || i <= 0) Console.WriteLine("Input error. Try again");
        arraySize = i;
    }
    while (arraySize <= 0);

    string[] array = new string[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        Console.Write($"Input array element number {i} : ");
        array[i] = Console.ReadLine();
    }
    Console.WriteLine("Array successfully created ! ");
    return array;
}
