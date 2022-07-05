Console.WriteLine("Написать программу которая из имеющегося массива строк формирует массив из строк, меньше либо равна 3 символам.");

int n = InputNumbers("Введите кол-во элементов массива: ");
string[] arrayStrings = new string[] { };
arrayStrings = new string[n];
for (int i = 0; i < arrayStrings.Length; i++)
{
    Console.Write($" Введите {i + 1} строку: ");
    arrayStrings[i] = Console.ReadLine();
}

int lengthLimit = 3;

int numbersItems = ValidatonArray(arrayStrings, lengthLimit);

string[] newArrayStrings = new string[numbersItems];

FillNewArray(arrayStrings, newArrayStrings, lengthLimit);

Console.WriteLine($"{PrintArray(newArrayStrings)}");


void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
    int temp = 0;
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= lengthLimit)
        {
            newArray[temp] = oldArray[i];
            temp++;
        }
    }
}

int ValidatonArray(string[] array, int lengthLimit)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLimit) result++;
    }
    return result;
}

string PrintArray(string[] array)
{
    string result = string.Empty;
    result = "{ ";
    for (int i = 0; i < array.Length; i++)
    {
        result += $"{array[i],1}";
        if (i < array.Length - 1) result += ", ";
    }
    result += " }";
    return result;
}
int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
