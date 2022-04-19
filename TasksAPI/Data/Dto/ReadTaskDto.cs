using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace TasksAPI.Data.Dto
{
    public class ReadTaskDto
    {
        [Key]
        [Required]
        public long Id { get; internal set; }

        [Required(ErrorMessage = "Campo Titutlo é Obrigatório"), StringLength(20)]
        public string Title { get; set; }
        public DateTime CompleteDay { get; set; }
        public bool IsDone { get; set; }
    }
}
