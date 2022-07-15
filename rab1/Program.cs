/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void Initializer(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            double sbor = new Random().NextDouble() * 10;

            string dliaAnaliza = Convert.ToString(sbor);

            string konteiner = "";

            for(int l = 0; l < 3; l++)
            {
                konteiner += dliaAnaliza[l];
            }
            sbor = Convert.ToDouble(konteiner);

            int minPlus = new Random().Next(2);

            if (minPlus == 0)
            {
                sbor *= -1;
            }
            array[i, j] = sbor;

            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

double[,] mass = new double[3, 3];

Initializer(mass);