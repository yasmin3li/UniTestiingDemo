namespace MathLibrary;

public static class Calculator
{
    public static int Multiply(int a, int b){
        return a*b ;
    }
    public static int Divide(int a, int b){
        if (b==0){
            throw new DivideByZeroException("cannont divide by zero!");
        }
        return a/b ;
    }
}
