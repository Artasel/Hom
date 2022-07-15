/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

void Initializer(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
}

void ReadMass(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void CheckNumber(int[,] Array, int number)
{
    bool check = false;
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            if(Array[i, j] == number)   check = true;
        }
    }
    if(check == true)   Console.WriteLine("Такое число есть в массиве");
    else                Console.WriteLine("такого числа в массиве нет");
}

int[,] SomeMass = new int[6, 7];

Initializer(SomeMass);
ReadMass(SomeMass);
CheckNumber(SomeMass, 6);