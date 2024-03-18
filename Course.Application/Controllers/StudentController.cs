using Service.Services.Interfaces;
using Service.Services;
using Domain.Models;
using Service.Helpers.Extentions;

namespace Course.Application.Controllers
{
    internal class StudentController
    {
        private readonly IStudentService _studentService;
        public StudentController()
        {
            _studentService = new StudentService();
        }

        public void Create()
        {
            Console.WriteLine("Add name:");
        Name: string? name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteConsole("Input can't be empty");
                goto Name;
            }
            Console.WriteLine("Add Surname:");
        Surname: string? surname = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(surname))
            {
                ConsoleColor.Red.WriteConsole("Input can't be empty");
                goto Surname;
            }
            Console.WriteLine("Add Age:");
        Age: string? ageStr = Console.ReadLine();
            int age= int.Parse(ageStr);
            if (age==null)
            {
                ConsoleColor.Red.WriteConsole("Input can't be empty");
                goto Age;
            }
            Console.WriteLine("Add Room:");
        Group: string? group = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(group))
            {
                ConsoleColor.Red.WriteConsole("Input can't be empty");
                goto Group;
            }
            try
            {
                _studentService.Create(new Student { Name = name, Surname = surname, Age = age,Group=group });
                ConsoleColor.Green.WriteConsole("Data successfully added");
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
                goto Name;
            }

        }
    }
}
