class Program
{
    static void Main()
    {

        int number = 5;
        string numberString = Convert.ToString(number);
        Console.WriteLine(numberString);
        numberString = "56,3";
        float decimalNumber = Convert.ToSingle(numberString);
        number = (int) Math.Round(decimalNumber);
        Console.WriteLine(number);
    }
}