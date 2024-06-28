while (true)
{
    Console.WriteLine("Enter a date or type 'exit' to quit:");
    string userInput = Console.ReadLine();

    if (userInput == "exit")
    {
        break;
    }

    DateTime enteredDate;
    bool isValidDate = DateTime.TryParse(userInput, out enteredDate);
  
    if (!isValidDate)
    {
        Console.WriteLine("Invalid date");
        continue;
    }

    DateTime currentDate = DateTime.Now;
    int daysDifference = (enteredDate - currentDate).Days;

    if (daysDifference > 0)
    {
        Console.WriteLine($"There are {daysDifference} days until {enteredDate:D}.");
    }
    else if (daysDifference < 0)
    {
        Console.WriteLine($"{Math.Abs(daysDifference)} days have passed since {enteredDate:D}.");
    }
    else
    {
        Console.WriteLine($"Today is {enteredDate:D}.");
    }
}
