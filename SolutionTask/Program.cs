//Write a program that, from an existing array of ints, 
//forms an array of ints whose length is less than or equal to 3 characters. 
//The initial array can be entered from the keyboard, 
//or set at the start of the algorithm execution. When solving, 
//it is not recommended to use collections, it is better to do exclusively with arrays
Console.Clear();

int i;

//A method that is filled in randomly, the length of 10 elements
int[] FillingArray()
{
    int[] outArray = new int[10];

    System.Random numberSintezator = new Random();

    for (i = 0; i < 10; i++)
    {
        outArray[i] = numberSintezator.Next(10, 1000);
    }
    return outArray;
}

//The method outputs the resulting array to the user
void PrintIntArray(int[] inputArray)
{

    for (i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write(inputArray[i] + ", ");
    }
    Console.WriteLine(inputArray[i]);
}

//
int[] Conculate(int[] inputArraay)
{
    int constant = 3;
    int size = inputArraay.Length;

    for (i = 0; i < size; i++)
    {
        while (inputArraay[i] < constant)
        {
            size = size - 1;

            if (size < 1)
            {
                break;
            }

            int val = inputArraay[i];
            inputArraay[i] = inputArraay[size];
            inputArraay[size] = val;
        }
    }
    return val;
}

void ResultPrintIntArray(int[] inputArray)
{
    Console.WriteLine(" ");
    Console.WriteLine("Измененный массив: ");

    for (int i = 0; i <inputArray.Length; i++)
        Console.Write("{0}", B[i]);

    Console.ReadKey();
}


int[] array = FillingArray();
PrintIntArray(array);

int[] resultArray = Conculate(array);
ResultPrintIntArray(resultArray);
