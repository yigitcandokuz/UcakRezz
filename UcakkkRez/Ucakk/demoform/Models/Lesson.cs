using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formm
{
    public partial class Lesson
    {        
        public int id { get; set; }
        public DateTime createdate { get; set; }
        public int userId { get; set; }
        public string lessonName { get; set; }
        public virtual Teacher CuurentTeacher { get; set; } = null;
        public int? TeacherId { get; set; }        
    }
}
