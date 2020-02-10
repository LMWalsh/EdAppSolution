using System;

namespace EdAppProject {
    class Program {
        static void Main(string[] args) {
            // Console.WriteLine("Hello World!");
            //below is an array
            var majors = new Major[] {
                new Major(100, "Accounting", 1000),  
                new Major(200, "Business", 1000),
                new Major(300, "Engineering", 1200),
                new Major(400, "Math", 1300),
                new Major(500, "Education", 1100)

            };
 
 
 
 

            for(var idx = 0; idx < majors.Length; idx++) {
                var major = majors[idx];
                major.Print();
            }
            //below is the array
            var students = new Student[] {
                new Student(1, "Eric", "Ephram", 1200, 3.0, majors[0]),
                new Student(2, "Greg", "Gould", 1100, 2.5, majors[2]),
                new Student(3, "Adam", "Ant", 1300, 3.2, majors[1]),
                new Student(4, "Fred", "Flintstone", 600, 1.0, majors[1])

            };
 
            foreach(var student in students) {
                student.Print();
            }
 
 
          }

        }
    }//========================================================================
