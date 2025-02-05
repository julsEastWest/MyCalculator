using Calculator;
using NUnit.Framework;

namespace Calculator.UnitTest;
 
[TestFixture]
public class Tests
{
    private Operation _operation;
    
    [SetUp]
    public void Setup()
    {
        _operation = new Operation();
    }

    // TEST CASE //

    [TestCase(1, 2, 3)] //[TestCase(param1, param2, expectedResult)] testcase attributes can be used to pass parameters to the test method.
    //public void Test1(double Fnum, double Snum, string operands)
    public void Addition(double Fnum, double Snum, double expected)
    {
        var result = _operation.Addition(Fnum, Snum);
        Assert.That(result, Is.EqualTo(expected));
    }
    [TestCase(5, 5, 0)]
    [TestCase(10, 9, 1)]
    public void Subtraction(double Fnum, double Snum, double expected)
    {
        var result = _operation.Subtraction(Fnum, Snum);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(5, 5, 25)]
    public void Multiplication(double Fnum, double Snum, double expected)
    {
        var result = _operation.Multiplication(Fnum, Snum);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(10, 5, 2)]
    public void Division(double Fnum, double Snum, double expected)
    {
        var result = _operation.Division(Fnum, Snum);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(5, 0)]
    public void DivideByZero(double FNum, double SNum){
        Assert.Throws<DivideByZeroException>(() => _operation.Division(FNum, SNum)); //lambda expression
    }

    [TestCase(5, 5, "%")]
    public void InvalidOperationException(double Fnum, double Snum, string Operands){   
        Assert.Throws<InvalidOperationException>(() => _operation.Execute(Fnum, Snum, Operands));
    }
    // note arrangements of paremeters are crucial 
    // assert - checks whether the condition is true or verify if the code behaves as expected.
    // Assert.AreEqual(expected, actual, message);

}