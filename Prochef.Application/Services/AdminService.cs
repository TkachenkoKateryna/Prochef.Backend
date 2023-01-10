using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Prochef.Application.Interfaces.Util;
using Prochef.Core.Entities;
using Prochef.Core.Interfaces.Repositories;

namespace Prochef.Application.Services
{
    public class AdminService
    {
        private readonly IUnitOfWork _uow;
        private readonly Func<IQueryable<Employee>, IIncludableQueryable<Employee, object>> _includes;

        public AdminService(IUnitOfWork uow)
        {
            _uow = uow;
            _includes = employees => employees.Include(employee => employee.Restaurant)
                .Include(employee => employee.Role);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return _uow.GetRepository<Employee>().GetAll(_includes).ToList();
        }

        public void ChangeUserRole(int userId, int roleId)
        {
            var user = _uow.GetRepository<Employee>().FirstOrDefault(u => u.Id == userId);
            var role = _uow.GetRepository<Role>().FirstOrDefault(r => r.Id == roleId);
            
            try
            {
                if (user == null)
                    throw new ArgumentException("No user exists with such id");

                if (role == null)
                    throw new ArgumentException("No role exists with such name");

                user.RoleId = roleId;
                _uow.GetRepository<Employee>().Update(user);
                _uow.Save();
            }
            catch (ArgumentException e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}
