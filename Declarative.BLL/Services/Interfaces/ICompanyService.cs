using Declarative.Api.Models.Company;
using Declarative.DAL.Entities;

namespace Declarative.BLL.Services.Interfaces
{
    public interface ICompanyService
    {
        IEnumerable<CompanyViewModel> GetAll();
        CompanyViewModel GetById(int id);
        void Create(CompanyAddModel item);
        void Update(CompanyEditModel item);
        void Delete(int id);
    }
}
