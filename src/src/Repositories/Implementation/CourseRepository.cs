using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCourseRepo.Configurations;
using WebCourseRepo.Models;

namespace WebCourseRepo.Repositories.Implementation
{
    public class CourseRepository : ICourseRepository
    {
        private readonly EntityContext _entityContext;

        public CourseRepository(EntityContext entityContext)
        {
            _entityContext = entityContext;
        }

        public async Task<List<Course>> FindAll()
        {
            return await _entityContext.Course.ToListAsync();
        }

        public async Task<Course?> FindById(int id)
        {
            return await _entityContext.Course.FindAsync(id);
        }

        public void Insert(Course course)
        {
            _entityContext.Course.Add(course);
        }

        public async Task Delete(int id)
        {
            Course? toDelete = await FindById(id);
            _entityContext.Course.Remove(toDelete!);
        }

        public void Update(Course course)
        {
            _entityContext.Course.Update(course);
        }

        public async Task<int> Save()
        {
            return await _entityContext.SaveChangesAsync();
        }

    }
}