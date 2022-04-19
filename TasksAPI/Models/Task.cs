using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace TasksAPI.Models
{
    public class Task
    {
        [Key]
        [Required]
        public long Id { get; internal set; }
        [Required(ErrorMessage = "Campo Titutlo é Obrigatório"),StringLength(20)]
        public string Title { get; set; }
        public DateTime CompleteDay { get; set; }
        public bool IsDone { get; set; }
    }
}
