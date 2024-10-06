using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infarastructure.Abstracts;
using SchoolProject.Infarastructure.Context;
using SchoolProject.Infarastructure.InfrastructureBases;

namespace SchoolProject.Infarastructure.Repositories
{
    public class SubjectRepository : GenericRepositoryAsync<Subjects>, ISubjectRepository
    {
        #region Fields
        private DbSet<Subjects> subjects;
        #endregion

        #region Constructors
        public SubjectRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            subjects = dbContext.Set<Subjects>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
