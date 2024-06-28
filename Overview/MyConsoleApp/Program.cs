// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string response;
Console.WriteLine("What's your name");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
response = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
Console.WriteLine($"Enjoy the course, {response}");

OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine("thisOS.Platform");
Console.WriteLine("thisOS.VersionString");

