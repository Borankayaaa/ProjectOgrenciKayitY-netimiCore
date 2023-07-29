using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectENTITIES.Models
{
    public class Student : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public double FillPercentage { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public virtual List<Grade> Grades { get; set; }

        //İsteğe göre daha fazla öğrenci bilgisi ekleyebilriiz.
    }
}
