﻿using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities.Identity;
using SchoolProject.Infarastructure.Context;
using SchoolProject.Infarastructure.InfrastructureBases;
using SchoolProject.Infrustructure.Abstracts;

namespace SchoolProject.Infrustructure.Repositories
{
    public class RefreshTokenRepository : GenericRepositoryAsync<UserRefreshToken>, IRefreshTokenRepository
    {
        #region Fields
        private DbSet<UserRefreshToken> userRefreshToken;
        #endregion

        #region Constructors
        public RefreshTokenRepository(ApplicationDBContext dbContext) : base(dbContext)
        {
            userRefreshToken=dbContext.Set<UserRefreshToken>();
        }
        #endregion

        #region Handle Functions

        #endregion
    }
}
