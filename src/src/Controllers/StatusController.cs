using AutoMapper;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using WebCourseRepo.Dtos;
using WebCourseRepo.Models;
using WebCourseRepo.Services;

namespace WebCourseRepo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        private readonly ICourseService _statusController;

        public StatusController(ICourseService courseService)
        {
            _statusController = courseService;
        }
        //Get: api/Course
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<CourseDto> status = await _statusController.FindAll();
            return Ok(status);
        }
        //Get api/Course/Id
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            CourseDto? courseDto = await _statusController.FindById(id);
            return courseDto != null ? Ok(courseDto) : NotFound();
        }

        //Post create
        [HttpPost]
        public async Task<IActionResult> Create(CourseDto courseDto)
        {
            try
            {
                await _statusController.Insert(courseDto);
                return Created(Request.GetDisplayUrl(), courseDto);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest();
            }
        }

        //Put update
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, CourseDto courseDto)
        {
            if (id != courseDto.Id) return BadRequest();
            _statusController.Update(courseDto);
            return NoContent();
        }
    }
}
