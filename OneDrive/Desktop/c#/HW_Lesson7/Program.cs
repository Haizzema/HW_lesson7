// // Задача N47
// // Задайте двумерный массив размером mxn, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// Console.WriteLine("Введите через пробел два целых числа, определяющих размер двумерного массива: ");
// string inputString = Console.ReadLine();
// // Проверка на ошибочность ввода \ пока еще не сделано: 
// // 1) ввод НУЛЯ 
// // 2) ввод более ДВУХ чисел 
// // 3) ввод менее ДВУХ чисел
// // 4) ввод чисел через запятую
// // 5) отсутствие ввода вообще
// string[] matrixSize = inputString.Split(" ");
// int matrixSize0 = Convert.ToInt32(matrixSize[0]);
// int matrixSize1 = Convert.ToInt32(matrixSize[1]);
// Console.WriteLine("paзмер массива: " + matrixSize0 + "x" + matrixSize1);
// double[,] matrix = new double[matrixSize0, matrixSize1];
// for (int i = 0; i < matrixSize0; i++)
// {
// 	for (int j = 0; j < matrixSize1; j++)
// 	{
// 		matrix[i, j] = new Random().NextDouble();
// 		double num = matrix[i, j];
// 		Console.Write(matrix[i, j] + " ");
// 	}
// 	Console.WriteLine();
// }
// Console.ReadLine();



//______________________________________________________________________________________________
// //Задача N50. 
// //Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// //и возвращает значение этого элемента или же указание, что такого элемента нет.
// //Например, задан массив:
// //1 4 7 2
// //5 9 2 3
// //8 4 2 4
// //17->такого числа в массиве нет
// // заполнение массива случайными числами
// int[,] matrix = new int[3, 4];
// for (int i = 0; i < 3; i++)
// {
// 	Console.WriteLine();
// 	for (int j = 0; j < 4; j++)
// 	{
// 		matrix[i, j] = new Random().Next(1, 10);
// 		Console.Write(matrix[i, j] + " ");
// 	}
// }
// Console.WriteLine();
// Console.Write("Введите целое число, определяющее строку в массиве: ");
// int rowNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите целое число, определяющее колонку в массиве: ");
// int columnNum = Convert.ToInt32(Console.ReadLine());
// if (rowNum > 3 || columnNum > 4)
// 	Console.WriteLine("Такого элемента в массиве нет");
// else
// {
// 	Console.WriteLine();
// 	Console.WriteLine("Значение элемента массива = " + matrix[rowNum - 1, columnNum - 1]);
// }
// Console.ReadLine();
//_________________________________________________________________________________
//Задача N52.
//Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Write("Введите целое число, определяющее количество строк в массиве: ");
int rowNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число, определяющее количество колонок в массиве: ");
int columnNum = Convert.ToInt32(Console.ReadLine());
//Заполнение массива случайными целыми числами
int[,] matrix = new int[rowNum, columnNum];
for (int i = 0; i < rowNum; i++)
{
	Console.WriteLine();
	for (int j = 0; j < columnNum; j++)
	{
		matrix[i, j] = new Random().Next(1, 100);
		Console.Write(matrix[i, j] + " ");
	}
}
Console.WriteLine();
Console.Write("Среднее арифметическое каждого из столбцов: ");
for (int j = 0; j < columnNum; j++)
{
	int columnAverage = 0;
	for (int i = 0; i < rowNum; i++)
	{
		columnAverage = columnAverage + matrix[i, j];
		if (i == rowNum - 1)
		{
			double result = (double)columnAverage / rowNum;
			Console.Write("{0:0.00}", result + "   ");
		}
	}
}
Console.ReadLine();
//_____________________________________________________________________________________________
