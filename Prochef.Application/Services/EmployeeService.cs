
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Prochef.Application.Dtos.Response.JWTToken;
using Prochef.Application.Interfaces;
using Prochef.Application.Interfaces.Util;
using Prochef.Core.Entities;
using Prochef.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using Prochef.Core.Dtos.Request.Registration;

namespace Prochef.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _employeeRepository;
        private readonly IUnitOfWork _uow;
        private readonly IJwtTokenService _jwtTokenService;
        private readonly IPasswordService _passwordService;
        private readonly Func<IQueryable<Employee>, IIncludableQueryable<Employee, object>> _includes;

        public EmployeeService(
            IUnitOfWork uow, IJwtTokenService jWtTokenService, IPasswordService passwordService)
        {
            _uow = uow;
            _employeeRepository = uow.GetRepository<Employee>();
            _jwtTokenService = jWtTokenService;
            _passwordService = passwordService;
            _includes = employees => employees.Include(employee => employee.Restaurant)
                .Include(employee => employee.Role);
        }

        public void RegisterEmployee(RegistrationEmployeeRequest registrationRequest)
        {
            Employee employee = new Employee()
            {
                Email = registrationRequest.Email,
                Password = registrationRequest.Password,
                FirstName = registrationRequest.FirstName,
                MiddleName = registrationRequest.MiddleName,
                LastName = registrationRequest.LastName,
                RoleId = registrationRequest.RoleId,
                RestaurantId = registrationRequest.RestaurantId
            };

            if (IsUserRegistered(employee))
            {
                throw new Exception("The user with such login is already registered.");
            }

            SecurePassword(employee);

             _employeeRepository.Create(employee);
             _uow.Save();
        }

        public JWTTokenEmployeeResponse LoginEmployee(LoginEmployeeRequest loginRequest)
        {
            var identity =  GetEmployee(loginRequest);
            var employee = _employeeRepository
                .FirstOrDefault(entity => entity.Id == identity.Id);
            if (employee == null)
            {
                throw new Exception("Login failed. The user is not a customer.");
            }
             
            JwtSecurityToken JWTToken = _jwtTokenService.CreateJwtToken(identity);
            string encodedJwt = _jwtTokenService.EncodeJwtToken(JWTToken);

            return new JWTTokenEmployeeResponse(
                encodedJwt, JWTToken.ValidTo, employee.FirstName, employee.MiddleName,  employee.LastName, identity.RoleId);
        }

        private  bool IsUserRegistered(Employee employee)
        {
            Employee registeredIdentity =  GetUserIdentityByLogin(employee.Email);
            bool isAlreadyRegistered = registeredIdentity != null;
            return isAlreadyRegistered;
        }

        private Employee GetUserIdentityByLogin(string email)
        {
            return  _employeeRepository
                .FirstOrDefault(identity => identity.Email == email);
        }


        private void SecurePassword(Employee employee)
        {
            employee.Password = _passwordService.HashPassword(employee.Password);
        }

        private  Employee GetEmployee(LoginEmployeeRequest loginRequest)
        {
            Employee userIdentity =  GetUserIdentityByLogin(loginRequest.Login);
            if (userIdentity == null)
            {
                throw new Exception("The user with such login doesn't exist");
            }

            bool isPasswordCorrect = _passwordService.VerifyHashedPassword(
                userIdentity.Password, loginRequest.Password);
            if (!isPasswordCorrect)
            {
                throw new Exception("The password is not correct");
            }

            return userIdentity;
        }

    }
}
