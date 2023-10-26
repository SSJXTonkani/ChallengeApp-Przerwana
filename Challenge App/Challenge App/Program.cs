using Challenge_App;


Employee employee = new Employee("Paulina", "Kowalska", 22);
employee.AddGrade(10000);
employee.AddGrade("khutaz");
employee.AddGrade(4);
employee.AddGrade("99");
employee.AddGrade(6);
var statistics = employee.GetStatistics();


Console.WriteLine($"Average: {statistics.Average:N2} Min: {statistics.Min} Max: {statistics.Max}");
