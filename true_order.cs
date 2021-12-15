using System;
using System.Linq;

public class Exercise1
{
    public static void Main( )
    {
         System.Console.Write("True Orders : " + TrueOrder("have a nice day"));
    }
    
    public static string TrueOrder(string sentence){
        string[] words = sentence.Split(' ');
        int[] words_length = new int[words.Length];
        sentence = string.Concat(sentence.Where(c => !char.IsWhiteSpace(c)));
        Console.WriteLine(sentence);
        char[] smash = sentence.ToArray();
        string[] temp = new string[words.Length];
        
        for(var j = 0; j < words.Length; j++){
            words_length[j] = words[j].Length;
        }
        
        Array.Sort(smash);
        Console.WriteLine("Smash :{0}", new string(smash));
        Console.WriteLine("Smash  length :{0}", smash.Length);
        words_length.ToList().ForEach(ad => Console.WriteLine(ad));
        
        
        for(var i = 0; i < words.Length; i++){
            char[] what = smash.Take(words_length[i]).ToArray();
            temp[i] = new string(what);
            smash = smash.Skip(words_length[i]).ToArray();
            Console.WriteLine("Smash : {0}", new string(smash));
        }
        
        return string.Join(" ", temp);
    }
}