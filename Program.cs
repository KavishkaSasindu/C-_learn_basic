using System;

class Program{
    public static void Main(string[] args){

        // Console.WriteLine(age);

        // Console.WriteLine(int.MaxValue);
        // Console.WriteLine(int.MinValue);

        // Console.WriteLine(long.MaxValue);
        // Console.WriteLine(long.MinValue);

        // converting string into numbers

        // string number = "23";

        // int age = Convert.ToInt32(number);
        // Console.WriteLine(age);

        // int number = 22;

        // if(number%2 == 0){
        //     Console.WriteLine("Number is even number");
        // }else{
        //     Console.WriteLine("Number is odd number");
        // }

        // var keyword
        /*using var keyword when the variable initialize using var the compiler will automatically updated the data type what we assign*/

        // var name = "Kavishka Sasindu";
        // Console.WriteLine(name);

        // COnsole.input/output

        Console.Write("Enter your name :");
        string name = Console.ReadLine();
        Console.WriteLine(name);

        Console.Write("Enter your age :");
        int age  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(age);


    }
}