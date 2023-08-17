public class MathManger
{
    public static void Main(string[] args)
    {
        MathManger myCal = new MathManger();
        myCal.Add3Numbers();
        myCal.Add5Numbers(1,2,3,4,5);
    }

    public void Add3Numbers()
    {
        int n1 = 5;
        int n2 = 9;
        int sumOfNumbers = n1 + n2 ;
        System.Console.Write("The Sum of two numbers is : ");
        System.Console.WriteLine(sumOfNumbers);
    }

    public void Add5Numbers(int a, int b, int c, int d, int e)
    {
        
        int sumOf5Numbers = a+b+c+d+e;
        System.Console.Write("The Sum of 5 numbers is : ");
        System.Console.WriteLine(sumOf5Numbers);
    }

}
