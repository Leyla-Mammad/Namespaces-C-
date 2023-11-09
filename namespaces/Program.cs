
using System;
using System.Linq;

public class ArrayHelper
{
    public static bool IsArrayContains(params int[][] arrays)
    {
        if (arrays.Length < 2)
        {
            return false;
        }
        int[] arr1 = arrays[0];
        int[] arr2 = arrays[1];

        for (int i = 0; i <= arr1.Length - arr2.Length; i++)
        {
            if (arr1[i] == arr2[0])
            {
                bool contains = true;
                for (int j = 1; j < arr2.Length; j++)
                {
                    if (arr1[i + j] != arr2[j])
                    {
                        contains = false;
                        break;
                    }
                }
                if (contains)
                {
                    return true;
                }
            }
        }

        return false;
    }

    public static void Main2(string[] args)
    {
        int[] arr1 = { 2, 3, 4, 7 };
        int[] arr2 = { 3, 2, 7 };

        bool result = IsArrayContains(arr1, arr2);
        Console.WriteLine(result);  

        int[] arr3 = { 2, 3, 4, 7 };
        int[] arr4 = { 3, 4 };

        result = IsArrayContains(arr3, arr4);
        Console.WriteLine(result);  
    }
}


public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}

public class Student : User
{
    public int Grade { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        User[] users = {
            new Student { Name = "John", Surname = "Doe", Username = "john123", Password = "pass123", Grade = 10 },
            new Student { Name = "Alice", Surname = "Smith", Username = "alice456", Password = "pass456", Grade = 11 },
        };

        Console.WriteLine("Enter username:");
        string enteredUsername = Console.ReadLine();

        Console.WriteLine("Enter password:");
        string enteredPassword = Console.ReadLine();

        bool isAuthenticated = false;
        foreach (var user in users)
        {
            if (user.Username == enteredUsername && user.Password == enteredPassword && user is Student)
            {
                var student = (Student)user;
                Console.WriteLine($"Welcome, {student.Name} {student.Surname}!");
                Console.WriteLine($"Grade: {student.Grade}");
                isAuthenticated = true;
                break;
            }
        }

        if (!isAuthenticated)
        {
            Console.WriteLine("Authentication failed. Invalid username or password.");
        }
    }
}