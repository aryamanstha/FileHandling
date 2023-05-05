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
        public static void DisplayList()
        {
            var stdlist = new List<Student>
        {
            new Student{sid=1,sname="Ram",saddress="Kathmandu",sage=12,sclass=5 },
            new Student{sid=2,sname="Shyam",saddress="Pokhara",sage=15,sclass=5 },
            new Student{sid=3,sname="Hari",saddress="Birjung",sage=11,sclass=6 },
            new Student{sid=4,sname="Ram",saddress="Janakpur",sage=10,sclass=11 },
            new Student{sid=5,sname="Sita",saddress="Kathmandu",sage=24,sclass=5 }
        };

            Console.WriteLine("\nThe List of Students are:\n");
            foreach (Student student in stdlist)
            {
                Console.WriteLine(student.sid + " " + student.sname + " " + student.saddress + " " + student.sage + " " + student.sclass);
            }

            var stdaddress = stdlist
                      .Where(s => s.saddress == "Kathmandu")
                      .ToList();

            var stdname = stdlist
               .Where(s => s.sname == "Ram")
               .ToList();
            Console.WriteLine("\nThe List of students having address Kathmandu is:\n");
            foreach (Student student1 in stdaddress)
            {
                Console.WriteLine(student1.sid + " " + student1.sname + " " + student1.saddress + " " + student1.sage + " " + student1.sclass);
            }
            Console.WriteLine("\nThe List of Students having name Ram is:\n");
            foreach (Student student2 in stdname)
            {
                Console.WriteLine(student2.sid + " " + student2.sname + " " + student2.saddress + " " + student2.sage + " " + student2.sclass);
            }

        }
    }
}
