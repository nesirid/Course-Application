using Domain.Common;
using Domain.Models;
using Repository.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        var groupService = new GroupService();
        var createGroupDelegate = new Func<string, string, string, Group>(groupService.CreateGroup);

        // TestUcun olan metodu Cagirma usulu
        var group = createGroupDelegate("Math", "Imran Ekperov", "Room BP111");
        Console.WriteLine($"Created group: {group.Name}, Teacher: {group.Teacher}, Room: {group.Room}");
    }
}