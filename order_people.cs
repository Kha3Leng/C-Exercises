// Create a function that takes in the size of the line and the number of people waiting and places people in an S-shape ordering, returning the result as string. The demonstration below will make it clear:

// # Ordering numbers 1-15 in a 5 x 3 space.

// OrderPeople(5, 3, 15) ➞ 
// 1, 2, 3
// 6, 5, 4
// 7, 8, 9
// 12, 11, 10
// 13, 14, 15
// If there is extra room, leave those spots blank with a 0 filler.

// # Ordering numbers 1-5 in a 4 x 3 space.

// OrderPeople(4, 3, 5) ➞
// 1, 2, 3
// 0, 5, 4,
// 0, 0, 0,
// 0, 0, 0
// If there are too many people for the given dimensions, return "overcrowded".

// OrderPeople(4, 3, 20) ➞ "overcrowded"
using System;
using System.Linq;

public class Exercise1
{
    public static void Main( )
    {
         System.Console.WriteLine("Write your code at here");
         Console.WriteLine("Answer : \n" + OrderPeople(7, 20, 100));
    }
    
    
    public static string OrderPeople(int row, int col, int people){
        int[,] result = new int[row,col];
        int temp = 1;
        int shit = 0;
        
        string[] answer = new string[row];
        string return_res = "";
        if (row * col >= people){
            for(int i = 0; i < row; i++){
                for(int j = 0; j < col; j++, temp++, shit++){
                    if (temp > people){
                        result[i,j] = 0;
                    }else{
                        result[i,j] = temp;
                    }
                }
            }
            int[] reverse_array = new int[col];
            for(int i = 0; i < result.GetLength(0); i++){
                for(int j = 0; j < result.GetLength(1); j++){
                    
                    if (i % 2 != 0){
                        reverse_array[j] = result[i,j];
                    }
                }
                if (i % 2 != 0) reverse_array = reverse_array.Reverse().ToArray();
                for(int j = 0; j < result.GetLength(1); j++){
                    if (i % 2 != 0){
                        result[i,j] = reverse_array[j];
                    }
                }
            }
            for(int i = 0; i < result.GetLength(0); i++){
                for(int j = 0; j < result.GetLength(1); j++){
                    answer[i] += result[i,j].ToString() + (j == col - 1?"\n": ", ");
                }
            }
            return_res = string.Join("", answer);
        }else{
            return_res = "overcrowded";
        }
        
        return return_res;
    }
}