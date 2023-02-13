// Задача: Написать программу,которая из имеющегося массива строк формирует массив из
// строк, длина которых меньше, либо равна 3 символа. Первоначальный массив, можно ввести
// с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры: ["hello", "2", "world", ":-)"]               ->    ["2", ":-)"]
//          ["1234", "1567", "-2", "computer science"]   ->    ["-2"]
//          ["Russia", "Denmark", "Kazan"]               ->    []




String[] inputArray = new String[] { "hello", "2", "world", ":-)" };

String [] outputArray = GetNewArray(inputArray);
PrintArray(outputArray);


String[] GetNewArray(String[] arr)
{
    int count = 0;
    String temp = String.Empty;
    for (int i = 0; i < arr.Length; i++)
    {
        temp = arr[i];
        if (temp.Length <= 3) count += 1;
    }
    String [] newArr = new String [count];
    count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        temp = arr[i];
        if (temp.Length <= 3)
        {
            newArr[count] = arr[i];
            count += 1;
        } 
    }
    return newArr;
}

void PrintArray(String[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write(arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.WriteLine("]");
}