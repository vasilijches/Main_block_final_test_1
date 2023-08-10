/*
Написать программу, которая из имеющегося массива строк 
формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
*/



void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+", ");
    }
    Console.Write(array[array.Length-1]);
}

string[] ArrToArr3(string[] array1)
{
    int size1 = array1.Length;

    int size2 = 0;
    int firstIndex = 0;
    int lastIndex = 0;
    bool countFlag = true;

    for (int i = 0; i < size1; i++)
    {
        if(array1[i].Length <= 3)
        {
            if(countFlag == true)
            {
                firstIndex = i;
                countFlag = false;
            }
            lastIndex = i;
            size2++;
        }
    }

    string[] array2 = new string[size2];
    if(size2 > 0)
    {
        int m = 0;
        for (int j = firstIndex; j <= lastIndex; j++)
        {
            if(array1[j].Length <= 3)
            {
                array2[m] = array1[j];
                m++;
            }
        }
    }
    return array2;
}

string[] arr1 = {"1234", "12", "123", "12345", "123456", "123", "1"};
PrintArray(arr1);

string[] arr2 = ArrToArr3(arr1);
Console.WriteLine();
PrintArray(arr2);