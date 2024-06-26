using Task1;

IndexOutOfRangeException ex1 = new IndexOutOfRangeException();
DivideByZeroException ex2 = new DivideByZeroException();
FormatException ex3 = new FormatException();
ArgumentException ex4 = new ArgumentException();
MyException ex5 = new MyException();

Exception[] ExArray = { ex1, ex2, ex3, ex4, ex5 };

foreach (var exception in ExArray)
{
    try
    {
        throw exception;
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}