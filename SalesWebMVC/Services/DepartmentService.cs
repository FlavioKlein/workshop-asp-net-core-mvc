using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMVCContext _context;

        public DepartmentService(SalesWebMVCContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(ord => ord.Name).ToList();
        }
        public void Insert(Department obj)
        {            
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
