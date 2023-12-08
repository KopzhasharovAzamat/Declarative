using AutoMapper;
using Declarative.BLL.Services.Interfaces;
using Declarative.DAL.Entities;
using Declarative.DAL.Interfaces;
using Declarative.DAL.Repositories;

namespace Declarative.BLL.Services
{
    public abstract class Service : IService
    {
        protected IUnitOfWork UnitOfWork { get; private set; }
        protected IMapper mapper { get; private set; }
        public Service(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }
    }
}
