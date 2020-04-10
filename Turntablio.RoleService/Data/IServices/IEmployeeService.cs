﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turntablio.RoleService.Data.Model;

namespace Turntablio.RoleService.Data.IServices
{
    interface IEmployeeService
    {
        public List<Employee> GetEmployees();
        public Employee GetEmployee(int id);
        public string AddEmployee(Employee employee);
        public string UpdateEmployee(Employee employee);
        public string DeleteEmployee(Employee employee);
    }
}