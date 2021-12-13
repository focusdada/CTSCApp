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
    public class User : Entity, IEntityTypeBuilder<User>
    {
        public int UserId { get; set; }

        public string LoginName { get; set; }

        public string Password { get; set; }

        public string UserDesc { get; set; }

        public int UserStatus { get; set; }

        public void Configure(EntityTypeBuilder<User> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            throw new NotImplementedException();
        }
    }
}
