using System;


public class Exercise1
{
    public static void Main( )
    {
        bool flag = false;
        for(int i = 0; i < 5; i++){
            for(int j = 0; j <= i; j++){
                Console.Write(flag?0:1);
                flag = flag?false:true;
            }
            Console.Write("\n");
        }
    }
}