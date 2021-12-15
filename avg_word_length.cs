using System;

public class Exercise1
{
    public static void Main( )
    {
        
        Console.Write("The result is \n" + AvgWordLength("Dude, this is so awesome!"));
    }
    
    public static float AvgWordLength(string str){
        char[] charToTrim = {',', '.', '!', '/'};
        str = str.Trim(charToTrim);
        string[] words = str.Split(' ');
        Console.Write(words);
        float avg = 0.0f;
        float sum = 0.0f;
        
        foreach(var word in words){
            sum += word.Length;
        }
        
        avg = sum / words.Length;
        
        return avg;
        
    }
}