using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infarastructure.Abstracts;
using SchoolProject.Infarastructure.Context;
using SchoolProject.Infarastructure.InfrastructureBases;

namespace SchoolProject.Infarastructure.Repositories
{
    public class InstructorsRepository : GenericRepositoryAsync<Instructor>, IInstructorsRepository
    {
        #region Fields
        private DbSet<Instructor> instructors;
        #endregion

        #region Constructors
        public InstructorsRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            instructors = dbContext.Set<Instructor>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
