using DataAccessLayer.Map;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MyTicketContext:DbContext
    {
        public MyTicketContext():base("MyTicketDB")
        {

        }
        internal DbSet<User> User { get; set; }
        internal DbSet<Customer> UserProfile { get; set; }
        internal DbSet<Ticket> Ticket { get; set; }
        internal DbSet<TicketDetail> TicketDetails { get; set; }
        internal DbSet<Schedule> Schedule { get; set; }
        internal DbSet<City> City { get; set; }
        internal DbSet<Bus> Bus { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new CustomerMap());
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new TicketDetailsMap());
            modelBuilder.Configurations.Add(new ScheduleMap());
            modelBuilder.Configurations.Add(new ScheduleTimeMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new BusMap());
            modelBuilder.Configurations.Add(new RouteMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
