using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTSCApp.Core.Domain
{
    public class UserExtend : Entity, IEntityTypeBuilder<UserExtend>
    {
        public decimal HourlyRate { get; set; }

        public string Titile { get; set; }

        public void Configure(EntityTypeBuilder<UserExtend> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasKey(u => u.Id);
        }
    }
}
