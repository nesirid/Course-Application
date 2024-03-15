using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;


namespace Repository.Interfaces

{
    public interface IGroupService
    {
        Group CreateGroup(string name, string teacher, string room);
    }
}
