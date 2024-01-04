using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Services
{
    public class ElectionSerevice : Service<Election>, IElectionService
    {
        public ElectionSerevice(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int nbrElectionByDate(DateTime date)
        {
            return GetAll().Where(e=>e.DateElection.Equals(date)).Count();
        }
    }
}
