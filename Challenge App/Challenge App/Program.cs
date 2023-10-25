using Challenge_App;


Employee employee = new Employee("Paulina", "Kowalska", 22);
employee.AddGrade(19);
employee.AddGrade(8);
employee.AddGrade(4);
employee.AddGrade(123);
employee.AddGrade(4);
var statistics = employee.GetStatistics();


Console.WriteLine($"Average: {statistics.Average:N2} Min: {statistics.Min} Max: {statistics.Max}");
