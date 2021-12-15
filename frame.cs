using System;

public class Exercise1
{
    public static void Main( )
    {
        
        Console.Write("The sentence is \n");
        
        foreach(var line in GetFrame(1, 100,"*")){
            Console.WriteLine(line);
        }
    }
    
    public static string[] GetFrame(int height, int width, string character){
        string[] frame = new string[height];
        string temp;
        bool first = false, last = false;
        string[] invalid = {"invalid"};
        
        if ( height < 3 || width < 3) return invalid;
        
        for(int i = 0; i < height; i++){
            temp = "";
            if (i == 0) first = true;
            if (i == height - 1) last = true;
            for(int j = 0; j < width; j++){
                if(first || last){
                    temp += character;
                }else if (j == 0 || j == width - 1){
                    temp += character;
                }else{
                    temp += " ";
                }
            }
            frame[i] = temp;
            first = false;
            last = false;
        }
        
        return frame;
    }
}