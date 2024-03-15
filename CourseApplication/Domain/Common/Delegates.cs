using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    internal class Delegates
    {
        public delegate bool FilterGroup(Group group);
        public delegate bool FilterStudent(Student student);
    }
}
