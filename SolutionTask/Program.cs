//Write a program that, from an existing array of strings, 
//forms an array of strings whose length is less than or equal to 3 characters. 
//The initial array can be entered from the keyboard, 
//or set at the start of the algorithm execution. When solving, 
//it is not recommended to use collections, it is better to do exclusively with arrays
Console.Clear();


double[] Main()
{
    // Задать с клавиатуры число элементов массива
    int n;
    Console.WriteLine("Введите число элементов массива");
    n = Convert.ToInt16(Console.ReadLine());
    // Объявим одномерный массив inputArraay с n-элементами 
    double[] inputArraay = new double[n];
    int i = 0;
    while (i < n)
    {
        Console.WriteLine("Введите элемент массива");
        /* Вводим элементы массива с клавиатуры 
         * и заполняем ими массив */
        inputArraay[i] = double.Parse(Console.ReadLine());
        Console.WriteLine();
        i++;
    }
    // Вывод содержимого массива
    for (i = 0; i < n; i = i + 1)
        Console.WriteLine("Элемент[" + i + "]: " + inputArraay[i]);
    Console.ReadKey();
    return inputArraay;
}

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

double[] result = Main();
factorial(result);

