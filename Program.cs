Console.Clear();
// __________________________________________________________________
// Создаем новый массив
string[] array = new string[] { "hello", "2", "world", ":-)" };
// __________________________________________________________________

// Создаем функцию 
int GetArray(string[] array) // проверка на кол-во элементов в массиве и соответсвие условиям задачи <= 3
{
    int count = 0; // задаем счетчик

    for (int i = 0; i < array.Length; i++) //условие выхода
    {
        if (array[i].Length <= 3)
        {
            count += 1; // count = count + 1
        }
    }
    return count; // вернем значение count 
}
// Console.WriteLine(GetArray(array)); // проверка работы функции
// __________________________________________________________________

void ResultArray(int count) // в функци resultArray создается новый массив, который заполняется
// значениями, удовлетворяющими условия задачи.
{
    string[] newArray = new string[count];

    int j = 0; // задаем счетчик

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j += 1; // j = j + 1
        }
    }
    var rolting = string.Join(" ", newArray); // раздеяем пробелом элементы
    Console.Write(rolting);
}
// ____________________________START_________________________________
ResultArray(GetArray(array)); //запуск программы
// ____________________________END___________________________________
