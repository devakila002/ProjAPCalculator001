using ProjCal; //Added using namespace
namespace ProjCalculator.Tests;

public class Calculatortest
{
    [Fact]
    public void Add3NumbersTest1()
    {
        //Arrange
        MathManger myCal = new MathManger();
        //Act
        myCal.Add3Numbers();
        //Assert
        //Assert.Equal(21,myCal.Add3Numbers());

    }

    [Fact]
    public void Add5NumbersTest2()
    {
        
        //Arrange
        MathManger myCal = new MathManger();
        //Act
       // int sumOf5Numbers = myCal.Add5Numbers(1,2,3,4,5);
       myCal.Add5Numbers(1,2,3,4,5);
        //Assert
       // Assert.Equal(15,sumOf5Numbers);

    }
    [Fact]
    public void Add7NumbersTest3()
    {
         //Arrange
        MathManger myCal = new MathManger();
        //Act
        int sumOf7Numbers = myCal.Add7Numbers(1,2,3,4,5);
        //Assert
        Assert.Equal(26,sumOf7Numbers);
    }
}


