using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAYS
{   
        class Student
        {
            private string firstName, lastName;
            private int gpa;
            
            public Student() { }
            public Student(string firstName)
        {
            this.firstName = firstName;
        }
            public Student(string firstName, string lastName, int gpa)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.gpa = gpa;
            }

            public override string ToString()
            {
                return "First name = " + firstName + "\n" + "Last name = " + lastName + "\n" + "GPA = " + gpa;
            }
        }

        class Sample
        {
            static void Main()
            {
                Student student = new Student("Yerkebulan");

                Console.WriteLine(student);
                Console.ReadKey();
            }
        }
    }
