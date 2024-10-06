using SchoolProject.Infarastructure.InfrastructureBases;

namespace SchoolProject.Infrustructure.Abstracts.Views
{
    public interface IViewRepository<T> : IGenericRepositoryAsync<T> where T : class
    {
    }
}
