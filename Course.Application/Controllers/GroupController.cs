using Repository.Repositories.Interfaces;
using Service.Helpers.Extentions;
using Service.Services;
using Service.Services.Interfaces;
using Domain.Models;
using System.Threading.Tasks;

namespace Course.Application.Controllers
{
    internal class GroupController
    {
        private readonly IGroupService _groupService;
        public GroupController()
        {
            _groupService = new GroupService();
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
            Console.WriteLine("Add Teacher:");
        Teacher: string? teacher = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(teacher))
            {
                ConsoleColor.Red.WriteConsole("Input can't be empty");
                goto Teacher;
            }
            Console.WriteLine("Add Room:");
        Room: string? room = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(room))
            {
                ConsoleColor.Red.WriteConsole("Input can't be empty");
                goto Room;
            }
            try
            {
                _groupService.Create(new Group { Name = name, Teacher = teacher, Room = room });
                ConsoleColor.Green.WriteConsole("Data successfully added");
            }
            catch (Exception ex)
            {
                ConsoleColor.Red.WriteConsole(ex.Message);
                goto Name;
            }

        }
        public void GetAll()
        {
            var response = _groupService.GetAll();

            foreach (var item in response)
            {
                string data = $"Id: {item.Id}, Group name : {item.Name}, Group Teacher : {item.Teacher}, Group Room : {item.Room}";
                Console.WriteLine(data);
            }
        }

        //public void Update()
        //{

        //}

    }
}
