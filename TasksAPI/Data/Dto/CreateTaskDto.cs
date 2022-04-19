using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasksAPI.Data.Dto
{
    public class CreateTaskDto
    {
        [Required(ErrorMessage = "Campo Titutlo é Obrigatório"), StringLength(60)]
        public string Title { get; set; }
        public DateTime CompleteDay { get; set; }
        public bool IsDone { get; set; }
    }
}
