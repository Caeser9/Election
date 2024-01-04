using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infrastructure.Configuration
{
    public class VoteConfiguration : IEntityTypeConfiguration<Vote>
    {
        

        public void Configure(EntityTypeBuilder<Vote> builder)
        {
            builder.HasKey(v => new
            {
                v.DateElection,
                v.PartiePolitiqueId,
                v.VoteId
            });
        }
    }
}
