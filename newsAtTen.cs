// A local news station needs your help to generate the scrolling text for the headlines!

// Create a function that returns an array of strings, where each string contains a single frame of what the scrolling text will look like.

// Text will scroll from right to left.
// The screen will have a width of n characters.
// Start and stop when no letters appear on the screen.
// The example below will demonstrate the output when the screen width is 10.using System;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

public class Exercise1
{
    public static void Main( )
    {
         Console.WriteLine("Result : \n{0}\n\n", string.Join("\n", NewsAtTen("I love eating potato. I want to quit.. I want to pursue my dream.", 200)));
    }
    
    public static string[] NewsAtTen(string news, int width){
        List<string> scr = new List<string>();
        int line_count = width - news.Length + 1 + (news.Length * 2);
        string temp = "";
        char[] character = news.ToArray();
        
        for(int j = 0; j < line_count; j++){
            temp = "";
            for(int i = 0; i < width; i++){
                
                if (j == 0 || j == line_count -1) {
                    temp += "*";
                    continue;
                }
                
                if (Math.Abs(width - j) <= i){
                    if (news.Length >= j){
                        // temp += character[j-1]; 
                        string mani = new string(character.Take(j).ToArray());
                        temp += mani[Math.Abs(width-i-j)];
                    }
                    else{
                        // temp += "!";
                        if (j <= line_count - news.Length -1){
                            string mani = new string(character.Take(width-i).ToArray());
                            mani = new string(mani.ToCharArray().Take(news.Length).ToArray());
                            temp += mani;
                            // Console.WriteLine(" i : {0}, j : {1}", i, j);
                            break;
                        }else{
                            // string mani = new string(character.Take(line_count-j).ToArray());
                            // mani = new string(mani.ToCharArray().Skip(line_count-j).ToArray());
                            string mani = new string(character.Skip(i).ToArray());
                            // Console.WriteLine(" i : {0}, j : {1}", i, j);
                            temp += mani;
                            break;
                        }
                    }
                }else if ((width - j) > i){
                    temp += " ";
                }
                // else{
                //     temp += "-";
                // }
                
            }
            scr.Add(temp);
        }
        
        
        return scr.ToArray();
    }
}