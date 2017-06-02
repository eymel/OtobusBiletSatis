using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Map
{
   public class RouteMap:EntityTypeConfiguration<Route>
    {
        public RouteMap()
        {
            HasKey(x=>x.ID);
            Property(x => x.DeparturePointID).IsRequired();
            Ignore(x => x.Name);
            HasRequired(x => x.DeparturePoint).WithMany().HasForeignKey(x => x.DeparturePointID).WillCascadeOnDelete(false);

            HasRequired(x => x.Destiration).WithMany().HasForeignKey(x => x.DestirationID).WillCascadeOnDelete(false);

        }
    }
}
