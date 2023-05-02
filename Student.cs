using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class StudentCollection
    {
        public class Student
        {
            public int sid { get; set; }
            public string sname { get; set; } = string.Empty;
            public int sage { get; set; }
            public string saddress { get; set; } = string.Empty;
            public int sclass { get; set; }

        }
        public static void AddToList()
        {
            var stdlist = new List<Student>
        {
            new Student{sid=1,sname="Ram",saddress="Kathmandu",sage=10,sclass=5 },
            new Student{sid=2,sname="Shyam",saddress="Pokhara",sage=10,sclass=5 },
            new Student{sid=3,sname="Hari",saddress="Birjung",sage=10,sclass=5 },
            new Student{sid=4,sname="Gita",saddress="Kathmandu",sage=10,sclass=5 },
            new Student{sid=5,sname="Sita",saddress="Jomsom",sage=10,sclass=5 }
        };
        }
        public static void DisplayList(IList<Student> stdlist)
        {
            var std = from s in stdlist
                      where s.saddress == "Kathmandu"
                      select s;
                    
                    
                    
        }
    }

}
