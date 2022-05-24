

int[] arr = {1,2,5,4,6,8,3,7};

void PrintArray(int[] array )
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
}


void SelectuonSort(int[] array)
{
    
    for ( int i = 0; i < array.Length -1; i++)
    {
        int minPosition = i;

        for (int j = i; j < array.Length; j++)
        {
            if(array[j] > array[minPosition]) minPosition = j;
        }
        int temprorary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temprorary;

    }
}

PrintArray(arr);
SelectuonSort(arr);

PrintArray(arr);


