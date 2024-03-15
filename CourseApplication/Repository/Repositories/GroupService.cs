using Domain.Models;
using Domain.Common;
using Repository.Interfaces;


namespace Repository.Repositories
{
    public class GroupService : IGroupService
    {
        public Group CreateGroup(string name, string teacher, string room)
        {
            // Burda Mentiq Qura bilerem (deqiq deil)
            return new Group { Name = name, Teacher = teacher, Room = room };
        }
    }
}
