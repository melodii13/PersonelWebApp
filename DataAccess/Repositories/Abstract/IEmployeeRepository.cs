﻿using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Abstract
{
    public interface IEmployeeRepository : IGenericRepository<Employee>
    {
        public Employee? GetEmployeeByEmail(string Email);
    }
}
