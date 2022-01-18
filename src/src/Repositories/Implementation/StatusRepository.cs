﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebCourseRepo.Configurations;
using WebCourseRepo.Models;

namespace WebCourseRepo.Repositories.Implementation
{
    public class StatusRepository : IStatusRepository
    {
        private readonly EntityContext _entityContext;

        public StatusRepository(EntityContext entityContext)
        {
            _entityContext = entityContext;
        }

        public async Task<List<Status>> FindAll()
        {
            return await _entityContext.Status.ToListAsync();
        }

        public async Task<Status?> FindById(int id)
        {
            return await _entityContext.Status.FindAsync(id);
        }

        public void Insert(Status course)
        {
            _entityContext.Status.Add(course);
        }

        public async Task Delete(int id)
        {
            Status? toDelete = await FindById(id);
            _entityContext.Status.Remove(toDelete!);
        }

        public void Update(Status course)
        {
            _entityContext.Status.Update(course);
        }

        public async Task<int> Save()
        {
            return await _entityContext.SaveChangesAsync();
        }

    }
}