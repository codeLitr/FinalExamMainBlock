// Задача:
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Метода для создания массива строк с количеством строк в диапазоне от 1 до 10 и длинной каждой строки в диапазоне от 1 до 5.
// Количество и длина строк создаются при каждом запуске разные в указанных диапазонах.
string[] CreateRandomString(string[] arraySymbols)
{
    Random rnd = new Random();
    int countString = rnd.Next(1, 10); // Переменная, определяющая количество строк.
    string[] str = new string[countString];

    for (int i = 0; i < countString; i++)
    {
        int lengthString = rnd.Next(1, 6); // Переменная, определяющая длину каждой строки. 
        for (int j = 0; j < lengthString; j++)
        {
            int index = rnd.Next(arraySymbols.Length);
            str[i] += arraySymbols[index];
        }
    }
    return str;
}
// Метод для вывода полученного массива строк в консоль.
void PrintArray(string[] arrayString)
{
    Console.Write("[{0}] -> ", string.Join(", ", arrayString));
}
// Метод для поиска строк, длина которых меньше или равна 3 символам с последующим выводом в консоль результата.
// При не выполнении условий будут выведены пустые скобки "[]" (как это указано в примере).
void FindThreeDigitString(string[] arrayString)
{
    string[] threeDigitStrings = arrayString.Where(s => s.Length <= 3).ToArray();
    Console.Write("[{0}]", string.Join(", ", threeDigitStrings));
}

string[] arraySymbols =
{ "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у",
"ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

string[] arrayString = CreateRandomString(arraySymbols);
PrintArray(arrayString);

FindThreeDigitString(arrayString);