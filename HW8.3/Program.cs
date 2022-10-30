// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
void FillArray(int[,,] array)
{
    int ARR = 10;
    int Arr = -100;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
         for (int k = 0; k < array.GetLength(2); k++)
            {   if (ARR >= 99 && Arr<-9)
                {  
                   array[i, j, k] = Arr++;
                }
                if (ARR>=10 && ARR<100)
                {
                    array[i, j, k] = ARR++;
                }
                
            }
        

}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k}) ");
                
            }
            Console.WriteLine();
        }
        
    }
}

int[,,] Array = new int[3,3,3];
FillArray(Array);
PrintArray(Array);
