using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectENTITIES.Models
{
    public class Grade : BaseEntity
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double Score { get; set; }
        // Diğer propertyleri buraya ekleyebiliriz.
        public Student Student { get; set; }
        public Course Course { get; set; }
    }
}
