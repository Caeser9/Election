using AM.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Interfaces
{
    public interface IPartiePolitiqueService : IService<PartiePolitique>
    {
        IEnumerable<PartiePolitique> plusGrandNbrVotes(DateTime date);
    }
}
