// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Программа, которая будет создавать два одинаковых массива
// запелненных рандомными числами и создайте такой метод, который будет
// перемножать между собой массивы и складывать их в новый массив

int rows = WorkWithUser("Введите количество строк: ");
int columns = WorkWithUser("Введите количество столбцов: ");
int[,] array1 = GetRandomArray(rows, columns);

int[,] array2 = GetRandomArray(rows, columns);
// int[,] array1 = { { 2, 4 }, { 3, 2 } };
// int[,] array2 = { { 3, 4 }, { 3, 3 } };

Console.WriteLine();
Console.WriteLine("Первая матрица:");
PrintArray(array1);

Console.WriteLine();
Console.WriteLine("Вторая матрица:");
PrintArray(array2);

Console.WriteLine();
Console.WriteLine("Произведение матриц:");
int[,] product = MultiplyMatrices(array1, array2);
PrintArray(product);

// Метод для работы с пользователем: принимает сообщение и возвращает введенное им число.
int WorkWithUser(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

// Метод для генерации случайной матрицы с заданными параметрами.
int[,] GetRandomArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(1, 4);
        }
    }
    return result;
}

// Метод для вывода матрицы в консоль.
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

// Метод для умножения двух матриц.
int[,] MultiplyMatrices(int[,] array1, int[,] array2)
{
    int rows = array1.GetLength(0);
    int columns = array2.GetLength(1);
    int sumLength = array1.GetLength(1);

    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int sum = 0;
            for (int k = 0; k < sumLength; k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            result[i, j] = sum;
        }
    }

    return result;
}