using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TransportCompany.Model;
using TransportCompany.Model.DatabaseModels;

#region creating a configuration
var builder = new ConfigurationBuilder();
builder.SetBasePath(Directory.GetCurrentDirectory());
builder.AddJsonFile("appsettings.json");
var config = builder.Build();
string connectionString = config.GetConnectionString("DefaultConnection");
var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
var options = optionsBuilder.UseSqlServer(connectionString).Options;
#endregion
using (ApplicationContext db = new ApplicationContext(options))
{

    Address address1 = new Address { Country = "Country1", City = "City1", Index = 12332, Street = "Street1" };
    Office office1 = new Office { Address = address1 };
    Manager manager1 = new Manager { Name = "Manager1", Department = "Dep1" };
    Manager manager2 = new Manager { Name = "Manager2", Department = "Dep2" };
    Employee employee1 = new Employee { Name = "Employee1", Post = "Post1", Manager = manager1, Office = office1 };
    db.Addresses.Add(address1);
    db.Offices.Add(office1);
    db.Managers.AddRange(manager1, manager2);
    db.Employees.Add(employee1);
    //db.SaveChanges();

    var employees = db.Employees.Include(m => m.Manager).ToList();
    foreach (var item in employees)
        Console.WriteLine($"Работник: {item.Name}, Менеджер: {item.Manager.Name}");

    var infoEmployees = db.EmployeesManagersGroup.ToList();
    foreach (var item in infoEmployees)
        Console.WriteLine($"{item.EmployeeId}, {item.EmployeePost}, {item.ManagerId}, {item.ManagerDepartment}");

    SqlParameter parameter = new SqlParameter("@idAddress", 1);
        var offices = db.Offices.FromSqlRaw("TakeOffice @idAddress", parameter).ToList();
    foreach (var item in offices)
        Console.WriteLine($"{item.Id}");
}