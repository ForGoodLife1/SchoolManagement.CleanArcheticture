﻿using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infarastructure.Abstracts;
using SchoolProject.Infarastructure.Context;
using SchoolProject.Infarastructure.InfrastructureBases;

namespace SchoolProject.Infarastructure.Repositories
{
    public class DepartmentRepository : GenericRepositoryAsync<Department>, IDepartmentRepository
    {
        #region Fields
        private DbSet<Department> departments;
        #endregion

        #region Constructors
        public DepartmentRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            departments = dbContext.Set<Department>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
