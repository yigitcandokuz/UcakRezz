

using System.Data.Entity;
using System.Xml;

namespace Formm
{
    public partial class HelloContext : DbContext {
        public HelloContext() : base("name=HelloContext") { }

        public DbSet<User> Users { get; set; }

       
        public  DbSet<Lesson> Lessons
        {
            get;
            set;
        }
        

        public DbSet<Teacher> Teachers
        {
            get;
            set;
        }

        

    }



}
