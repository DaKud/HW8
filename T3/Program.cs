/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц. */


void printArray(int[,] mass)                        // PRNT 2D ARRY
{                            
    for (int i = 0; i < mass.GetLength(0); i++) 
    {      
        for (int j = 0; j < mass.GetLength(1); j++)            
        {    
            Console.Write(mass[i,j] + " ");              
        }
        Console.WriteLine();
    }
}

void fillArray(int[,] matrix)                       // FILL 2D ARRY
{                        
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {      
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {  
           matrix[i,j] = new Random().Next(0, 10);     
        }
    }
}

void MultiplyMatrixes(int[,] arr, int[,] arr2, int[,] arr3)       // MLTPL 3 ARRYS
{      //метод перемножает значения массивов array1 и array2
    for (int i = 0; i < arr.GetLength(0); i++)                    // SORTNG thrgh arr1 rows
     {                 
        for (int j = 0; j < arr2.GetLength(1); j++)              // SORTNG thrgh arr2 columns
        {                      
            arr3[i,j] = arr[i,j] * arr2[i,j];                    //SAVE MULTPLD AR1 AND ARR2 IN ARR3
            Console.Write(arr3[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Insert number of rows: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Insert number of columns: ");   // 2ND ARRAY WOLD BE WITH CONTAVERSE VALUES
int m = int.Parse(Console.ReadLine());

int[,] mass1 = new int[n,m];

Console.WriteLine();

fillArray(mass1);
Console.WriteLine("Massive 1:");
printArray(mass1);

int[,] mass2 = new int[m,n];

Console.WriteLine();

fillArray(mass2);
Console.WriteLine("Massive 2:");
printArray(mass2);

Console.WriteLine();

int[,] mass3 = new int[n,n];
Console.WriteLine("Massive 3 (mass1 x mass2):");
MultiplyMatrixes(mass1, mass2, mass3);