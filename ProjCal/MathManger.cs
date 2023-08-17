namespace ProjCal;
public class MathManger
{
    public static void Main(string[] args)
    {
        MathManger myCal = new MathManger();
        myCal.Add3Numbers();
        myCal.Add5Numbers(1,2,3,4,5);
        int sumof7 = myCal.Add7Numbers(1,2,3,4,5);
        
    }

    public void Add3Numbers()
    {
        int n1 = 5;
        int n2 = 9;
        int n3 = 7;
        int sumOf3Numbers = n1 + n2 + n3 ;
        System.Console.Write("The Sum of two numbers is : ");
        System.Console.WriteLine(sumOf3Numbers);
    }

    public void Add5Numbers(int a, int b, int c, int d, int e)
    {
        
        int sumOf5Numbers = a+b+c+d+e;
        System.Console.Write("The Sum of 5 numbers is : ");
        System.Console.WriteLine(sumOf5Numbers);
    }

    public int Add7Numbers(int n1, int n2, int n3, int n4, int n5)
    {
        int n6 = 3;
        int n7 = 8;
        int sumOf7Numbers = n1+n2+n3+n4+n5+n6+n7;
        System.Console.Write("The Sum of 7 numbers is : ");
        System.Console.WriteLine(sumOf7Numbers);
        return sumOf7Numbers;
    }

}
