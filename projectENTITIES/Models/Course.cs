using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectENTITIES.Models
{
    public class Course : BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // Other properties for the course
        public virtual List<Grade> Grades { get; set; }
    }
}
