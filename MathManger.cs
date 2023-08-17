public class MathManger
{
    public static void Main(string[] args)
    {
        MathManger myCal = new MathManger();
        myCal.Add3Numbers();
    }

    public void Add3Numbers()
    {
        int n1 = 5;
        int n2 = 9;
        int sumOfNumbers = n1 + n2 ;
         System.Console.Write("The Sum of two numbers is : ");
        System.Console.WriteLine(sumOfNumbers);
    }

}
