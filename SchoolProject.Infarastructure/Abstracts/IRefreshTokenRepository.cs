using SchoolProject.Data.Entities.Identity;
using SchoolProject.Infarastructure.InfrastructureBases;

namespace SchoolProject.Infrustructure.Abstracts
{
    public interface IRefreshTokenRepository : IGenericRepositoryAsync<UserRefreshToken>
    {

    }
}
