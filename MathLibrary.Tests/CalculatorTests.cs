using Xunit;
using MathLibrary;
namespace MathLibrary.Tests;

public class  CalculatorTests 
{
    [Fact]
     public void Multiply_TwoPositiveNumbers_ReturnsCorrectResult()
    {
         int a = 2, b = 3; 
         int result = Calculator.Multiply(a, b); 
         Assert.Equal(6, result); 
    }
     [Fact] 
    public void Multiply_NumberWithZero_ReturnsZero() 
    { 
        // Arrange 
        int a = 0, b = 5; 
 
        // Act 
        int result = Calculator.Multiply(a, b); 
 
        // Assert 
        Assert.Equal(0, result); 
    } 
 
    [Fact] 
    public void Multiply_NegativeAndPositiveNumber_ReturnsNegative() 
    { 
        // Arrange 
        int a = -2, b = 3; 
 
        // Act 
        int result = Calculator.Multiply(a, b); 
 
        // Assert 
        Assert.Equal(-6, result); 
    } 
 
    [Fact] 
    public void Multiply_TwoNegativeNumbers_ReturnsPositive() 
    { 
        // Arrange 
        int a = -2, b = -3; 
 
        // Act 
        int result = Calculator.Multiply(a, b); 
 
        // Assert 
        Assert.Equal(6, result); 
    } 

    // add Dividing: 3 tests
    //the first: Divide Two Negative Numbers Returns Positive number
    [Fact] 
    public void Divide_TwoNegativeNumbers_ReturnsPositive() 
    { 
        // Arrange 
        int a = -6, b = -2; 
 
        // Act 
        int result = Calculator.Divide(a, b); 
 
        // Assert 
        Assert.Equal(3, result); 
    }

    //second test: Divide ByZero Throws DivideByZeroException
    [Fact] 
    public void Divide_ByZero_ThrowsDivideByZeroException() 
    { 
        // Arrange 
        int a = -6, b = 0; 
 
        // Act with assert
        var exception = Assert.Throws<DivideByZeroException>(
            () => Calculator.Divide(a, b)
            );
        // Assert 
        Assert.Contains("cannont divide by zero", exception.Message); 
    }

    //third test: Divide Negative Number On Positive Number Return Negative Number
    [Fact] 
    public void Divide_NegativeNumberOnPositiveNumber_ReturnNegativeNumber() 
    { 
        // Arrange 
        int a = -6, b = 2; 
 
        // Act 
        int result = Calculator.Divide(a, b); 
 
        // Assert 
        Assert.Equal(-3, result); 
    }
}
