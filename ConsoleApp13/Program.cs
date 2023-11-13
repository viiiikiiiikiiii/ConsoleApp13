using static System.Console;
class Programm
{
    public static void Main()
    {
        WriteLine("Введите X");
        double x = Convert.ToDouble(ReadLine());
        WriteLine(8 * Math.Pow(x - 3, 6) - 7 * Math.Pow(x - 3, 3) + 27);
    }
}