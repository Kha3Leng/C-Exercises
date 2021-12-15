using System;


public class Exercise1
{
    public static void Main( )
    {
        int input = 5;
        int factorial = 1;
        
        while(input > 0){
            factorial *= input;
            input--;
        }
        
        Console.Write("Factorial is {0,-50:N}",factorial);
    }
}