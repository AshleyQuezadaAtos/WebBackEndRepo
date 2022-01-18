using System.Collections.Generic;
using System.Threading.Tasks;
using WebCourseRepo.Models;

namespace WebCourseRepo.Repositories
{
    public interface ICourseRepository
    {
        Task<List<Course>> FindAll();
        Task<Course?> FindById(int id);
        void Insert(Course Course);
        Task Delete(int id);
        void Update(Course Course);
        Task<int> Save();
    }
}