using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasksAPI.Data.Dto
{
    public class UpdateTaskDto
    {
        public string Title { get; set; }
        public DateTime CompleteDay { get; set; }
        public bool IsDone { get; set; }
    }
}
