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

    /* 
    add Dividing: 3 tests
    the first: Divide Two Negative Numbers Returns Positive number
    */
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

    /*
    second test: Divide ByZero Throws DivideByZeroException
    A test code that verifies the division function's handling of the divide-by-zero case
    */
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

    // Check if the number is even: in fact, it is really even
    [Fact] 
    public void IsEven() 
    { 
        // Arrange 
        int a = 2; 
 
        // Act 
        bool result = Calculator.IsEven(a); 
 
        // Assert 
        Assert.True(result) ;
    }

    // Check if the number is even: in fact, it is really even(0 is even)
    [Fact] 
    public void IsEven_Zero_Return_Yes() 
    { 
        // Arrange
        //0 is even and we expect that the returned result will be true     
        int a = 0; 
 
        // Act 
        bool result = Calculator.IsEven(a); 
 
        // Assert 
        Assert.True(result) ;
    }

    // Check if the number is even: in fact, it is not even, it is odd
    [Fact] 
    public void IsEven_OddNumber_Return_No() 
    { 
        // Arrange 
        //1 is odd and we expect that the returned result will be false
        int a = 1; 
 
        // Act 
        bool result = Calculator.IsEven(a); 
 
        // Assert 
        Assert.False(result) ;
    }  

    // Check if the number is even: in fact, it is realy even
    // And it is a negative number, but it will stay an even number
    [Fact] 
    public void IsEven_EvenAndNegativeNumber_Return_EvenNumber() 
    { 
        // Arrange 
        // -2 it is an even and negative number, we expect that the returned result will be true
        int a = -2; 
 
        // Act 
        bool result = Calculator.IsEven(a); 
 
        // Assert 
        Assert.True(result) ;
    }           
}
