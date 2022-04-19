using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TasksAPI.Data.Dto;
using TasksAPI.Models;

namespace TasksAPI.Profiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<CreateTaskDto, Task>();
            CreateMap<Task, ReadTaskDto>();
            CreateMap<UpdateTaskDto, Task>();
            CreateMap<UpdateIsDone, Task>();
        }
    }
}
