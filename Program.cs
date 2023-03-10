Console.Clear();

string[] array = new string[] { "hello", "2", "world", ":-)" };

int GetArray(string[] array) // функция по подсчет кол-ва элементов в массиве 
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count += 1;
        }
    }
    return count;
}

Console.WriteLine(GetArray(array)); // проверка работы функции