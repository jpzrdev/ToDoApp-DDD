using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Commands.CreateToDo
{
    public class CreateToDoCommandResponse
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
    }
}