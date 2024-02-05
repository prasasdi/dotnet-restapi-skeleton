using Contracts.Repository.Manager;
using Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ClassMemberService : IClassMemberService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly ILoggerManager _loggerManager;

        /**
         * Asking dependencies to the IServiceCollection, calling them by Contracts (or by their Domain, cmiiw)
         * 
         * This remain in line with Onion Architecture since we never call the dependencies by the Repository and Logger layer
         */
        public ClassMemberService(IRepositoryManager repositoryManager, ILoggerManager loggerManager)
        {
            _repositoryManager = repositoryManager;
            _loggerManager = loggerManager;
        }


    }
}
