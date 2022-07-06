/* Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент массива. Если есть два минимальных элемента, то ориентроваться
на расположение первого элемента:
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим следующий массив:
9 4 2
2 2 6
3 4 7 */


void printArray(int[,] mass) 
{                                                                // create 2d mass
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

void fillArray(int[,] coll) 
{                                                                //fill 2d massive
    for (int i = 0; i < coll.GetLength(0); i++)
     {
        for (int j = 0; j < coll.GetLength(1); j++) 
        {
           coll[i,j] = new Random().Next(0, 10);
        }
    }
}

int [,] createNewArr(int[,] array) 
{                                                                 //min value and its location, new massive
    int iMin = 0;
    int jMin = 0;                             
    int min = array[iMin, jMin];                                     //initialize variable as min element
        for (int i = 0; i < array.GetLength(0); i++) 
        {                                                          
            for (int j = 0; j < array.GetLength(1); j++) 
            {
                if (array[i, j] < min) {
                    min = array[i, j];
                    iMin = i;
                    jMin = j; 
                }
            }   
        }
        Console.Write("Минимальное значение = " + min + ";");
        Console.WriteLine(" Индекс строки = " + iMin + ";" + " Индекс столбца = " + jMin + ".");
        Console.WriteLine();

    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1]; // create new mass - 1 size 
        for (int i = 0; i < newArray.GetLength(0); i++) 
        {
            for (int j = 0; j < newArray.GetLength(1); j++) 
            {
                if (i < iMin && j < jMin)                    //elements are upper and more left the cross without alternations
                 {                                   
                    newArray[i, j] = array[i, j]; 
                } else if (i == iMin && j == jMin && i == j)     //put in the cross the lower diagonal element
                {                                                   
                    newArray[i, j] = array[i + 1, j + 1];
                } else if (j >= jMin && i < iMin)                  //put upper and more right elements     more left
                {                                                          
                    newArray[i, j] = array[i, j + 1];
                } else if (i >= iMin && j < jMin)                //put lower and more left elements   more upper
                {                                                                
                    newArray[i, j] = array[i + 1, j];
                } else if (i != iMin && j != jMin && i == j)     //put more lower and more  right on daigonal elements   upper on diagonal
                {                                              
                    newArray[i, j] = array[i + 1, j + 1];
                } else {                                     //put all the elements lower and more right on the 2nd diagonal to the cross   upper and higher on the second diagonal
                    newArray[i, j] = array[i + 1, j + 1];     
                }
            }
        }
        return newArray;
    }

Console.Write("Instert rows: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Instert columns: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine();

int[,] array = new int[n,m];
fillArray(array);                             //fill 2d mass
printArray(array);                            //print 2d mass
printArray(createNewArr(array));              //print new 2d massive without column and row with min element