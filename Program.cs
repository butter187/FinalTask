﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
string[]array = new string[5];
array[0]= "Cat";
array[1]= "King";
array[2]= "Green";
array[3]= "12";
array[4]= "123456789";
Console.WriteLine($"[{String.Join("; ", array)}]");
Console.WriteLine($"[{String.Join("; ", DellSymbols(array))}]");

// -------------------------------Метод удаление из массива элементов больше 3 символов----------------------------------------
string[] DellSymbols (string[]array)
{
    string[] newArray =new string[array.Length];
    int j =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
         newArray[j]=array[i];
         j++;   
        }
    }
    newArray = newArray.Where(x => x != null).ToArray();
  return newArray;
}
