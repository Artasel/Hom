/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void Initializer(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11);
        }
    }
}

void ReadMass(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanColumn(int[,] Array)
{
    int j = 0;
    double arithmeticMeanColumn = 0;
    string konteiner = "";
    string dliaAnaliza = "";
    string result = "";
    string znak = "; ";
    for(int i = 0; i < Array.GetLength(0); i++)
    {
        arithmeticMeanColumn += Array[i, j];
        if(i == Array.GetLength(0) - 1)
        {
            arithmeticMeanColumn /= Array.GetLength(0);
            
            dliaAnaliza = Convert.ToString(arithmeticMeanColumn);

            if (dliaAnaliza.Length > 1)
            {
                for (int l = 0; l < 3; l++)
                {
                    konteiner += dliaAnaliza[l];
                }
            }
            else
            {
                if(j == Array.GetLength(1) - 1)  result += dliaAnaliza + ".";
                else  result += dliaAnaliza + znak;
            }

            if(j != Array.GetLength(1) - 1 && dliaAnaliza.Length > 1)  result += konteiner + znak;
            
            if(j == Array.GetLength(1) - 1 && dliaAnaliza.Length > 1) result += konteiner + ".";
        }
        if(i == Array.GetLength(0) - 1 && j < Array.GetLength(1) - 1)
        {
            ++j;
            i = -1;
            arithmeticMeanColumn = 0;
            konteiner = "";
            dliaAnaliza = "";
        }
    }
    Console.WriteLine("Среднее арифметическое каждого столбца: " + result);
}


int[,] mass = new int[3, 4];

Initializer(mass);
ReadMass(mass);
ArithmeticMeanColumn(mass);