using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

/*
 * System.Linq.Dynamic.Core is provided by Nuget the package System.Linq.Dynamic.Core
 * https://www.nuget.org/packages/System.Linq.Dynamic/
 */

namespace SageFoundation.Playground {

    class Student {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
        public int ColInt { get; set; }
        public String ColTxt { get; set; }

        public override string ToString() {
            return this.StudentName + " " + this.Age + " " + this.ColInt + " " + this.ColTxt;
        }
    }


    class LinqOrderBy {

        public static void Go() {

            IList<Student> studentList = new List<Student>()
             {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, ColInt = 5, ColTxt = "X" } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15, ColInt = 3, ColTxt = "F"  } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25, ColInt = 9, ColTxt = "A"  } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 25, ColInt = 500, ColTxt = "A"  } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15, ColInt = 3, ColTxt = "H"  }
        };

            var l = studentList.AsQueryable().OrderBy("ColInt DESC, ColTxt ASC, Age DESC, StudentName ASC").ToList();

            foreach (Student std in l) {
                Console.WriteLine(std);
            }
        }
    }
}