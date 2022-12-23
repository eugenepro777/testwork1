/* написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо
равна 3 символа. Первоначальный массив можно ввести
 с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше
 обойтись исключительно массивами
 */

var inputArray = FillStringsArray();
Console.WriteLine
("Массив исходных строк:\t");
PrintArray(inputArray);

var outputArray = FindLessEqualThree(inputArray);
Console.WriteLine
("Массив на выходе: ");
PrintArray(outputArray);

string[] FindLessEqualThree(string[] input)
{
    int count = 0;
    int length = input.Length;
    string[] outputArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        if (input[i].Length <= 3)
        {
            outputArray[count] = input[i];
            count++;
        }
    }
    return outputArray;
}

string[] FillStringsArray()
{
    int numberLines = 0;
    string[] arrayInitial = new string[numberLines];
    string inputString;
    string[] arrayTempOld;
    Console.WriteLine("Введите строки массива:");
    do
    {       
        inputString = Console.ReadLine()!;       
        if (inputString != String.Empty)
        {                       
            numberLines++;                      
            arrayTempOld = new string[numberLines];                      
            for (int i = 0; i < arrayTempOld.Length - 1; i++)
            {
                arrayTempOld[i] = arrayInitial[i];
            }                        
            arrayTempOld[numberLines - 1] = inputString;                        
            arrayInitial = arrayTempOld;
        }
    }
    while (inputString != String.Empty);
    return arrayInitial;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == null) Console.WriteLine(string.Join(",", arr[i]));
        else if (i == arr.Length - 1)
        {
            Console.WriteLine($"\"{arr[i]}\"");
        }
        else
        {
            Console.Write($"\"{arr[i]}\",  ");
        }
    }
}
