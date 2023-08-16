using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace FinalChallenge2
{
    // Creating the SchoolContext class so that I can use a db
    public class SchoolContext : DbContext
    {
        public SchoolContext(): base()
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
