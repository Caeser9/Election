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
    public class PartiePolitiqueService : Service<PartiePolitique>, IPartiePolitiqueService
    {
        public PartiePolitiqueService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public IEnumerable<PartiePolitique> plusGrandNbrVotes(DateTime date)
        {
            //return GetAll().OrderByDescending(p=>p.Votes).Where(p=>p.Votes.Any(v=>v.DateElection.Equals(date))).Take(1);
            return GetAll().OrderByDescending(p => p.Votes.Count()).Take(1).Where(c => c.Votes.Any(c => c.DateElection.Equals(date)));
        }
    }
}
