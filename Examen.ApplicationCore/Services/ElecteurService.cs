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
    public class ElecteurService : Service<Electeur>, IElecteurService
    {
        public ElecteurService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public int prcElecteurJeunes(DateTime date)
        {
            return (GetAll().Where(e=>e.Elections.Any(e=>e.DateElection.Equals(date))&& 18<(DateTime.Now.Year - (e.DateNaissance.Year)) && (DateTime.Now.Year - (e.DateNaissance.Year)) < 35).Count()*100)/100;
        }
    }
}
