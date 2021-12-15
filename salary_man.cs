// Write a function that calculates overtime and pay associated with overtime.

// Working 9 to 5: regular hours
// After 5pm is overtime
// Your function gets an array with 4 values:

// Start of working day, in decimal format, (24-hour day notation)
// End of working day. (Same format)
// Hourly rate
// Overtime multiplier
// Your function should spit out:

// $ + earned that day (rounded to the nearest hundreth)
// Examples
// OverTime([9, 17, 30, 1.5]) ➞ "$240.00"

// OverTime([16, 18, 30, 1.8]) ➞ "$84.00"

// OverTime([13.25, 15, 30, 1.5]) ➞ "$52.50"


using System;
using System.Linq;

public class Exercise1
{
    public static void Main()
    {
        double[] fuck = {16, 18, 30, 1.8};
        System.Console.Write("Earned Amount : {0,20:c}", SalaryMan(fuck));
    }
    
    public static double SalaryMan(double[] working_hour){
        double startHr = working_hour[0];
        double endHr = working_hour[1];
        double earnedPerHr = working_hour[2];
        double otMultiple = working_hour[3];
        double workingHr = endHr - startHr;
        double ot;
        double earned = 0f;
        
        if (endHr > 17){
            ot = endHr - 17;
            workingHr = workingHr - ot;
            earned = otMultiple * ot * earnedPerHr + workingHr * earnedPerHr;
            Console.WriteLine("Earnedd");
        }else{
            earned = workingHr * earnedPerHr;
        }
        
        return earned;
    }
}