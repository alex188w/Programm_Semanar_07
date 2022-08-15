void Zadacha46()
// Задача 46: Задайте двумерный массив размером m×n, 
// заполненный случайными целыми числами
{
    Random random = new Random();
    int rows = random.Next(4, 10);
    int colums = random.Next(4, 10);
    int[,] array = new int[rows, colums];
    FillArray(array, -99, 100);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
}

void Zadacha48()
// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₘ = m+n. 
// Выведите полученный массив на экран
{
    Console.WriteLine("Введите число m ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число n ");
    int n = Convert.ToInt32(Console.ReadLine());

    int rows =  m;
    int colums = n;
    int[,] array = new int[rows, colums];

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = i + j;   
        }
    }

    Console.WriteLine("Заданный массив ");
    PrintArray(array);
}

void Zadacha49()
// Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты
{
    Random random = new Random();
    int rows = random.Next(4, 10);
    int colums = random.Next(4, 10);
    int[,] array = new int[rows, colums];
    FillArray(array, -99, 100);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
            if(i % 2 == 0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];   
        }
    }
    
    Console.WriteLine("Полученный массив ");
    PrintArray(array);
}

void Zadacha51()
// Задайте двумерный массив. Найдите сумму элементов,
//  находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д
{
    Random random = new Random();
    int rows = random.Next(4, 10);
    int colums = random.Next(4, 10);
    int[,] array = new int[rows, colums];
    FillArray(array, 0, 10);
    Console.WriteLine("Заданный массив ");
    PrintArray(array);
    int sum = 0;
    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
            if(i == j) sum = sum + array[i, j];   
        }
    }
    
    Console.WriteLine("Сумма элементов главной диагонали равна " + sum);
}

void FillArray(int[,] array, int startNumber, int finishNumder)
{
    Random random = new Random();
    finishNumder++;
    int rows =  array.GetLength(0);
    int colums = array.GetLength(1);

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(startNumber, finishNumder);   
        }
    }
}

void PrintArray(int[,] array)
{
    int rows =  array.GetLength(0);
    int colums = array.GetLength(1);

    for (int i = 0; i < rows; i++) 
    {
        for (int j = 0; j < colums; j++)
        {
              Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

//Zadacha46();
//Zadacha48();
//Zadacha49();
Zadacha51();
