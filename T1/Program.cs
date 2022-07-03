// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

void PrintArray(int[,] mass) //метод печатает двумерный массив
{                        
    for (int i = 0; i < mass.GetLength(0); i++) {     
        for (int j = 0; j < mass.GetLength(1); j++) { 
            Console.Write(mass[i,j] + " ");           
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] qantity) 
{                                            
    for (int i = 0; i < qantity.GetLength(0); i++) 
    {    
        for (int j = 0; j < qantity.GetLength(1); j++) 
        { 
           qantity[i,j] = new Random().Next(0, 10);     
        }
    }
}

void BubbleSort( int[,] arr)
{
    int temp=0;
    for (int i = 0; i <arr.GetLength(0); i++)
    { 
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = j+1; k < arr.GetLength(1); k++)
            {
                if (arr[i,j] < arr[i,k])
                {
                    temp = arr[i,j];
                    arr[i,j] = arr[i,k];
                    arr[i,k] = temp;
                }
            }
        }
    } 
}

Console.WriteLine( "Insert raw number elements:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine( "Insert column number elements:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] array = new int[n,m];

FillArray(array);                        
Console.WriteLine("Unsorted array: ");
PrintArray(array);

Console.WriteLine("Descending sorted  array: ");
BubbleSort(array);
PrintArray(array);



