﻿using BusinessApp.DataAccess.Abstract;
using BusinessApp.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessApp.DataAccess.Concrete.EfCore
{
    public class EfCoreRequestDepartmentRepository: EfCoreGenericRepository<RequestDepartment>, IRequestDepartmentRepository
    {
        public EfCoreRequestDepartmentRepository(BusinessAppContext context) : base(context)
        {

        }
        private BusinessAppContext BusinessAppContext
        {
            get { return context as BusinessAppContext; }
        }
    }
}
