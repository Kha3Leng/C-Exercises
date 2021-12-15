using System;


public class Exercise1
{
    public static void Main( )
    {
        int input = 100000;
        int temp = 100000;
        int reverse_num = 0, dummy = 0;
        
        while (temp%10 != 0){
            dummy = (temp % 10);
            reverse_num = (int) reverse_num*10 + dummy;
            //Console.Write(dummy+"\n");
            temp = temp / 10;
            //Console.Write(temp+"\n");
            
        }
        
        Console.Write("Reverse Number : {0,-16}", reverse_num);
    }
}