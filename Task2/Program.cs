using Task1;
using Task2;

SortList sortList = new SortList();
sortList.SortEvent += SortMethod;

string[] LastNames = { "Иванов", "Петров", "Сидоров", "Кузеванов", "Волков" };
foreach (var lastName in LastNames)
{
    Console.Write(lastName + " ");
}
Console.WriteLine();

Console.WriteLine("Введите 1 или 2 чтобы отсортировать список фамилий. 1 - от А до Я, 2 - от Я до А");
string choice = Console.ReadLine();

sortList.StartProcess(choice, LastNames);

foreach (var lastName in LastNames)
{
    Console.Write(lastName + " ");
}

static void SortMethod(string choice, string[] LastNames)
{
    try
    {
        switch (choice)
        {
            case "1":
                for (int i = 0; i < LastNames.Length; i++)
                {
                    for (int j = i + 1; j < LastNames.Length; j++)
                    {
                        if (string.Compare(LastNames[i], LastNames[j]) > 0)
                        {
                            string temp = LastNames[i];
                            LastNames[i] = LastNames[j];
                            LastNames[j] = temp;
                        }
                    }
                }
                break;
            case "2":
                for (int i = 0; i < LastNames.Length; i++)
                {
                    for (int j = i + 1; j < LastNames.Length; j++)
                    {
                        if (string.Compare(LastNames[i], LastNames[j]) < 0)
                        {
                            string temp = LastNames[i];
                            LastNames[i] = LastNames[j];
                            LastNames[j] = temp;
                        }
                    }
                }
                break;
            default:
                throw new MyException("Некорректный ввод");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}