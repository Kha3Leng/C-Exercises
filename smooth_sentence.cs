using System;

public class Exercise1
{
    public static void Main( )
    {
        string result = SmoothSentences("She eats super righteously")?"smooth.":"not smooth.";
        Console.Write("The sentence is " + result);
    }
    
    public static bool SmoothSentences(string str){
        string[] words = str.Split();
        /*foreach(var word in words){
            Console.WriteLine("words : "+word);
            Console.WriteLine("last char : "+word[word.Length-1]);
        }*/
        string initial_word = words[0];
        char last_char1;
        char last_char;
        int i = 1;
        bool smooth = false;
        bool all_smooth = false;
        
        do{
            last_char = initial_word[initial_word.Length-1];           //previous word's last char
            
            if (words[i].StartsWith(Convert.ToString(last_char)))
                smooth = true;
            
            initial_word = words[i];
            i++;
        }while(i < words.Length && smooth);
        
        if ( i == words.Length && smooth){
            all_smooth = true;
        }
        
        return all_smooth;
    }
}