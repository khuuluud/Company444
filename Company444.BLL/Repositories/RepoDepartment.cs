using Company444.BLL.Interfaces;
using Company444.DAL.Data;
using Company444.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company444.BLL.Repositories
{
    public class RepoDepartment : IDepartmentRepository
    {
        private readonly ApplicationDbContext _DbContext;


        public RepoDepartment(ApplicationDbContext dbContext)
        {
            _DbContext = dbContext;
        }

        public int Add(Department entity)
        {
            _DbContext.Add(entity);

            return _DbContext.SaveChanges();
        }

        public int Delete(Department entity)
        {
            _DbContext.Remove(entity);

            return _DbContext.SaveChanges();
        }

        public Department Get(int id)
        {
            return _DbContext.Departments.Find(id);
        }

        public IEnumerable<Department> GetAll()
        => _DbContext.Departments.AsNoTracking().ToList();
        

        public int Update(Department entity)
        {
            _DbContext.Departments.Update(entity);

            return _DbContext.SaveChanges();
        }
    }
}
