//Write a program that, from an existing array of strings, 
//forms an array of strings whose length is less than or equal to 3 characters. 
//The initial array can be entered from the keyboard, 
//or set at the start of the algorithm execution. When solving, 
//it is not recommended to use collections, it is better to do exclusively with arrays
Console.Clear();

int i;

//
string[] FillingArray()
{
    string[] outArray = new string[10];

    System.Random numberSintezator = new Random();

    for (i = 0; i < 10; i++)
    {
        outArray[i] = numberSintezator.Next();
    }
    return outArray;
}

//The method outputs a random array of numbers to the console
void PrintIntArray(string[] inputArray)
{
    for (i = 0; i < inputArray.Length - 1; i++)
    {
        Console.Write(inputArray[i] + ", ");
    }
    Console.WriteLine(inputArray[i]);
}

// //
// string[] Conculate(string[] inputArraay)
// {
//     int buf = 0;
//     int len = 0;
//     int[] resultArray = new int[inputArraay.Length];

//     for (i = 0; i < inputArraay.Length; i++)
//     {
//         inputArraay[i] = buf;
//         len = Length(buf);
//         if (len< 3)
//         {
//             inputArraay[i] = resultArray;
//             Console.Write(resultArray[i] + ", ");
//         }
//         else
//         {
//             i++;
//         }
//     }
// }


int[] array = FillingArray();
PrintIntArray(array);

// Conculate(array);
