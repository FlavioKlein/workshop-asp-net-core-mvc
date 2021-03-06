﻿using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(ord => ord.Name).ToListAsync();
        }
        public async Task InsertAsync(Department obj)
        {            
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
    }
}
