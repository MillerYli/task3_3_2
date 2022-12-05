using System;

class MyProgramm
{
    public static void Main(string[] args)
    {
        string MyName = "Yliua";
        int Age = 27;
        bool Pets = true;
        double MySize = 36;

        Console.WriteLine("My name is " + MyName);
        Console.WriteLine("I am " + Age + " years old");
        Console.WriteLine("Do you have pats " + Pets);
        Console.WriteLine("My size " + MySize);

        //Проверка занчений в типе данных
        Console.WriteLine("IntMin{0}", int.MinValue);
        Console.WriteLine("IntMax{0}", int.MaxValue);
    }
}