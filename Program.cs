using System;

namespace Семинар_8
{
    class Program
    {
        static void Main(string[] args)
        {
            
       
        //________________Домашнее задание к 8 семинару____________________


        /*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
        элементы каждой строки двумерного массива.
        Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        В итоге получается вот такой массив:
        7 4 2 1
        9 5 3 2
        8 4 4 2
        */
        
        /* Console.WriteLine("Введите кол-во строк:");
        int Rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов");
        int Colums = int.Parse(Console.ReadLine());
        int[,] Array = GetArray2(Rows,Colums,0,9);
        PrintArray(Array);
        Console.WriteLine();
        SortColumn(Array);
        PrintArray(Array);
    

        //метод сортировки массива по убыванию
        void SortColumn (int[,] array){
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(1)-1; k++)
                    {
                        
                    if (array[i,k] < array[i,k+1])
                    {
                        int lost = array[i,k+1];
                        array[i,k+1] = array[i,k];
                        array[i,k] = lost;
                    }
                    }
                }
            }
        
        } */
       

        //Задача 56: Задайте прямоугольный двумерный массив. 
        //Напишите программу, которая будет находить строку с наименьшей суммой элементов.

        /*
        Console.WriteLine("Введите кол-во строк:");
        int Rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов");
        int Colums = int.Parse(Console.ReadLine());

        int[,] Array = GetArray2(Rows,Colums,0,9);
        PrintArray(Array);
        Console.WriteLine();
        Console.WriteLine($"В строке {MinSumRows(Array)} наименьшая сумма элементов");

        int MinSumRows(int[,] array){
            int RowMinNum = 99;
            for (int i = 0; i < array.GetLength(0)-1; i++)
            {
                
                if (SumElementInRow(array,i) < SumElementInRow(array,i+1))
                {
                    RowMinNum = i;
                }
            }
            return RowMinNum+1;
        }

        int SumElementInRow (int[,] array, int row){
            int sum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum = sum + array[row,i];
            }
            return sum;
        }

        */

        //Задача 58: Задайте две квадратные матрицы.
        //Напишите программу, которая будет находить произведение двух матриц.

        
        /* Console.WriteLine("Введите размер квадратной матрицы:");
        int Rows = int.Parse(Console.ReadLine());
        int[,] FirstArray = GetArray2(Rows, Rows, 0, 9);
        PrintArray(FirstArray);
        Console.WriteLine();
        int[,] SecondArray = GetArray2(Rows, Rows, 0, 9);
        PrintArray(SecondArray);
        Console.WriteLine();
        PrintArray(SumArray(FirstArray,SecondArray));


        int[,] SumArray(int[,]array1, int[,] array2){
            int[,] ResArray = new int[array1.GetLength(0),array2.GetLength(1)];
            for (int i = 0; i < ResArray.GetLength(0); i++)
            {
                for (int j = 0; j < ResArray.GetLength(1); j++)
                {
                    ResArray[i,j] = ProductRow(array1,i) + ProductColumn(array2,j);
                }
            }
            return ResArray;
        }

        int ProductRow(int[,] array, int row){
            int Product = 1;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Product = Product * array[row,i];
            }
            return Product;
        }

        int ProductColumn(int[,] array, int column){
            int Product = 1;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Product = Product * array[i,column];
            }
            return Product;
        } */


        

        //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
        //Напишите программу, которая будет построчно выводить массив, 
        //добавляя индексы каждого элемента.
        
        /* Console.WriteLine("Введите кол-во строк:");
        int Rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во стобцов:");
        int Columns = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во уровней:");
        int Levels = int.Parse(Console.ReadLine());
        int[,,] Array = GetArray3(Rows, Columns, Levels, 10, 99);
        PrintArray3(Array);


        void PrintArray3 (int[,,] array){
            for (int i = 0; i < array.GetLength(0); i++){
                for (int j = 0; j < array.GetLength(1); j++){
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write($"{(array[i,j,k])} ({i}, {j}, {k}) "); //печатаем
                    }
                    
                }
                Console.WriteLine();
            }
          }






        bool CheckUniqValue (int[,,] array, int num ){
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array[i,j,k] == num ) 
                        {
                            return false;
                        }
                                    
                    } 
                }
                
            }
            return true; 
        }


        int[,,] GetArray3 (int m, int n, int h, int minvalue, int maxvalue)
        {
          int[,,] result = new int[m,n,h];
            for (int i = 0; i < m; i++)
            {
              for (int j = 0; j < n; j++)
                {
                   for (int k = 0; k < h; k++)
                   {
                         do
                        {
                        result[i,j,k] = new Random().Next(minvalue,maxvalue+1);
                        }                    
                        while (CheckUniqValue(result, result[i,j,k]));
                   } 
                   
                } 
            }
          return result;
        } */


        //Задача 62. Напишите программу, которая заполнит спирально массив с четным (!!!) кол-вом столбцов .

        /* Console.WriteLine("Введите кол-во строк:");
        int Rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов:");
        int Clmn = int.Parse(Console.ReadLine());
        int[,] array = GetArray2(Rows,Clmn,0,0);

        FillArrayAround(0,0);
        PrintArray(array);
        
        int count = 1;
        int i = new int();
        int j = new int();
        int row = Rows;
        int column = Clmn;

        //Рекурсивный метод
        void FillArrayAround (int I, int J){
        i = I;
        j = J;
        FillArrayRight();
        FillArrayDown();
        FillArrayLeft();
        FillArrayUp();
        row = row-1;
        column = column-1;
        if (row>2)
        {
           FillArrayAround(i+1, j+1);
        } 
        }

        void FillArrayRight(){ //заполняет вправо
            if (j<column-1)
            {
                
                array[i,j] = count;
                j++;
                count++;
                
                FillArrayRight();
            }
            return;
            
        }
        void FillArrayDown(){  // заполняет вниз
            if (i<row-1)
            {
                
                array[i,j] = count;
                i++;
                count++;
                FillArrayDown();
            }
            return;
        }
        void FillArrayLeft(){  // заполняет влево
            if (j>array.GetLength(1)-column)
            {
                
                array[i,j] = count;
                j--;
                count++;
                FillArrayLeft();
            }
            return;
        }
        void FillArrayUp(){  // заполняет вверх
            if (i>array.GetLength(0)-row)
            {
                array[i,j] = count;
                i--;
                count++;
                FillArrayUp();
            }
            return;
        } */

        

        /* _____Рекомендованная задача: Отсортировать нечетные столбцы массива по возрастанию. 
        Вывести массив изначальный и массив с отсортированными нечетными столбцами */

        /* Console.WriteLine("Введите кол-во строк:");
        int Rows = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов");
        int Colums = int.Parse(Console.ReadLine());
        int[,] Array = GetArray2(Rows,Colums,0,9);
        PrintArray(Array);
        Console.WriteLine();
        SortColumn(Array);
        PrintArray(Array);
    

        //метод сортировки нечетных столбцов массива по возростанию
        void SortColumn (int[,] array){
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int i = 0; i < array.GetLength(0)-1; i++)
                {
                    for (int k = 1; k < array.GetLength(0); k=k+2)
                    {
                        
                    if (array[i,k] > array[i+1,k])
                    {
                        int lost = array[i,k];
                        array[i,k] = array[i+1,k];
                        array[i+1,k] = lost;
                    }
                    }
                }
            }
        
        } */
 





        void PrintArray (int[,] array){
            for (int i = 0; i < array.GetLength(0); i++){
                for (int j = 0; j < array.GetLength(1); j++){
                    Console.Write($"{(array[i,j])} "); //печатаем
                }
                Console.WriteLine();
            }

          }
        
        int[,] GetArray2 (int m, int n, int minvalue, int maxvalue)
        {
          int[,] result = new int[m,n];
            for (int i = 0; i < m; i++)
            {
              for (int j = 0; j < n; j++)
                {
                   result[i,j] = new Random().Next(minvalue,maxvalue+1); 
                   
                } 
            }
          return result;
        }
        
        }
    }
}
