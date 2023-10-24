using Challenge_App;


Employee employee1 = new Employee("Paulina", "Kowalska", 22);
Employee employee2 = new Employee("Wiktoria", "Kowalska", 23);
Employee employee3 = new Employee("Kamila", "Kowalska", 19);



employee1.AddScore(19);
employee1.AddScore(8);
employee1.AddScore(4);
employee1.AddScore(123);
employee1.AddScore(4);

employee2.AddScore(2);
employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(1);
employee2.AddScore(2);

employee3.AddScore(10);
employee3.AddScore(11);
employee3.AddScore(12);
employee3.AddScore(10);
employee3.AddScore(16);

List<Employee> employees = new List<Employee>()
{
    employee1,employee2,employee3,

};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (Employee employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine($"pracownica: {employeeWithMaxResult.Name} {employeeWithMaxResult.Surname} lat: {employeeWithMaxResult.Age} Osiągnęła największy wynik: {employeeWithMaxResult.Result}");