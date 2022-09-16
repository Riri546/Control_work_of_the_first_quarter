//Write a program that, from an existing array of ints, 
//forms an array of ints whose length is less than or equal to 3 characters. 
//The initial array can be entered from the keyboard, 
//or set at the start of the algorithm execution. When solving, 
//it is not recommended to use collections, it is better to do exclusively with arrays
Console.Clear();

string[] inputArray = new string[5] { "655", "1561", "154", "1562", "165" };
string[] bufArray = new string[inputArray.Length];

//The method runs the array in a loop to check the condition
void SecondArrayWithIF(string[] inputArray, string[] bufArray)
{
    int count = 0;

    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= 3)
        {
            bufArray[count] = inputArray[i];
            count++;
        }
    }
}

//The method outputs the result for the user to the console
void PrintResultArray(string[] array)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Result array: ");
    Console.ResetColor();


    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//The body of the task, launches the ce methods
void Result()
{
    DateTime d1 = DateTime.Now;

    SecondArrayWithIF(inputArray, bufArray);
    PrintResultArray(bufArray);

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Solution time: ");
    Console.ResetColor();

    Console.WriteLine(DateTime.Now - d1);
}

Result();