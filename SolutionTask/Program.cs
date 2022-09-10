//Write a program that, from an existing array of strings, 
//forms an array of strings whose length is less than or equal to 3 characters. 
//The initial array can be entered from the keyboard, 
//or set at the start of the algorithm execution. When solving, 
//it is not recommended to use collections, it is better to do exclusively with arrays
Console.Clear();


Console.Clear();

int i;
int t;

//The method returns an array filled with random numbers from -9 to 9.
int[] FillingArray()
{
    int[] outArray = new int[12];
    i = 0;
    System.Random numberSintezator = new Random();

    while (i < 12)
    {
        outArray[i] = numberSintezator.Next(-9, 10);
        i++;
    }
    return outArray;
}

//The method outputs a random array of numbers to the console
void PrintIntArray(int[] inputArray)
{
    i = 0;

    while (i < inputArray.Length - 1)
    {
        Console.Write(inputArray[i] + ", ");
        i++;
    }
    Console.WriteLine(inputArray[i]);

//The method calculates the factorial
double[] factorial(double[] inputArraay)
{ 
    double[] resultArray = new double[inputArraay.Length];
    for (int i = 0; i <= resultArray.Length; i++)
    {
        resultArray[i] /= 1000;
        if (resultArray[i] % 1000 == 0)
        {
            Console.WriteLine(" Нов Элемент[" + i + "]: " + resultArray[i]);
            Console.ReadKey();
        }
        else
        {
            i++;
        }
    }
    return resultArray;
}
}