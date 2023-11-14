using static System.Console;
class Programm
{
    public static void Main()
    {
        WriteLine("Введите y");
        double y = Convert.ToDouble(ReadLine());
        WriteLine(8 * Math.Pow(y - 3, 6) - 7 * Math.Pow(y - 3, 3) + 27);
    }
}