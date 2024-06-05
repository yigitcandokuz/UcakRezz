using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formm
{
    public partial class Teacher
    {        
        public int id { get; set; }
        public DateTime createdate { get; set; }
        public string name { get; set; }
        public string section { get; set; }          
        
        public virtual ICollection<Lesson> Lessons { get; } = new List<Lesson>();

    }
}
