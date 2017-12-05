using FinanciasWeb.Domain.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanciasWeb.Infra.Persistence.Map
{
    public class UserMap : EntityTypeConfiguration<User>
    {
    public UserMap ()
	{
        ToTable("User");
        HasKey(x => x.Id);
        Property(x => x.Id).IsRequired();
	}
        
        

    }
}
