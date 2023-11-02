using Challenge_App;

Console.WriteLine("Witam w aplikacji do oceniania pracowników");
Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");
Console.WriteLine();
Console.WriteLine("podaj ocenę pracownika");

var employee = new Employee();

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}


var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average} " +
    $"Min: {statistics.Min} " +
    $"Max: {statistics.Max}");



