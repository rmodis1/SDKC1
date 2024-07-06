using Calculator;
using FluentAssertions;

namespace Calculator.Tests;

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void CalculatorNullTest()
    {
        Calculator calculator = new Calculator();
        Assert.IsNotNull(calculator);

        Assert.IsTrue(true);
    }

    [TestMethod]
    public void AddTest()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        var actual = calculator.Add(1, 1);

        // Assert
        Assert.AreEqual(2, actual);
    }

    [TestMethod]
    public void SubtractTest()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var actual = calculator.Subtract(2, 1);

        //Assert
        Assert.AreEqual(1, actual);
    }

    [TestMethod]
    public void MultiplyTest()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var actual = calculator.Multiply(6, 6);

        //Assert
        Assert.AreEqual(36, actual);
    }

    [TestMethod]
    public void DivideTest()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var actual = calculator.Divide(10, 5);

        //Assert
        Assert.AreEqual(2, actual);
    }

    [TestMethod]
    public void DivideByZeroTest()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        double? actual = calculator.Divide(10, 0);

        //Assert
        Assert.IsNull(actual);
    }

    [TestMethod]
    public void AddTestFluentassertion()
    {
        var calculator = new Calculator();
        var actual = calculator.Add(1, 1);

        // Non-fluent asserts:
        // Assert.AreEqual(actual, 2);
        // Assert.AreNotEqual(actual, 1);

        // Same asserts as what is commented out above, but using Fluent Assertions
        actual.Should().Be(2).And.NotBe(1);
    }
}
