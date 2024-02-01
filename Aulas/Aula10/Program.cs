using System;

class Program{

    enum WeekDays{Sunday,Monday,Tuesday,
    Wednesday,Thursday,Friday,
    Saturday
    };

    static void Main(){

        //WeekDays wD = WeekDays.Sunday;
        //WeekDays wD = (WeekDays)3;

        int wD = (int) Program.WeekDays.Tuesday; 


        Console.WriteLine(wD);
        
    }
}