using DAL.Entities;
using DAL.Interfaces;

namespace BLL.Services
{
    public class HomeService : IHomeService
    {
        private readonly IRepository<Company> _companyRepository;
        public HomeService(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public void Get(string id)
        {
            return;
        }

    }
}
