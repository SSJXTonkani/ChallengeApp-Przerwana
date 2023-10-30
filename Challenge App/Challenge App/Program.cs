using Challenge_App;


Employee employee = new Employee("Paulina", "Kowalska", 22);
employee.AddGrade(10000);
employee.AddGrade("Maciek z klanu do góry nogami");
employee.AddGrade(4);
employee.AddGrade("99");
employee.AddGrade(6f);

var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithForeach();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine($"GetStatistics: Max Value: {statistics1.Max}, Min Value: {statistics1.Min} Average: {statistics1.Average}");
Console.WriteLine($"GetStatistics: Max Value: {statistics2.Max}, Min Value: {statistics2.Min} Average: {statistics2.Average}");
Console.WriteLine($"GetStatistics: Max Value: {statistics3.Max}, Min Value: {statistics3.Min} Average: {statistics3.Average}");
Console.WriteLine($"GetStatistics: Max Value: {statistics4.Max}, Min Value: {statistics4.Min} Average: {statistics4.Average}");

//Console.WriteLine($"Average: {statistics.Average:N2} Min: {statistics.Min} Max: {statistics.Max}");
