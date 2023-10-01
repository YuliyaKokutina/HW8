/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
System.Console.WriteLine("Введите размер массива");
string stroka = Console.ReadLine();
string[] str = stroka.Split(", ");
int n = int.Parse(str[0]);
int m = int.Parse(str[1]);
int[,] CreateRandomMatrix(int n, int m)
{
    Random rand = new Random();
    int[,] array = new int[n, m];
    for (n = 0; n < array.GetLength(0); n++)
    {
        for (m = 0; m < array.GetLength(1); m++)
        {
            array[n, m] = rand.Next(1, 100);
        }
    }
    return array;
}

void MInmax(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int p = 0; p < array.GetLength(1)-1; p++)
                {
                    if (array[i, p] < array[i, p + 1])
                    {
                        int temp = array[i, p];
                        array[i, p] = array[i, p + 1];
                        array[i, p + 1] = temp;
                    }
                }
            }
        }
    }
    
}
void PrintArray(int[,] array)
{
    for (int n = 0; n < array.GetLength(0); n++)
    {
        for (int m = 0; m < array.GetLength(1); m++)
        {
            System.Console.Write(array[n, m] + "\t");
        }
        System.Console.WriteLine();
    }
}
int[,] array = CreateRandomMatrix(n, m);
PrintArray(array);
System.Console.WriteLine();
MInmax(array);
PrintArray(array);

