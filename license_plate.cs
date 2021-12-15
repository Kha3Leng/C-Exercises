// Travelling through Europe one needs to pay attention to how the license plate in the given country is displayed. When crossing the border you need to park on the shoulder, unscrew the plate, re-group the characters according to the local regulations, attach it back and proceed with the journey.

// Create a solution that can format the dmv number into a plate number with correct grouping. The function input consists of string s and group length n. The output has to be upper case characters and digits. The new groups are made from right to left and connected by -. The original order of the dmv number is preserved.

using System;
using System.Text.RegularExpressions;
using System.Linq;

public class Exercise1
{
    public static void Main( )
    {
         Console.WriteLine("Result : {0}", LicencePlate("nlj-206-fv", 3));
    }
    
    public static string LicencePlate(string dmv, int grouping){
        string dmvRip = Regex.Replace(dmv, @"-", "");
        string dmvRipCap = dmvRip.ToUpper();
        string dmvReverse = new string(dmvRipCap.ToCharArray().Reverse().ToArray());
        
        if (grouping < 1){
            return "invalid grouping";
        }
        
        int len = dmvReverse.Length%grouping == 0? dmvReverse.Length/grouping: dmvReverse.Length/grouping + 1;
        string[] result = new string[len];
        string[] new_result = new string[len];
        
        for(int i = 0; i < len; i++){
            result[i] = new string(dmvReverse.ToArray().Take(grouping).ToArray());
            dmvReverse = new string(dmvReverse.ToArray().Skip(grouping).ToArray());
            Console.WriteLine("line : {0}", dmvReverse);
        }
        
        // reverse string into reverse array
        for(int i = 0, j = len - 1; i < len && j >= 0; i++, j--){
            new_result[i] = new string(result[j].ToCharArray().Reverse().ToArray());
        }
        
        return string.Join("-", new_result);
    }
}