/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет
находить строку с наименьшей суммой элементов. */


void PrintArray(int[,] mass) 
{                        
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++) 
        {
            Console.Write(mass[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] quantity) 
{                         
    for (int i = 0; i < quantity.GetLength(0); i++) 
    {
        for (int j = 0; j < quantity.GetLength(1); j++) 
        {
           quantity[i,j] = new Random().Next(0, 10);
        }
    }
}

void FindRowSum(int[,] arr, int[] sum) 
{      
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++) 
        {
            sum[i] += arr[i,j];                                        
        }
    }
    Console.WriteLine();
}

void FindMinRow(int[] sum) 
{                   
    int index = 0;                                    
    int min = sum[index];                      
    for (int i = 0; i < sum.Length; i++) 
    {     
        if (sum[i] < min) 
        {                       
            index = i;                                
            min = sum[i];                      
        }
    }
    Console.WriteLine("Min sum  = " + min + " in row № " + index);
}

Console.Write("Insert number of rows: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Insert number of columns: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array1 = new int[n,m];
int[] array = new int[array1.GetLength(0)] ; 

FillArray(array1);                           
PrintArray(array1);                          
FindRowSum(array1, array);                   
FindMinRow(array);                            
