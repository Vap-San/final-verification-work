//Из имеющегося массива строк сформировать массив слов, длина которых меньше либо равна 3 

//Вывод массива строк на экран
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (!string.IsNullOrEmpty(array[i]))   // Строка не нулевая или не пустая, тогда выводим
        {
            Console.WriteLine($"array[{i + 1}] = {array[i]}");
        }
    }
    System.Console.WriteLine();
}
//Генерация нового массива по условию задачи
string[] GenerateNewArray(string[] array)
{
    string[] newArray = new string[array.Length];
    int j = -1;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
        {
            j++;
            newArray[j] = array[i];
        }
    return (newArray);
}

string[] arrayOfStrings = { "Hello", "  ", "   ", "World", ":)      ", "One    ", "123", "2=2   ", "Sat" };
PrintArray(arrayOfStrings);
string[] newArrayOfStrings = GenerateNewArray(arrayOfStrings);
PrintArray(newArrayOfStrings);




