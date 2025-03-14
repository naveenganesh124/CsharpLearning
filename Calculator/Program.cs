class Calculator
{
    static void Main(string[] args)
    {
        int  num =Convert.ToInt32("43");
        Console.WriteLine(num + 6);   // it will do the math operation, because we are converting the string into integer;


        //calculator

        Console.Write("enter first number :");
        double num1 =Convert.ToDouble(Console.ReadLine());
        Console.Write("enter second number :");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("calculated value is " + (num1 + num2));
    }
}