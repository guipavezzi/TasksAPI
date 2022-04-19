using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TasksAPI.Data;
using TasksAPI.Data.Dto;
using TasksAPI.Models;

namespace TasksAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private TaskContext _context;
        private IMapper _mapper;
        public TaskController(TaskContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AddTask([FromBody] CreateTaskDto taskDto)
        {
            Task task = _mapper.Map<Task>(taskDto);
            _context.Task.Add(task);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetTaskById), new { Id = task.Id }, task);
        }

        [HttpGet]
        public IActionResult GetTasks()
        {
            return Ok(_context.Task);
        }

        [HttpGet("{id}")]
        public ActionResult GetTaskById(long id)
        {
            Task task = _context.Task.FirstOrDefault(task => task.Id == id);
            if (task != null)
            {
                ReadTaskDto taskDto = _mapper.Map<ReadTaskDto>(task);
                return Ok(taskDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTask(long id, [FromBody] UpdateTaskDto taskDto)
        {
            Task task = _context.Task.FirstOrDefault(task => task.Id == id);
            if(task == null)
            {
                return NotFound();
            }
            _mapper.Map(taskDto, task);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTask(long id)
        {
            Task task = _context.Task.FirstOrDefault(task => task.Id == id);
            if(task == null)
            {
                return NotFound();
            }
            _context.Remove(task);
            _context.SaveChanges();
            return NoContent();
        }



    }
}
