using System;
using System.Linq;

public class Exercise1
{
    public static void Main( )
    {
         System.Console.Write("Waiting Minutes : " + License("Zebediah", 1, "Bob Jim Becky Pat"));
    }
    
    public static int License(string name, int agent, string names){
        int waiting_time = 0;
        string[] customers = names.Split(' ');
        string[] new_customers = new string[customers.Length+1];
        string[] temp;
        
        for(var j = 0; j < names.Length+1; j++){
            /*if (j == names.Length){
                new_customers[j] = name;
                break;
            }else{
                new_customers[j] = customers[j];
            }*/
        }
        
        Array.Sort(new_customers);
        string[] temp1 = new_customers;
        
        
        for(var i = 0; i < customers.Length; i = i + agent){
            temp = temp1.Take(agent).ToArray();
            temp1 = temp1.Skip(agent).ToArray();

            Console.WriteLine("temp : {0, 10}  ----- {1,20}", string.Join(", ", temp), i);
            
            waiting_time += 20;
            if (temp.Contains(name)) break;
        }
        
        
        return waiting_time;
    }
}