﻿using BusinessApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.DataAccess.Abstract
{
    public interface IEmployeeRequestsRepository: IRepository<EmployeeRequests>
    {
        EmployeeRequests GetByEmployeeIdAndRequestId(string employeeId, int requestId);
    }
}
