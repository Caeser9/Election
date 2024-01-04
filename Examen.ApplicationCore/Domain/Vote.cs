using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Vote
    {
        public DateTime DateElection { get; set; }
        public DateTime DateVote { get; set; }
        public MonBureauVote MonBureauVote { get; set; }
        public int PartiePolitiqueId { get; set; }
        public int VoteId { get; set;}
        public virtual PartiePolitique PartiePolitique { get; set;}
        public virtual Election Election { get; set; }
    }
}
