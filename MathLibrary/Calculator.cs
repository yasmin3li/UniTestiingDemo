﻿namespace MathLibrary;

public static class Calculator
{
    public static int Multiply(int a, int b){
        return a*b ;
    }

    /*a: first number
    b: second number
    dividing a/b then, retuen the result
    I implemented zero division handling in the calculator's
    core logic and wrote corresponding test cases that specifically verify this edge case
    */
     core logic and wrote corresponding test cases that specifically verify this edge case
    public static int Divide(int a, int b){
        if (b==0){
            throw new DivideByZeroException("cannont divide by zero!");
        }
        return a/b ;
    }

   // a is the number to test if it's even or not
    public static bool IsEven(int a){
        if (a%2==0)
            return true;
        return false;
        
    }    
}
