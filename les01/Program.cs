internal class Program
{
    private static void Main(string[] args)
    {
        // Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        Console.WriteLine("Введите пятизначное число :");
        string? numa = Console.ReadLine();
        void CheckingNumber(string numa)
        {
            if (numa[0] == numa[4] & numa[1] == numa[3])
            {
                Console.WriteLine($"Число :{numa} палиндром");
            }
            else Console.WriteLine($"Число :{numa} не палиндром");
        }
        if (numa!.Length==5)
        {
            CheckingNumber(numa);
        }
        else Console.WriteLine(($"Введите правильное число"));
    }
}