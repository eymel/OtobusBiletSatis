using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Map
{
    public class CityMap:EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            HasKey(x => x.CityID);
            Property(x => x.CityName).HasColumnType("varchar").IsRequired();
        }
    }
}
