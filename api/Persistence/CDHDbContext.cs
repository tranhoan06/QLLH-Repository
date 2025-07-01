using api.Entities;
using api.Entities.Bases;


//using api.Interfaces.Helpers;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace api.Persistence
{
    public class CDHDbContext : DbContext
    {
        //private readonly IDateTimeService _dateTime;
        public CDHDbContext(DbContextOptions<CDHDbContext> options) : base(options)
        {
            //_dateTime = datetime;
        }

        public virtual DbSet<User> Users { get; set; }


    }
}
