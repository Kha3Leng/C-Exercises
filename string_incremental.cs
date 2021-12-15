// Write a function which increments a string to create a new string.

// If the string ends with a number, the number should be incremented by 1.
// If the string doesn't end with a number, 1 should be added to the new string.
// If the number has leading zeros, the amount of digits should be considered.


using System.Text.RegularExpressions;
using System.Linq;

public class Exercise1
{
    public static void Main( )
    {
         System.Console.WriteLine("Result : {0}", StringInc("fooba000012"));
    }
    
    public static string StringInc(string str){
        string processed;
        string result; 
        
        string[] character = Regex.Split(str, @"[0-9]*");
        string[] number = Regex.Split(str, @"[a-z]*");
        
        
            character = character.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            number = number.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
        
        if (number.Length == 0){
            str += "1";
            result = str;
        }else{
            
            foreach(var sp in character){
                System.Console.WriteLine("what : " + sp);
            }
            
            foreach(var sp in number){
                System.Console.WriteLine("what1: " + sp);
            }
            
            int num = System.Convert.ToInt32(string.Join("", number)) + 1;
            string length = "";
            
            for(int w = 0; w < number.Length; w++){
                length += "0";
            }
            result = num.ToString(length);
            
            string yes = string.Join("", character);
            
            result = yes + result;
            
            System.Console.WriteLine(length);
            
        }
        
        
        
        return result;
    }
}